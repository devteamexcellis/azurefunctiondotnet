# Cursor Issues Troubleshooting Guide

## Problem Summary
Your Azure Functions application was experiencing "cursor stopped working" issues, which in the context of a web API typically refers to database connectivity problems affecting cursor-based pagination or data retrieval operations.

## Root Cause Identified
The main issue was **database connectivity problems** caused by:

1. **Unreachable Database Server**: The connection string points to `Server=netske-desktop`, which is not accessible from the current environment
2. **Hardcoded Connection String**: The connection string was hardcoded in the `ApplicationDbContext.cs` file, making it difficult to manage across different environments

## Fixes Applied

### 1. Configuration Management
- ✅ Created `appsettings.json` with proper configuration structure
- ✅ Created `local.settings.json` for Azure Functions local development
- ✅ Removed hardcoded connection string from `ApplicationDbContext.cs`
- ✅ Eliminated build warnings about sensitive connection string information

### 2. Diagnostic Tools
- ✅ Created `DatabaseConnectionTest.cs` with two new Azure Functions:
  - `TestConnection`: Tests basic database connectivity
  - `TestPagination`: Tests cursor-based pagination functionality

## How to Resolve the Issues

### Option 1: Fix Database Connectivity (Recommended)
1. **Update Connection String**: Modify the connection string in `local.settings.json` to point to an accessible database server:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_ACCESSIBLE_SERVER;Database=dbcueprdcac02-20241210;User Id=root;Password=root;TrustServerCertificate=True;"
     }
   }
   ```

2. **Ensure Database Server is Running**: Make sure your SQL Server instance is:
   - Running and accessible
   - Configured to accept remote connections (if needed)
   - Has the correct firewall rules

### Option 2: Use Alternative Database
If `netske-desktop` is not available, consider:
- Using SQL Server LocalDB for development
- Setting up a Docker container with SQL Server
- Using Azure SQL Database for cloud development

### Option 3: Mock Database for Testing
For testing without a database, you can implement an in-memory database:
```csharp
// In Program.cs, replace the SQL Server configuration with:
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("TestDatabase"));
```

## Testing Your Fixes

### 1. Test Database Connection
Run the application and call the test endpoint:
```bash
curl http://localhost:7071/api/TestConnection
```

### 2. Test Pagination
Test cursor-based pagination:
```bash
curl "http://localhost:7071/api/TestPagination?pageSize=5"
curl "http://localhost:7071/api/TestPagination?pageSize=5&cursor=123"
```

### 3. Test Original Functions
Test your existing functions:
```bash
curl http://localhost:7071/api/HttpTrigger1
curl http://localhost:7071/api/GetData
```

## Running the Application

1. **Start the Function App**:
   ```bash
   export PATH="$HOME/.dotnet:$PATH"
   func start
   ```

2. **If you don't have Azure Functions Core Tools installed**:
   ```bash
   npm install -g azure-functions-core-tools@4 --unsafe-perm true
   ```

## Common Cursor-Related Issues and Solutions

### 1. Database Connection Timeouts
- **Symptom**: Functions timeout when accessing database
- **Solution**: Check connection string and database availability

### 2. Pagination Not Working
- **Symptom**: Data retrieval returns inconsistent results
- **Solution**: Ensure proper ordering in queries and cursor implementation

### 3. Memory Issues with Large Datasets
- **Symptom**: Application crashes or becomes slow with large result sets
- **Solution**: Implement proper cursor-based pagination instead of loading all data

## Best Practices for Cursor Implementation

1. **Always Order Results**: Use consistent ordering (usually by ID or timestamp)
2. **Use Proper Indexing**: Ensure database indexes support your cursor queries
3. **Implement Error Handling**: Handle database connection failures gracefully
4. **Use Configuration**: Never hardcode connection strings
5. **Test Pagination**: Always test with various page sizes and cursor positions

## Environment-Specific Configuration

### Development
- Use `local.settings.json` for local development
- Consider using LocalDB or Docker containers

### Production
- Use Azure App Configuration or Key Vault for connection strings
- Implement proper logging and monitoring
- Use connection pooling and retry policies

## Next Steps

1. **Fix the database connection** by updating the connection string to point to an accessible server
2. **Test the diagnostic endpoints** to verify connectivity
3. **Implement proper error handling** in your existing functions
4. **Consider implementing retry policies** for database operations
5. **Add logging** to track cursor-based operations

## Need Further Help?

If you continue experiencing issues:
1. Check the diagnostic endpoints first
2. Review application logs for specific error messages
3. Verify network connectivity to your database server
4. Test with a minimal connection string to isolate issues

The diagnostic functions I've added will help you identify exactly what's causing the cursor issues in your application.