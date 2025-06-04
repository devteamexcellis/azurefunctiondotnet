using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class UserAddress
{
    public int Id { get; set; }

    public string FkUserId { get; set; } = null!;

    public string Zipcode { get; set; } = null!;

    public string State { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public string? Country { get; set; }

    public string? CountryCode { get; set; }

    public bool? IsPrimary { get; set; }

    public string? Type { get; set; }

    public string? Unit { get; set; }

    public string? Building { get; set; }

    public virtual User FkUser { get; set; } = null!;
}
