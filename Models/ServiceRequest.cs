using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ServiceRequest
{
    public int Id { get; set; }

    public int? FkCustomerId { get; set; }

    public int? FkProductId { get; set; }

    public int? FkCustomerAddressId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? ModifiedBy { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public string Status { get; set; } = null!;

    public string ReferenceId { get; set; } = null!;

    public string Type { get; set; } = null!;

    public double? InitialPrice { get; set; }

    public double? ConfirmedPrice { get; set; }

    public DateTime ServiceDate { get; set; }

    public string? TankId { get; set; }

    public string? Reason { get; set; }

    public string? Description { get; set; }

    public string? Notes { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerAddress { get; set; }

    public bool? WithProtectionPlan { get; set; }

    public int? RegionId { get; set; }

    public bool? IsAdminCreated { get; set; }

    public string? ServiceRequestSource { get; set; }

    public virtual ICollection<AssetServiceRequestMap> AssetServiceRequestMaps { get; set; } = new List<AssetServiceRequestMap>();

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<EquipmentServiceRequestMap> EquipmentServiceRequestMaps { get; set; } = new List<EquipmentServiceRequestMap>();

    public virtual Customer? FkCustomer { get; set; }

    public virtual CustomerAddress? FkCustomerAddress { get; set; }

    public virtual Product? FkProduct { get; set; }

    public virtual ICollection<InspectionLog> InspectionLogs { get; set; } = new List<InspectionLog>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<Note> NotesNavigation { get; set; } = new List<Note>();

    public virtual ICollection<OrderLineItem> OrderLineItems { get; set; } = new List<OrderLineItem>();

    public virtual ICollection<ServiceRequestFormResponse> ServiceRequestFormResponses { get; set; } = new List<ServiceRequestFormResponse>();

    public virtual ICollection<ServiceRequestSchedule> ServiceRequestSchedules { get; set; } = new List<ServiceRequestSchedule>();
}
