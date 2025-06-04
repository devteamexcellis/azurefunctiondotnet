using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class SupplierVendor
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? ContactFirstName { get; set; }

    public string? ContactLastName { get; set; }

    public string? ContactNumber1 { get; set; }

    public string? ContactNumber2 { get; set; }

    public string? ContactEmail { get; set; }

    public string? Website { get; set; }

    public string? VendorNumber { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<SupplierVendorAddress> SupplierVendorAddresses { get; set; } = new List<SupplierVendorAddress>();

    public virtual ICollection<SupplierVendorMaterialMap> SupplierVendorMaterialMaps { get; set; } = new List<SupplierVendorMaterialMap>();

    public virtual ICollection<SupplierVendorProductMap> SupplierVendorProductMaps { get; set; } = new List<SupplierVendorProductMap>();
}
