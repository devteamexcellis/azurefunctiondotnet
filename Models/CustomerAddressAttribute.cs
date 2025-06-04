using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerAddressAttribute
{
    public int Id { get; set; }

    public int FkCustomerAddressId { get; set; }

    public string? Type { get; set; }

    public string? LegacyType { get; set; }

    public string? Flags { get; set; }

    public string? TankId { get; set; }

    public double? TankSize { get; set; }

    public string? IdealVolume { get; set; }

    public double? PresetAmount { get; set; }

    public double? PresetVolume { get; set; }

    public string? ScheduleCode { get; set; }

    public string? DeliveryCode { get; set; }

    public string? LlType { get; set; }

    public double? KFactor { get; set; }

    public string? ForecastingProjection { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateOnly? LastDeliverDate { get; set; }

    public double? LastDeliveryVolume { get; set; }

    public string? TankMonitor { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public double? CurrentVolume { get; set; }

    public string? LocationDescription { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public DateOnly? LastReadDate { get; set; }

    public string? TankMonitorId { get; set; }

    public double? Threshold { get; set; }

    public double? DeliveryThreshold { get; set; }

    public string? Unit { get; set; }

    public bool? IsRental { get; set; }

    public string? Category { get; set; }

    public DateOnly? RunoutDate { get; set; }

    public string? AssetSerialNumber { get; set; }

    public DateTime? DateInstalled { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? RemainingRentalInstallments { get; set; }

    public string? RentalFrequency { get; set; }

    public double? RentalAmount { get; set; }

    public DateTime? DateOfManufacture { get; set; }

    public string? Owner { get; set; }

    public bool? IsParent { get; set; }

    public bool? ParentId { get; set; }

    public double? VolAfterDlvry { get; set; }

    public double? UsableCapacity { get; set; }

    public double? ReserveCapacity { get; set; }

    public int? FkProductId { get; set; }

    public int? NumTanks { get; set; }

    public int? FkFillLocationId { get; set; }

    public decimal? CurrentVolumePercentage { get; set; }

    public string? PoNumber { get; set; }

    public string? LegacyHold { get; set; }

    public virtual Asset? AssetSerialNumberNavigation { get; set; }

    public virtual ICollection<CaAttributesHistory> CaAttributesHistories { get; set; } = new List<CaAttributesHistory>();

    public virtual ICollection<CaAttributesProjection> CaAttributesProjections { get; set; } = new List<CaAttributesProjection>();

    public virtual User? CreatedByNavigation { get; set; }

    public virtual CustomerAddress FkCustomerAddress { get; set; } = null!;

    public virtual FillLocation? FkFillLocation { get; set; }

    public virtual Product? FkProduct { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }
}
