using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Equipment
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public int FkCustomerAddressId { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string? LocationDescription { get; set; }

    public string? Type { get; set; }

    public DateTime? LastServiceDate { get; set; }

    public string? SerialNo { get; set; }

    public string? Manufacturer { get; set; }

    public string? DateOfManufacture { get; set; }

    public string? AssetOwner { get; set; }

    public double? Size { get; set; }

    public string? Status { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<EquipmentServiceRequestMap> EquipmentServiceRequestMaps { get; set; } = new List<EquipmentServiceRequestMap>();

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual CustomerAddress FkCustomerAddress { get; set; } = null!;

    public virtual ICollection<InspectionLog> InspectionLogs { get; set; } = new List<InspectionLog>();

    public virtual User? ModifiedByNavigation { get; set; }
}
