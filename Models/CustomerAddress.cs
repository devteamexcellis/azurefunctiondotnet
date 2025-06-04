using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerAddress
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public string Zipcode { get; set; } = null!;

    public string State { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public string? Country { get; set; }

    public bool? IsPrimary { get; set; }

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

    public string? LegacyId { get; set; }

    public string? IntlContactName { get; set; }

    public string? IntlContactNumber { get; set; }

    public string? IntlContactEmail { get; set; }

    public string? TaxId { get; set; }

    public DateTime? DateModified { get; set; }

    public string? ShippingAccountLegacyId { get; set; }

    public string? CustomerAddressCode { get; set; }

    public double? MinLatitude { get; set; }

    public double? MaxLatitude { get; set; }

    public double? MinLongitude { get; set; }

    public double? MaxLongitude { get; set; }

    public string? Region { get; set; }

    public string? Zone { get; set; }

    public string? MapCode { get; set; }

    public string? Notes { get; set; }

    public double? KFactor { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public string? Comment1 { get; set; }

    public string? Comment2 { get; set; }

    public string? Comment3 { get; set; }

    public string? Comment4 { get; set; }

    public string? Comment5 { get; set; }

    public string? Comment6 { get; set; }

    public string? Comment7 { get; set; }

    public string? Comment8 { get; set; }

    public string? Comment9 { get; set; }

    public string? Comment10 { get; set; }

    public string? Comment11 { get; set; }

    public string? Comment12 { get; set; }

    public string? Comment13 { get; set; }

    public string? Comment14 { get; set; }

    public string? Comment15 { get; set; }

    public string? Comment16 { get; set; }

    public string? Comment17 { get; set; }

    public string? Comment18 { get; set; }

    public string? Comment19 { get; set; }

    public string? Comment20 { get; set; }

    public int? LlType { get; set; }

    public string? Status { get; set; }

    public string? DeliveryMethod { get; set; }

    public string? ShipToCode { get; set; }

    public string? LegacyTaxcat { get; set; }

    public string? LegacyTradeClass { get; set; }

    public string? LegacyPriceClass { get; set; }

    public int? OplynxLocationId { get; set; }

    public string? TaxCategory { get; set; }

    public string? RebateCode { get; set; }

    public bool? IsServiceLocation { get; set; }

    public string? Street2 { get; set; }

    public string? Street3 { get; set; }

    public virtual ICollection<AccountCustomerAddressMap> AccountCustomerAddressMaps { get; set; } = new List<AccountCustomerAddressMap>();

    public virtual ICollection<AssetHistory> AssetHistories { get; set; } = new List<AssetHistory>();

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual ICollection<BlockCustomerMap> BlockCustomerMaps { get; set; } = new List<BlockCustomerMap>();

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<CustomerAddressAttribute> CustomerAddressAttributes { get; set; } = new List<CustomerAddressAttribute>();

    public virtual ICollection<CustomerAddressGroupMap> CustomerAddressGroupMaps { get; set; } = new List<CustomerAddressGroupMap>();

    public virtual ICollection<CustomerAddressProductPriceModelMap> CustomerAddressProductPriceModelMaps { get; set; } = new List<CustomerAddressProductPriceModelMap>();

    public virtual ICollection<CustomerAddressProductSetting> CustomerAddressProductSettings { get; set; } = new List<CustomerAddressProductSetting>();

    public virtual ICollection<CustomerAddressProductTemplateMap> CustomerAddressProductTemplateMaps { get; set; } = new List<CustomerAddressProductTemplateMap>();

    public virtual ICollection<CustomerAddressRegionMap> CustomerAddressRegionMaps { get; set; } = new List<CustomerAddressRegionMap>();

    public virtual ICollection<DeliveryQueue> DeliveryQueues { get; set; } = new List<DeliveryQueue>();

    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();

    public virtual ICollection<EquipmentServiceRequestMap> EquipmentServiceRequestMaps { get; set; } = new List<EquipmentServiceRequestMap>();

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual ICollection<Inspection> Inspections { get; set; } = new List<Inspection>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<Note> NotesNavigation { get; set; } = new List<Note>();

    public virtual ICollection<Recurrence> Recurrences { get; set; } = new List<Recurrence>();

    public virtual ICollection<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();

    public virtual ICollection<TaxExemptionEntityMap> TaxExemptionEntityMaps { get; set; } = new List<TaxExemptionEntityMap>();

    public virtual ICollection<TaxRebateEntityMap> TaxRebateEntityMaps { get; set; } = new List<TaxRebateEntityMap>();
}
