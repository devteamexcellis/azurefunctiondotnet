using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Material
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string MaterialCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public double? TargetPrice { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<SupplierVendorMaterialMap> SupplierVendorMaterialMaps { get; set; } = new List<SupplierVendorMaterialMap>();
}
