using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using excellis.Data;
using excellis.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace excellis.Functions
{
    public class DatabaseConnectionTest
    {
        private readonly ILogger _logger;
        private readonly ApplicationDbContext _dbContext;

        public DatabaseConnectionTest(ILoggerFactory loggerFactory, ApplicationDbContext dbContext)
        {
            _logger = loggerFactory.CreateLogger<DatabaseConnectionTest>();
            _dbContext = dbContext;
        }

        [Function("TestConnection")]
        public async Task<HttpResponseData> TestConnection(
            [HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequestData req)
        {
            _logger.LogInformation("Testing database connection...");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "application/json; charset=utf-8");

            try
            {
                // Test basic connection
                var canConnect = await _dbContext.Database.CanConnectAsync();
                
                if (!canConnect)
                {
                    var errorResult = new
                    {
                        status = "error",
                        message = "Cannot connect to database",
                        connectionString = _dbContext.Database.GetConnectionString()?.Replace("Password=root", "Password=***"),
                        timestamp = DateTime.UtcNow
                    };
                    
                    await response.WriteAsJsonAsync(errorResult);
                    response.StatusCode = HttpStatusCode.ServiceUnavailable;
                    return response;
                }

                // Test a simple query with cursor-like pagination
                var customerCount = await _dbContext.Customers.CountAsync();
                var firstCustomers = await _dbContext.Customers
                    .OrderBy(c => c.Id)
                    .Take(5)
                    .Select(c => new { c.Id, c.CueId, c.DateModified })
                    .ToListAsync();

                var result = new
                {
                    status = "success",
                    message = "Database connection successful",
                    connectionTest = new
                    {
                        canConnect = true,
                        totalCustomers = customerCount,
                        sampleCustomers = firstCustomers,
                        cursorPaginationTest = "Working - can retrieve ordered data"
                    },
                    timestamp = DateTime.UtcNow
                };

                await response.WriteAsJsonAsync(result);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Database connection test failed");
                
                var errorResult = new
                {
                    status = "error",
                    message = "Database connection failed",
                    error = ex.Message,
                    innerException = ex.InnerException?.Message,
                    connectionString = _dbContext.Database.GetConnectionString()?.Replace("Password=root", "Password=***"),
                    timestamp = DateTime.UtcNow
                };

                await response.WriteAsJsonAsync(errorResult);
                response.StatusCode = HttpStatusCode.InternalServerError;
                return response;
            }
        }

        [Function("TestPagination")]
        public async Task<HttpResponseData> TestPagination(
            [HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequestData req)
        {
            _logger.LogInformation("Testing cursor-based pagination...");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "application/json; charset=utf-8");

            try
            {
                // Parse query parameters for cursor pagination
                var query = System.Web.HttpUtility.ParseQueryString(req.Url.Query);
                var pageSize = int.TryParse(query["pageSize"], out var size) ? size : 10;
                var cursor = query["cursor"]; // This would be the last ID from previous page

                IQueryable<Customer> customerQuery = _dbContext.Customers.OrderBy(c => c.Id);

                if (!string.IsNullOrEmpty(cursor) && int.TryParse(cursor, out var cursorId))
                {
                    customerQuery = customerQuery.Where(c => c.Id > cursorId);
                }

                var customers = await customerQuery
                    .Take(pageSize)
                    .Select(c => new { c.Id, c.CueId, c.DateModified })
                    .ToListAsync();

                var nextCursor = customers.Any() ? customers.Last().Id.ToString() : null;

                var result = new
                {
                    status = "success",
                    data = customers,
                                         pagination = new
                     {
                         pageSize,
                         currentCursor = cursor,
                         nextCursor,
                         hasMore = customers.Count() == pageSize
                     },
                    timestamp = DateTime.UtcNow
                };

                await response.WriteAsJsonAsync(result);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Pagination test failed");
                
                var errorResult = new
                {
                    status = "error",
                    message = "Pagination test failed",
                    error = ex.Message,
                    timestamp = DateTime.UtcNow
                };

                await response.WriteAsJsonAsync(errorResult);
                response.StatusCode = HttpStatusCode.InternalServerError;
                return response;
            }
        }
    }
}