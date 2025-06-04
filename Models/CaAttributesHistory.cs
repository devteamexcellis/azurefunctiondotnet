using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CaAttributesHistory
{
    public long Id { get; set; }

    public int FkCustomerAddressAttributesId { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? Module { get; set; }

    public double? CurrentVolume { get; set; }

    public DateOnly? DueDate { get; set; }

    public string? KFactor { get; set; }

    public string? Status { get; set; }

    public DateOnly? LastReadDate { get; set; }

    public decimal? CurrentVolumePercentage { get; set; }

    public string? PoNumber { get; set; }

    public string? LegacyHold { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual CustomerAddressAttribute FkCustomerAddressAttributes { get; set; } = null!;
}
