using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using excellis.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using Microsoft.AspNetCore.Builder;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddFunctionsWorkerDefaults();

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

var host = builder.Build();
host.Run();
