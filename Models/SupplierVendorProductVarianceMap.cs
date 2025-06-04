using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class SupplierVendorProductVarianceMap
{
    public int FkProductId { get; set; }

    public int FkSupplierVendorId { get; set; }

    public string VarianceId { get; set; } = null!;

    public string? Name { get; set; }

    public double? UnitPrice { get; set; }

    public double? PricePerVariance { get; set; }

    public int QuantityPerVariance { get; set; }

    public virtual SupplierVendorProductMap SupplierVendorProductMap { get; set; } = null!;
}
