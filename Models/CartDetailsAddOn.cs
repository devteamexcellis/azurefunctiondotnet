using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CartDetailsAddOn
{
    public int Id { get; set; }

    public string CdFkUserId { get; set; } = null!;

    public int CdFkCustomerId { get; set; }

    public int CdFkProductId { get; set; }

    public string CdFkVarianceId { get; set; } = null!;

    public int FkProductId { get; set; }

    public string? FkVarianceId { get; set; }

    public int? Quantity { get; set; }

    public virtual CartDetail CartDetail { get; set; } = null!;

    public virtual Product FkProduct { get; set; } = null!;

    public virtual ProductVariance? ProductVariance { get; set; }
}
