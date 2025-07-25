# Excellis API Documentation

## Overview

The Excellis API is an Azure Functions-based application built with .NET 8.0 that provides comprehensive business management functionality including customer management, order processing, asset tracking, and service management. The application uses Entity Framework Core with SQL Server for data persistence.

## Table of Contents

1. [Getting Started](#getting-started)
2. [Architecture](#architecture)
3. [Azure Functions API Endpoints](#azure-functions-api-endpoints)
4. [Data Models](#data-models)
5. [Database Context](#database-context)
6. [Configuration](#configuration)
7. [Usage Examples](#usage-examples)
8. [Error Handling](#error-handling)

## Getting Started

### Prerequisites

- .NET 8.0 SDK
- Azure Functions Core Tools v4
- SQL Server (local or Azure SQL Database)
- Azure subscription (for deployment)

### Installation

1. Clone the repository
2. Restore NuGet packages:
   ```bash
   dotnet restore
   ```
3. Configure your connection string in `local.settings.json`:
   ```json
   {
     "IsEncrypted": false,
     "Values": {
       "AzureWebJobsStorage": "UseDevelopmentStorage=true",
       "FUNCTIONS_WORKER_RUNTIME": "dotnet-isolated"
     },
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ExcellisDb;Trusted_Connection=true;"
     }
   }
   ```
4. Run the application:
   ```bash
   func start
   ```

## Architecture

The application follows a clean architecture pattern with the following components:

- **Functions/**: Azure Functions HTTP triggers
- **Models/**: Entity Framework data models
- **Data/**: Database context and data access layer
- **Program.cs**: Application startup and dependency injection configuration

### Technology Stack

- **Framework**: .NET 8.0
- **Runtime**: Azure Functions v4
- **ORM**: Entity Framework Core 9.0.5
- **Database**: SQL Server
- **Monitoring**: Application Insights

## Azure Functions API Endpoints

### 1. HttpTrigger1

**Endpoint**: `/api/HttpTrigger1`  
**Methods**: GET, POST  
**Authorization**: Anonymous  
**Description**: Basic health check endpoint

#### Request
```http
GET /api/HttpTrigger1
```

#### Response
```json
"Welcome to Azure Functions123!"
```

#### Example Usage
```bash
curl -X GET "http://localhost:7071/api/HttpTrigger1"
```

### 2. GetData

**Endpoint**: `/api/GetData`  
**Methods**: GET  
**Authorization**: Function level  
**Description**: Retrieves all customers from the database

#### Request
```http
GET /api/GetData
```

#### Response
```json
[
  {
    "id": 1,
    "cueId": "CUE001",
    "legacyId": "LEG001",
    "name": "Customer Name",
    "type": "Corporate",
    "status": "Active",
    "contactNumber": "+1234567890",
    "paymentTerms": "NET30",
    "timestamp": "2024-01-01T00:00:00Z",
    "isPublic": true
  }
]
```

#### Example Usage
```bash
curl -X GET "http://localhost:7071/api/GetData" \
  -H "x-functions-key: YOUR_FUNCTION_KEY"
```

## Data Models

### Core Business Entities

#### Customer Model

Represents a business customer in the system.

```csharp
public partial class Customer
{
    public int Id { get; set; }
    public string CueId { get; set; } = null!;
    public string? LegacyId { get; set; }
    public string? FkPriceListCode { get; set; }
    public int? FkTimezoneId { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string? Status { get; set; }
    public string? ContactNumber { get; set; }
    public string? Duns { get; set; }
    public int? MinOrderValue { get; set; }
    public string? PaymentTerms { get; set; }
    public string? TpiAccount { get; set; }
    public string? ClientGroupType { get; set; }
    public DateTime? Timestamp { get; set; }
    public DateTime? DateModified { get; set; }
    public string? Regional { get; set; }
    public bool? IsPublic { get; set; }
    public bool? HasEmailTemplate { get; set; }
    public bool? HasTwilio { get; set; }
    public string? Classification { get; set; }
    public int? Rank { get; set; }
}
```

**Properties:**
- `Id`: Unique identifier
- `CueId`: Business identifier (required)
- `Name`: Customer name
- `Type`: Customer classification (Corporate, Individual, etc.)
- `Status`: Current status (Active, Inactive, etc.)
- `PaymentTerms`: Payment terms (NET30, COD, etc.)
- `IsPublic`: Whether customer is publicly visible

#### Order Model

Represents a customer order with billing and shipping information.

```csharp
public partial class Order
{
    public string Id { get; set; } = null!;
    public int FkCustomerId { get; set; }
    public int FkCustomerIdShip { get; set; }
    public int FkCustomerIdBill { get; set; }
    public string FkUserId { get; set; } = null!;
    public string? FkShipmentId { get; set; }
    public int? FkShipTypeId { get; set; }
    public int? FkShipVendorId { get; set; }
    public DateTime Timestamp { get; set; }
    public string? PoNumber { get; set; }
    public DateTime? DateModified { get; set; }
    public string OrderStatus { get; set; } = null!;
    public string BillAddrCountry { get; set; } = null!;
    public string BillAddrState { get; set; } = null!;
    public string BillAddrCity { get; set; } = null!;
    public string BillAddrStreet { get; set; } = null!;
    public string BillAddrZipcode { get; set; } = null!;
    public string ShipAddrCountry { get; set; } = null!;
    public string ShipAddrState { get; set; } = null!;
    public string ShipAddrCity { get; set; } = null!;
    public string ShipAddrStreet { get; set; } = null!;
    public string ShipAddrZipcode { get; set; } = null!;
}
```

**Properties:**
- `Id`: Unique order identifier
- `FkCustomerId`: Reference to customer
- `PoNumber`: Purchase order number
- `OrderStatus`: Current order status
- `BillAddr*`: Billing address components
- `ShipAddr*`: Shipping address components

#### Account Model

Represents customer accounts for service management.

```csharp
public partial class Account
{
    public int Id { get; set; }
    public int FkCustomerId { get; set; }
    public string? LegacyId { get; set; }
    public string Name { get; set; } = null!;
    public string Type { get; set; } = null!;
    public string Status { get; set; } = null!;
    public string? ContactNumber { get; set; }
    public string? ContactPerson { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public string CreatedBy { get; set; } = null!;
    public bool IsPublic { get; set; }
}
```

#### Service Model

Represents services offered to customers.

```csharp
public partial class Service
{
    public int Id { get; set; }
    public int FkCustomerId { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Status { get; set; } = null!;
    public string ServiceCode { get; set; } = null!;
    public string? LegacyId { get; set; }
    public string Type { get; set; } = null!;
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? ActualChargerStatus { get; set; }
    public DateTime? LastHeartbeat { get; set; }
}
```

#### Asset Model

Represents physical assets managed by the system.

```csharp
public partial class Asset
{
    public int Id { get; set; }
    public int FkProductId { get; set; }
    public string SerialNumber { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; } = null!;
    public bool IsRental { get; set; }
    public bool IsInInventory { get; set; }
    public string? LegacyAssetId { get; set; }
    public int? ReferenceInvId { get; set; }
    public int? ReferenceCustomerAaId { get; set; }
    public int? FkInventoryLocationId { get; set; }
    public DateOnly? DateOfManufacture { get; set; }
    public double? Capacity { get; set; }
    public string? CapacityUnit { get; set; }
    public double? UsableCapacity { get; set; }
    public double? ReserveCapacity { get; set; }
    public DateOnly? DateInstalled { get; set; }
}
```

#### Response Model

Represents form responses and surveys.

```csharp
public partial class Response
{
    public int Id { get; set; }
    public int FkCustomerId { get; set; }
    public string ResponseCode { get; set; } = null!;
    public DateTime DateSubmitted { get; set; }
    public int FormReferenceId { get; set; }
    public string FormType { get; set; } = null!;
    public string FormName { get; set; } = null!;
    public string? RespondentUserId { get; set; }
    public string? RespondentName { get; set; }
    public string? RespondentEmail { get; set; }
    public string? RespondentContactNumber { get; set; }
}
```

### Supporting Models

The system includes numerous supporting models for comprehensive business management:

- **Category & CategoryLevel**: Product categorization
- **ClientContact & ClientGroup**: Client relationship management
- **CustomerAddress**: Customer address management
- **Inventory Models**: Stock and warehouse management
- **Manufacturing Models**: Production tracking
- **User Management**: Authentication and authorization
- **Audit Models**: Change tracking and logging

## Database Context

### ApplicationDbContext

The `ApplicationDbContext` provides access to all data entities through Entity Framework Core.

```csharp
public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
    // Core entities
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<Account> Accounts { get; set; }
    public virtual DbSet<Service> Services { get; set; }
    public virtual DbSet<Asset> Assets { get; set; }
    public virtual DbSet<Response> Responses { get; set; }
    
    // ... and many more DbSets for comprehensive data management
}
```

### DbContextFactory

For design-time operations and migrations:

```csharp
public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        // Loads configuration and creates DbContext for design-time operations
    }
}
```

## Configuration

### Dependency Injection Setup

The application is configured in `Program.cs`:

```csharp
var builder = FunctionsApplication.CreateBuilder(args);

// Configure Functions
builder.ConfigureFunctionsWebApplication();

// Add Application Insights
builder.Services
    .AddApplicationInsightsTelemetryWorkerService()
    .ConfigureFunctionsApplicationInsights();

// Register DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    if (string.IsNullOrEmpty(connectionString))
    {
        throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
    }
    options.UseSqlServer(connectionString);
});

builder.Build().Run();
```

### Required Configuration

#### local.settings.json (Development)
```json
{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "UseDevelopmentStorage=true",
    "FUNCTIONS_WORKER_RUNTIME": "dotnet-isolated",
    "APPINSIGHTS_INSTRUMENTATIONKEY": "your-app-insights-key"
  },
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ExcellisDb;Trusted_Connection=true;"
  }
}
```

#### host.json
```json
{
  "version": "2.0",
  "logging": {
    "applicationInsights": {
      "samplingSettings": {
        "isEnabled": true,
        "excludedTypes": "Request"
      },
      "enableLiveMetricsFilters": true
    }
  }
}
```

## Usage Examples

### Creating a Customer Service

```csharp
public class CustomerService
{
    private readonly ApplicationDbContext _context;
    
    public CustomerService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<Customer> CreateCustomerAsync(Customer customer)
    {
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();
        return customer;
    }
    
    public async Task<Customer?> GetCustomerAsync(int id)
    {
        return await _context.Customers
            .Include(c => c.CustomerAddresses)
            .FirstOrDefaultAsync(c => c.Id == id);
    }
    
    public async Task<List<Customer>> GetActiveCustomersAsync()
    {
        return await _context.Customers
            .Where(c => c.Status == "Active")
            .OrderBy(c => c.Name)
            .ToListAsync();
    }
}
```

### Order Management Example

```csharp
public class OrderService
{
    private readonly ApplicationDbContext _context;
    
    public async Task<Order> CreateOrderAsync(Order order)
    {
        order.Timestamp = DateTime.UtcNow;
        order.OrderStatus = "Pending";
        
        _context.Orders.Add(order);
        await _context.SaveChangesAsync();
        return order;
    }
    
    public async Task<List<Order>> GetCustomerOrdersAsync(int customerId)
    {
        return await _context.Orders
            .Where(o => o.FkCustomerId == customerId)
            .OrderByDescending(o => o.Timestamp)
            .ToListAsync();
    }
}
```

### Asset Tracking Example

```csharp
public class AssetService
{
    private readonly ApplicationDbContext _context;
    
    public async Task<Asset> CreateAssetAsync(Asset asset)
    {
        asset.DateCreated = DateTime.UtcNow;
        asset.IsInInventory = true;
        
        _context.Assets.Add(asset);
        await _context.SaveChangesAsync();
        return asset;
    }
    
    public async Task<List<Asset>> GetAvailableAssetsAsync()
    {
        return await _context.Assets
            .Where(a => a.IsInInventory && !a.IsRental)
            .ToListAsync();
    }
}
```

## Error Handling

### Common Error Responses

#### 400 Bad Request
```json
{
  "error": "Invalid request parameters",
  "details": "Customer ID is required"
}
```

#### 401 Unauthorized
```json
{
  "error": "Unauthorized",
  "details": "Function key is required for this endpoint"
}
```

#### 404 Not Found
```json
{
  "error": "Resource not found",
  "details": "Customer with ID 123 not found"
}
```

#### 500 Internal Server Error
```json
{
  "error": "Internal server error",
  "details": "An unexpected error occurred while processing the request"
}
```

### Best Practices

1. **Always validate input parameters**
2. **Use appropriate HTTP status codes**
3. **Include meaningful error messages**
4. **Log errors for debugging**
5. **Handle database connection issues gracefully**

### Logging Example

```csharp
[Function("CreateCustomer")]
public async Task<HttpResponseData> CreateCustomer(
    [HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req)
{
    _logger.LogInformation("Creating new customer");
    
    try
    {
        // Process request
        _logger.LogInformation("Customer created successfully with ID: {CustomerId}", customer.Id);
        return response;
    }
    catch (Exception ex)
    {
        _logger.LogError(ex, "Error creating customer");
        var errorResponse = req.CreateResponse(HttpStatusCode.InternalServerError);
        await errorResponse.WriteAsJsonAsync(new { error = "Failed to create customer" });
        return errorResponse;
    }
}
```

## Development Guidelines

### Adding New Functions

1. Create a new class in the `Functions` folder
2. Add the `[Function]` attribute with a unique name
3. Use dependency injection for services
4. Follow consistent error handling patterns
5. Add appropriate logging
6. Update this documentation

### Database Changes

1. Update the model classes in the `Models` folder
2. Create and run Entity Framework migrations
3. Update the `ApplicationDbContext` if needed
4. Test with sample data

### Testing

- Use integration tests for Azure Functions
- Mock the `ApplicationDbContext` for unit tests
- Test error scenarios and edge cases
- Validate all API responses

---

## Support

For questions or issues with the Excellis API, please contact the development team or create an issue in the project repository.

**Version**: 1.0  
**Last Updated**: January 2024  
**Framework**: .NET 8.0 / Azure Functions v4