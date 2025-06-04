using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class AssetHistory
{
    public int Id { get; set; }

    public int FkAssetId { get; set; }

    public string Module { get; set; } = null!;

    public string? SerialNumber { get; set; }

    public int? FkProductId { get; set; }

    public bool? IsRental { get; set; }

    public bool? IsInInventory { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? AssetHistoryNotes { get; set; }

    public string? LegacyAssetId { get; set; }

    public int? ReferenceInvId { get; set; }

    public int? ReferenceCustomerAaId { get; set; }

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

    public DateTime? DateModified { get; set; }

    public string? Status { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Asset FkAsset { get; set; } = null!;

    public virtual CustomerAddress? FkCustomerAddress { get; set; }
}
