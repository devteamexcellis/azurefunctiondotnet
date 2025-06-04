using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using excellis.Data;
using System;

// Create the Functions application builder
var builder = FunctionsApplication.CreateBuilder(args);

// Configure for Functions web application
builder.ConfigureFunctionsWebApplication();

// Add Application Insights
builder.Services
    .AddApplicationInsightsTelemetryWorkerService()
    .ConfigureFunctionsApplicationInsights();

// Register your DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    // Get connection string from configuration with null checking
    string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    
    if (string.IsNullOrEmpty(connectionString))
    {
        throw new InvalidOperationException("Connection string 'DefaultConnection' not found. Please add it to your configuration.");
    }
    
    // Use the appropriate provider with the non-null connection string
    options.UseSqlServer(connectionString);
});

// Build and run the application
builder.Build().Run();
