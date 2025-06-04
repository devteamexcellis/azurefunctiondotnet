using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class SupplierVendorMaterialMap
{
    public int FkSupplierVendorId { get; set; }

    public int FkMaterialId { get; set; }

    public double? Price { get; set; }

    public string? VendorCode { get; set; }

    public bool? IsPrimary { get; set; }

    public virtual Material FkMaterial { get; set; } = null!;

    public virtual SupplierVendor FkSupplierVendor { get; set; } = null!;
}
