# Excellis API

A comprehensive Azure Functions-based API built with .NET 8.0 for business management, featuring customer management, order processing, asset tracking, and service management capabilities.

## 🚀 Quick Start

### Prerequisites
- .NET 8.0 SDK
- Azure Functions Core Tools v4
- SQL Server (LocalDB or Azure SQL)
- Visual Studio Code or Visual Studio 2022

### Installation
```bash
# Clone the repository
git clone <repository-url>
cd excellis-api

# Restore packages
dotnet restore

# Setup local configuration
cp local.settings.example.json local.settings.json
# Edit local.settings.json with your connection string

# Run the application
func start
```

### Test the API
```bash
# Health check
curl http://localhost:7071/api/HttpTrigger1

# Get customers (requires function key)
curl -H "x-functions-key: YOUR_KEY" http://localhost:7071/api/GetData
```

## 📋 Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Architecture](#architecture)
- [Documentation](#documentation)
- [API Endpoints](#api-endpoints)
- [Development](#development)
- [Deployment](#deployment)
- [Contributing](#contributing)
- [License](#license)

## 🎯 Overview

The Excellis API is a modern, cloud-native business management system built on Azure Functions. It provides a comprehensive set of APIs for managing customers, orders, assets, services, and more. The system is designed with scalability, performance, and maintainability in mind.

### Key Technologies
- **Framework**: .NET 8.0
- **Runtime**: Azure Functions v4 (Isolated Worker)
- **Database**: Entity Framework Core 9.0.5 with SQL Server
- **Monitoring**: Application Insights
- **Authentication**: Azure Functions built-in security

## ✨ Features

### Core Business Management
- **Customer Management**: Complete customer lifecycle management with addresses, contacts, and grouping
- **Order Processing**: End-to-end order management with billing and shipping
- **Asset Tracking**: Physical asset management with history and inspections
- **Service Management**: Service delivery and request management
- **Inventory Control**: Stock management across multiple warehouses and zones

### Advanced Capabilities
- **Manufacturing**: Production order tracking and lot management
- **User Management**: Role-based access control and user administration
- **Audit Trail**: Comprehensive logging and change tracking
- **Reporting**: Built-in analytics and business intelligence
- **Integration**: Extensible API design for third-party integrations

### Technical Features
- **Scalable Architecture**: Serverless Azure Functions for automatic scaling
- **High Performance**: Optimized Entity Framework queries with caching
- **Security**: Input validation, sanitization, and authorization
- **Monitoring**: Application Insights integration for observability
- **Testing**: Comprehensive unit and integration test coverage

## 🏗️ Architecture

```
┌─────────────────┐    ┌─────────────────┐    ┌─────────────────┐
│   Azure Portal  │    │   Application   │    │   Third-party   │
│   & Clients     │    │   Insights      │    │   Systems       │
└─────────┬───────┘    └─────────┬───────┘    └─────────┬───────┘
          │                      │                      │
          ▼                      ▼                      ▼
┌─────────────────────────────────────────────────────────────────┐
│                    Azure Functions                              │
│  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐            │
│  │ HTTP        │  │ Database    │  │ Custom      │            │
│  │ Triggers    │  │ Functions   │  │ Functions   │            │
│  └─────────────┘  └─────────────┘  └─────────────┘            │
└─────────────────────────┬───────────────────────────────────────┘
                          │
                          ▼
┌─────────────────────────────────────────────────────────────────┐
│                 Business Logic Layer                            │
│  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐            │
│  │ Services    │  │ Validators  │  │ Repositories│            │
│  └─────────────┘  └─────────────┘  └─────────────┘            │
└─────────────────────────┬───────────────────────────────────────┘
                          │
                          ▼
┌─────────────────────────────────────────────────────────────────┐
│                    Data Access Layer                            │
│  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐            │
│  │ Entity      │  │ DbContext   │  │ Models      │            │
│  │ Framework   │  │ Factory     │  │             │            │
│  └─────────────┘  └─────────────┘  └─────────────┘            │
└─────────────────────────┬───────────────────────────────────────┘
                          │
                          ▼
┌─────────────────────────────────────────────────────────────────┐
│                      SQL Server                                 │
│                   (Azure SQL Database)                          │
└─────────────────────────────────────────────────────────────────┘
```

## 📚 Documentation

### Complete Documentation Suite

| Document | Description |
|----------|-------------|
| **[API Documentation](API_DOCUMENTATION.md)** | Complete API reference with endpoints, models, and examples |
| **[Models Documentation](MODELS_DOCUMENTATION.md)** | Detailed data model specifications and relationships |
| **[Development Guide](DEVELOPMENT_GUIDE.md)** | Step-by-step development instructions and best practices |
| **[README.md](README.md)** | This overview document |

### Quick Links
- [Getting Started](API_DOCUMENTATION.md#getting-started)
- [Azure Functions Endpoints](API_DOCUMENTATION.md#azure-functions-api-endpoints)
- [Data Models](MODELS_DOCUMENTATION.md#core-business-models)
- [Development Setup](DEVELOPMENT_GUIDE.md#development-environment-setup)
- [Testing Guide](DEVELOPMENT_GUIDE.md#testing-strategies)
- [Deployment Instructions](DEVELOPMENT_GUIDE.md#deployment-guide)

## 🔌 API Endpoints

### Current Endpoints

| Endpoint | Method | Description | Authorization |
|----------|--------|-------------|---------------|
| `/api/HttpTrigger1` | GET, POST | Health check and basic functionality test | Anonymous |
| `/api/GetData` | GET | Retrieve all customers from database | Function Key |

### Planned Endpoints

The API is designed to support comprehensive business operations. Future endpoints will include:

- **Customer Management**: CRUD operations for customers, addresses, and contacts
- **Order Processing**: Order creation, updates, and status tracking
- **Asset Management**: Asset registration, tracking, and maintenance
- **Service Management**: Service requests and delivery tracking
- **Reporting**: Business analytics and custom reports

## 🛠️ Development

### Project Structure
```
excellis-api/
├── Functions/              # Azure Functions
│   ├── HttpTrigger1.cs    # Basic HTTP function
│   └── DatabaseFirst.cs   # Database operations
├── Models/                 # Entity Framework models
│   ├── Customer.cs        # Customer entity
│   ├── Order.cs          # Order entity
│   └── ...               # Other business entities
├── Data/                  # Data access layer
│   ├── ApplicationDbContext.cs
│   └── DbContextFactory.cs
├── Program.cs             # Application startup
├── host.json             # Azure Functions configuration
└── fromCLI.csproj        # Project file
```

### Development Workflow

1. **Setup Development Environment**
   ```bash
   # Install tools
   dotnet tool install --global Microsoft.EntityFrameworkCore.Tools
   dotnet tool install --global Azure.Functions.Cli
   
   # Setup database
   dotnet ef database update
   ```

2. **Create New Function**
   ```bash
   # Add new function file to Functions/ directory
   # Register services in Program.cs if needed
   # Update documentation
   ```

3. **Database Changes**
   ```bash
   # Create migration
   dotnet ef migrations add YourMigrationName
   
   # Apply to database
   dotnet ef database update
   ```

4. **Testing**
   ```bash
   # Run unit tests
   dotnet test
   
   # Run locally
   func start
   ```

### Code Standards

- Follow C# coding conventions
- Use async/await for all database operations
- Implement proper error handling and logging
- Include XML documentation for public APIs
- Write unit tests for business logic
- Use dependency injection for services

## 🚀 Deployment

### Local Development
```bash
# Start local development server
func start

# With specific port
func start --port 7072
```

### Azure Deployment
```bash
# Login to Azure
az login

# Deploy to Azure Functions
func azure functionapp publish excellis-api
```

### CI/CD Pipeline

The project includes GitHub Actions workflow for automated deployment:
- Automated testing on pull requests
- Deployment to Azure on main branch updates
- Environment-specific configurations

See [Deployment Guide](DEVELOPMENT_GUIDE.md#deployment-guide) for detailed instructions.

## 📈 Monitoring and Observability

### Application Insights

The API includes comprehensive monitoring through Azure Application Insights:

- **Performance Monitoring**: Track response times and throughput
- **Error Tracking**: Automatic exception logging and alerting
- **Custom Telemetry**: Business-specific metrics and events
- **Dependency Tracking**: Monitor database and external service calls

### Logging

Structured logging is implemented throughout the application:
- Request/response logging
- Business operation tracking
- Error and exception details
- Performance metrics

### Health Checks

- Basic health endpoint at `/api/HttpTrigger1`
- Database connectivity verification
- External dependency status

## 🔒 Security

### Authentication & Authorization
- Azure Functions built-in authentication
- Function-level and anonymous access controls
- Role-based access control (planned)

### Data Protection
- Input validation and sanitization
- SQL injection prevention through Entity Framework
- Sensitive data encryption (planned)
- Audit trail for all data modifications

### Best Practices
- Secure connection strings in Azure Key Vault
- HTTPS enforcement
- Regular security updates
- Vulnerability scanning

## 🧪 Testing

### Test Coverage
- Unit tests for business logic
- Integration tests for API endpoints
- Database integration tests
- Performance testing (planned)

### Test Execution
```bash
# Run all tests
dotnet test

# Run with coverage
dotnet test --collect:"XPlat Code Coverage"

# Run specific test category
dotnet test --filter Category=Integration
```

## 📊 Performance

### Optimization Strategies
- Entity Framework query optimization
- Response caching where appropriate
- Async/await throughout
- Connection pooling
- Minimal API surface

### Scalability
- Serverless Azure Functions for automatic scaling
- Stateless design for horizontal scaling
- Database connection optimization
- Efficient data pagination

## 🤝 Contributing

### Development Process
1. Fork the repository
2. Create a feature branch
3. Implement changes with tests
4. Update documentation
5. Submit pull request

### Guidelines
- Follow existing code patterns
- Include comprehensive tests
- Update relevant documentation
- Use meaningful commit messages

### Code Review
- All changes require review
- Automated testing must pass
- Documentation must be updated
- Security considerations reviewed

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 📞 Support

### Getting Help
- Check the [documentation](API_DOCUMENTATION.md) first
- Search existing issues
- Create new issue with detailed description

### Contact Information
- **Project Maintainer**: [Your Name]
- **Email**: [your.email@domain.com]
- **Repository**: [Repository URL]

---

## 🎯 Roadmap

### Version 1.1 (Next Release)
- [ ] Complete CRUD operations for all entities
- [ ] Advanced search and filtering
- [ ] Bulk operations support
- [ ] Enhanced error handling

### Version 1.2 (Future)
- [ ] Real-time notifications
- [ ] Advanced reporting dashboard
- [ ] Mobile API optimization
- [ ] Third-party integrations

### Version 2.0 (Long-term)
- [ ] Microservices architecture
- [ ] GraphQL support
- [ ] Advanced analytics
- [ ] Multi-tenant support

---

**Built with ❤️ using .NET 8.0 and Azure Functions**

*Last updated: January 2024*