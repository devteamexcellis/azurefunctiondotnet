# Data Models Documentation

## Overview

This document provides comprehensive documentation for all data models in the Excellis system. The models are designed using Entity Framework Core and follow domain-driven design principles.

## Table of Contents

1. [Core Business Models](#core-business-models)
2. [Customer Management Models](#customer-management-models)
3. [Order Management Models](#order-management-models)
4. [Asset Management Models](#asset-management-models)
5. [Service Management Models](#service-management-models)
6. [User Management Models](#user-management-models)
7. [Inventory Management Models](#inventory-management-models)
8. [Manufacturing Models](#manufacturing-models)
9. [Audit and Logging Models](#audit-and-logging-models)
10. [Supporting Models](#supporting-models)

## Core Business Models

### Customer

**Namespace**: `excellis.Models`  
**Description**: Represents a business customer in the system with comprehensive business information.

```csharp
public partial class Customer
{
    public int Id { get; set; }                    // Primary Key
    public string CueId { get; set; } = null!;     // Business Identifier (Required)
    public string? LegacyId { get; set; }          // Legacy System Reference
    public string? FkPriceListCode { get; set; }   // Price List Reference
    public int? FkTimezoneId { get; set; }         // Timezone Reference
    public string? Name { get; set; }              // Customer Name
    public string? Type { get; set; }              // Customer Type
    public string? Status { get; set; }            // Current Status
    public string? ContactNumber { get; set; }     // Primary Contact
    public string? Duns { get; set; }              // DUNS Number
    public int? MinOrderValue { get; set; }        // Minimum Order Value
    public string? PaymentTerms { get; set; }      // Payment Terms
    public string? TpiAccount { get; set; }        // TPI Account Reference
    public string? ClientGroupType { get; set; }   // Client Group Classification
    public DateTime? Timestamp { get; set; }       // Creation Timestamp
    public DateTime? DateModified { get; set; }    // Last Modified Date
    public string? Regional { get; set; }          // Regional Classification
    public bool? IsPublic { get; set; }            // Public Visibility Flag
    public bool? HasEmailTemplate { get; set; }    // Email Template Flag
    public bool? HasTwilio { get; set; }           // Twilio Integration Flag
    public string? Classification { get; set; }    // Customer Classification
    public int? Rank { get; set; }                 // Customer Ranking
}
```

**Usage Examples:**
```csharp
// Create a new customer
var customer = new Customer
{
    CueId = "CUE001",
    Name = "Acme Corporation",
    Type = "Corporate",
    Status = "Active",
    PaymentTerms = "NET30",
    IsPublic = true
};

// Filter active customers
var activeCustomers = context.Customers
    .Where(c => c.Status == "Active")
    .ToList();
```

### Order

**Namespace**: `excellis.Models`  
**Description**: Represents customer orders with comprehensive billing and shipping information.

```csharp
public partial class Order
{
    public string Id { get; set; } = null!;        // Primary Key
    public int FkCustomerId { get; set; }          // Customer Reference
    public int FkCustomerIdShip { get; set; }      // Shipping Customer Reference
    public int FkCustomerIdBill { get; set; }      // Billing Customer Reference
    public string FkUserId { get; set; } = null!;  // User Reference
    public string? FkShipmentId { get; set; }      // Shipment Reference
    public int? FkShipTypeId { get; set; }         // Shipping Type Reference
    public int? FkShipVendorId { get; set; }       // Shipping Vendor Reference
    public DateTime Timestamp { get; set; }        // Order Creation Time
    public string? PoNumber { get; set; }          // Purchase Order Number
    public DateTime? DateModified { get; set; }    // Last Modified Date
    public string OrderStatus { get; set; } = null!; // Order Status
    
    // Billing Address
    public string BillAddrCountry { get; set; } = null!;
    public string BillAddrState { get; set; } = null!;
    public string BillAddrCity { get; set; } = null!;
    public string BillAddrStreet { get; set; } = null!;
    public string BillAddrZipcode { get; set; } = null!;
    
    // Shipping Address
    public string ShipAddrCountry { get; set; } = null!;
    public string ShipAddrState { get; set; } = null!;
    public string ShipAddrCity { get; set; } = null!;
    public string ShipAddrStreet { get; set; } = null!;
    public string ShipAddrZipcode { get; set; } = null!;
}
```

**Common Order Statuses:**
- `Pending`: Order created but not processed
- `Processing`: Order being prepared
- `Shipped`: Order has been shipped
- `Delivered`: Order delivered to customer
- `Cancelled`: Order cancelled
- `Returned`: Order returned by customer

## Customer Management Models

### CustomerAddress

**Description**: Manages multiple addresses for customers including billing, shipping, and service addresses.

```csharp
public partial class CustomerAddress
{
    public int Id { get; set; }
    public int FkCustomerId { get; set; }
    public string? LegacyId { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }              // Address Type (Billing, Shipping, Service)
    public string? Status { get; set; }
    public string? ContactPerson { get; set; }
    public string? ContactNumber { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Zipcode { get; set; }
    public string? Country { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public DateTime? Timestamp { get; set; }
    public DateTime? DateModified { get; set; }
    public bool? IsDefault { get; set; }           // Default Address Flag
    public bool? IsPublic { get; set; }
}
```

### CustomerContact

**Description**: Manages contact information for customers.

```csharp
public partial class CustomerContact
{
    public int Id { get; set; }
    public int FkCustomerId { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Mobile { get; set; }
    public string? Type { get; set; }              // Contact Type (Primary, Secondary, Technical)
    public bool? IsActive { get; set; }
    public DateTime? DateCreated { get; set; }
}
```

### CustomerGroup

**Description**: Groups customers for management and reporting purposes.

```csharp
public partial class CustomerGroup
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string? Type { get; set; }
    public string Status { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; } = null!;
    public bool IsPublic { get; set; }
}
```

## Asset Management Models

### Asset

**Description**: Represents physical assets managed by the system including equipment, vehicles, and devices.

```csharp
public partial class Asset
{
    public int Id { get; set; }
    public int FkProductId { get; set; }           // Product Reference
    public string SerialNumber { get; set; } = null!; // Unique Serial Number
    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; } = null!;
    public bool IsRental { get; set; }             // Rental Asset Flag
    public bool IsInInventory { get; set; }        // Inventory Status
    public string? LegacyAssetId { get; set; }     // Legacy System Reference
    public int? ReferenceInvId { get; set; }       // Inventory Reference
    public int? ReferenceCustomerAaId { get; set; } // Customer Address Reference
    public int? FkInventoryLocationId { get; set; } // Location Reference
    public DateOnly? DateOfManufacture { get; set; } // Manufacturing Date
    public double? Capacity { get; set; }          // Asset Capacity
    public string? CapacityUnit { get; set; }      // Capacity Unit
    public double? UsableCapacity { get; set; }    // Usable Capacity
    public double? ReserveCapacity { get; set; }   // Reserve Capacity
    public DateOnly? DateInstalled { get; set; }   // Installation Date
}
```

### AssetHistory

**Description**: Tracks historical changes and movements of assets.

```csharp
public partial class AssetHistory
{
    public int Id { get; set; }
    public int FkAssetId { get; set; }
    public string Action { get; set; } = null!;    // Action Type (Created, Moved, Serviced, etc.)
    public string? Description { get; set; }
    public string? PreviousValue { get; set; }
    public string? NewValue { get; set; }
    public DateTime Timestamp { get; set; }
    public string ActionBy { get; set; } = null!;
    public string? Location { get; set; }
    public string? Notes { get; set; }
}
```

### AssetInspection

**Description**: Records asset inspections and maintenance activities.

```csharp
public partial class AssetInspection
{
    public int Id { get; set; }
    public int FkAssetId { get; set; }
    public DateTime InspectionDate { get; set; }
    public string InspectedBy { get; set; } = null!;
    public string InspectionType { get; set; } = null!; // Type (Routine, Emergency, Preventive)
    public string Status { get; set; } = null!;     // Status (Pass, Fail, Needs Attention)
    public string? Notes { get; set; }
    public string? Recommendations { get; set; }
    public DateTime? NextInspectionDate { get; set; }
}
```

## Service Management Models

### Service

**Description**: Represents services offered to customers including location-based services.

```csharp
public partial class Service
{
    public int Id { get; set; }
    public int FkCustomerId { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Status { get; set; } = null!;
    public string ServiceCode { get; set; } = null!;   // Unique Service Code
    public string? LegacyId { get; set; }
    public string Type { get; set; } = null!;          // Service Type
    public double? Latitude { get; set; }              // GPS Coordinates
    public double? Longitude { get; set; }
    public string? Street { get; set; }                // Service Location
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? ActualChargerStatus { get; set; }   // For charging services
    public DateTime? LastHeartbeat { get; set; }       // Last communication
}
```

### ServiceRequest

**Description**: Manages service requests from customers.

```csharp
public partial class ServiceRequest
{
    public int Id { get; set; }
    public int FkCustomerId { get; set; }
    public int? FkServiceId { get; set; }
    public string RequestNumber { get; set; } = null!;
    public string Type { get; set; } = null!;          // Request Type
    public string Priority { get; set; } = null!;      // Priority Level
    public string Status { get; set; } = null!;        // Current Status
    public string Subject { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; } = null!;
    public DateTime? DateResolved { get; set; }
    public string? ResolvedBy { get; set; }
    public string? Resolution { get; set; }
}
```

**Service Request Priorities:**
- `Low`: Non-urgent requests
- `Medium`: Standard priority
- `High`: Urgent requests
- `Critical`: Emergency requests

**Service Request Statuses:**
- `Open`: New request
- `In Progress`: Being worked on
- `Pending`: Waiting for information
- `Resolved`: Request completed
- `Closed`: Request closed

## User Management Models

### User (Referenced in other models)

**Description**: Represents system users with authentication and authorization.

```csharp
public partial class User
{
    public string Id { get; set; } = null!;        // Primary Key
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string Status { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public DateTime? LastLogin { get; set; }
    public bool IsActive { get; set; }
}
```

### Role

**Description**: Defines user roles and permissions.

```csharp
public partial class Role
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string Type { get; set; } = null!;
    public bool IsActive { get; set; }
    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; } = null!;
}
```

### UserGroupMap

**Description**: Maps users to groups for role-based access control.

```csharp
public partial class UserGroupMap
{
    public int Id { get; set; }
    public string FkUserId { get; set; } = null!;
    public int FkGroupId { get; set; }
    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; } = null!;
    public bool IsActive { get; set; }
}
```

## Inventory Management Models

### Inventory (Referenced in other models)

**Description**: Manages inventory items and stock levels.

### Warehouse

**Description**: Represents warehouse locations.

```csharp
public partial class Warehouse
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Code { get; set; }
    public string? Description { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public bool IsActive { get; set; }
}
```

### Zone

**Description**: Defines zones within warehouses for better organization.

```csharp
public partial class Zone
{
    public int Id { get; set; }
    public int FkWarehouseId { get; set; }
    public string Name { get; set; } = null!;
    public string? Code { get; set; }
    public string? Description { get; set; }
    public string Type { get; set; } = null!;      // Zone Type
    public bool IsActive { get; set; }
    public double? Temperature { get; set; }        // Temperature Control
    public double? Humidity { get; set; }           // Humidity Control
}
```

## Manufacturing Models

### Manufacturing

**Description**: Represents manufacturing orders and production runs.

```csharp
public partial class Manufacturing
{
    public int Id { get; set; }
    public string ManufacturingNumber { get; set; } = null!;
    public int FkProductId { get; set; }
    public int Quantity { get; set; }
    public string Status { get; set; } = null!;
    public DateTime DateCreated { get; set; }
    public DateTime? DateStarted { get; set; }
    public DateTime? DateCompleted { get; set; }
    public string CreatedBy { get; set; } = null!;
    public string? Notes { get; set; }
}
```

### Lot

**Description**: Tracks production lots for quality control and traceability.

```csharp
public partial class Lot
{
    public int Id { get; set; }
    public string LotNumber { get; set; } = null!;
    public int FkProductId { get; set; }
    public int? FkManufacturingId { get; set; }
    public int Quantity { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string Status { get; set; } = null!;
    public string? QualityGrade { get; set; }
}
```

## Audit and Logging Models

### MasterDataLog

**Description**: Logs changes to master data for audit purposes.

```csharp
public partial class MasterDataLog
{
    public int Id { get; set; }
    public string TableName { get; set; } = null!;
    public string RecordId { get; set; } = null!;
    public string Action { get; set; } = null!;     // INSERT, UPDATE, DELETE
    public string? OldValues { get; set; }          // JSON of old values
    public string? NewValues { get; set; }          // JSON of new values
    public DateTime Timestamp { get; set; }
    public string ActionBy { get; set; } = null!;
}
```

### UserLogMap

**Description**: Tracks user activities and system access.

```csharp
public partial class UserLogMap
{
    public int Id { get; set; }
    public string FkUserId { get; set; } = null!;
    public string Action { get; set; } = null!;
    public string? Description { get; set; }
    public DateTime Timestamp { get; set; }
    public string? IpAddress { get; set; }
}
```

## Supporting Models

### Category & CategoryLevel

**Description**: Hierarchical categorization system for products and services.

```csharp
public partial class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public int? ParentId { get; set; }             // Parent Category
    public int Level { get; set; }                 // Hierarchy Level
    public bool IsActive { get; set; }
}

public partial class CategoryLevel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public int Level { get; set; }
    public bool IsActive { get; set; }
}
```

### Response & ResponseQuestion

**Description**: Survey and form response management.

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

public partial class ResponseQuestion
{
    public int Id { get; set; }
    public int FkResponseId { get; set; }
    public int QuestionId { get; set; }
    public string QuestionText { get; set; } = null!;
    public string? AnswerText { get; set; }
    public string QuestionType { get; set; } = null!;
    public int? Score { get; set; }
}
```

## Model Relationships

### Navigation Properties

Most models include navigation properties for Entity Framework relationships:

```csharp
// Example: Customer with related entities
public partial class Customer
{
    // Navigation Properties
    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
    public virtual ICollection<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();
}
```

### Common Query Patterns

```csharp
// Include related data
var customerWithAddresses = context.Customers
    .Include(c => c.CustomerAddresses)
    .Include(c => c.Orders)
    .FirstOrDefault(c => c.Id == customerId);

// Filter by status
var activeServices = context.Services
    .Where(s => s.Status == "Active")
    .ToList();

// Group by type
var customersByType = context.Customers
    .GroupBy(c => c.Type)
    .Select(g => new { Type = g.Key, Count = g.Count() })
    .ToList();
```

## Best Practices

### Data Validation

1. **Required Fields**: Use `= null!` for required string properties
2. **Nullable Fields**: Use `?` for optional properties
3. **Enums**: Consider using enums for status fields
4. **Constraints**: Implement database constraints for data integrity

### Performance Considerations

1. **Indexing**: Add indexes on frequently queried fields
2. **Lazy Loading**: Be careful with navigation properties
3. **Projection**: Use `Select` to retrieve only needed fields
4. **Batching**: Use batch operations for bulk updates

### Security

1. **Sensitive Data**: Encrypt sensitive information
2. **Audit Trail**: Log all data modifications
3. **Access Control**: Implement proper authorization
4. **Data Retention**: Follow data retention policies

---

**Last Updated**: January 2024  
**Entity Framework Version**: 9.0.5