# Excellis Development Guide

## Overview

This guide provides practical examples, best practices, and step-by-step instructions for developing with the Excellis Azure Functions API. It includes code samples, testing strategies, and deployment guidelines.

## Table of Contents

1. [Development Environment Setup](#development-environment-setup)
2. [Creating New Functions](#creating-new-functions)
3. [Database Operations](#database-operations)
4. [Error Handling Patterns](#error-handling-patterns)
5. [Testing Strategies](#testing-strategies)
6. [Performance Optimization](#performance-optimization)
7. [Security Best Practices](#security-best-practices)
8. [Deployment Guide](#deployment-guide)
9. [Monitoring and Logging](#monitoring-and-logging)
10. [Common Patterns](#common-patterns)

## Development Environment Setup

### Prerequisites

1. **Install Required Tools**
   ```bash
   # Install .NET 8.0 SDK
   winget install Microsoft.DotNet.SDK.8
   
   # Install Azure Functions Core Tools
   npm install -g azure-functions-core-tools@4 --unsafe-perm true
   
   # Install Azure CLI (optional)
   winget install Microsoft.AzureCLI
   ```

2. **Clone and Setup Project**
   ```bash
   git clone <repository-url>
   cd excellis-api
   dotnet restore
   ```

3. **Configure Local Settings**
   Create `local.settings.json`:
   ```json
   {
     "IsEncrypted": false,
     "Values": {
       "AzureWebJobsStorage": "UseDevelopmentStorage=true",
       "FUNCTIONS_WORKER_RUNTIME": "dotnet-isolated",
       "APPINSIGHTS_INSTRUMENTATIONKEY": ""
     },
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ExcellisDb;Trusted_Connection=true;MultipleActiveResultSets=true;"
     }
   }
   ```

4. **Database Setup**
   ```bash
   # Create and apply migrations
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

5. **Run the Application**
   ```bash
   func start
   ```

## Creating New Functions

### Basic HTTP Function Template

```csharp
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using excellis.Data;
using excellis.Models;
using Microsoft.EntityFrameworkCore;

namespace excellis.Functions
{
    public class CustomerFunction
    {
        private readonly ILogger<CustomerFunction> _logger;
        private readonly ApplicationDbContext _dbContext;

        public CustomerFunction(ILogger<CustomerFunction> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [Function("GetCustomers")]
        public async Task<IActionResult> GetCustomers(
            [HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequest req)
        {
            _logger.LogInformation("Getting customers list");

            try
            {
                // Parse query parameters
                var pageSize = int.TryParse(req.Query["pageSize"], out var ps) ? ps : 10;
                var page = int.TryParse(req.Query["page"], out var p) ? p : 1;
                var status = req.Query["status"].ToString();

                // Build query
                var query = _dbContext.Customers.AsQueryable();
                
                if (!string.IsNullOrEmpty(status))
                {
                    query = query.Where(c => c.Status == status);
                }

                // Apply pagination
                var customers = await query
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .Select(c => new
                    {
                        c.Id,
                        c.CueId,
                        c.Name,
                        c.Type,
                        c.Status,
                        c.ContactNumber
                    })
                    .ToListAsync();

                var totalCount = await query.CountAsync();

                var result = new
                {
                    Data = customers,
                    TotalCount = totalCount,
                    Page = page,
                    PageSize = pageSize,
                    TotalPages = (int)Math.Ceiling((double)totalCount / pageSize)
                };

                return new OkObjectResult(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving customers");
                return new StatusCodeResult(500);
            }
        }

        [Function("CreateCustomer")]
        public async Task<IActionResult> CreateCustomer(
            [HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
        {
            _logger.LogInformation("Creating new customer");

            try
            {
                // Read request body
                using var reader = new StreamReader(req.Body);
                var requestBody = await reader.ReadToEndAsync();
                var customerData = JsonSerializer.Deserialize<Customer>(requestBody, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });

                if (customerData == null)
                {
                    return new BadRequestObjectResult("Invalid customer data");
                }

                // Validate required fields
                if (string.IsNullOrEmpty(customerData.CueId))
                {
                    return new BadRequestObjectResult("CueId is required");
                }

                // Check for duplicate CueId
                var existingCustomer = await _dbContext.Customers
                    .FirstOrDefaultAsync(c => c.CueId == customerData.CueId);
                
                if (existingCustomer != null)
                {
                    return new ConflictObjectResult("Customer with this CueId already exists");
                }

                // Set default values
                customerData.Timestamp = DateTime.UtcNow;
                customerData.Status ??= "Active";

                // Save to database
                _dbContext.Customers.Add(customerData);
                await _dbContext.SaveChangesAsync();

                _logger.LogInformation("Customer created with ID: {CustomerId}", customerData.Id);

                return new CreatedResult($"/api/customers/{customerData.Id}", new
                {
                    customerData.Id,
                    customerData.CueId,
                    customerData.Name,
                    customerData.Status
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating customer");
                return new StatusCodeResult(500);
            }
        }
    }
}
```

### Advanced Function with Complex Operations

```csharp
[Function("ProcessOrder")]
public async Task<IActionResult> ProcessOrder(
    [HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
{
    _logger.LogInformation("Processing order");

    using var transaction = await _dbContext.Database.BeginTransactionAsync();
    
    try
    {
        // Read and validate input
        var orderData = await ReadRequestBodyAsync<ProcessOrderRequest>(req);
        if (orderData == null)
        {
            return new BadRequestObjectResult("Invalid order data");
        }

        // Validate customer exists
        var customer = await _dbContext.Customers
            .FirstOrDefaultAsync(c => c.Id == orderData.CustomerId);
        
        if (customer == null)
        {
            return new NotFoundObjectResult("Customer not found");
        }

        // Create order
        var order = new Order
        {
            Id = Guid.NewGuid().ToString(),
            FkCustomerId = orderData.CustomerId,
            FkCustomerIdShip = orderData.ShippingCustomerId ?? orderData.CustomerId,
            FkCustomerIdBill = orderData.BillingCustomerId ?? orderData.CustomerId,
            FkUserId = orderData.UserId,
            PoNumber = orderData.PoNumber,
            OrderStatus = "Pending",
            Timestamp = DateTime.UtcNow,
            // Set addresses from request
            BillAddrCountry = orderData.BillingAddress.Country,
            BillAddrState = orderData.BillingAddress.State,
            BillAddrCity = orderData.BillingAddress.City,
            BillAddrStreet = orderData.BillingAddress.Street,
            BillAddrZipcode = orderData.BillingAddress.Zipcode,
            ShipAddrCountry = orderData.ShippingAddress.Country,
            ShipAddrState = orderData.ShippingAddress.State,
            ShipAddrCity = orderData.ShippingAddress.City,
            ShipAddrStreet = orderData.ShippingAddress.Street,
            ShipAddrZipcode = orderData.ShippingAddress.Zipcode
        };

        _dbContext.Orders.Add(order);

        // Process order items (if applicable)
        foreach (var item in orderData.Items)
        {
            // Add order items logic here
            // Validate inventory, calculate pricing, etc.
        }

        // Save changes
        await _dbContext.SaveChangesAsync();
        await transaction.CommitAsync();

        _logger.LogInformation("Order processed successfully: {OrderId}", order.Id);

        return new CreatedResult($"/api/orders/{order.Id}", new
        {
            order.Id,
            order.OrderStatus,
            order.Timestamp
        });
    }
    catch (Exception ex)
    {
        await transaction.RollbackAsync();
        _logger.LogError(ex, "Error processing order");
        return new StatusCodeResult(500);
    }
}

private async Task<T?> ReadRequestBodyAsync<T>(HttpRequest req) where T : class
{
    try
    {
        using var reader = new StreamReader(req.Body);
        var requestBody = await reader.ReadToEndAsync();
        return JsonSerializer.Deserialize<T>(requestBody, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });
    }
    catch
    {
        return null;
    }
}
```

## Database Operations

### Common Query Patterns

```csharp
// Service class for database operations
public class CustomerService
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<CustomerService> _logger;

    public CustomerService(ApplicationDbContext context, ILogger<CustomerService> logger)
    {
        _context = context;
        _logger = logger;
    }

    // Get customer with related data
    public async Task<Customer?> GetCustomerWithDetailsAsync(int customerId)
    {
        return await _context.Customers
            .Include(c => c.CustomerAddresses)
            .Include(c => c.CustomerContacts)
            .Include(c => c.Orders.Take(10)) // Limit orders to prevent large queries
            .FirstOrDefaultAsync(c => c.Id == customerId);
    }

    // Search customers with filters
    public async Task<PagedResult<Customer>> SearchCustomersAsync(CustomerSearchRequest request)
    {
        var query = _context.Customers.AsQueryable();

        // Apply filters
        if (!string.IsNullOrEmpty(request.Name))
        {
            query = query.Where(c => c.Name!.Contains(request.Name));
        }

        if (!string.IsNullOrEmpty(request.Status))
        {
            query = query.Where(c => c.Status == request.Status);
        }

        if (!string.IsNullOrEmpty(request.Type))
        {
            query = query.Where(c => c.Type == request.Type);
        }

        if (request.IsPublic.HasValue)
        {
            query = query.Where(c => c.IsPublic == request.IsPublic.Value);
        }

        // Get total count
        var totalCount = await query.CountAsync();

        // Apply pagination and sorting
        var customers = await query
            .OrderBy(c => c.Name)
            .Skip((request.Page - 1) * request.PageSize)
            .Take(request.PageSize)
            .ToListAsync();

        return new PagedResult<Customer>
        {
            Data = customers,
            TotalCount = totalCount,
            Page = request.Page,
            PageSize = request.PageSize
        };
    }

    // Bulk operations
    public async Task<int> BulkUpdateCustomerStatusAsync(List<int> customerIds, string newStatus)
    {
        var customers = await _context.Customers
            .Where(c => customerIds.Contains(c.Id))
            .ToListAsync();

        foreach (var customer in customers)
        {
            customer.Status = newStatus;
            customer.DateModified = DateTime.UtcNow;
        }

        return await _context.SaveChangesAsync();
    }

    // Complex aggregation
    public async Task<CustomerStatistics> GetCustomerStatisticsAsync()
    {
        var stats = await _context.Customers
            .GroupBy(c => c.Status)
            .Select(g => new { Status = g.Key, Count = g.Count() })
            .ToListAsync();

        var totalCustomers = await _context.Customers.CountAsync();
        var activeCustomers = stats.FirstOrDefault(s => s.Status == "Active")?.Count ?? 0;

        return new CustomerStatistics
        {
            TotalCustomers = totalCustomers,
            ActiveCustomers = activeCustomers,
            StatusBreakdown = stats.ToDictionary(s => s.Status ?? "Unknown", s => s.Count)
        };
    }
}
```

### Repository Pattern Implementation

```csharp
// Generic repository interface
public interface IRepository<T> where T : class
{
    Task<T?> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
    Task<int> SaveChangesAsync();
}

// Generic repository implementation
public class Repository<T> : IRepository<T> where T : class
{
    protected readonly ApplicationDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public virtual async Task<T?> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync();
    }

    public virtual async Task<T> AddAsync(T entity)
    {
        _dbSet.Add(entity);
        return entity;
    }

    public virtual async Task UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
    }

    public virtual async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
        }
    }

    public virtual async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}

// Specific repository with custom methods
public interface ICustomerRepository : IRepository<Customer>
{
    Task<Customer?> GetByCodeAsync(string cueId);
    Task<IEnumerable<Customer>> GetActiveCustomersAsync();
    Task<bool> ExistsAsync(string cueId);
}

public class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    public CustomerRepository(ApplicationDbContext context) : base(context) { }

    public async Task<Customer?> GetByCodeAsync(string cueId)
    {
        return await _dbSet.FirstOrDefaultAsync(c => c.CueId == cueId);
    }

    public async Task<IEnumerable<Customer>> GetActiveCustomersAsync()
    {
        return await _dbSet.Where(c => c.Status == "Active").ToListAsync();
    }

    public async Task<bool> ExistsAsync(string cueId)
    {
        return await _dbSet.AnyAsync(c => c.CueId == cueId);
    }
}
```

## Error Handling Patterns

### Global Error Handler

```csharp
public class GlobalExceptionHandler
{
    private readonly ILogger<GlobalExceptionHandler> _logger;

    public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
    {
        _logger = logger;
    }

    public IActionResult HandleException(Exception ex, string operation)
    {
        _logger.LogError(ex, "Error in operation: {Operation}", operation);

        return ex switch
        {
            ArgumentNullException => new BadRequestObjectResult(new ErrorResponse
            {
                Error = "Invalid input",
                Message = "Required parameter is missing",
                Details = ex.Message
            }),
            
            InvalidOperationException => new BadRequestObjectResult(new ErrorResponse
            {
                Error = "Invalid operation",
                Message = ex.Message
            }),
            
            UnauthorizedAccessException => new UnauthorizedObjectResult(new ErrorResponse
            {
                Error = "Unauthorized",
                Message = "Access denied"
            }),
            
            KeyNotFoundException => new NotFoundObjectResult(new ErrorResponse
            {
                Error = "Not found",
                Message = ex.Message
            }),
            
            DbUpdateException dbEx => new StatusCodeResult(500) // Don't expose DB details
            {
                Value = new ErrorResponse
                {
                    Error = "Database error",
                    Message = "An error occurred while saving data"
                }
            },
            
            _ => new StatusCodeResult(500)
            {
                Value = new ErrorResponse
                {
                    Error = "Internal server error",
                    Message = "An unexpected error occurred"
                }
            }
        };
    }
}

public class ErrorResponse
{
    public string Error { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public string? Details { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
```

### Validation Patterns

```csharp
public class CustomerValidator
{
    public static ValidationResult ValidateCustomer(Customer customer)
    {
        var errors = new List<string>();

        if (string.IsNullOrEmpty(customer.CueId))
            errors.Add("CueId is required");

        if (customer.CueId?.Length > 50)
            errors.Add("CueId cannot exceed 50 characters");

        if (!string.IsNullOrEmpty(customer.ContactNumber) && 
            !IsValidPhoneNumber(customer.ContactNumber))
            errors.Add("Invalid contact number format");

        if (!string.IsNullOrEmpty(customer.Status) && 
            !IsValidStatus(customer.Status))
            errors.Add("Invalid status value");

        return new ValidationResult
        {
            IsValid = errors.Count == 0,
            Errors = errors
        };
    }

    private static bool IsValidPhoneNumber(string phoneNumber)
    {
        // Simple phone validation - customize as needed
        return Regex.IsMatch(phoneNumber, @"^\+?[\d\s\-\(\)]+$");
    }

    private static bool IsValidStatus(string status)
    {
        var validStatuses = new[] { "Active", "Inactive", "Pending", "Suspended" };
        return validStatuses.Contains(status, StringComparer.OrdinalIgnoreCase);
    }
}

public class ValidationResult
{
    public bool IsValid { get; set; }
    public List<string> Errors { get; set; } = new();
}
```

## Testing Strategies

### Unit Tests

```csharp
[TestClass]
public class CustomerServiceTests
{
    private ApplicationDbContext _context;
    private CustomerService _customerService;
    private ILogger<CustomerService> _logger;

    [TestInitialize]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _context = new ApplicationDbContext(options);
        _logger = Mock.Of<ILogger<CustomerService>>();
        _customerService = new CustomerService(_context, _logger);
    }

    [TestCleanup]
    public void Cleanup()
    {
        _context.Dispose();
    }

    [TestMethod]
    public async Task GetCustomerAsync_ExistingId_ReturnsCustomer()
    {
        // Arrange
        var customer = new Customer
        {
            CueId = "TEST001",
            Name = "Test Customer",
            Status = "Active"
        };
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();

        // Act
        var result = await _customerService.GetCustomerAsync(customer.Id);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual("TEST001", result.CueId);
    }

    [TestMethod]
    public async Task CreateCustomerAsync_ValidCustomer_ReturnsCreatedCustomer()
    {
        // Arrange
        var customer = new Customer
        {
            CueId = "NEW001",
            Name = "New Customer",
            Status = "Active"
        };

        // Act
        var result = await _customerService.CreateCustomerAsync(customer);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Id > 0);
        
        var savedCustomer = await _context.Customers.FindAsync(result.Id);
        Assert.IsNotNull(savedCustomer);
        Assert.AreEqual("NEW001", savedCustomer.CueId);
    }
}
```

### Integration Tests

```csharp
[TestClass]
public class CustomerFunctionIntegrationTests
{
    private TestServer _testServer;
    private HttpClient _client;
    private ApplicationDbContext _context;

    [TestInitialize]
    public async Task Setup()
    {
        var hostBuilder = new HostBuilder()
            .ConfigureWebHost(webHost =>
            {
                webHost.UseTestServer();
                webHost.ConfigureServices(services =>
                {
                    services.AddDbContext<ApplicationDbContext>(options =>
                        options.UseInMemoryDatabase(Guid.NewGuid().ToString()));
                });
            });

        var host = await hostBuilder.StartAsync();
        _testServer = host.GetTestServer();
        _client = _testServer.CreateClient();
        
        _context = host.Services.GetRequiredService<ApplicationDbContext>();
    }

    [TestMethod]
    public async Task GetCustomers_ReturnsOkWithData()
    {
        // Arrange
        _context.Customers.AddRange(new[]
        {
            new Customer { CueId = "TEST001", Name = "Customer 1", Status = "Active" },
            new Customer { CueId = "TEST002", Name = "Customer 2", Status = "Active" }
        });
        await _context.SaveChangesAsync();

        // Act
        var response = await _client.GetAsync("/api/GetCustomers");

        // Assert
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        
        var content = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<PagedResult<Customer>>(content);
        
        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.TotalCount);
    }

    [TestCleanup]
    public void Cleanup()
    {
        _testServer?.Dispose();
        _client?.Dispose();
        _context?.Dispose();
    }
}
```

## Performance Optimization

### Query Optimization

```csharp
// Good: Use projection to select only needed fields
public async Task<IEnumerable<CustomerSummary>> GetCustomerSummariesAsync()
{
    return await _context.Customers
        .Where(c => c.Status == "Active")
        .Select(c => new CustomerSummary
        {
            Id = c.Id,
            Name = c.Name,
            Status = c.Status,
            OrderCount = c.Orders.Count()
        })
        .ToListAsync();
}

// Good: Use AsNoTracking for read-only queries
public async Task<IEnumerable<Customer>> GetCustomersReadOnlyAsync()
{
    return await _context.Customers
        .AsNoTracking()
        .Where(c => c.Status == "Active")
        .ToListAsync();
}

// Good: Use pagination for large datasets
public async Task<PagedResult<Customer>> GetCustomersPagedAsync(int page, int pageSize)
{
    var query = _context.Customers.AsNoTracking();
    
    var totalCount = await query.CountAsync();
    var customers = await query
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .ToListAsync();

    return new PagedResult<Customer>
    {
        Data = customers,
        TotalCount = totalCount,
        Page = page,
        PageSize = pageSize
    };
}
```

### Caching Strategies

```csharp
public class CachedCustomerService
{
    private readonly ICustomerRepository _repository;
    private readonly IMemoryCache _cache;
    private readonly ILogger<CachedCustomerService> _logger;

    public CachedCustomerService(
        ICustomerRepository repository, 
        IMemoryCache cache, 
        ILogger<CachedCustomerService> logger)
    {
        _repository = repository;
        _cache = cache;
        _logger = logger;
    }

    public async Task<Customer?> GetCustomerAsync(int id)
    {
        var cacheKey = $"customer_{id}";
        
        if (_cache.TryGetValue(cacheKey, out Customer? cachedCustomer))
        {
            _logger.LogDebug("Customer {Id} retrieved from cache", id);
            return cachedCustomer;
        }

        var customer = await _repository.GetByIdAsync(id);
        if (customer != null)
        {
            var cacheOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10),
                SlidingExpiration = TimeSpan.FromMinutes(5)
            };
            
            _cache.Set(cacheKey, customer, cacheOptions);
            _logger.LogDebug("Customer {Id} cached", id);
        }

        return customer;
    }

    public async Task<Customer> UpdateCustomerAsync(Customer customer)
    {
        var updatedCustomer = await _repository.UpdateAsync(customer);
        
        // Invalidate cache
        var cacheKey = $"customer_{customer.Id}";
        _cache.Remove(cacheKey);
        _logger.LogDebug("Cache invalidated for customer {Id}", customer.Id);

        return updatedCustomer;
    }
}
```

## Security Best Practices

### Input Validation and Sanitization

```csharp
public class SecurityHelper
{
    public static string SanitizeInput(string input, int maxLength = 255)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        // Remove potentially dangerous characters
        var sanitized = input.Trim()
            .Replace("<", "&lt;")
            .Replace(">", "&gt;")
            .Replace("\"", "&quot;")
            .Replace("'", "&#x27;")
            .Replace("/", "&#x2F;");

        // Truncate if too long
        if (sanitized.Length > maxLength)
            sanitized = sanitized.Substring(0, maxLength);

        return sanitized;
    }

    public static bool IsValidEmail(string email)
    {
        if (string.IsNullOrEmpty(email))
            return false;

        try
        {
            var addr = new MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}
```

### Authorization Patterns

```csharp
public class AuthorizationService
{
    private readonly ILogger<AuthorizationService> _logger;

    public AuthorizationService(ILogger<AuthorizationService> logger)
    {
        _logger = logger;
    }

    public bool CanAccessCustomer(string userId, int customerId, string[] requiredRoles)
    {
        // Implement your authorization logic here
        // This is a simplified example
        
        try
        {
            // Check if user has required roles
            if (!HasRequiredRoles(userId, requiredRoles))
            {
                _logger.LogWarning("User {UserId} lacks required roles for customer {CustomerId}", 
                    userId, customerId);
                return false;
            }

            // Check if user has access to specific customer
            if (!HasCustomerAccess(userId, customerId))
            {
                _logger.LogWarning("User {UserId} denied access to customer {CustomerId}", 
                    userId, customerId);
                return false;
            }

            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error checking authorization for user {UserId}", userId);
            return false;
        }
    }

    private bool HasRequiredRoles(string userId, string[] requiredRoles)
    {
        // Implement role checking logic
        return true; // Placeholder
    }

    private bool HasCustomerAccess(string userId, int customerId)
    {
        // Implement customer access checking logic
        return true; // Placeholder
    }
}
```

## Deployment Guide

### Azure Deployment

1. **Create Azure Resources**
   ```bash
   # Create resource group
   az group create --name excellis-rg --location eastus

   # Create storage account
   az storage account create --name excellisstorage --resource-group excellis-rg --location eastus --sku Standard_LRS

   # Create function app
   az functionapp create --resource-group excellis-rg --consumption-plan-location eastus --runtime dotnet-isolated --functions-version 4 --name excellis-api --storage-account excellisstorage

   # Create SQL Database
   az sql server create --name excellis-sql --resource-group excellis-rg --location eastus --admin-user sqladmin --admin-password YourPassword123!
   az sql db create --resource-group excellis-rg --server excellis-sql --name ExcellisDb --service-objective S0
   ```

2. **Configure Application Settings**
   ```bash
   # Set connection string
   az functionapp config connection-string set --resource-group excellis-rg --name excellis-api --connection-string-type SQLAzure --settings DefaultConnection="Server=tcp:excellis-sql.database.windows.net,1433;Database=ExcellisDb;User ID=sqladmin;Password=YourPassword123!;Encrypt=true;Connection Timeout=30;"

   # Set application settings
   az functionapp config appsettings set --name excellis-api --resource-group excellis-rg --settings FUNCTIONS_WORKER_RUNTIME=dotnet-isolated
   ```

3. **Deploy Function App**
   ```bash
   # Build and publish
   dotnet publish --configuration Release --output ./publish

   # Deploy to Azure
   func azure functionapp publish excellis-api
   ```

### CI/CD Pipeline (GitHub Actions)

```yaml
name: Deploy Azure Function

on:
  push:
    branches: [ main ]
  pull_request:
    branches: [ main ]

env:
  AZURE_FUNCTIONAPP_NAME: excellis-api
  AZURE_FUNCTIONAPP_PACKAGE_PATH: '.'
  DOTNET_VERSION: '8.0.x'

jobs:
  build-and-deploy:
    runs-on: ubuntu-latest
    steps:
    - name: Checkout
      uses: actions/checkout@v3

    - name: Setup .NET
      uses: actions/setup-dotnet@v3
      with:
        dotnet-version: ${{ env.DOTNET_VERSION }}

    - name: Restore dependencies
      run: dotnet restore

    - name: Build
      run: dotnet build --configuration Release --no-restore

    - name: Test
      run: dotnet test --no-build --verbosity normal

    - name: Publish
      run: dotnet publish --configuration Release --no-build --output ./output

    - name: Deploy to Azure Function App
      uses: Azure/functions-action@v1
      with:
        app-name: ${{ env.AZURE_FUNCTIONAPP_NAME }}
        package: './output'
        publish-profile: ${{ secrets.AZURE_FUNCTIONAPP_PUBLISH_PROFILE }}
```

## Monitoring and Logging

### Application Insights Configuration

```csharp
// In Program.cs - already configured
builder.Services
    .AddApplicationInsightsTelemetryWorkerService()
    .ConfigureFunctionsApplicationInsights();
```

### Custom Telemetry

```csharp
public class TelemetryService
{
    private readonly TelemetryClient _telemetryClient;

    public TelemetryService(TelemetryClient telemetryClient)
    {
        _telemetryClient = telemetryClient;
    }

    public void TrackCustomerOperation(string operation, int customerId, TimeSpan duration, bool success)
    {
        var telemetry = new EventTelemetry("CustomerOperation");
        telemetry.Properties["Operation"] = operation;
        telemetry.Properties["CustomerId"] = customerId.ToString();
        telemetry.Properties["Success"] = success.ToString();
        telemetry.Metrics["Duration"] = duration.TotalMilliseconds;

        _telemetryClient.TrackEvent(telemetry);
    }

    public void TrackDependency(string dependencyName, string commandName, DateTimeOffset startTime, TimeSpan duration, bool success)
    {
        _telemetryClient.TrackDependency(dependencyName, commandName, startTime, duration, success);
    }
}
```

## Common Patterns

### Request/Response Models

```csharp
// Request models
public class CreateCustomerRequest
{
    public string CueId { get; set; } = string.Empty;
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string? ContactNumber { get; set; }
    public string? PaymentTerms { get; set; }
    public bool IsPublic { get; set; } = true;
}

public class UpdateCustomerRequest
{
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string? Status { get; set; }
    public string? ContactNumber { get; set; }
    public string? PaymentTerms { get; set; }
    public bool? IsPublic { get; set; }
}

public class CustomerSearchRequest
{
    public string? Name { get; set; }
    public string? Status { get; set; }
    public string? Type { get; set; }
    public bool? IsPublic { get; set; }
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}

// Response models
public class PagedResult<T>
{
    public IEnumerable<T> Data { get; set; } = new List<T>();
    public int TotalCount { get; set; }
    public int Page { get; set; }
    public int PageSize { get; set; }
    public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
}

public class ApiResponse<T>
{
    public bool Success { get; set; }
    public T? Data { get; set; }
    public string? Message { get; set; }
    public List<string> Errors { get; set; } = new();
}
```

### Helper Extensions

```csharp
public static class QueryExtensions
{
    public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool condition, Expression<Func<T, bool>> predicate)
    {
        return condition ? query.Where(predicate) : query;
    }

    public static IQueryable<T> PageBy<T>(this IQueryable<T> query, int page, int pageSize)
    {
        return query.Skip((page - 1) * pageSize).Take(pageSize);
    }
}

public static class HttpRequestExtensions
{
    public static async Task<T?> ReadJsonAsync<T>(this HttpRequest request) where T : class
    {
        try
        {
            using var reader = new StreamReader(request.Body);
            var json = await reader.ReadToEndAsync();
            return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
        }
        catch
        {
            return null;
        }
    }
}
```

---

**Last Updated**: January 2024  
**Version**: 1.0