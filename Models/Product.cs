using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Body { get; set; } = null!;

    public string? Icon { get; set; }

    public string Status { get; set; } = null!;

    public double? Price { get; set; }

    public string? PriceUnit { get; set; }

    public double? Weight { get; set; }

    public string? WeightUnit { get; set; }

    public string? FkFamilyId { get; set; }

    public string? FkSubFamilyId { get; set; }

    public string? ProductCode { get; set; }

    public string? Case { get; set; }

    public string? Umconversions { get; set; }

    public string? Casewt { get; set; }

    public string? Pallet { get; set; }

    public int? SellingRestriction { get; set; }

    public string? CaseUpc { get; set; }

    public string? Gtin { get; set; }

    public string? ShelfLife { get; set; }

    public string? RefrigerationText { get; set; }

    public string? Establishment { get; set; }

    public string? Characteristics { get; set; }

    public string? Allergens { get; set; }

    public string? Package { get; set; }

    public string? CaseWeightType { get; set; }

    public string? CodeDating { get; set; }

    public int? MinOrderQuantity { get; set; }

    public string? Strength { get; set; }

    public string? DosageForm { get; set; }

    public string? OtcRx { get; set; }

    public string? StorageCondition { get; set; }

    public string? Size { get; set; }

    public int? CasePackQuantity { get; set; }

    public string? TeCode { get; set; }

    public string? LegacyId { get; set; }

    public string? TrademarkStatement { get; set; }

    public string? Type { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string? Classification { get; set; }

    public DateTime? LastTransaction { get; set; }

    public DateTime? LastHeartbeat { get; set; }

    public bool? TextOverrideFlag { get; set; }

    public bool? BinRequiredFlag { get; set; }

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual ICollection<BillOfMaterial> BillOfMaterialFkChildProducts { get; set; } = new List<BillOfMaterial>();

    public virtual ICollection<BillOfMaterial> BillOfMaterialFkParentProducts { get; set; } = new List<BillOfMaterial>();

    public virtual ICollection<BranchProductTemplateMap> BranchProductTemplateMaps { get; set; } = new List<BranchProductTemplateMap>();

    public virtual ICollection<CartDetailsAddOn> CartDetailsAddOns { get; set; } = new List<CartDetailsAddOn>();

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<CustomerAddressAttribute> CustomerAddressAttributes { get; set; } = new List<CustomerAddressAttribute>();

    public virtual ICollection<CustomerAddressProductPriceModelMap> CustomerAddressProductPriceModelMaps { get; set; } = new List<CustomerAddressProductPriceModelMap>();

    public virtual ICollection<CustomerAddressProductSetting> CustomerAddressProductSettings { get; set; } = new List<CustomerAddressProductSetting>();

    public virtual ICollection<CustomerAddressProductTemplateMap> CustomerAddressProductTemplateMaps { get; set; } = new List<CustomerAddressProductTemplateMap>();

    public virtual ICollection<CustomerProductMap> CustomerProductMaps { get; set; } = new List<CustomerProductMap>();

    public virtual Family? FkFamily { get; set; }

    public virtual SubFamily? FkSubFamily { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

    public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; } = new List<InvoiceLineItem>();

    public virtual ICollection<LotBom> LotBoms { get; set; } = new List<LotBom>();

    public virtual ICollection<LotLog> LotLogs { get; set; } = new List<LotLog>();

    public virtual ICollection<Lot> Lots { get; set; } = new List<Lot>();

    public virtual ICollection<ManufacturingBom> ManufacturingBoms { get; set; } = new List<ManufacturingBom>();

    public virtual ICollection<Manufacturing> Manufacturings { get; set; } = new List<Manufacturing>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<OrderDetailsAddOn> OrderDetailsAddOns { get; set; } = new List<OrderDetailsAddOn>();

    public virtual ICollection<OrderLineItem> OrderLineItems { get; set; } = new List<OrderLineItem>();

    public virtual ICollection<ProductAsset> ProductAssets { get; set; } = new List<ProductAsset>();

    public virtual ProductClientAttribute? ProductClientAttribute { get; set; }

    public virtual ICollection<ProductRegionMap> ProductRegionMaps { get; set; } = new List<ProductRegionMap>();

    public virtual ICollection<ProductVariance> ProductVariances { get; set; } = new List<ProductVariance>();

    public virtual ICollection<ProductionSchedule> ProductionSchedules { get; set; } = new List<ProductionSchedule>();

    public virtual ICollection<RackPlusProductPriceModelMap> RackPlusProductPriceModelMaps { get; set; } = new List<RackPlusProductPriceModelMap>();

    public virtual ICollection<RegionProductPriceMap> RegionProductPriceMaps { get; set; } = new List<RegionProductPriceMap>();

    public virtual ICollection<RegionProductPriceZoneClassMap> RegionProductPriceZoneClassMaps { get; set; } = new List<RegionProductPriceZoneClassMap>();

    public virtual ICollection<RegionProductWeatherMap> RegionProductWeatherMaps { get; set; } = new List<RegionProductWeatherMap>();

    public virtual ICollection<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();

    public virtual ICollection<SupplierVendorProductMap> SupplierVendorProductMaps { get; set; } = new List<SupplierVendorProductMap>();

    public virtual ICollection<TaxExemptionEntityMap> TaxExemptionEntityMaps { get; set; } = new List<TaxExemptionEntityMap>();

    public virtual ICollection<TaxRate> TaxRates { get; set; } = new List<TaxRate>();

    public virtual ICollection<TaxRebateEntityMap> TaxRebateEntityMaps { get; set; } = new List<TaxRebateEntityMap>();

    public virtual ICollection<UserProductList> UserProductLists { get; set; } = new List<UserProductList>();

    public virtual ICollection<ClientGroup> FkClientGroups { get; set; } = new List<ClientGroup>();

    public virtual ICollection<PromotionTargetMap> FkPromotionTargetMaps { get; set; } = new List<PromotionTargetMap>();
}
