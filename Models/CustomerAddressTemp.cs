using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerAddressTemp
{
    public string Client { get; set; } = null!;

    public string? Type { get; set; }

    public string? DelId { get; set; }

    public string? Zip { get; set; }

    public string? DelStateProv { get; set; }

    public string? City { get; set; }

    public string? Addr1 { get; set; }

    public string? Longitude { get; set; }

    public string? Latitude { get; set; }

    public string? PCountryCode { get; set; }

    public string? Name { get; set; }

    public string? Direction { get; set; }

    public string? Status { get; set; }
}
