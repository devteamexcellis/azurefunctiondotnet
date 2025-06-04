using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using excellis.Database;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace excellis.Functions
{
    public class DatabaseFunction
    {
        private readonly ILogger _logger;
        private readonly ApplicationDbContext _dbContext;

        public DatabaseFunction(ILoggerFactory loggerFactory, ApplicationDbContext dbContext)
        {
            _logger = loggerFactory.CreateLogger<DatabaseFunction>();
            _dbContext = dbContext;
        }

        [Function("GetData")]
        public async Task<HttpResponseData> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            // Example query using EF Core
            var data = await _dbContext.Customers.ToListAsync();

            var response = req.CreateResponse(HttpStatusCode.OK);
            await response.WriteAsJsonAsync(data);
            
            return response;
        }
    }
}
