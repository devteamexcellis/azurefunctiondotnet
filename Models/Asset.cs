using System;
using System.Collections.Generic;

namespace excellis.Models;

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

    public double? IdealCapacity { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? RemainingRentalInstallments { get; set; }

    public string? RentalFrequency { get; set; }

    public double? RentalAmount { get; set; }

    public string? Category { get; set; }

    public int? FkCustomerAddressId { get; set; }

    public string? AssetType { get; set; }

    public string? Owner { get; set; }

    public string? Status { get; set; }

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<AssetHistory> AssetHistories { get; set; } = new List<AssetHistory>();

    public virtual ICollection<AssetInspection> AssetInspections { get; set; } = new List<AssetInspection>();

    public virtual ICollection<AssetServiceRequestMap> AssetServiceRequestMaps { get; set; } = new List<AssetServiceRequestMap>();

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<CustomerAddressAttribute> CustomerAddressAttributes { get; set; } = new List<CustomerAddressAttribute>();

    public virtual CustomerAddress? FkCustomerAddress { get; set; }

    public virtual InventoryLocation? FkInventoryLocation { get; set; }

    public virtual Product FkProduct { get; set; } = null!;

    public virtual ICollection<Inspection> Inspections { get; set; } = new List<Inspection>();

    public virtual User? ModifiedByNavigation { get; set; }
}
