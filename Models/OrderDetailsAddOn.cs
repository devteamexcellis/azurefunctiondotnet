using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrderDetailsAddOn
{
    public int Id { get; set; }

    public string OdFkOrderId { get; set; } = null!;

    public int OdFkProductId { get; set; }

    public string OdFkVarianceId { get; set; } = null!;

    public int FkProductId { get; set; }

    public string? FkVarianceId { get; set; }

    public int? Quantity { get; set; }

    public virtual Product FkProduct { get; set; } = null!;

    public virtual OrderDetail OrderDetail { get; set; } = null!;

    public virtual ProductVariance? ProductVariance { get; set; }
}
