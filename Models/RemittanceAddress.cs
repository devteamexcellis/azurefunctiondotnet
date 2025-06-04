using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class RemittanceAddress
{
    public int Id { get; set; }

    public string Zipcode { get; set; } = null!;

    public string State { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public string? Country { get; set; }

    public string? Type { get; set; }

    public string? CountryCodeAlpha { get; set; }

    public string? CountryCodeDigit { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? ContactPerson { get; set; }

    public string? Email { get; set; }

    public string? MobileNumber { get; set; }

    public string? AlternateNumber { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public string? Province { get; set; }

    public string? Status { get; set; }

    public bool? IsDefault { get; set; }

    public string? Street2 { get; set; }

    public string? Street3 { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<CustomerRemittanceAddressMap> CustomerRemittanceAddressMaps { get; set; } = new List<CustomerRemittanceAddressMap>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<RemittanceAddressRegionInventoryLocationMap> RemittanceAddressRegionInventoryLocationMaps { get; set; } = new List<RemittanceAddressRegionInventoryLocationMap>();
}
