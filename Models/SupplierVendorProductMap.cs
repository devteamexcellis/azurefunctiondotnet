using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class SupplierVendorProductMap
{
    public int FkSupplierVendorId { get; set; }

    public int FkProductId { get; set; }

    public string VendorCode { get; set; } = null!;

    public string? KitNumber { get; set; }

    public double? Price { get; set; }

    public bool? IsPrimary { get; set; }

    public virtual Product FkProduct { get; set; } = null!;

    public virtual SupplierVendor FkSupplierVendor { get; set; } = null!;

    public virtual ICollection<SupplierVendorProductVarianceMap> SupplierVendorProductVarianceMaps { get; set; } = new List<SupplierVendorProductVarianceMap>();
}
