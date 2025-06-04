using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class User
{
    public string Id { get; set; } = null!;

    public string? SiteUserId { get; set; }

    public string Email { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string? Middlename { get; set; }

    public string Lastname { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? MobileNumber { get; set; }

    public string? AlternateNumber { get; set; }

    public string? Position { get; set; }

    public string? Department { get; set; }

    public string? Location { get; set; }

    public string? CountryCode { get; set; }

    public string? ImageUrl { get; set; }

    public bool? IsFirstTimeLogin { get; set; }

    public DateTime? Timestamp { get; set; }

    public DateTime? DateModified { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<Asset> AssetCreatedByNavigations { get; set; } = new List<Asset>();

    public virtual ICollection<AssetHistory> AssetHistories { get; set; } = new List<AssetHistory>();

    public virtual ICollection<AssetInspection> AssetInspectionCreatedByNavigations { get; set; } = new List<AssetInspection>();

    public virtual ICollection<AssetInspection> AssetInspectionModifiedByNavigations { get; set; } = new List<AssetInspection>();

    public virtual ICollection<Asset> AssetModifiedByNavigations { get; set; } = new List<Asset>();

    public virtual ICollection<AssetServiceRequestMap> AssetServiceRequestMapCreatedByNavigations { get; set; } = new List<AssetServiceRequestMap>();

    public virtual ICollection<AssetServiceRequestMap> AssetServiceRequestMapModifiedByNavigations { get; set; } = new List<AssetServiceRequestMap>();

    public virtual ICollection<Attachment> AttachmentCreatedByNavigations { get; set; } = new List<Attachment>();

    public virtual ICollection<Attachment> AttachmentModifiedByNavigations { get; set; } = new List<Attachment>();

    public virtual ICollection<Block> BlockCreatedByNavigations { get; set; } = new List<Block>();

    public virtual ICollection<BlockCustomerMap> BlockCustomerMapCreatedByNavigations { get; set; } = new List<BlockCustomerMap>();

    public virtual ICollection<BlockCustomerMap> BlockCustomerMapModifiedByNavigations { get; set; } = new List<BlockCustomerMap>();

    public virtual ICollection<Block> BlockModifiedByNavigations { get; set; } = new List<Block>();

    public virtual ICollection<BptmDetail> BptmDetailCreatedByNavigations { get; set; } = new List<BptmDetail>();

    public virtual ICollection<BptmDetail> BptmDetailModifiedByNavigations { get; set; } = new List<BptmDetail>();

    public virtual ICollection<Branch> BranchCreatedByNavigations { get; set; } = new List<Branch>();

    public virtual ICollection<Branch> BranchModifiedByNavigations { get; set; } = new List<Branch>();

    public virtual ICollection<BranchProductTemplateMap> BranchProductTemplateMapCreatedByNavigations { get; set; } = new List<BranchProductTemplateMap>();

    public virtual ICollection<BranchProductTemplateMap> BranchProductTemplateMapModifiedByNavigations { get; set; } = new List<BranchProductTemplateMap>();

    public virtual ICollection<BranchUserMap> BranchUserMaps { get; set; } = new List<BranchUserMap>();

    public virtual ICollection<CaAttributesHistory> CaAttributesHistories { get; set; } = new List<CaAttributesHistory>();

    public virtual ICollection<CappmmHistory> CappmmHistories { get; set; } = new List<CappmmHistory>();

    public virtual ICollection<CaptmDetail> CaptmDetailCreatedByNavigations { get; set; } = new List<CaptmDetail>();

    public virtual ICollection<CaptmDetail> CaptmDetailModifiedByNavigations { get; set; } = new List<CaptmDetail>();

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<CustomerAddressAttribute> CustomerAddressAttributeCreatedByNavigations { get; set; } = new List<CustomerAddressAttribute>();

    public virtual ICollection<CustomerAddressAttribute> CustomerAddressAttributeModifiedByNavigations { get; set; } = new List<CustomerAddressAttribute>();

    public virtual ICollection<CustomerAddress> CustomerAddressCreatedByNavigations { get; set; } = new List<CustomerAddress>();

    public virtual ICollection<CustomerAddress> CustomerAddressModifiedByNavigations { get; set; } = new List<CustomerAddress>();

    public virtual ICollection<CustomerAddressProductPriceModelMap> CustomerAddressProductPriceModelMapCreatedByNavigations { get; set; } = new List<CustomerAddressProductPriceModelMap>();

    public virtual ICollection<CustomerAddressProductPriceModelMap> CustomerAddressProductPriceModelMapModifiedByNavigations { get; set; } = new List<CustomerAddressProductPriceModelMap>();

    public virtual ICollection<CustomerAddressProductTemplateMap> CustomerAddressProductTemplateMapCreatedByNavigations { get; set; } = new List<CustomerAddressProductTemplateMap>();

    public virtual ICollection<CustomerAddressProductTemplateMap> CustomerAddressProductTemplateMapModifiedByNavigations { get; set; } = new List<CustomerAddressProductTemplateMap>();

    public virtual ICollection<CustomerAddressRegionMap> CustomerAddressRegionMapCreatedByNavigations { get; set; } = new List<CustomerAddressRegionMap>();

    public virtual ICollection<CustomerAddressRegionMap> CustomerAddressRegionMapModifiedByNavigations { get; set; } = new List<CustomerAddressRegionMap>();

    public virtual ICollection<Customer> CustomerCreatedByNavigations { get; set; } = new List<Customer>();

    public virtual ICollection<CustomerEnrollmentLog> CustomerEnrollmentLogs { get; set; } = new List<CustomerEnrollmentLog>();

    public virtual ICollection<Customer> CustomerModifiedByNavigations { get; set; } = new List<Customer>();

    public virtual ICollection<CustomerType> CustomerTypeCreatedByNavigations { get; set; } = new List<CustomerType>();

    public virtual ICollection<CustomerType> CustomerTypeModifiedByNavigations { get; set; } = new List<CustomerType>();

    public virtual ICollection<CustomerUserMap> CustomerUserMaps { get; set; } = new List<CustomerUserMap>();

    public virtual ICollection<DegreeDay> DegreeDayCreatedByNavigations { get; set; } = new List<DegreeDay>();

    public virtual ICollection<DegreeDay> DegreeDayModifiedByNavigations { get; set; } = new List<DegreeDay>();

    public virtual ICollection<DeliveryQueue> DeliveryQueueCreatedByNavigations { get; set; } = new List<DeliveryQueue>();

    public virtual ICollection<DeliveryQueue> DeliveryQueueModifiedByNavigations { get; set; } = new List<DeliveryQueue>();

    public virtual ICollection<DeliveryQueueOperation> DeliveryQueueOperations { get; set; } = new List<DeliveryQueueOperation>();

    public virtual ICollection<Equipment> EquipmentCreatedByNavigations { get; set; } = new List<Equipment>();

    public virtual ICollection<Equipment> EquipmentModifiedByNavigations { get; set; } = new List<Equipment>();

    public virtual ICollection<EquipmentServiceRequestMap> EquipmentServiceRequestMapCreatedByNavigations { get; set; } = new List<EquipmentServiceRequestMap>();

    public virtual ICollection<EquipmentServiceRequestMap> EquipmentServiceRequestMapModifiedByNavigations { get; set; } = new List<EquipmentServiceRequestMap>();

    public virtual ICollection<EquipmentType> EquipmentTypeCreatedByNavigations { get; set; } = new List<EquipmentType>();

    public virtual ICollection<EquipmentType> EquipmentTypeModifiedByNavigations { get; set; } = new List<EquipmentType>();

    public virtual ICollection<Form> FormCreatedByNavigations { get; set; } = new List<Form>();

    public virtual ICollection<Form> FormModifiedByNavigations { get; set; } = new List<Form>();

    public virtual ICollection<Inspection> InspectionCreatedByNavigations { get; set; } = new List<Inspection>();

    public virtual ICollection<InspectionLog> InspectionLogCreatedByNavigations { get; set; } = new List<InspectionLog>();

    public virtual ICollection<InspectionLog> InspectionLogModifiedByNavigations { get; set; } = new List<InspectionLog>();

    public virtual ICollection<Inspection> InspectionModifiedByNavigations { get; set; } = new List<Inspection>();

    public virtual ICollection<Inventory> InventoryCreatedByNavigations { get; set; } = new List<Inventory>();

    public virtual ICollection<InventoryLocation> InventoryLocations { get; set; } = new List<InventoryLocation>();

    public virtual ICollection<InventoryLog> InventoryLogs { get; set; } = new List<InventoryLog>();

    public virtual ICollection<Inventory> InventoryModifiedByNavigations { get; set; } = new List<Inventory>();

    public virtual ICollection<User> InverseCreatedByNavigation { get; set; } = new List<User>();

    public virtual ICollection<User> InverseModifiedByNavigation { get; set; } = new List<User>();

    public virtual ICollection<Lead> LeadCreatedByNavigations { get; set; } = new List<Lead>();

    public virtual ICollection<Lead> LeadModifiedByNavigations { get; set; } = new List<Lead>();

    public virtual ICollection<ListSharingDetail> ListSharingDetails { get; set; } = new List<ListSharingDetail>();

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    public virtual ICollection<LotBomInventoryMap> LotBomInventoryMaps { get; set; } = new List<LotBomInventoryMap>();

    public virtual ICollection<Lot> LotCreatedByNavigations { get; set; } = new List<Lot>();

    public virtual ICollection<LotLog> LotLogs { get; set; } = new List<LotLog>();

    public virtual ICollection<Lot> LotModifiedByNavigations { get; set; } = new List<Lot>();

    public virtual ICollection<Manufacturing> ManufacturingCreatedByNavigations { get; set; } = new List<Manufacturing>();

    public virtual ICollection<Manufacturing> ManufacturingLastModifiedByNavigations { get; set; } = new List<Manufacturing>();

    public virtual ICollection<ManufacturingLog> ManufacturingLogCreatedByNavigations { get; set; } = new List<ManufacturingLog>();

    public virtual ICollection<ManufacturingLog> ManufacturingLogReleasedByNavigations { get; set; } = new List<ManufacturingLog>();

    public virtual ICollection<Manufacturing> ManufacturingReleasedByNavigations { get; set; } = new List<Manufacturing>();

    public virtual ICollection<Manufacturing> ManufacturingUnrestrictedByNavigations { get; set; } = new List<Manufacturing>();

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();

    public virtual ICollection<MiscellaneousCharge> MiscellaneousChargeCreatedByNavigations { get; set; } = new List<MiscellaneousCharge>();

    public virtual ICollection<MiscellaneousCharge> MiscellaneousChargeModifiedByNavigations { get; set; } = new List<MiscellaneousCharge>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<MultiFactorAuthToken> MultiFactorAuthTokens { get; set; } = new List<MultiFactorAuthToken>();

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual ICollection<Order> OrderCancelledByNavigations { get; set; } = new List<Order>();

    public virtual ICollection<OrderCode> OrderCodeCreatedByNavigations { get; set; } = new List<OrderCode>();

    public virtual ICollection<OrderCode> OrderCodeModifiedByNavigations { get; set; } = new List<OrderCode>();

    public virtual ICollection<Order> OrderFkUsers { get; set; } = new List<Order>();

    public virtual ICollection<Order> OrderReasonByUsers { get; set; } = new List<Order>();

    public virtual ICollection<OrderReturnLabel> OrderReturnLabelCreatedBies { get; set; } = new List<OrderReturnLabel>();

    public virtual ICollection<OrderReturnLabel> OrderReturnLabelModifiedBies { get; set; } = new List<OrderReturnLabel>();

    public virtual ICollection<Payment> PaymentCreatedByNavigations { get; set; } = new List<Payment>();

    public virtual ICollection<PaymentMethod> PaymentMethodCreatedByNavigations { get; set; } = new List<PaymentMethod>();

    public virtual ICollection<PaymentMethod> PaymentMethodModifiedByNavigations { get; set; } = new List<PaymentMethod>();

    public virtual ICollection<Payment> PaymentModifiedByNavigations { get; set; } = new List<Payment>();

    public virtual ICollection<PaymentType> PaymentTypeCreatedByNavigations { get; set; } = new List<PaymentType>();

    public virtual ICollection<PaymentType> PaymentTypeModifiedByNavigations { get; set; } = new List<PaymentType>();

    public virtual ICollection<PriceZone> PriceZoneCreatedByNavigations { get; set; } = new List<PriceZone>();

    public virtual ICollection<PriceZone> PriceZoneModifiedByNavigations { get; set; } = new List<PriceZone>();

    public virtual ICollection<Product> ProductCreatedByNavigations { get; set; } = new List<Product>();

    public virtual ICollection<Product> ProductModifiedByNavigations { get; set; } = new List<Product>();

    public virtual ICollection<ProductRegionMap> ProductRegionMapCreatedByNavigations { get; set; } = new List<ProductRegionMap>();

    public virtual ICollection<ProductRegionMap> ProductRegionMapModifiedByNavigations { get; set; } = new List<ProductRegionMap>();

    public virtual ICollection<ProductionSchedule> ProductionScheduleCreatedByNavigations { get; set; } = new List<ProductionSchedule>();

    public virtual ICollection<ProductionScheduleLog> ProductionScheduleLogs { get; set; } = new List<ProductionScheduleLog>();

    public virtual ICollection<ProductionSchedule> ProductionScheduleModifiedByNavigations { get; set; } = new List<ProductionSchedule>();

    public virtual ICollection<ProductionScheduleTicket> ProductionScheduleTicketCreatedByNavigations { get; set; } = new List<ProductionScheduleTicket>();

    public virtual ICollection<ProductionScheduleTicket> ProductionScheduleTicketModifiedByNavigations { get; set; } = new List<ProductionScheduleTicket>();

    public virtual ICollection<RackPlusProductPriceModelMap> RackPlusProductPriceModelMapCreatedByNavigations { get; set; } = new List<RackPlusProductPriceModelMap>();

    public virtual ICollection<RackPlusProductPriceModelMap> RackPlusProductPriceModelMapModifiedByNavigations { get; set; } = new List<RackPlusProductPriceModelMap>();

    public virtual ICollection<RecurrenceOrderSetting> RecurrenceOrderSettings { get; set; } = new List<RecurrenceOrderSetting>();

    public virtual ICollection<Region> RegionCreatedByNavigations { get; set; } = new List<Region>();

    public virtual ICollection<Region> RegionModifiedByNavigations { get; set; } = new List<Region>();

    public virtual ICollection<RegionProductPriceMap> RegionProductPriceMapCreatedByNavigations { get; set; } = new List<RegionProductPriceMap>();

    public virtual ICollection<RegionProductPriceMap> RegionProductPriceMapModifiedByNavigations { get; set; } = new List<RegionProductPriceMap>();

    public virtual ICollection<RegionProductPriceZoneClassMap> RegionProductPriceZoneClassMapCreatedByNavigations { get; set; } = new List<RegionProductPriceZoneClassMap>();

    public virtual ICollection<RegionProductPriceZoneClassMap> RegionProductPriceZoneClassMapModifiedByNavigations { get; set; } = new List<RegionProductPriceZoneClassMap>();

    public virtual ICollection<RegionUserMap> RegionUserMapCreatedByNavigations { get; set; } = new List<RegionUserMap>();

    public virtual ICollection<RegionUserMap> RegionUserMapFkUsers { get; set; } = new List<RegionUserMap>();

    public virtual ICollection<RemittanceAddress> RemittanceAddressCreatedByNavigations { get; set; } = new List<RemittanceAddress>();

    public virtual ICollection<RemittanceAddress> RemittanceAddressModifiedByNavigations { get; set; } = new List<RemittanceAddress>();

    public virtual ICollection<RppmHistory> RppmHistories { get; set; } = new List<RppmHistory>();

    public virtual ICollection<RpppmmHistory> RpppmmHistories { get; set; } = new List<RpppmmHistory>();

    public virtual ICollection<RppzcmHistory> RppzcmHistories { get; set; } = new List<RppzcmHistory>();

    public virtual ICollection<ServiceRequest> ServiceRequestCreatedByNavigations { get; set; } = new List<ServiceRequest>();

    public virtual ICollection<ServiceRequest> ServiceRequestModifiedByNavigations { get; set; } = new List<ServiceRequest>();

    public virtual ICollection<SetupEnumeration> SetupEnumerations { get; set; } = new List<SetupEnumeration>();

    public virtual ICollection<SetupEnumerationsCustomerMap> SetupEnumerationsCustomerMaps { get; set; } = new List<SetupEnumerationsCustomerMap>();

    public virtual ICollection<Shipping> Shippings { get; set; } = new List<Shipping>();

    public virtual ICollection<Statement> StatementApprovedByNavigations { get; set; } = new List<Statement>();

    public virtual ICollection<Statement> StatementCreatedByNavigations { get; set; } = new List<Statement>();

    public virtual ICollection<StatementDetail> StatementDetails { get; set; } = new List<StatementDetail>();

    public virtual ICollection<Statement> StatementModifiedByNavigations { get; set; } = new List<Statement>();

    public virtual ICollection<Statement> StatementPdfGeneratedByNavigations { get; set; } = new List<Statement>();

    public virtual ICollection<StatementType> StatementTypeCreatedByNavigations { get; set; } = new List<StatementType>();

    public virtual ICollection<StatementType> StatementTypeModifiedByNavigations { get; set; } = new List<StatementType>();

    public virtual ICollection<TableCustomization> TableCustomizations { get; set; } = new List<TableCustomization>();

    public virtual ICollection<TaxCategory> TaxCategoryCreatedByNavigations { get; set; } = new List<TaxCategory>();

    public virtual ICollection<TaxCategory> TaxCategoryModifiedByNavigations { get; set; } = new List<TaxCategory>();

    public virtual ICollection<TaxClass> TaxClassCreatedByNavigations { get; set; } = new List<TaxClass>();

    public virtual ICollection<TaxClass> TaxClassModifiedByNavigations { get; set; } = new List<TaxClass>();

    public virtual ICollection<Tax> TaxCreatedByNavigations { get; set; } = new List<Tax>();

    public virtual ICollection<TaxExemption> TaxExemptionCreatedByNavigations { get; set; } = new List<TaxExemption>();

    public virtual ICollection<TaxExemptionEntityMap> TaxExemptionEntityMapCreatedByNavigations { get; set; } = new List<TaxExemptionEntityMap>();

    public virtual ICollection<TaxExemptionEntityMap> TaxExemptionEntityMapModifiedByNavigations { get; set; } = new List<TaxExemptionEntityMap>();

    public virtual ICollection<TaxExemption> TaxExemptionModifiedByNavigations { get; set; } = new List<TaxExemption>();

    public virtual ICollection<TaxHistory> TaxHistories { get; set; } = new List<TaxHistory>();

    public virtual ICollection<Tax> TaxModifiedByNavigations { get; set; } = new List<Tax>();

    public virtual ICollection<TaxRate> TaxRateCreatedByNavigations { get; set; } = new List<TaxRate>();

    public virtual ICollection<TaxRate> TaxRateModifiedByNavigations { get; set; } = new List<TaxRate>();

    public virtual ICollection<TaxRebate> TaxRebateCreatedByNavigations { get; set; } = new List<TaxRebate>();

    public virtual ICollection<TaxRebateEntityMap> TaxRebateEntityMapCreatedByNavigations { get; set; } = new List<TaxRebateEntityMap>();

    public virtual ICollection<TaxRebateEntityMap> TaxRebateEntityMapModifiedByNavigations { get; set; } = new List<TaxRebateEntityMap>();

    public virtual ICollection<TaxRebate> TaxRebateModifiedByNavigations { get; set; } = new List<TaxRebate>();

    public virtual ICollection<TransactionType> TransactionTypeCreatedByNavigations { get; set; } = new List<TransactionType>();

    public virtual ICollection<TransactionType> TransactionTypeModifiedByNavigations { get; set; } = new List<TransactionType>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual ICollection<UserActivity> UserActivities { get; set; } = new List<UserActivity>();

    public virtual ICollection<UserAddress> UserAddresses { get; set; } = new List<UserAddress>();

    public virtual UserIpAddress? UserIpAddress { get; set; }

    public virtual ICollection<UserList> UserListCreatedByNavigations { get; set; } = new List<UserList>();

    public virtual ICollection<UserList> UserListFkUsers { get; set; } = new List<UserList>();

    public virtual ICollection<UserList> UserListModifiedByNavigations { get; set; } = new List<UserList>();

    public virtual ICollection<UserLogMap> UserLogMaps { get; set; } = new List<UserLogMap>();

    public virtual UserSetting? UserSetting { get; set; }

    public virtual ICollection<UserToken> UserTokens { get; set; } = new List<UserToken>();

    public virtual ICollection<Vehicle> VehicleCreatedByNavigations { get; set; } = new List<Vehicle>();

    public virtual ICollection<Vehicle> VehicleModifiedByNavigations { get; set; } = new List<Vehicle>();

    public virtual ICollection<Warehouse> Warehouses { get; set; } = new List<Warehouse>();

    public virtual ICollection<CustomerGroup> FkCustomerGroups { get; set; } = new List<CustomerGroup>();

    public virtual ICollection<PromotionTargetMap> FkPromotionTargetMaps { get; set; } = new List<PromotionTargetMap>();
}
