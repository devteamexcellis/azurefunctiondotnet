using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Region
{
    public int Id { get; set; }

    public string? RegionCode { get; set; }

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public string? Description { get; set; }

    public string? NsExid { get; set; }

    public string? CurrentSeason { get; set; }

    public string? Zipcode { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public string? Country { get; set; }

    public string? CountryCodeAlpha { get; set; }

    public string? CountryCodeDigit { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<CustomerAddressRegionMap> CustomerAddressRegionMaps { get; set; } = new List<CustomerAddressRegionMap>();

    public virtual ICollection<DegreeDay> DegreeDays { get; set; } = new List<DegreeDay>();

    public virtual ICollection<DeliveryQueueOperation> DeliveryQueueOperations { get; set; } = new List<DeliveryQueueOperation>();

    public virtual ICollection<InventoryLocation> InventoryLocations { get; set; } = new List<InventoryLocation>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<PriceZone> PriceZones { get; set; } = new List<PriceZone>();

    public virtual ICollection<ProductRegionMap> ProductRegionMaps { get; set; } = new List<ProductRegionMap>();

    public virtual ICollection<RegionProductPriceMap> RegionProductPriceMaps { get; set; } = new List<RegionProductPriceMap>();

    public virtual ICollection<RegionProductPriceZoneClassMap> RegionProductPriceZoneClassMaps { get; set; } = new List<RegionProductPriceZoneClassMap>();

    public virtual ICollection<RegionProductWeatherMap> RegionProductWeatherMaps { get; set; } = new List<RegionProductWeatherMap>();

    public virtual ICollection<RegionUserMap> RegionUserMaps { get; set; } = new List<RegionUserMap>();

    public virtual ICollection<RemittanceAddressRegionInventoryLocationMap> RemittanceAddressRegionInventoryLocationMaps { get; set; } = new List<RemittanceAddressRegionInventoryLocationMap>();

    public virtual ICollection<Tax> Taxes { get; set; } = new List<Tax>();
}
