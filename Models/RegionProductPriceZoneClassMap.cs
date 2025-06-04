using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class RegionProductPriceZoneClassMap
{
    public int Id { get; set; }

    public int FkProductId { get; set; }

    public int FkRegionId { get; set; }

    public string PriceZoneCode { get; set; } = null!;

    public string PriceClass { get; set; } = null!;

    public string? Type { get; set; }

    public double Value { get; set; }

    public string Variance { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public DateTime? DateApplicable { get; set; }

    public string? Reason { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Product FkProduct { get; set; } = null!;

    public virtual Region FkRegion { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
