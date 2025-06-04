using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class SupplierVendorAddress
{
    public int Id { get; set; }

    public int FkSupplierVendorId { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public bool? IsPrimary { get; set; }

    public string Country { get; set; } = null!;

    public string? CountryCodeAlpha { get; set; }

    public string? CountryCodeDigit { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public virtual SupplierVendor FkSupplierVendor { get; set; } = null!;
}
