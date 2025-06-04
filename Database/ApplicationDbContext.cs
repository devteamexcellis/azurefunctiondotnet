using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using excellis.Models;

namespace excellis.Database;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountCustomerAddressMap> AccountCustomerAddressMaps { get; set; }

    public virtual DbSet<AccountServiceMap> AccountServiceMaps { get; set; }

    public virtual DbSet<AccountUserMap> AccountUserMaps { get; set; }

    public virtual DbSet<Alert> Alerts { get; set; }

    public virtual DbSet<ApiDump> ApiDumps { get; set; }

    public virtual DbSet<ArRecord> ArRecords { get; set; }

    public virtual DbSet<Asset> Assets { get; set; }

    public virtual DbSet<AssetHistory> AssetHistories { get; set; }

    public virtual DbSet<AssetInspection> AssetInspections { get; set; }

    public virtual DbSet<AssetServiceRequestMap> AssetServiceRequestMaps { get; set; }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<Batch> Batches { get; set; }

    public virtual DbSet<BillOfMaterial> BillOfMaterials { get; set; }

    public virtual DbSet<Block> Blocks { get; set; }

    public virtual DbSet<BlockCustomerMap> BlockCustomerMaps { get; set; }

    public virtual DbSet<BptmDetail> BptmDetails { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<BranchProductTemplateMap> BranchProductTemplateMaps { get; set; }

    public virtual DbSet<BranchUserMap> BranchUserMaps { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<CaAttributesHistory> CaAttributesHistories { get; set; }

    public virtual DbSet<CaAttributesProjection> CaAttributesProjections { get; set; }

    public virtual DbSet<CappmmHistory> CappmmHistories { get; set; }

    public virtual DbSet<CaptmDetail> CaptmDetails { get; set; }

    public virtual DbSet<Cart> Carts { get; set; }

    public virtual DbSet<CartDetail> CartDetails { get; set; }

    public virtual DbSet<CartDetailsAddOn> CartDetailsAddOns { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CategoryLevel> CategoryLevels { get; set; }

    public virtual DbSet<ClientContact> ClientContacts { get; set; }

    public virtual DbSet<ClientGroup> ClientGroups { get; set; }

    public virtual DbSet<CodeSequence> CodeSequences { get; set; }

    public virtual DbSet<ContentAsset> ContentAssets { get; set; }

    public virtual DbSet<CueProduct> CueProducts { get; set; }

    public virtual DbSet<CustSequenceRecord> CustSequenceRecords { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }

    public virtual DbSet<CustomerAddressAccountServiceMap> CustomerAddressAccountServiceMaps { get; set; }

    public virtual DbSet<CustomerAddressAccountUserMap> CustomerAddressAccountUserMaps { get; set; }

    public virtual DbSet<CustomerAddressAttribute> CustomerAddressAttributes { get; set; }

    public virtual DbSet<CustomerAddressGroupMap> CustomerAddressGroupMaps { get; set; }

    public virtual DbSet<CustomerAddressProductPriceModelMap> CustomerAddressProductPriceModelMaps { get; set; }

    public virtual DbSet<CustomerAddressProductPriceModelMapTemp> CustomerAddressProductPriceModelMapTemps { get; set; }

    public virtual DbSet<CustomerAddressProductSetting> CustomerAddressProductSettings { get; set; }

    public virtual DbSet<CustomerAddressProductTemplateMap> CustomerAddressProductTemplateMaps { get; set; }

    public virtual DbSet<CustomerAddressRegionMap> CustomerAddressRegionMaps { get; set; }

    public virtual DbSet<CustomerAddressTemp> CustomerAddressTemps { get; set; }

    public virtual DbSet<CustomerBackup> CustomerBackups { get; set; }

    public virtual DbSet<CustomerContact> CustomerContacts { get; set; }

    public virtual DbSet<CustomerContactTemp> CustomerContactTemps { get; set; }

    public virtual DbSet<CustomerEnrollmentLog> CustomerEnrollmentLogs { get; set; }

    public virtual DbSet<CustomerGroup> CustomerGroups { get; set; }

    public virtual DbSet<CustomerGroupApi> CustomerGroupApis { get; set; }

    public virtual DbSet<CustomerIntegration> CustomerIntegrations { get; set; }

    public virtual DbSet<CustomerIntegrationDetail> CustomerIntegrationDetails { get; set; }

    public virtual DbSet<CustomerNotesTemp> CustomerNotesTemps { get; set; }

    public virtual DbSet<CustomerPartner> CustomerPartners { get; set; }

    public virtual DbSet<CustomerProductMap> CustomerProductMaps { get; set; }

    public virtual DbSet<CustomerProductVarianceMap> CustomerProductVarianceMaps { get; set; }

    public virtual DbSet<CustomerRemittanceAddressMap> CustomerRemittanceAddressMaps { get; set; }

    public virtual DbSet<CustomerServiceMap> CustomerServiceMaps { get; set; }

    public virtual DbSet<CustomerShippingVendorMap> CustomerShippingVendorMaps { get; set; }

    public virtual DbSet<CustomerSubscriptionMap> CustomerSubscriptionMaps { get; set; }

    public virtual DbSet<CustomerTemp> CustomerTemps { get; set; }

    public virtual DbSet<CustomerType> CustomerTypes { get; set; }

    public virtual DbSet<CustomerUserMap> CustomerUserMaps { get; set; }

    public virtual DbSet<CustomerUserRolePermissionMap> CustomerUserRolePermissionMaps { get; set; }

    public virtual DbSet<DegreeDay> DegreeDays { get; set; }

    public virtual DbSet<DeliveryQueue> DeliveryQueues { get; set; }

    public virtual DbSet<DeliveryQueueOperation> DeliveryQueueOperations { get; set; }

    public virtual DbSet<DeliveryQueueOperationMap> DeliveryQueueOperationMaps { get; set; }

    public virtual DbSet<DumpCustomerTable> DumpCustomerTables { get; set; }

    public virtual DbSet<DumpCustomerTableDetail> DumpCustomerTableDetails { get; set; }

    public virtual DbSet<EdiTransactLog> EdiTransactLogs { get; set; }

    public virtual DbSet<Edisequence> Edisequences { get; set; }

    public virtual DbSet<EntityEnum> EntityEnums { get; set; }

    public virtual DbSet<Equipment> Equipment { get; set; }

    public virtual DbSet<EquipmentServiceRequestMap> EquipmentServiceRequestMaps { get; set; }

    public virtual DbSet<EquipmentType> EquipmentTypes { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<ExceptionCodeReference> ExceptionCodeReferences { get; set; }

    public virtual DbSet<Family> Families { get; set; }

    public virtual DbSet<FillLocation> FillLocations { get; set; }

    public virtual DbSet<Form> Forms { get; set; }

    public virtual DbSet<FormQuestion> FormQuestions { get; set; }

    public virtual DbSet<FormSubQuestion> FormSubQuestions { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<Hold> Holds { get; set; }

    public virtual DbSet<Inspection> Inspections { get; set; }

    public virtual DbSet<InspectionHistory> InspectionHistories { get; set; }

    public virtual DbSet<InspectionLog> InspectionLogs { get; set; }

    public virtual DbSet<InvSequenceRecord> InvSequenceRecords { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<InventoryLocation> InventoryLocations { get; set; }

    public virtual DbSet<InventoryLog> InventoryLogs { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceCharge> InvoiceCharges { get; set; }

    public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }

    public virtual DbSet<InvoiceLineItem> InvoiceLineItems { get; set; }

    public virtual DbSet<InvoicePayment> InvoicePayments { get; set; }

    public virtual DbSet<InvoicePaymentMap> InvoicePaymentMaps { get; set; }

    public virtual DbSet<Lead> Leads { get; set; }

    public virtual DbSet<ListSharingDetail> ListSharingDetails { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<LogAudience> LogAudiences { get; set; }

    public virtual DbSet<LogGroupAudience> LogGroupAudiences { get; set; }

    public virtual DbSet<LogRoleAudience> LogRoleAudiences { get; set; }

    public virtual DbSet<LogUserAudience> LogUserAudiences { get; set; }

    public virtual DbSet<Lot> Lots { get; set; }

    public virtual DbSet<LotBom> LotBoms { get; set; }

    public virtual DbSet<LotBomInventoryMap> LotBomInventoryMaps { get; set; }

    public virtual DbSet<LotLog> LotLogs { get; set; }

    public virtual DbSet<Manufacturing> Manufacturings { get; set; }

    public virtual DbSet<ManufacturingBom> ManufacturingBoms { get; set; }

    public virtual DbSet<ManufacturingBomInventoryMap> ManufacturingBomInventoryMaps { get; set; }

    public virtual DbSet<ManufacturingLog> ManufacturingLogs { get; set; }

    public virtual DbSet<MasterDataLog> MasterDataLogs { get; set; }

    public virtual DbSet<MasterGroup> MasterGroups { get; set; }

    public virtual DbSet<MasterRole> MasterRoles { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<MiscellaneousCharge> MiscellaneousCharges { get; set; }

    public virtual DbSet<MultiFactorAuthToken> MultiFactorAuthTokens { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderAsset> OrderAssets { get; set; }

    public virtual DbSet<OrderCharge> OrderCharges { get; set; }

    public virtual DbSet<OrderCode> OrderCodes { get; set; }

    public virtual DbSet<OrderDelivery> OrderDeliveries { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrderDetailShipmentMap> OrderDetailShipmentMaps { get; set; }

    public virtual DbSet<OrderDetailsAddOn> OrderDetailsAddOns { get; set; }

    public virtual DbSet<OrderException> OrderExceptions { get; set; }

    public virtual DbSet<OrderInventoryMap> OrderInventoryMaps { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<OrderLineItem> OrderLineItems { get; set; }

    public virtual DbSet<OrderLineItemDetail> OrderLineItemDetails { get; set; }

    public virtual DbSet<OrderLog> OrderLogs { get; set; }

    public virtual DbSet<OrderNotificationRecipient> OrderNotificationRecipients { get; set; }

    public virtual DbSet<OrderNumber> OrderNumbers { get; set; }

    public virtual DbSet<OrderReturnLabel> OrderReturnLabels { get; set; }

    public virtual DbSet<OrnuSequenceRecord> OrnuSequenceRecords { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<PaymentTerm> PaymentTerms { get; set; }

    public virtual DbSet<PaymentType> PaymentTypes { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<PreprintReturnLabel> PreprintReturnLabels { get; set; }

    public virtual DbSet<PriceZone> PriceZones { get; set; }

    public virtual DbSet<PricingTemplate> PricingTemplates { get; set; }

    public virtual DbSet<PricingTemplateDetail> PricingTemplateDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductAsset> ProductAssets { get; set; }

    public virtual DbSet<ProductAttributeDefinition> ProductAttributeDefinitions { get; set; }

    public virtual DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }

    public virtual DbSet<ProductClientAttribute> ProductClientAttributes { get; set; }

    public virtual DbSet<ProductRegionMap> ProductRegionMaps { get; set; }

    public virtual DbSet<ProductVariance> ProductVariances { get; set; }

    public virtual DbSet<ProductionSchedTicketInvMap> ProductionSchedTicketInvMaps { get; set; }

    public virtual DbSet<ProductionSchedule> ProductionSchedules { get; set; }

    public virtual DbSet<ProductionScheduleLog> ProductionScheduleLogs { get; set; }

    public virtual DbSet<ProductionScheduleTicket> ProductionScheduleTickets { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<PromotionCoupon> PromotionCoupons { get; set; }

    public virtual DbSet<PromotionTargetMap> PromotionTargetMaps { get; set; }

    public virtual DbSet<RackPlusProductPriceModelMap> RackPlusProductPriceModelMaps { get; set; }

    public virtual DbSet<Recurrence> Recurrences { get; set; }

    public virtual DbSet<RecurrenceCharge> RecurrenceCharges { get; set; }

    public virtual DbSet<RecurrenceDetail> RecurrenceDetails { get; set; }

    public virtual DbSet<RecurrenceOrderSetting> RecurrenceOrderSettings { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<RegionProductPriceMap> RegionProductPriceMaps { get; set; }

    public virtual DbSet<RegionProductPriceZoneClassMap> RegionProductPriceZoneClassMaps { get; set; }

    public virtual DbSet<RegionProductWeatherMap> RegionProductWeatherMaps { get; set; }

    public virtual DbSet<RegionTemp> RegionTemps { get; set; }

    public virtual DbSet<RegionUserMap> RegionUserMaps { get; set; }

    public virtual DbSet<RemittanceAddress> RemittanceAddresses { get; set; }

    public virtual DbSet<RemittanceAddressRegionInventoryLocationMap> RemittanceAddressRegionInventoryLocationMaps { get; set; }

    public virtual DbSet<ReportProductProductionCapability> ReportProductProductionCapabilities { get; set; }

    public virtual DbSet<Response> Responses { get; set; }

    public virtual DbSet<ResponseQuestion> ResponseQuestions { get; set; }

    public virtual DbSet<ResponseSubQuestion> ResponseSubQuestions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolePermissionMap> RolePermissionMaps { get; set; }

    public virtual DbSet<RppmHistory> RppmHistories { get; set; }

    public virtual DbSet<RpppmmHistory> RpppmmHistories { get; set; }

    public virtual DbSet<RppzcmHistory> RppzcmHistories { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<ServiceAsset> ServiceAssets { get; set; }

    public virtual DbSet<ServiceAttributeDefinition> ServiceAttributeDefinitions { get; set; }

    public virtual DbSet<ServiceAttributeValue> ServiceAttributeValues { get; set; }

    public virtual DbSet<ServiceClientAttribute> ServiceClientAttributes { get; set; }

    public virtual DbSet<ServicePrice> ServicePrices { get; set; }

    public virtual DbSet<ServiceRequest> ServiceRequests { get; set; }

    public virtual DbSet<ServiceRequestFormResponse> ServiceRequestFormResponses { get; set; }

    public virtual DbSet<ServiceRequestSchedule> ServiceRequestSchedules { get; set; }

    public virtual DbSet<SetupEnumeration> SetupEnumerations { get; set; }

    public virtual DbSet<SetupEnumerationsCustomerMap> SetupEnumerationsCustomerMaps { get; set; }

    public virtual DbSet<Shipment> Shipments { get; set; }

    public virtual DbSet<Shipping> Shippings { get; set; }

    public virtual DbSet<ShippingType> ShippingTypes { get; set; }

    public virtual DbSet<ShippingVendor> ShippingVendors { get; set; }

    public virtual DbSet<Statement> Statements { get; set; }

    public virtual DbSet<StatementDetail> StatementDetails { get; set; }

    public virtual DbSet<StatementSubscriptionMap> StatementSubscriptionMaps { get; set; }

    public virtual DbSet<StatementType> StatementTypes { get; set; }

    public virtual DbSet<SubFamily> SubFamilies { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    public virtual DbSet<SupplierVendor> SupplierVendors { get; set; }

    public virtual DbSet<SupplierVendorAddress> SupplierVendorAddresses { get; set; }

    public virtual DbSet<SupplierVendorMaterialMap> SupplierVendorMaterialMaps { get; set; }

    public virtual DbSet<SupplierVendorProductMap> SupplierVendorProductMaps { get; set; }

    public virtual DbSet<SupplierVendorProductVarianceMap> SupplierVendorProductVarianceMaps { get; set; }

    public virtual DbSet<TableCustomization> TableCustomizations { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<TagEntityMap> TagEntityMaps { get; set; }

    public virtual DbSet<TankTemp> TankTemps { get; set; }

    public virtual DbSet<Tax> Taxes { get; set; }

    public virtual DbSet<TaxCategory> TaxCategories { get; set; }

    public virtual DbSet<TaxClass> TaxClasses { get; set; }

    public virtual DbSet<TaxExemption> TaxExemptions { get; set; }

    public virtual DbSet<TaxExemptionEntityMap> TaxExemptionEntityMaps { get; set; }

    public virtual DbSet<TaxHistory> TaxHistories { get; set; }

    public virtual DbSet<TaxRate> TaxRates { get; set; }

    public virtual DbSet<TaxRebate> TaxRebates { get; set; }

    public virtual DbSet<TaxRebateEntityMap> TaxRebateEntityMaps { get; set; }

    public virtual DbSet<TempCustomerRegion> TempCustomerRegions { get; set; }

    public virtual DbSet<TickSequenceRecord> TickSequenceRecords { get; set; }

    public virtual DbSet<Timezone> Timezones { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<TransactionDetail> TransactionDetails { get; set; }

    public virtual DbSet<TransactionType> TransactionTypes { get; set; }

    public virtual DbSet<Upload> Uploads { get; set; }

    public virtual DbSet<UploadHistory> UploadHistories { get; set; }

    public virtual DbSet<UploadRow> UploadRows { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserActivity> UserActivities { get; set; }

    public virtual DbSet<UserActivityLog> UserActivityLogs { get; set; }

    public virtual DbSet<UserAddress> UserAddresses { get; set; }

    public virtual DbSet<UserGroupMap> UserGroupMaps { get; set; }

    public virtual DbSet<UserIpAddress> UserIpAddresses { get; set; }

    public virtual DbSet<UserList> UserLists { get; set; }

    public virtual DbSet<UserLogMap> UserLogMaps { get; set; }

    public virtual DbSet<UserProductList> UserProductLists { get; set; }

    public virtual DbSet<UserSetting> UserSettings { get; set; }

    public virtual DbSet<UserToken> UserTokens { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<ViewCategoryHierarchyDetail> ViewCategoryHierarchyDetails { get; set; }

    public virtual DbSet<ViewTagCustomerMapDetail> ViewTagCustomerMapDetails { get; set; }

    public virtual DbSet<ViewTagEntityMapDetail> ViewTagEntityMapDetails { get; set; }

    public virtual DbSet<ViewTagProductMapDetail> ViewTagProductMapDetails { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    public virtual DbSet<WeatherStation> WeatherStations { get; set; }

    public virtual DbSet<Zone> Zones { get; set; }

    public virtual DbSet<ZoneTemp> ZoneTemps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=netske-desktop;Database=dbcueprdcac02-20241210;User Id=root;Password=root;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("ACCOUNT");

            entity.HasIndex(e => e.FkCustomerId, "IX_ACCOUNT");

            entity.HasIndex(e => e.CreatedBy, "IX_ACCOUNT_1");

            entity.HasIndex(e => e.LegacyId, "IX_ACCOUNT_2");

            entity.HasIndex(e => e.Status, "IX_ACCOUNT_3");

            entity.HasIndex(e => e.Type, "IX_ACCOUNT_4");

            entity.HasIndex(e => e.ContactPerson, "IX_ACCOUNT_5");

            entity.HasIndex(e => new { e.Id, e.FkCustomerId }, "IX_ACCOUNT_6").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTACT_NUMBER");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CONTACT_PERSON");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.IsPublic).HasColumnName("IS_PUBLIC");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCOUNT_USER");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCOUNT_CUSTOMER");
        });

        modelBuilder.Entity<AccountCustomerAddressMap>(entity =>
        {
            entity.HasKey(e => new { e.FkAccountId, e.FkCustomerAddressId, e.FkCustomerId });

            entity.ToTable("ACCOUNT_CUSTOMER_ADDRESS_MAP");

            entity.HasIndex(e => e.FkAccountId, "IX_ACCOUNT_CUSTOMER_ADDRESS_MAP");

            entity.HasIndex(e => e.FkCustomerAddressId, "IX_ACCOUNT_CUSTOMER_ADDRESS_MAP_1");

            entity.HasIndex(e => e.FkCustomerId, "IX_ACCOUNT_CUSTOMER_ADDRESS_MAP_2");

            entity.Property(e => e.FkAccountId).HasColumnName("FK_ACCOUNT_ID");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");

            entity.HasOne(d => d.Account).WithMany(p => p.AccountCustomerAddressMaps)
                .HasPrincipalKey(p => new { p.Id, p.FkCustomerId })
                .HasForeignKey(d => new { d.FkAccountId, d.FkCustomerId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCOUNT_CUSTOMER_ADDRESS_MAP_ACCOUNT");

            entity.HasOne(d => d.CustomerAddress).WithMany(p => p.AccountCustomerAddressMaps)
                .HasPrincipalKey(p => new { p.Id, p.FkCustomerId })
                .HasForeignKey(d => new { d.FkCustomerAddressId, d.FkCustomerId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCOUNT_CUSTOMER_ADDRESS_MAP_CUSTOMER_ADDRESS");
        });

        modelBuilder.Entity<AccountServiceMap>(entity =>
        {
            entity.HasKey(e => new { e.FkAccountId, e.FkServiceId, e.FkCustomerId });

            entity.ToTable("ACCOUNT_SERVICE_MAP");

            entity.HasIndex(e => e.FkAccountId, "IX_ACCOUNT_SERVICE_MAP");

            entity.HasIndex(e => e.FkCustomerId, "IX_ACCOUNT_SERVICE_MAP_1");

            entity.HasIndex(e => e.FkServiceId, "IX_ACCOUNT_SERVICE_MAP_2");

            entity.Property(e => e.FkAccountId).HasColumnName("FK_ACCOUNT_ID");
            entity.Property(e => e.FkServiceId).HasColumnName("FK_SERVICE_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");

            entity.HasOne(d => d.Account).WithMany(p => p.AccountServiceMaps)
                .HasPrincipalKey(p => new { p.Id, p.FkCustomerId })
                .HasForeignKey(d => new { d.FkAccountId, d.FkCustomerId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCOUNT_SERVICE_MAP_ACCOUNT");

            entity.HasOne(d => d.CustomerServiceMap).WithMany(p => p.AccountServiceMaps)
                .HasForeignKey(d => new { d.FkCustomerId, d.FkServiceId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCOUNT_SERVICE_MAP_CUSTOMER_SERVICE_MAP");
        });

        modelBuilder.Entity<AccountUserMap>(entity =>
        {
            entity.HasKey(e => new { e.FkAccountId, e.FkUserId, e.FkCustomerId });

            entity.ToTable("ACCOUNT_USER_MAP");

            entity.HasIndex(e => e.FkAccountId, "IX_ACCOUNT_USER_MAP");

            entity.HasIndex(e => e.FkCustomerId, "IX_ACCOUNT_USER_MAP_1");

            entity.HasIndex(e => e.FkRoleId, "IX_ACCOUNT_USER_MAP_2");

            entity.HasIndex(e => e.FkUserId, "IX_ACCOUNT_USER_MAP_3");

            entity.HasIndex(e => e.LegacyId, "IX_ACCOUNT_USER_MAP_4");

            entity.HasIndex(e => e.Status, "IX_ACCOUNT_USER_MAP_5");

            entity.HasIndex(e => e.DateCreated, "IX_ACCOUNT_USER_MAP_6");

            entity.HasIndex(e => e.DateModified, "IX_ACCOUNT_USER_MAP_7");

            entity.Property(e => e.FkAccountId).HasColumnName("FK_ACCOUNT_ID");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkRoleId).HasColumnName("FK_ROLE_ID");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ID");
            entity.Property(e => e.Location)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Spot)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("SPOT");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.Account).WithMany(p => p.AccountUserMaps)
                .HasPrincipalKey(p => new { p.Id, p.FkCustomerId })
                .HasForeignKey(d => new { d.FkAccountId, d.FkCustomerId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCOUNT_USER_MAP_ACCOUNT");

            entity.HasOne(d => d.CustomerUserMap).WithMany(p => p.AccountUserMaps)
                .HasForeignKey(d => new { d.FkCustomerId, d.FkUserId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ACCOUNT_USER_MAP_CUSTOMER_USER_MAP");

            entity.HasOne(d => d.Role).WithMany(p => p.AccountUserMaps)
                .HasPrincipalKey(p => new { p.Id, p.FkCustomerId })
                .HasForeignKey(d => new { d.FkRoleId, d.FkCustomerId })
                .HasConstraintName("FK_ACCOUNT_USER_MAP_ROLE");
        });

        modelBuilder.Entity<Alert>(entity =>
        {
            entity.ToTable("ALERT");

            entity.HasIndex(e => e.Code, "IX_ALERT");

            entity.HasIndex(e => e.Id, "IX_ALERT_1");

            entity.HasIndex(e => e.FkCustomerId, "IX_ALERT_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.IsCore).HasColumnName("IS_CORE");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NotificationBody)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOTIFICATION_BODY");
            entity.Property(e => e.NotificationTitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOTIFICATION_TITLE");
            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.Alerts)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ALERT_CUSTOMER");
        });

        modelBuilder.Entity<ApiDump>(entity =>
        {
            entity.ToTable("API_DUMP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.Message)
                .IsUnicode(false)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.RequestOrigin)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("REQUEST_ORIGIN");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<ArRecord>(entity =>
        {
            entity.ToTable("AR_RECORD");

            entity.Property(e => e.Id)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.Balance)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("BALANCE");
            entity.Property(e => e.DateCreatedDtm)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED_DTM");
            entity.Property(e => e.DateCreatedString)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATE_CREATED_STRING");
            entity.Property(e => e.Description)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.ReferenceIdInt).HasColumnName("REFERENCE_ID_INT");
            entity.Property(e => e.ReferenceIdString)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFERENCE_ID_STRING");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TRANSACTION_TYPE");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.ArRecords)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AR_RECORD_CUSTOMER");
        });

        modelBuilder.Entity<Asset>(entity =>
        {
            entity.ToTable("ASSET");

            entity.HasIndex(e => e.FkProductId, "IX_ASSET");

            entity.HasIndex(e => e.SerialNumber, "IX_ASSET_1").IsUnique();

            entity.HasIndex(e => e.Status, "IX_ASSET_11");

            entity.HasIndex(e => e.DateCreated, "IX_ASSET_2");

            entity.HasIndex(e => e.CreatedBy, "IX_ASSET_3");

            entity.HasIndex(e => e.LegacyAssetId, "IX_ASSET_4");

            entity.HasIndex(e => e.ReferenceInvId, "IX_ASSET_5");

            entity.HasIndex(e => e.ReferenceCustomerAaId, "IX_ASSET_6");

            entity.HasIndex(e => e.FkInventoryLocationId, "IX_ASSET_7");

            entity.HasIndex(e => e.FkCustomerAddressId, "IX_ASSET_8");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssetType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ASSET_TYPE");
            entity.Property(e => e.Capacity).HasColumnName("CAPACITY");
            entity.Property(e => e.CapacityUnit)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CAPACITY_UNIT");
            entity.Property(e => e.Category)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateInstalled).HasColumnName("DATE_INSTALLED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DateOfManufacture).HasColumnName("DATE_OF_MANUFACTURE");
            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkInventoryLocationId).HasColumnName("FK_INVENTORY_LOCATION_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.IdealCapacity).HasColumnName("IDEAL_CAPACITY");
            entity.Property(e => e.IsInInventory).HasColumnName("IS_IN_INVENTORY");
            entity.Property(e => e.IsRental).HasColumnName("IS_RENTAL");
            entity.Property(e => e.LegacyAssetId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ASSET_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Owner)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OWNER");
            entity.Property(e => e.ReferenceCustomerAaId).HasColumnName("REFERENCE_CUSTOMER_AA_ID");
            entity.Property(e => e.ReferenceInvId).HasColumnName("REFERENCE_INV_ID");
            entity.Property(e => e.RemainingRentalInstallments).HasColumnName("REMAINING_RENTAL_INSTALLMENTS");
            entity.Property(e => e.RentalAmount).HasColumnName("RENTAL_AMOUNT");
            entity.Property(e => e.RentalFrequency)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RENTAL_FREQUENCY");
            entity.Property(e => e.ReserveCapacity).HasColumnName("RESERVE_CAPACITY");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.UsableCapacity).HasColumnName("USABLE_CAPACITY");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AssetCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ASSET_USER");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.Assets)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_ASSET");

            entity.HasOne(d => d.FkInventoryLocation).WithMany(p => p.Assets)
                .HasForeignKey(d => d.FkInventoryLocationId)
                .HasConstraintName("FK_INVENTORY_LOCATION_ASSET");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.Assets)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ASSET_PRODUCT");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.AssetModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_ASSET_USER_2");
        });

        modelBuilder.Entity<AssetHistory>(entity =>
        {
            entity.ToTable("ASSET_HISTORY");

            entity.HasIndex(e => e.FkAssetId, "IX_ASSET_HISTORY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssetHistoryNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("ASSET_HISTORY_NOTES");
            entity.Property(e => e.AssetType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ASSET_TYPE");
            entity.Property(e => e.Capacity).HasColumnName("CAPACITY");
            entity.Property(e => e.CapacityUnit)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CAPACITY_UNIT");
            entity.Property(e => e.Category)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateInstalled).HasColumnName("DATE_INSTALLED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DateOfManufacture).HasColumnName("DATE_OF_MANUFACTURE");
            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.FkAssetId).HasColumnName("FK_ASSET_ID");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.IdealCapacity).HasColumnName("IDEAL_CAPACITY");
            entity.Property(e => e.IsInInventory).HasColumnName("IS_IN_INVENTORY");
            entity.Property(e => e.IsRental).HasColumnName("IS_RENTAL");
            entity.Property(e => e.LegacyAssetId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ASSET_ID");
            entity.Property(e => e.Module)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.Owner)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OWNER");
            entity.Property(e => e.ReferenceCustomerAaId).HasColumnName("REFERENCE_CUSTOMER_AA_ID");
            entity.Property(e => e.ReferenceInvId).HasColumnName("REFERENCE_INV_ID");
            entity.Property(e => e.RemainingRentalInstallments).HasColumnName("REMAINING_RENTAL_INSTALLMENTS");
            entity.Property(e => e.RentalAmount).HasColumnName("RENTAL_AMOUNT");
            entity.Property(e => e.RentalFrequency)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RENTAL_FREQUENCY");
            entity.Property(e => e.ReserveCapacity).HasColumnName("RESERVE_CAPACITY");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .HasColumnName("SERIAL_NUMBER");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.UsableCapacity).HasColumnName("USABLE_CAPACITY");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AssetHistories)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ASSET_HISTORY_USER");

            entity.HasOne(d => d.FkAsset).WithMany(p => p.AssetHistories)
                .HasForeignKey(d => d.FkAssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ASSET_HISTORY_ASSET");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.AssetHistories)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .HasConstraintName("FK_ASSET_HISTORY_CUSTOMER_ADDRESS");
        });

        modelBuilder.Entity<AssetInspection>(entity =>
        {
            entity.ToTable("ASSET_INSPECTION");

            entity.HasIndex(e => e.FkAssetId, "IX_ASSET_INSPECTION");

            entity.HasIndex(e => e.DateCreated, "IX_ASSET_INSPECTION_1");

            entity.HasIndex(e => e.CreatedBy, "IX_ASSET_INSPECTION_2");

            entity.HasIndex(e => e.DateModified, "IX_ASSET_INSPECTION_3");

            entity.HasIndex(e => e.ModifiedBy, "IX_ASSET_INSPECTION_4");

            entity.HasIndex(e => e.LastInspection, "IX_ASSET_INSPECTION_5");

            entity.HasIndex(e => e.NextInspection, "IX_ASSET_INSPECTION_6");

            entity.HasIndex(e => e.Condition, "IX_ASSET_INSPECTION_7");

            entity.HasIndex(e => e.IsInspectionRequired, "IX_ASSET_INSPECTION_8");

            entity.HasIndex(e => e.IsFollowUpNeeded, "IX_ASSET_INSPECTION_9");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Condition)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CONDITION");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkAssetId).HasColumnName("FK_ASSET_ID");
            entity.Property(e => e.IsFollowUpNeeded).HasColumnName("IS_FOLLOW_UP_NEEDED");
            entity.Property(e => e.IsInspectionRequired).HasColumnName("IS_INSPECTION_REQUIRED");
            entity.Property(e => e.LastInspection)
                .HasColumnType("datetime")
                .HasColumnName("LAST_INSPECTION");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.NextInspection)
                .HasColumnType("datetime")
                .HasColumnName("NEXT_INSPECTION");
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOTES");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AssetInspectionCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ASSET_INSPECTION_USER");

            entity.HasOne(d => d.FkAsset).WithMany(p => p.AssetInspections)
                .HasForeignKey(d => d.FkAssetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ASSET_INSPECTION_ASSET");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.AssetInspectionModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_ASSET_INSPECTION_USER1");
        });

        modelBuilder.Entity<AssetServiceRequestMap>(entity =>
        {
            entity.ToTable("ASSET_SERVICE_REQUEST_MAP");

            entity.HasIndex(e => e.FkServiceRequestId, "IX_ASSET_SERVICE_REQUEST_MAP_1");

            entity.HasIndex(e => e.FkAssetId, "IX_ASSET_SERVICE_REQUEST_MAP_2");

            entity.HasIndex(e => e.DateCreated, "IX_ASSET_SERVICE_REQUEST_MAP_3");

            entity.HasIndex(e => e.CreatedBy, "IX_ASSET_SERVICE_REQUEST_MAP_4");

            entity.HasIndex(e => e.DateModified, "IX_ASSET_SERVICE_REQUEST_MAP_5");

            entity.HasIndex(e => e.ModifiedBy, "IX_ASSET_SERVICE_REQUEST_MAP_6");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkAssetId).HasColumnName("FK_ASSET_ID");
            entity.Property(e => e.FkServiceRequestId).HasColumnName("FK_SERVICE_REQUEST_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AssetServiceRequestMapCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ASSET_SERVICE_REQUEST_MAP_USER_1");

            entity.HasOne(d => d.FkAsset).WithMany(p => p.AssetServiceRequestMaps)
                .HasForeignKey(d => d.FkAssetId)
                .HasConstraintName("FK_ASSET_SERVICE_REQUEST_MAP_ASSET");

            entity.HasOne(d => d.FkServiceRequest).WithMany(p => p.AssetServiceRequestMaps)
                .HasForeignKey(d => d.FkServiceRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ASSET_SERVICE_REQUEST_MAP_SERVICE_REQUEST");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.AssetServiceRequestMapModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_ASSET_SERVICE_REQUEST_MAP_USER_2");
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ORDER_ATTACHMENT");

            entity.ToTable("ATTACHMENT");

            entity.HasIndex(e => e.FkCustomerId, "IX_ATTACHMENT");

            entity.HasIndex(e => e.Module, "IX_ATTACHMENT_1");

            entity.HasIndex(e => e.FkStatementId, "IX_ATTACHMENT_10");

            entity.HasIndex(e => e.FkInvoiceId, "IX_ATTACHMENT_3");

            entity.HasIndex(e => e.FkServiceRequestId, "IX_ATTACHMENT_4");

            entity.HasIndex(e => e.FkLeadId, "IX_ATTACHMENT_5");

            entity.HasIndex(e => e.FkInspectionId, "IX_ATTACHMENT_6");

            entity.HasIndex(e => e.ModifiedBy, "IX_ATTACHMENT_7");

            entity.HasIndex(e => e.DateModified, "IX_ATTACHMENT_8");

            entity.HasIndex(e => e.IsPrimary, "IX_ATTACHMENT_9");

            entity.HasIndex(e => e.FkOrderId, "IX_ORDER_ATTACHMENT");

            entity.HasIndex(e => e.DateCreated, "IX_ORDER_ATTACHMENT_1");

            entity.HasIndex(e => e.Type, "IX_ORDER_ATTACHMENT_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FileBinary).HasColumnName("FILE_BINARY");
            entity.Property(e => e.FileName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FILE_NAME");
            entity.Property(e => e.FileSize).HasColumnName("FILE_SIZE");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkInspectionId).HasColumnName("FK_INSPECTION_ID");
            entity.Property(e => e.FkInvoiceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FK_INVOICE_ID");
            entity.Property(e => e.FkLeadId).HasColumnName("FK_LEAD_ID");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.FkServiceRequestId).HasColumnName("FK_SERVICE_REQUEST_ID");
            entity.Property(e => e.FkStatementId).HasColumnName("FK_STATEMENT_ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("GUID");
            entity.Property(e => e.IsPrimary).HasColumnName("IS_PRIMARY");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Module)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Url)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("URL");
            entity.Property(e => e.UrlBase)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URL_BASE");
            entity.Property(e => e.UrlContainer)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("URL_CONTAINER");
            entity.Property(e => e.UrlEntity)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("URL_ENTITY");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AttachmentCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_ATTACHMENT_USER");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.Attachments)
                .HasForeignKey(d => d.FkCustomerId)
                .HasConstraintName("FK_ATTACHMENT_CUSTOMER");

            entity.HasOne(d => d.FkInspection).WithMany(p => p.Attachments)
                .HasForeignKey(d => d.FkInspectionId)
                .HasConstraintName("FK_INSPECTION_ATTACHMENT");

            entity.HasOne(d => d.FkInvoice).WithMany(p => p.Attachments)
                .HasForeignKey(d => d.FkInvoiceId)
                .HasConstraintName("FK_INVOICE_ATTACHMENT");

            entity.HasOne(d => d.FkLead).WithMany(p => p.Attachments)
                .HasForeignKey(d => d.FkLeadId)
                .HasConstraintName("FK_LEAD_ATTACHMENT");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.Attachments)
                .HasForeignKey(d => d.FkOrderId)
                .HasConstraintName("FK_ORDER_ATTACHMENT_ORDER");

            entity.HasOne(d => d.FkServiceRequest).WithMany(p => p.Attachments)
                .HasForeignKey(d => d.FkServiceRequestId)
                .HasConstraintName("FK_ATTACHMENT_SERVICE_REQUEST");

            entity.HasOne(d => d.FkStatement).WithMany(p => p.Attachments)
                .HasForeignKey(d => d.FkStatementId)
                .HasConstraintName("FK_ATTACHMENT_STATEMENT");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.AttachmentModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_ATTACHMENT_USER_2");
        });

        modelBuilder.Entity<Batch>(entity =>
        {
            entity.ToTable("BATCH");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Module)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<BillOfMaterial>(entity =>
        {
            entity.HasKey(e => new { e.Version, e.FkParentProductId, e.FkChildProductId });

            entity.ToTable("BILL_OF_MATERIALS");

            entity.HasIndex(e => e.Version, "IX_BILL_OF_MATERIALS");

            entity.HasIndex(e => e.FkParentProductId, "IX_BILL_OF_MATERIALS_1");

            entity.HasIndex(e => e.FkChildProductId, "IX_BILL_OF_MATERIALS_2");

            entity.Property(e => e.Version).HasColumnName("VERSION");
            entity.Property(e => e.FkParentProductId).HasColumnName("FK_PARENT_PRODUCT_ID");
            entity.Property(e => e.FkChildProductId).HasColumnName("FK_CHILD_PRODUCT_ID");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.FkChildProduct).WithMany(p => p.BillOfMaterialFkChildProducts)
                .HasForeignKey(d => d.FkChildProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_OF_MATERIALS_PRODUCT1");

            entity.HasOne(d => d.FkParentProduct).WithMany(p => p.BillOfMaterialFkParentProducts)
                .HasForeignKey(d => d.FkParentProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BILL_OF_MATERIALS_PRODUCT");
        });

        modelBuilder.Entity<Block>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BLOCK__3214EC2740824FB2");

            entity.ToTable("BLOCK");

            entity.HasIndex(e => e.Description, "IX_BLOCK_1");

            entity.HasIndex(e => e.Message, "IX_BLOCK_2");

            entity.HasIndex(e => e.DateCreated, "IX_BLOCK_3");

            entity.HasIndex(e => e.DateModified, "IX_BLOCK_4");

            entity.HasIndex(e => e.CreatedBy, "IX_BLOCK_5");

            entity.HasIndex(e => e.ModifiedBy, "IX_BLOCK_6");

            entity.HasIndex(e => e.BlockCode, "UQ__BLOCK__7E38763A0E48006C").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BlockCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BLOCK_CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Message)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BlockCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__BLOCK__CREATED_B__0F824689");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.BlockModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__BLOCK__MODIFIED___116A8EFB");
        });

        modelBuilder.Entity<BlockCustomerMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BLOCK_CU__3214EC273FDD5236");

            entity.ToTable("BLOCK_CUSTOMER_MAP");

            entity.HasIndex(e => e.FkCustomerId, "IX_BLOCK_CUSTOMER_MAP_1");

            entity.HasIndex(e => e.FkCustomerAddressId, "IX_BLOCK_CUSTOMER_MAP_2");

            entity.HasIndex(e => e.FkBlockId, "IX_BLOCK_CUSTOMER_MAP_3");

            entity.HasIndex(e => e.DateCreated, "IX_BLOCK_CUSTOMER_MAP_4");

            entity.HasIndex(e => e.DateModified, "IX_BLOCK_CUSTOMER_MAP_5");

            entity.HasIndex(e => e.CreatedBy, "IX_BLOCK_CUSTOMER_MAP_6");

            entity.HasIndex(e => e.ModifiedBy, "IX_BLOCK_CUSTOMER_MAP_7");

            entity.HasIndex(e => e.Status, "IX_BLOCK_CUSTOMER_MAP_8");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkBlockId).HasColumnName("FK_BLOCK_ID");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BlockCustomerMapCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__BLOCK_CUS__CREAT__1352D76D");

            entity.HasOne(d => d.FkBlock).WithMany(p => p.BlockCustomerMaps)
                .HasForeignKey(d => d.FkBlockId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BLOCK_CUS__FK_BL__153B1FDF");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.BlockCustomerMaps)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .HasConstraintName("FK__BLOCK_CUS__FK_CU__17236851");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.BlockCustomerMaps)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__BLOCK_CUS__FK_CU__18178C8A");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.BlockCustomerMapModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__BLOCK_CUS__MODIF__1AF3F935");
        });

        modelBuilder.Entity<BptmDetail>(entity =>
        {
            entity.ToTable("BPTM_DETAILS");

            entity.HasIndex(e => e.FkBptmId, "IX_BPTM_DETAILS");

            entity.HasIndex(e => e.CreatedBy, "IX_BPTM_DETAILS_1");

            entity.HasIndex(e => e.ModifiedBy, "IX_BPTM_DETAILS_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkBptmId).HasColumnName("FK_BPTM_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.PricingTypeCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRICING_TYPE_CODE");
            entity.Property(e => e.PricingTypeName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRICING_TYPE_NAME");
            entity.Property(e => e.Value).HasColumnName("VALUE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BptmDetailCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BPTM_DETAILS_USER");

            entity.HasOne(d => d.FkBptm).WithMany(p => p.BptmDetails)
                .HasForeignKey(d => d.FkBptmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BPTM_DETAILS_BRANCH_PRODUCT_TEMPLATE_MAP");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.BptmDetailModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_BPTM_DETAILS_USER1");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.ToTable("BRANCH");

            entity.HasIndex(e => e.FkRegionId, "IX_BRANCH");

            entity.HasIndex(e => e.CreatedBy, "IX_BRANCH_1");

            entity.HasIndex(e => e.ModifiedBy, "IX_BRANCH_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BranchCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BRANCH_CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkRegionId).HasColumnName("FK_REGION_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.WeatherStation)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("WEATHER_STATION");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BranchCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRANCH_USER");

            entity.HasOne(d => d.FkRegion).WithMany(p => p.Branches)
                .HasForeignKey(d => d.FkRegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRANCH_REGION");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.BranchModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_BRANCH_USER1");
        });

        modelBuilder.Entity<BranchProductTemplateMap>(entity =>
        {
            entity.ToTable("BRANCH_PRODUCT_TEMPLATE_MAP");

            entity.HasIndex(e => e.FkBranchId, "IX_BRANCH_PRODUCT_TEMPLATE_MAP");

            entity.HasIndex(e => e.FkProductId, "IX_BRANCH_PRODUCT_TEMPLATE_MAP_1");

            entity.HasIndex(e => e.FkPricingTemplateId, "IX_BRANCH_PRODUCT_TEMPLATE_MAP_2");

            entity.HasIndex(e => e.CreatedBy, "IX_BRANCH_PRODUCT_TEMPLATE_MAP_3");

            entity.HasIndex(e => e.ModifiedBy, "IX_BRANCH_PRODUCT_TEMPLATE_MAP_4");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.FkBranchId).HasColumnName("FK_BRANCH_ID");
            entity.Property(e => e.FkPricingTemplateId).HasColumnName("FK_PRICING_TEMPLATE_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.LandingCost).HasColumnName("LANDING_COST");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.PriceModel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_MODEL");
            entity.Property(e => e.PriceName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRICE_NAME");
            entity.Property(e => e.PriceType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_TYPE");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.BranchProductTemplateMapCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRANCH_PRODUCT_TEMPLATE_MAP_USER");

            entity.HasOne(d => d.FkBranch).WithMany(p => p.BranchProductTemplateMaps)
                .HasForeignKey(d => d.FkBranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRANCH_PRODUCT_TEMPLATE_MAP_BRANCH");

            entity.HasOne(d => d.FkPricingTemplate).WithMany(p => p.BranchProductTemplateMaps)
                .HasForeignKey(d => d.FkPricingTemplateId)
                .HasConstraintName("FK_BRANCH_PRODUCT_TEMPLATE_MAP_PRICING_TEMPLATE");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.BranchProductTemplateMaps)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRANCH_PRODUCT_TEMPLATE_MAP_PRODUCT");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.BranchProductTemplateMapModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_BRANCH_PRODUCT_TEMPLATE_MAP_USER1");
        });

        modelBuilder.Entity<BranchUserMap>(entity =>
        {
            entity.HasKey(e => new { e.FkBranchId, e.FkUserId });

            entity.ToTable("BRANCH_USER_MAP");

            entity.HasIndex(e => e.FkBranchId, "IX_BRANCH_USER_MAP");

            entity.HasIndex(e => e.FkUserId, "IX_BRANCH_USER_MAP_1");

            entity.HasIndex(e => e.CreatedBy, "IX_BRANCH_USER_MAP_2");

            entity.Property(e => e.FkBranchId).HasColumnName("FK_BRANCH_ID");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");

            entity.HasOne(d => d.FkBranch).WithMany(p => p.BranchUserMaps)
                .HasForeignKey(d => d.FkBranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRANCH_USER_MAP_BRANCH");

            entity.HasOne(d => d.FkUser).WithMany(p => p.BranchUserMaps)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BRANCH_USER_MAP_USER");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.ToTable("BRAND");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<CaAttributesHistory>(entity =>
        {
            entity.ToTable("CA_ATTRIBUTES_HISTORY");

            entity.HasIndex(e => e.FkCustomerAddressAttributesId, "IX_CA_ATTRIBUTES_HISTORY");

            entity.HasIndex(e => e.DateCreated, "IX_CA_ATTRIBUTES_HISTORY_1");

            entity.HasIndex(e => e.CreatedBy, "IX_CA_ATTRIBUTES_HISTORY_2");

            entity.HasIndex(e => e.CurrentVolume, "IX_CA_ATTRIBUTES_HISTORY_3");

            entity.HasIndex(e => e.DueDate, "IX_CA_ATTRIBUTES_HISTORY_4");

            entity.HasIndex(e => e.KFactor, "IX_CA_ATTRIBUTES_HISTORY_5");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CurrentVolume).HasColumnName("CURRENT_VOLUME");
            entity.Property(e => e.CurrentVolumePercentage)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("CURRENT_VOLUME_PERCENTAGE");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DueDate).HasColumnName("DUE_DATE");
            entity.Property(e => e.FkCustomerAddressAttributesId).HasColumnName("FK_CUSTOMER_ADDRESS_ATTRIBUTES_ID");
            entity.Property(e => e.KFactor)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("K_FACTOR");
            entity.Property(e => e.LastReadDate).HasColumnName("LAST_READ_DATE");
            entity.Property(e => e.LegacyHold)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("LEGACY_HOLD");
            entity.Property(e => e.Module)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.PoNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PO_NUMBER");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CaAttributesHistories)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CA_ATTRIBUTES_HISTORY_USER");

            entity.HasOne(d => d.FkCustomerAddressAttributes).WithMany(p => p.CaAttributesHistories)
                .HasForeignKey(d => d.FkCustomerAddressAttributesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CA_ATTRIBUTES_HISTORY_CUSTOMER_ADDRESS_ATTRIBUTES");
        });

        modelBuilder.Entity<CaAttributesProjection>(entity =>
        {
            entity.ToTable("CA_ATTRIBUTES_PROJECTION");

            entity.HasIndex(e => e.FkCustomerAddressAttributesId, "IX_CA_ATTRIBUTES_PROJECTION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkCustomerAddressAttributesId).HasColumnName("FK_CUSTOMER_ADDRESS_ATTRIBUTES_ID");

            entity.HasOne(d => d.FkCustomerAddressAttributes).WithMany(p => p.CaAttributesProjections)
                .HasForeignKey(d => d.FkCustomerAddressAttributesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CA_ATTRIBUTES_PROJECTION_CUSTOMER_ADDRESS_ATTRIBUTES");
        });

        modelBuilder.Entity<CappmmHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAPPMM_H__3214EC2791DF4506");

            entity.ToTable("CAPPMM_HISTORY");

            entity.HasIndex(e => e.ReferenceCappmmId, "IX_CAPPMM_HISTORY");

            entity.HasIndex(e => e.PriceModel, "IX_CAPPMM_HISTORY_1");

            entity.HasIndex(e => e.Id, "IX_CAPPMM_HISTORY_10");

            entity.HasIndex(e => e.CreatedBy, "IX_CAPPMM_HISTORY_11");

            entity.HasIndex(e => e.DateCreated, "IX_CAPPMM_HISTORY_12");

            entity.HasIndex(e => e.Type, "IX_CAPPMM_HISTORY_2");

            entity.HasIndex(e => e.Value, "IX_CAPPMM_HISTORY_3");

            entity.HasIndex(e => e.Variance, "IX_CAPPMM_HISTORY_4");

            entity.HasIndex(e => e.ContractId, "IX_CAPPMM_HISTORY_5");

            entity.HasIndex(e => e.ContractStartDate, "IX_CAPPMM_HISTORY_6");

            entity.HasIndex(e => e.ContractEndDate, "IX_CAPPMM_HISTORY_7");

            entity.HasIndex(e => e.ContractLimitType, "IX_CAPPMM_HISTORY_8");

            entity.HasIndex(e => e.ContractLimitAmount, "IX_CAPPMM_HISTORY_9");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.ContractEndDate).HasColumnName("CONTRACT_END_DATE");
            entity.Property(e => e.ContractId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CONTRACT_ID");
            entity.Property(e => e.ContractLimitAmount).HasColumnName("CONTRACT_LIMIT_AMOUNT");
            entity.Property(e => e.ContractLimitType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CONTRACT_LIMIT_TYPE");
            entity.Property(e => e.ContractStartDate).HasColumnName("CONTRACT_START_DATE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateApplicable).HasColumnName("DATE_APPLICABLE");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.NcpDateApplicable)
                .HasColumnType("datetime")
                .HasColumnName("NCP_DATE_APPLICABLE");
            entity.Property(e => e.PriceModel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_MODEL");
            entity.Property(e => e.PriceSource)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_SOURCE");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REASON");
            entity.Property(e => e.ReferenceCappmmId).HasColumnName("REFERENCE_CAPPMM_ID");
            entity.Property(e => e.RppmReferenceId).HasColumnName("RPPM_REFERENCE_ID");
            entity.Property(e => e.RpppmmReferenceId).HasColumnName("RPPPMM_REFERENCE_ID");
            entity.Property(e => e.RppzcmReferenceId).HasColumnName("RPPZCM_REFERENCE_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Value).HasColumnName("VALUE");
            entity.Property(e => e.Variance)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VARIANCE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CappmmHistories)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CAPPMM_HI__CREAT__2FEF161B");
        });

        modelBuilder.Entity<CaptmDetail>(entity =>
        {
            entity.ToTable("CAPTM_DETAILS");

            entity.HasIndex(e => e.FkCaptmId, "IX_CAPTM_DETAILS");

            entity.HasIndex(e => e.CreatedBy, "IX_CAPTM_DETAILS_1");

            entity.HasIndex(e => e.ModifiedBy, "IX_CAPTM_DETAILS_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkCaptmId).HasColumnName("FK_CAPTM_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.PricingTypeCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRICING_TYPE_CODE");
            entity.Property(e => e.PricingTypeName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRICING_TYPE_NAME");
            entity.Property(e => e.Value).HasColumnName("VALUE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CaptmDetailCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAPTM_DETAILS_USER");

            entity.HasOne(d => d.FkCaptm).WithMany(p => p.CaptmDetails)
                .HasForeignKey(d => d.FkCaptmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAPTM_DETAILS_CUSTOMER_ADDRESS_PRODUCT_TEMPLATE_MAP");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.CaptmDetailModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_CAPTM_DETAILS_USER1");
        });

        modelBuilder.Entity<Cart>(entity =>
        {
            entity.HasKey(e => new { e.FkUserId, e.FkCustomerId });

            entity.ToTable("CART");

            entity.HasIndex(e => e.FkUserId, "IX_CART");

            entity.HasIndex(e => e.FkCustomerId, "IX_CART_1");

            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.Carts)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CART__FK_CUSTOME__17C286CF");

            entity.HasOne(d => d.FkUser).WithMany(p => p.Carts)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CART__FK_USER_ID__2BFE89A6");
        });

        modelBuilder.Entity<CartDetail>(entity =>
        {
            entity.HasKey(e => new { e.FkUserId, e.FkCustomerId, e.FkProductId, e.VarianceId });

            entity.ToTable("CART_DETAILS");

            entity.HasIndex(e => new { e.FkUserId, e.FkCustomerId }, "IX_CART_DETAILS");

            entity.HasIndex(e => e.FkProductId, "IX_CART_DETAILS_1");

            entity.HasIndex(e => e.FkUserId, "IX_CART_DETAILS_2");

            entity.HasIndex(e => e.FkCustomerId, "IX_CART_DETAILS_3");

            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.VarianceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VARIANCE_ID");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");

            entity.HasOne(d => d.Cart).WithMany(p => p.CartDetails)
                .HasForeignKey(d => new { d.FkUserId, d.FkCustomerId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CART_DETAILS__3493CFA7");

            entity.HasOne(d => d.CustomerProductVarianceMap).WithMany(p => p.CartDetails)
                .HasForeignKey(d => new { d.VarianceId, d.FkProductId, d.FkCustomerId })
                .HasConstraintName("FK__CART_DETA__FK_PR__2CF2ADDF");
        });

        modelBuilder.Entity<CartDetailsAddOn>(entity =>
        {
            entity.ToTable("CART_DETAILS_ADD_ON");

            entity.HasIndex(e => e.CdFkUserId, "IX_CART_DETAILS_ADD_ON");

            entity.HasIndex(e => e.CdFkCustomerId, "IX_CART_DETAILS_ADD_ON_1");

            entity.HasIndex(e => e.CdFkProductId, "IX_CART_DETAILS_ADD_ON_2");

            entity.HasIndex(e => e.CdFkVarianceId, "IX_CART_DETAILS_ADD_ON_3");

            entity.HasIndex(e => e.FkProductId, "IX_CART_DETAILS_ADD_ON_4");

            entity.HasIndex(e => e.FkVarianceId, "IX_CART_DETAILS_ADD_ON_5");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CdFkCustomerId).HasColumnName("CD_FK_CUSTOMER_ID");
            entity.Property(e => e.CdFkProductId).HasColumnName("CD_FK_PRODUCT_ID");
            entity.Property(e => e.CdFkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CD_FK_USER_ID");
            entity.Property(e => e.CdFkVarianceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CD_FK_VARIANCE_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkVarianceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FK_VARIANCE_ID");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.CartDetailsAddOns)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CART_DETAILS_ADD_ON_PRODUCT");

            entity.HasOne(d => d.ProductVariance).WithMany(p => p.CartDetailsAddOns)
                .HasForeignKey(d => new { d.FkVarianceId, d.FkProductId })
                .HasConstraintName("FK_CART_DETAILS_ADD_ON_PRODUCT_VARIANCE");

            entity.HasOne(d => d.CartDetail).WithMany(p => p.CartDetailsAddOns)
                .HasForeignKey(d => new { d.CdFkUserId, d.CdFkCustomerId, d.CdFkProductId, d.CdFkVarianceId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CART_DETAILS_ADD_ON_CART_DETAILS");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("CATEGORY");

            entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<CategoryLevel>(entity =>
        {
            entity.ToTable("CATEGORY_LEVEL");

            entity.Property(e => e.CategoryLevelId)
                .ValueGeneratedNever()
                .HasColumnName("CATEGORY_LEVEL_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<ClientContact>(entity =>
        {
            entity.ToTable("CLIENT_CONTACT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIRST_NAME");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MIDDLE_NAME");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<ClientGroup>(entity =>
        {
            entity.ToTable("CLIENT_GROUP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<CodeSequence>(entity =>
        {
            entity.ToTable("CODE_SEQUENCE");

            entity.HasIndex(e => e.Code, "IX_CODE_SEQUENCE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Prefix)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PREFIX");
            entity.Property(e => e.Value).HasColumnName("VALUE");
        });

        modelBuilder.Entity<ContentAsset>(entity =>
        {
            entity.ToTable("CONTENT_ASSET");

            entity.HasIndex(e => e.ContentType, "IX_CONTENT_ASSET").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContentType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTENT_TYPE");
            entity.Property(e => e.DataType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATA_TYPE");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Filename)
                .IsUnicode(false)
                .HasColumnName("FILENAME");
            entity.Property(e => e.HtmlContentUrl)
                .IsUnicode(false)
                .HasColumnName("HTML_CONTENT_URL");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TITLE");
        });

        modelBuilder.Entity<CueProduct>(entity =>
        {
            entity.ToTable("CUE_PRODUCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<CustSequenceRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUST_SEQ__3214EC27A2A5748B");

            entity.ToTable("CUST_SEQUENCE_RECORD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Prefix)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PREFIX");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("CUSTOMER");

            entity.HasIndex(e => e.FkTimezoneId, "IX_CUSTOMER");

            entity.HasIndex(e => e.FkPriceListCode, "IX_CUSTOMER_1");

            entity.HasIndex(e => e.PriceClass, "IX_CUSTOMER_10");

            entity.HasIndex(e => e.TaxCategory, "IX_CUSTOMER_11");

            entity.HasIndex(e => e.Province, "IX_CUSTOMER_12");

            entity.HasIndex(e => e.RebateCode, "IX_CUSTOMER_13");

            entity.HasIndex(e => e.FkSubscriptionId, "IX_CUSTOMER_14");

            entity.HasIndex(e => e.InvoiceMailIntegration, "IX_CUSTOMER_15");

            entity.HasIndex(e => e.CurrentBalance, "IX_CUSTOMER_16");

            entity.HasIndex(e => e.CueId, "IX_CUSTOMER_2").IsUnique();

            entity.HasIndex(e => e.CreatedBy, "IX_CUSTOMER_3");

            entity.HasIndex(e => e.ModifiedBy, "IX_CUSTOMER_4");

            entity.HasIndex(e => e.FkBranchId, "IX_CUSTOMER_5");

            entity.HasIndex(e => e.LegacyId, "IX_CUSTOMER_7");

            entity.HasIndex(e => e.RegionId, "IX_CUSTOMER_8");

            entity.HasIndex(e => e.PriceZone, "IX_CUSTOMER_9");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountCreditStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_CREDIT_STATUS");
            entity.Property(e => e.AccountType)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_TYPE");
            entity.Property(e => e.AcquisitionCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("ACQUISITION_CODE");
            entity.Property(e => e.BillingCycle)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BILLING_CYCLE");
            entity.Property(e => e.BillingSchedule)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BILLING_SCHEDULE");
            entity.Property(e => e.BillingSetup)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BILLING_SETUP");
            entity.Property(e => e.BudgetPlan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BUDGET_PLAN");
            entity.Property(e => e.BusinessEntity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BUSINESS_ENTITY");
            entity.Property(e => e.Classification)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLASSIFICATION");
            entity.Property(e => e.ClientGroupType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLIENT_GROUP_TYPE");
            entity.Property(e => e.CollectorId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COLLECTOR_ID");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTACT_NUMBER");
            entity.Property(e => e.ContractEnd)
                .HasColumnType("datetime")
                .HasColumnName("CONTRACT_END");
            entity.Property(e => e.ContractPrice)
                .HasColumnType("decimal(13, 4)")
                .HasColumnName("CONTRACT_PRICE");
            entity.Property(e => e.ContractRemainingAmt)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("CONTRACT_REMAINING_AMT");
            entity.Property(e => e.ContractRemainingVol)
                .HasColumnType("decimal(13, 1)")
                .HasColumnName("CONTRACT_REMAINING_VOL");
            entity.Property(e => e.ContractStart)
                .HasColumnType("datetime")
                .HasColumnName("CONTRACT_START");
            entity.Property(e => e.ContractType).HasColumnName("CONTRACT_TYPE");
            entity.Property(e => e.Corp)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CORP");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreditCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CREDIT_CODE");
            entity.Property(e => e.CreditLimit).HasColumnName("CREDIT_LIMIT");
            entity.Property(e => e.CueId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUE_ID");
            entity.Property(e => e.CurrentBalance).HasColumnName("CURRENT_BALANCE");
            entity.Property(e => e.CustomerSource)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_SOURCE");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("DATE_OF_BIRTH");
            entity.Property(e => e.Duns)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DUNS");
            entity.Property(e => e.FirstLevelDiscount)
                .HasColumnType("decimal(13, 4)")
                .HasColumnName("FIRST_LEVEL_DISCOUNT");
            entity.Property(e => e.FirstVolumeDiscount)
                .HasColumnType("decimal(13, 1)")
                .HasColumnName("FIRST_VOLUME_DISCOUNT");
            entity.Property(e => e.FkBranchId).HasColumnName("FK_BRANCH_ID");
            entity.Property(e => e.FkPriceListCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_PRICE_LIST_CODE");
            entity.Property(e => e.FkSubscriptionId).HasColumnName("FK_SUBSCRIPTION_ID");
            entity.Property(e => e.FkTimezoneId).HasColumnName("FK_TIMEZONE_ID");
            entity.Property(e => e.Gn)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GN");
            entity.Property(e => e.HasEmailTemplate).HasColumnName("HAS_EMAIL_TEMPLATE");
            entity.Property(e => e.HasTwilio).HasColumnName("HAS_TWILIO");
            entity.Property(e => e.InvoiceMailIntegration)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INVOICE_MAIL_INTEGRATION");
            entity.Property(e => e.IsForCreditAuthorization).HasColumnName("IS_FOR_CREDIT_AUTHORIZATION");
            entity.Property(e => e.IsLead).HasColumnName("IS_LEAD");
            entity.Property(e => e.IsPriced).HasColumnName("IS_PRICED");
            entity.Property(e => e.IsPublic).HasColumnName("IS_PUBLIC");
            entity.Property(e => e.IsTaxExempted).HasColumnName("IS_TAX_EXEMPTED");
            entity.Property(e => e.Language)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LANGUAGE");
            entity.Property(e => e.LegacyClassification)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_CLASSIFICATION");
            entity.Property(e => e.LegacyCollectorId)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("LEGACY_COLLECTOR_ID");
            entity.Property(e => e.LegacyCollectorName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_COLLECTOR_NAME");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ID");
            entity.Property(e => e.LegacySalesRepId)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("LEGACY_SALES_REP_ID");
            entity.Property(e => e.LegacySalesRepName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_SALES_REP_NAME");
            entity.Property(e => e.MinOrderValue).HasColumnName("MIN_ORDER_VALUE");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NatureOfBusiness)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NATURE_OF_BUSINESS");
            entity.Property(e => e.OrderType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORDER_TYPE");
            entity.Property(e => e.PaymentTermId).HasColumnName("PAYMENT_TERM_ID");
            entity.Property(e => e.PaymentTerms)
                .HasMaxLength(50)
                .HasColumnName("PAYMENT_TERMS");
            entity.Property(e => e.PoNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PO_NUMBER");
            entity.Property(e => e.PrevBalance)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("PREV_BALANCE");
            entity.Property(e => e.PriceClass)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PRICE_CLASS");
            entity.Property(e => e.PriceZone)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("PRICE_ZONE");
            entity.Property(e => e.PricingCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICING_CODE");
            entity.Property(e => e.PricingMethod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PRICING_METHOD");
            entity.Property(e => e.PromptPayDays).HasColumnName("PROMPT_PAY_DAYS");
            entity.Property(e => e.PromptPayDiscount)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("PROMPT_PAY_DISCOUNT");
            entity.Property(e => e.PromptPayDiscountType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PROMPT_PAY_DISCOUNT_TYPE");
            entity.Property(e => e.Province)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PROVINCE");
            entity.Property(e => e.Rank).HasColumnName("RANK");
            entity.Property(e => e.RebateCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REBATE_CODE");
            entity.Property(e => e.RegionId).HasColumnName("REGION_ID");
            entity.Property(e => e.Regional)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGIONAL");
            entity.Property(e => e.RemittanceCopyToPrint).HasColumnName("REMITTANCE_COPY_TO_PRINT");
            entity.Property(e => e.SalesRepId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SALES_REP_ID");
            entity.Property(e => e.StatementType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STATEMENT_TYPE");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.SyncRemarks)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SYNC_REMARKS");
            entity.Property(e => e.SyncStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SYNC_STATUS");
            entity.Property(e => e.TaxCategory)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TAX_CATEGORY");
            entity.Property(e => e.TaxGroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAX_GROUP");
            entity.Property(e => e.TicketCopyToPrint).HasColumnName("TICKET_COPY_TO_PRINT");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
            entity.Property(e => e.TpiAccount)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TPI_ACCOUNT");
            entity.Property(e => e.Type)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Volume)
                .HasColumnType("decimal(13, 1)")
                .HasColumnName("VOLUME");
            entity.Property(e => e.YearsOfOperation).HasColumnName("YEARS_OF_OPERATION");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CustomerCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_USER_CUSTOMER_1");

            entity.HasOne(d => d.FkBranch).WithMany(p => p.Customers)
                .HasForeignKey(d => d.FkBranchId)
                .HasConstraintName("FK_BRANCH_CUSTOMER");

            entity.HasOne(d => d.FkSubscription).WithMany(p => p.Customers)
                .HasForeignKey(d => d.FkSubscriptionId)
                .HasConstraintName("FK_SUBSCRIPTION_CUSTOMER");

            entity.HasOne(d => d.FkTimezone).WithMany(p => p.Customers)
                .HasForeignKey(d => d.FkTimezoneId)
                .HasConstraintName("FK_CUSTOMER_TIMEZONE");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.CustomerModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_USER_CUSTOMER_2");

            entity.HasMany(d => d.FkClientGroups).WithMany(p => p.FkCustomers)
                .UsingEntity<Dictionary<string, object>>(
                    "CustomerClientGroupMap",
                    r => r.HasOne<ClientGroup>().WithMany()
                        .HasForeignKey("FkClientGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CUSTOMER_CLIENT_GROUP_MAP_CLIENT_GROUP"),
                    l => l.HasOne<Customer>().WithMany()
                        .HasForeignKey("FkCustomerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CUSTOMER_CLIENT_GROUP_MAP_CUSTOMER"),
                    j =>
                    {
                        j.HasKey("FkCustomerId", "FkClientGroupId");
                        j.ToTable("CUSTOMER_CLIENT_GROUP_MAP");
                        j.HasIndex(new[] { "FkCustomerId" }, "IX_CUSTOMER_CLIENT_GROUP_MAP");
                        j.HasIndex(new[] { "FkClientGroupId" }, "IX_CUSTOMER_CLIENT_GROUP_MAP_1");
                        j.IndexerProperty<int>("FkCustomerId").HasColumnName("FK_CUSTOMER_ID");
                        j.IndexerProperty<int>("FkClientGroupId").HasColumnName("FK_CLIENT_GROUP_ID");
                    });

            entity.HasMany(d => d.FkCustomerTypes).WithMany(p => p.FkCustomers)
                .UsingEntity<Dictionary<string, object>>(
                    "CustomerCustomerTypeMap",
                    r => r.HasOne<CustomerType>().WithMany()
                        .HasForeignKey("FkCustomerTypeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CUSTOMER_CUSTOMER_TYPE_MAP_CUSTOMER_TYPE"),
                    l => l.HasOne<Customer>().WithMany()
                        .HasForeignKey("FkCustomerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CUSTOMER_CUSTOMER_TYPE_MAP_CUSTOMER"),
                    j =>
                    {
                        j.HasKey("FkCustomerId", "FkCustomerTypeId");
                        j.ToTable("CUSTOMER_CUSTOMER_TYPE_MAP");
                        j.HasIndex(new[] { "FkCustomerId" }, "IX_CUSTOMER_CUSTOMER_TYPE_MAP");
                        j.HasIndex(new[] { "FkCustomerTypeId" }, "IX_CUSTOMER_CUSTOMER_TYPE_MAP_1");
                        j.IndexerProperty<int>("FkCustomerId").HasColumnName("FK_CUSTOMER_ID");
                        j.IndexerProperty<int>("FkCustomerTypeId").HasColumnName("FK_CUSTOMER_TYPE_ID");
                    });
        });

        modelBuilder.Entity<CustomerAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(80);

            entity.ToTable("CUSTOMER_ADDRESS");

            entity.HasIndex(e => e.FkCustomerId, "IX_CUSTOMER_ADDRESS").HasFillFactor(80);

            entity.HasIndex(e => e.IsPrimary, "IX_CUSTOMER_ADDRESS_1").HasFillFactor(80);

            entity.HasIndex(e => e.IsServiceLocation, "IX_CUSTOMER_ADDRESS_10");

            entity.HasIndex(e => e.Street2, "IX_CUSTOMER_ADDRESS_11");

            entity.HasIndex(e => e.Street3, "IX_CUSTOMER_ADDRESS_12");

            entity.HasIndex(e => new { e.Id, e.FkCustomerId }, "IX_CUSTOMER_ADDRESS_2").IsUnique();

            entity.HasIndex(e => e.CreatedBy, "IX_CUSTOMER_ADDRESS_4");

            entity.HasIndex(e => e.ModifiedBy, "IX_CUSTOMER_ADDRESS_5");

            entity.HasIndex(e => e.ShipToCode, "IX_CUSTOMER_ADDRESS_6");

            entity.HasIndex(e => e.OplynxLocationId, "IX_CUSTOMER_ADDRESS_7");

            entity.HasIndex(e => e.TaxCategory, "IX_CUSTOMER_ADDRESS_8");

            entity.HasIndex(e => e.RebateCode, "IX_CUSTOMER_ADDRESS_9");

            entity.HasIndex(e => e.LegacyId, "IX_CUSTOMER_ADDRESS_GROUP_MAP_3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AlternateNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALTERNATE_NUMBER");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.Comment1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT1");
            entity.Property(e => e.Comment10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT10");
            entity.Property(e => e.Comment11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT11");
            entity.Property(e => e.Comment12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT12");
            entity.Property(e => e.Comment13)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT13");
            entity.Property(e => e.Comment14)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT14");
            entity.Property(e => e.Comment15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT15");
            entity.Property(e => e.Comment16)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT16");
            entity.Property(e => e.Comment17)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT17");
            entity.Property(e => e.Comment18)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT18");
            entity.Property(e => e.Comment19)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT19");
            entity.Property(e => e.Comment2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT2");
            entity.Property(e => e.Comment20)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT20");
            entity.Property(e => e.Comment3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT3");
            entity.Property(e => e.Comment4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT4");
            entity.Property(e => e.Comment5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT5");
            entity.Property(e => e.Comment6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT6");
            entity.Property(e => e.Comment7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT7");
            entity.Property(e => e.Comment8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT8");
            entity.Property(e => e.Comment9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENT9");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CONTACT_PERSON");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CountryCodeAlpha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_CODE_ALPHA");
            entity.Property(e => e.CountryCodeDigit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_CODE_DIGIT");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CustomerAddressCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ADDRESS_CODE");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DeliveryMethod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_METHOD");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.IntlContactEmail)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("INTL_CONTACT_EMAIL");
            entity.Property(e => e.IntlContactName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("INTL_CONTACT_NAME");
            entity.Property(e => e.IntlContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INTL_CONTACT_NUMBER");
            entity.Property(e => e.IsPrimary).HasColumnName("IS_PRIMARY");
            entity.Property(e => e.IsServiceLocation).HasColumnName("IS_SERVICE_LOCATION");
            entity.Property(e => e.KFactor).HasColumnName("K_FACTOR");
            entity.Property(e => e.Latitude).HasColumnName("LATITUDE");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ID");
            entity.Property(e => e.LegacyPriceClass)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LEGACY_PRICE_CLASS");
            entity.Property(e => e.LegacyTaxcat)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LEGACY_TAXCAT");
            entity.Property(e => e.LegacyTradeClass)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LEGACY_TRADE_CLASS");
            entity.Property(e => e.LlType).HasColumnName("LL_TYPE");
            entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");
            entity.Property(e => e.MapCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MAP_CODE");
            entity.Property(e => e.MaxLatitude).HasColumnName("MAX_LATITUDE");
            entity.Property(e => e.MaxLongitude).HasColumnName("MAX_LONGITUDE");
            entity.Property(e => e.MinLatitude).HasColumnName("MIN_LATITUDE");
            entity.Property(e => e.MinLongitude).HasColumnName("MIN_LONGITUDE");
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MOBILE_NUMBER");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Notes).HasColumnName("NOTES");
            entity.Property(e => e.OplynxLocationId).HasColumnName("OPLYNX_LOCATION_ID");
            entity.Property(e => e.RebateCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REBATE_CODE");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REGION");
            entity.Property(e => e.ShipToCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_CODE");
            entity.Property(e => e.ShippingAccountLegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIPPING_ACCOUNT_LEGACY_ID");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATE");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Street)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("STREET");
            entity.Property(e => e.Street2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STREET2");
            entity.Property(e => e.Street3)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("STREET3");
            entity.Property(e => e.TaxCategory)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TAX_CATEGORY");
            entity.Property(e => e.TaxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAX_ID");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZIPCODE");
            entity.Property(e => e.Zone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZONE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CustomerAddressCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_USER_CUSTOMER_ADDRESS_1");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.CustomerAddresses)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_CUSTOMER");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.CustomerAddressModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_USER_CUSTOMER_ADDRESS_2");
        });

        modelBuilder.Entity<CustomerAddressAccountServiceMap>(entity =>
        {
            entity.HasKey(e => new { e.FkAccountId, e.FkCustomerAddressId, e.FkCustomerId, e.FkServiceId });

            entity.ToTable("CUSTOMER_ADDRESS_ACCOUNT_SERVICE_MAP");

            entity.HasIndex(e => e.FkAccountId, "IX_CUSTOMER_ADDRESS_ACCOUNT_SERVICE_MAP");

            entity.HasIndex(e => e.FkCustomerAddressId, "IX_CUSTOMER_ADDRESS_ACCOUNT_SERVICE_MAP_1");

            entity.HasIndex(e => e.FkCustomerId, "IX_CUSTOMER_ADDRESS_ACCOUNT_SERVICE_MAP_2");

            entity.HasIndex(e => e.FkServiceId, "IX_CUSTOMER_ADDRESS_ACCOUNT_SERVICE_MAP_3");

            entity.Property(e => e.FkAccountId).HasColumnName("FK_ACCOUNT_ID");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkServiceId).HasColumnName("FK_SERVICE_ID");

            entity.HasOne(d => d.AccountCustomerAddressMap).WithMany(p => p.CustomerAddressAccountServiceMaps)
                .HasForeignKey(d => new { d.FkAccountId, d.FkCustomerAddressId, d.FkCustomerId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_ACCOUNT_SERVICE_MAP_ACCOUNT_CUSTOMER_ADDRESS_MAP");

            entity.HasOne(d => d.AccountServiceMap).WithMany(p => p.CustomerAddressAccountServiceMaps)
                .HasForeignKey(d => new { d.FkAccountId, d.FkServiceId, d.FkCustomerId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_ACCOUNT_SERVICE_MAP_ACCOUNT_SERVICE_MAP");
        });

        modelBuilder.Entity<CustomerAddressAccountUserMap>(entity =>
        {
            entity.HasKey(e => new { e.FkAccountId, e.FkCustomerAddressId, e.FkCustomerId, e.FkUserId });

            entity.ToTable("CUSTOMER_ADDRESS_ACCOUNT_USER_MAP");

            entity.HasIndex(e => e.FkAccountId, "IX_CUSTOMER_ADDRESS_ACCOUNT_USER_MAP");

            entity.HasIndex(e => e.FkCustomerAddressId, "IX_CUSTOMER_ADDRESS_ACCOUNT_USER_MAP_1");

            entity.HasIndex(e => e.FkCustomerId, "IX_CUSTOMER_ADDRESS_ACCOUNT_USER_MAP_2");

            entity.HasIndex(e => e.FkUserId, "IX_CUSTOMER_ADDRESS_ACCOUNT_USER_MAP_3");

            entity.Property(e => e.FkAccountId).HasColumnName("FK_ACCOUNT_ID");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");

            entity.HasOne(d => d.AccountCustomerAddressMap).WithMany(p => p.CustomerAddressAccountUserMaps)
                .HasForeignKey(d => new { d.FkAccountId, d.FkCustomerAddressId, d.FkCustomerId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_ACCOUNT_USER_MAP_ACCOUNT_CUSTOMER_ADDRESS_MAP");

            entity.HasOne(d => d.AccountUserMap).WithMany(p => p.CustomerAddressAccountUserMaps)
                .HasForeignKey(d => new { d.FkAccountId, d.FkUserId, d.FkCustomerId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_ACCOUNT_USER_MAP_ACCOUNT_USER_MAP");
        });

        modelBuilder.Entity<CustomerAddressAttribute>(entity =>
        {
            entity.ToTable("CUSTOMER_ADDRESS_ATTRIBUTES");

            entity.HasIndex(e => e.FkCustomerAddressId, "IX_CUSTOMER_ADDRESS_ATTRIBUTES");

            entity.HasIndex(e => e.CreatedBy, "IX_CUSTOMER_ADDRESS_ATTRIBUTES_1");

            entity.HasIndex(e => e.ModifiedBy, "IX_CUSTOMER_ADDRESS_ATTRIBUTES_2");

            entity.HasIndex(e => e.FkProductId, "IX_CUSTOMER_ADDRESS_ATTRIBUTES_4");

            entity.HasIndex(e => e.CurrentVolume, "IX_CUSTOMER_ADDRESS_ATTRIBUTES_5");

            entity.HasIndex(e => e.TankSize, "IX_CUSTOMER_ADDRESS_ATTRIBUTES_6");

            entity.HasIndex(e => e.FkFillLocationId, "IX_CUSTOMER_ADDRESS_ATTRIBUTES_7");

            entity.HasIndex(e => e.AssetSerialNumber, "IX_CUSTOMER_ADDRESS_ATTRIBUTE_3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssetSerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ASSET_SERIAL_NUMBER");
            entity.Property(e => e.Category)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CurrentVolume).HasColumnName("CURRENT_VOLUME");
            entity.Property(e => e.CurrentVolumePercentage)
                .HasColumnType("decimal(7, 4)")
                .HasColumnName("CURRENT_VOLUME_PERCENTAGE");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateInstalled)
                .HasColumnType("datetime")
                .HasColumnName("DATE_INSTALLED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DateOfManufacture)
                .HasColumnType("datetime")
                .HasColumnName("DATE_OF_MANUFACTURE");
            entity.Property(e => e.DeliveryCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_CODE");
            entity.Property(e => e.DeliveryThreshold).HasColumnName("DELIVERY_THRESHOLD");
            entity.Property(e => e.DueDate).HasColumnName("DUE_DATE");
            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkFillLocationId).HasColumnName("FK_FILL_LOCATION_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.Flags)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("FLAGS");
            entity.Property(e => e.ForecastingProjection)
                .HasMaxLength(50)
                .HasColumnName("FORECASTING_PROJECTION");
            entity.Property(e => e.IdealVolume)
                .HasMaxLength(50)
                .HasColumnName("IDEAL_VOLUME");
            entity.Property(e => e.IsParent).HasColumnName("IS_PARENT");
            entity.Property(e => e.IsRental).HasColumnName("IS_RENTAL");
            entity.Property(e => e.KFactor).HasColumnName("K_FACTOR");
            entity.Property(e => e.LastDeliverDate).HasColumnName("LAST_DELIVER_DATE");
            entity.Property(e => e.LastDeliveryVolume).HasColumnName("LAST_DELIVERY_VOLUME");
            entity.Property(e => e.LastReadDate).HasColumnName("LAST_READ_DATE");
            entity.Property(e => e.LegacyHold)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("LEGACY_HOLD");
            entity.Property(e => e.LegacyType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LEGACY_TYPE");
            entity.Property(e => e.LlType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LL_TYPE");
            entity.Property(e => e.LocationDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("LOCATION_DESCRIPTION");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NumTanks).HasColumnName("NUM_TANKS");
            entity.Property(e => e.Owner)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("OWNER");
            entity.Property(e => e.ParentId).HasColumnName("PARENT_ID");
            entity.Property(e => e.PoNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PO_NUMBER");
            entity.Property(e => e.PresetAmount).HasColumnName("PRESET_AMOUNT");
            entity.Property(e => e.PresetVolume).HasColumnName("PRESET_VOLUME");
            entity.Property(e => e.RemainingRentalInstallments).HasColumnName("REMAINING_RENTAL_INSTALLMENTS");
            entity.Property(e => e.RentalAmount).HasColumnName("RENTAL_AMOUNT");
            entity.Property(e => e.RentalFrequency)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RENTAL_FREQUENCY");
            entity.Property(e => e.ReserveCapacity).HasColumnName("RESERVE_CAPACITY");
            entity.Property(e => e.RunoutDate).HasColumnName("RUNOUT_DATE");
            entity.Property(e => e.ScheduleCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SCHEDULE_CODE");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.TankId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TANK_ID");
            entity.Property(e => e.TankMonitor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TANK_MONITOR");
            entity.Property(e => e.TankMonitorId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TANK_MONITOR_ID");
            entity.Property(e => e.TankSize).HasColumnName("TANK_SIZE");
            entity.Property(e => e.Threshold).HasColumnName("THRESHOLD");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Unit)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("UNIT");
            entity.Property(e => e.UsableCapacity).HasColumnName("USABLE_CAPACITY");
            entity.Property(e => e.VolAfterDlvry).HasColumnName("VOL_AFTER_DLVRY");

            entity.HasOne(d => d.AssetSerialNumberNavigation).WithMany(p => p.CustomerAddressAttributes)
                .HasPrincipalKey(p => p.SerialNumber)
                .HasForeignKey(d => d.AssetSerialNumber)
                .HasConstraintName("FK_ASSET_CUSTOMER_ADDRESS_ATTRIBUTES");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CustomerAddressAttributeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_USER_CUSTOMER_ADDRESS_ATTRIBUTES_1");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.CustomerAddressAttributes)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_ATTRIBUTES_CUSTOMER_ADDRESS");

            entity.HasOne(d => d.FkFillLocation).WithMany(p => p.CustomerAddressAttributes)
                .HasForeignKey(d => d.FkFillLocationId)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_ATTRIBUTES_FILL_LOCATION");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.CustomerAddressAttributes)
                .HasForeignKey(d => d.FkProductId)
                .HasConstraintName("FK_PRODUCT_CUSTOMER_ADDRESS_ATTRIBUTES");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.CustomerAddressAttributeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_USER_CUSTOMER_ADDRESS_ATTRIBUTES_2");
        });

        modelBuilder.Entity<CustomerAddressGroupMap>(entity =>
        {
            entity.HasKey(e => new { e.FkCustomerAddressId, e.FkGroupId });

            entity.ToTable("CUSTOMER_ADDRESS_GROUP_MAP");

            entity.HasIndex(e => e.FkCustomerAddressId, "IX_CUSTOMER_ADDRESS_GROUP_MAP");

            entity.HasIndex(e => e.FkGroupId, "IX_CUSTOMER_ADDRESS_GROUP_MAP_1");

            entity.HasIndex(e => e.LegacyId, "IX_CUSTOMER_ADDRESS_GROUP_MAP_2");

            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkGroupId).HasColumnName("FK_GROUP_ID");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ID");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.CustomerAddressGroupMaps)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_GROUP_MAP_CUSTOMER_ADDRESS");

            entity.HasOne(d => d.FkGroup).WithMany(p => p.CustomerAddressGroupMaps)
                .HasForeignKey(d => d.FkGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_GROUP_MAP_GROUP");
        });

        modelBuilder.Entity<CustomerAddressProductPriceModelMap>(entity =>
        {
            entity.ToTable("CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP", tb => tb.HasTrigger("CAPPMM_HISTORY_LOGGING"));

            entity.HasIndex(e => e.FkProductId, "IX_CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP");

            entity.HasIndex(e => e.FkCustomerAddressId, "IX_CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP_1");

            entity.HasIndex(e => e.CreatedBy, "IX_CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP_10");

            entity.HasIndex(e => e.DateCreated, "IX_CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP_11");

            entity.HasIndex(e => e.ModifiedBy, "IX_CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP_12");

            entity.HasIndex(e => e.DateModified, "IX_CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP_13");

            entity.HasIndex(e => e.PriceModel, "IX_CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP_2");

            entity.HasIndex(e => e.Type, "IX_CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP_3");

            entity.HasIndex(e => e.Variance, "IX_CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP_4");

            entity.HasIndex(e => e.ContractId, "IX_CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP_5");

            entity.HasIndex(e => e.ContractId, "IX_CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP_6");

            entity.HasIndex(e => e.ContractStartDate, "IX_CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP_7");

            entity.HasIndex(e => e.ContractEndDate, "IX_CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP_8");

            entity.HasIndex(e => e.ContractLimitType, "IX_CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP_9");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContractEndDate).HasColumnName("CONTRACT_END_DATE");
            entity.Property(e => e.ContractId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CONTRACT_ID");
            entity.Property(e => e.ContractLimitAmount).HasColumnName("CONTRACT_LIMIT_AMOUNT");
            entity.Property(e => e.ContractLimitType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CONTRACT_LIMIT_TYPE");
            entity.Property(e => e.ContractStartDate).HasColumnName("CONTRACT_START_DATE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.NcpDateApplicable)
                .HasColumnType("datetime")
                .HasColumnName("NCP_DATE_APPLICABLE");
            entity.Property(e => e.PriceModel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_MODEL");
            entity.Property(e => e.PriceSource)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_SOURCE");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REASON");
            entity.Property(e => e.RppmReferenceId).HasColumnName("RPPM_REFERENCE_ID");
            entity.Property(e => e.RpppmmReferenceId).HasColumnName("RPPPMM_REFERENCE_ID");
            entity.Property(e => e.RppzcmReferenceId).HasColumnName("RPPZCM_REFERENCE_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Value).HasColumnName("VALUE");
            entity.Property(e => e.Variance)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VARIANCE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CustomerAddressProductPriceModelMapCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_1_USER2");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.CustomerAddressProductPriceModelMaps)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_1_CUSTOMER_ADDRESS");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.CustomerAddressProductPriceModelMaps)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_1_PRODUCT");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.CustomerAddressProductPriceModelMapModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_Table_1_USER3");
        });

        modelBuilder.Entity<CustomerAddressProductPriceModelMapTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CUSTOMER_ADDRESS_PRODUCT_PRICE_MODEL_MAP_TEMP");

            entity.Property(e => e.ContractEndDate).HasColumnName("CONTRACT_END_DATE");
            entity.Property(e => e.ContractStartDate).HasColumnName("CONTRACT_START_DATE");
            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated).HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified).HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.ModifiedBy).HasColumnName("MODIFIED_BY");
            entity.Property(e => e.PriceModel).HasColumnName("PRICE_MODEL");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Type).HasColumnName("TYPE");
            entity.Property(e => e.Value).HasColumnName("VALUE");
            entity.Property(e => e.Variance).HasColumnName("VARIANCE");
        });

        modelBuilder.Entity<CustomerAddressProductSetting>(entity =>
        {
            entity.ToTable("CUSTOMER_ADDRESS_PRODUCT_SETTINGS");

            entity.HasIndex(e => e.FkCustomerAddressId, "IX_CUSTOMER_ADDRESS_PRODUCT_SETTINGS");

            entity.HasIndex(e => e.FkProductId, "IX_CUSTOMER_ADDRESS_PRODUCT_SETTINGS_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.LegacyFillLocationId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LEGACY_FILL_LOCATION_ID");
            entity.Property(e => e.LegacyMethod).HasColumnName("LEGACY_METHOD");
            entity.Property(e => e.LegacyMiscCharge)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LEGACY_MISC_CHARGE");
            entity.Property(e => e.LegacyRack).HasColumnName("LEGACY_RACK");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.CustomerAddressProductSettings)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_PRODUCT_SETTINGS_CUSTOMER_ADDRESS");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.CustomerAddressProductSettings)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_PRODUCT_SETTINGS_PRODUCT");
        });

        modelBuilder.Entity<CustomerAddressProductTemplateMap>(entity =>
        {
            entity.ToTable("CUSTOMER_ADDRESS_PRODUCT_TEMPLATE_MAP");

            entity.HasIndex(e => e.FkCustomerAddresId, "IX_CUSTOMER_ADDRESS_PRODUCT_TEMPLATE_MAP");

            entity.HasIndex(e => e.FkProductId, "IX_CUSTOMER_ADDRESS_PRODUCT_TEMPLATE_MAP_1");

            entity.HasIndex(e => e.FkPricingTemplateId, "IX_CUSTOMER_ADDRESS_PRODUCT_TEMPLATE_MAP_2");

            entity.HasIndex(e => e.CreatedBy, "IX_CUSTOMER_ADDRESS_PRODUCT_TEMPLATE_MAP_3");

            entity.HasIndex(e => e.ModifiedBy, "IX_CUSTOMER_ADDRESS_PRODUCT_TEMPLATE_MAP_4");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContractId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CONTRACT_ID");
            entity.Property(e => e.ContractType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CONTRACT_TYPE");
            entity.Property(e => e.ContractVolume).HasColumnName("CONTRACT_VOLUME");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.FkCustomerAddresId).HasColumnName("FK_CUSTOMER_ADDRES_ID");
            entity.Property(e => e.FkPricingTemplateId).HasColumnName("FK_PRICING_TEMPLATE_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.LandingCost).HasColumnName("LANDING_COST");
            entity.Property(e => e.LimitCost).HasColumnName("LIMIT_COST");
            entity.Property(e => e.LimitVolume).HasColumnName("LIMIT_VOLUME");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.PriceModel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_MODEL");
            entity.Property(e => e.PriceName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRICE_NAME");
            entity.Property(e => e.PriceType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_TYPE");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.TotalCurrentCost).HasColumnName("TOTAL_CURRENT_COST");
            entity.Property(e => e.TotalCurrentVolume).HasColumnName("TOTAL_CURRENT_VOLUME");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CustomerAddressProductTemplateMapCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_PRODUCT_TEMPLATE_MAP_USER");

            entity.HasOne(d => d.FkCustomerAddres).WithMany(p => p.CustomerAddressProductTemplateMaps)
                .HasForeignKey(d => d.FkCustomerAddresId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_PRODUCT_TEMPLATE_MAP_CUSTOMER_ADDRESS");

            entity.HasOne(d => d.FkPricingTemplate).WithMany(p => p.CustomerAddressProductTemplateMaps)
                .HasForeignKey(d => d.FkPricingTemplateId)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_PRODUCT_TEMPLATE_MAP_PRICING_TEMPLATE");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.CustomerAddressProductTemplateMaps)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_PRODUCT_TEMPLATE_MAP_PRODUCT");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.CustomerAddressProductTemplateMapModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_PRODUCT_TEMPLATE_MAP_USER1");
        });

        modelBuilder.Entity<CustomerAddressRegionMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CUSTOMER__3214EC272132882C");

            entity.ToTable("CUSTOMER_ADDRESS_REGION_MAP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkRegionId).HasColumnName("FK_REGION_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CustomerAddressRegionMapCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CUSTOMER___CREAT__5AD97420");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.CustomerAddressRegionMaps)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CUSTOMER___FK_CU__5DB5E0CB");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.CustomerAddressRegionMaps)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CUSTOMER___FK_CU__5CC1BC92");

            entity.HasOne(d => d.FkRegion).WithMany(p => p.CustomerAddressRegionMaps)
                .HasForeignKey(d => d.FkRegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CUSTOMER___FK_RE__60924D76");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.CustomerAddressRegionMapModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__CUSTOMER___MODIF__627A95E8");
        });

        modelBuilder.Entity<CustomerAddressTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CUSTOMER_ADDRESS_TEMP");

            entity.Property(e => e.Addr1).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Client).HasMaxLength(255);
            entity.Property(e => e.DelId)
                .HasMaxLength(255)
                .HasColumnName("DelID");
            entity.Property(e => e.DelStateProv).HasMaxLength(50);
            entity.Property(e => e.Direction).HasMaxLength(255);
            entity.Property(e => e.Latitude).HasMaxLength(255);
            entity.Property(e => e.Longitude).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.PCountryCode)
                .HasMaxLength(255)
                .HasColumnName("P_CountryCode");
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(20);
        });

        modelBuilder.Entity<CustomerBackup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC27C7B5B85F");

            entity.ToTable("CustomerBackup");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.LegacyId).HasColumnName("LEGACY_ID");
        });

        modelBuilder.Entity<CustomerContact>(entity =>
        {
            entity.ToTable("CUSTOMER_CONTACT");

            entity.HasIndex(e => e.FkCustomerId, "IX_CUSTOMER_CONTACT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AlternateNumber)
                .HasMaxLength(50)
                .HasColumnName("ALTERNATE_NUMBER");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTACT_NUMBER");
            entity.Property(e => e.Email)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.IsPrimary).HasColumnName("IS_PRIMARY");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Middlename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MIDDLENAME");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.CustomerContacts)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_CONTACT_CUSTOMER");
        });

        modelBuilder.Entity<CustomerContactTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CUSTOMER_CONTACT_TEMP");

            entity.Property(e => e.Account)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ContactId)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EMail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("eMail");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerEnrollmentLog>(entity =>
        {
            entity.ToTable("CUSTOMER_ENROLLMENT_LOG");

            entity.HasIndex(e => e.FkUserId, "IX_CUSTOMER_ENROLLMENT_LOG");

            entity.HasIndex(e => e.Name, "IX_CUSTOMER_ENROLLMENT_LOG_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");

            entity.HasOne(d => d.FkUser).WithMany(p => p.CustomerEnrollmentLogs)
                .HasForeignKey(d => d.FkUserId)
                .HasConstraintName("FK_CUSTOMER_ENROLLMENT_LOG_USER");
        });

        modelBuilder.Entity<CustomerGroup>(entity =>
        {
            entity.ToTable("CUSTOMER_GROUP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CONTACT_EMAIL");
            entity.Property(e => e.ContactName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CONTACT_NAME");
            entity.Property(e => e.ContactNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CONTACT_NUMBER");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CountryCodeAlpha)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_CODE_ALPHA");
            entity.Property(e => e.CountryCodeDigit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_CODE_DIGIT");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATE");
            entity.Property(e => e.Street)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STREET");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Zip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ZIP");

            entity.HasMany(d => d.FkCustomers).WithMany(p => p.FkCustomerGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "CustomerGroupMap",
                    r => r.HasOne<Customer>().WithMany()
                        .HasForeignKey("FkCustomerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CUSTOMER_GROUP_MAP_CUSTOMER"),
                    l => l.HasOne<CustomerGroup>().WithMany()
                        .HasForeignKey("FkCustomerGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CUSTOMER_GROUP_MAP_CUSTOMER_GROUP"),
                    j =>
                    {
                        j.HasKey("FkCustomerGroupId", "FkCustomerId");
                        j.ToTable("CUSTOMER_GROUP_MAP");
                        j.IndexerProperty<int>("FkCustomerGroupId").HasColumnName("FK_CUSTOMER_GROUP_ID");
                        j.IndexerProperty<int>("FkCustomerId").HasColumnName("FK_CUSTOMER_ID");
                    });

            entity.HasMany(d => d.FkUsers).WithMany(p => p.FkCustomerGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "CustomerGroupUserMap",
                    r => r.HasOne<User>().WithMany()
                        .HasForeignKey("FkUserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CUSTOMER_GROUP_USER_MAP_USER"),
                    l => l.HasOne<CustomerGroup>().WithMany()
                        .HasForeignKey("FkCustomerGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CUSTOMER_GROUP_USER_MAP_CUSTOMER_GROUP"),
                    j =>
                    {
                        j.HasKey("FkCustomerGroupId", "FkUserId");
                        j.ToTable("CUSTOMER_GROUP_USER_MAP");
                        j.HasIndex(new[] { "FkCustomerGroupId" }, "IX_CUSTOMER_GROUP_USER_MAP");
                        j.HasIndex(new[] { "FkUserId" }, "IX_CUSTOMER_GROUP_USER_MAP_1");
                        j.IndexerProperty<int>("FkCustomerGroupId").HasColumnName("FK_CUSTOMER_GROUP_ID");
                        j.IndexerProperty<string>("FkUserId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("FK_USER_ID");
                    });
        });

        modelBuilder.Entity<CustomerGroupApi>(entity =>
        {
            entity.ToTable("CUSTOMER_GROUP_API");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CLIENT_ID");
            entity.Property(e => e.ClientSecret)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CLIENT_SECRET");
            entity.Property(e => e.Column01)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COLUMN_01");
            entity.Property(e => e.Domain)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DOMAIN");
            entity.Property(e => e.FkCustomerGroupId).HasColumnName("FK_CUSTOMER_GROUP_ID");
            entity.Property(e => e.LastRun)
                .HasColumnType("datetime")
                .HasColumnName("LAST_RUN");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Scope)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SCOPE");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Username)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("USERNAME");

            entity.HasOne(d => d.FkCustomerGroup).WithMany(p => p.CustomerGroupApis)
                .HasForeignKey(d => d.FkCustomerGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_GROUP_API_CUSTOMER_GROUP");
        });

        modelBuilder.Entity<CustomerIntegration>(entity =>
        {
            entity.ToTable("CUSTOMER_INTEGRATION");

            entity.HasIndex(e => e.FkCustomerId, "IX_CUSTOMER_INTEGRATION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_NUMBER");
            entity.Property(e => e.BasicAuthHeaderKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BASIC_AUTH_HEADER_KEY");
            entity.Property(e => e.BasicAuthHeaderValue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BASIC_AUTH_HEADER_VALUE");
            entity.Property(e => e.ClientId)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CLIENT_ID");
            entity.Property(e => e.ClientSecret)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CLIENT_SECRET");
            entity.Property(e => e.Col01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COL_01");
            entity.Property(e => e.Col02)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COL_02");
            entity.Property(e => e.Domain)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DOMAIN");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.LastRun)
                .HasColumnType("datetime")
                .HasColumnName("LAST_RUN");
            entity.Property(e => e.Module)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Url)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("URL");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USERNAME");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.CustomerIntegrations)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_INTEGRATION_CUSTOMER");
        });

        modelBuilder.Entity<CustomerIntegrationDetail>(entity =>
        {
            entity.ToTable("CUSTOMER_INTEGRATION_DETAILS");

            entity.HasIndex(e => e.FkCustomerIntegrationId, "IX_CUSTOMER_INTEGRATION_DETAILS");

            entity.HasIndex(e => e.Module, "IX_CUSTOMER_INTEGRATION_DETAILS_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.FkCustomerIntegrationId).HasColumnName("FK_CUSTOMER_INTEGRATION_ID");
            entity.Property(e => e.IsAdminPortal).HasColumnName("IS_ADMIN_PORTAL");
            entity.Property(e => e.IsB2b).HasColumnName("IS_B2B");
            entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");
            entity.Property(e => e.Link)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LINK");
            entity.Property(e => e.Link2)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LINK_2");
            entity.Property(e => e.Module)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Value)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("VALUE");
            entity.Property(e => e.Value2)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VALUE_2");
            entity.Property(e => e.Value3).HasColumnName("VALUE_3");
            entity.Property(e => e.Value4)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VALUE_4");

            entity.HasOne(d => d.FkCustomerIntegration).WithMany(p => p.CustomerIntegrationDetails)
                .HasForeignKey(d => d.FkCustomerIntegrationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_INTEGRATION_DETAILS_CUSTOMER_INTEGRATION");
        });

        modelBuilder.Entity<CustomerNotesTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CUSTOMER_NOTES_TEMP");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("customer_id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.Module)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("module");
            entity.Property(e => e.Notes)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.OrderId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("order_id");
        });

        modelBuilder.Entity<CustomerPartner>(entity =>
        {
            entity.HasKey(e => new { e.FkCustomerId, e.PartnerId, e.Role });

            entity.ToTable("CUSTOMER_PARTNER");

            entity.HasIndex(e => e.FkCustomerId, "IX_CUSTOMER_PARTNER");

            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.PartnerId).HasColumnName("PARTNER_ID");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ROLE");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.CustomerPartnerFkCustomers)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CUSTOMER___PARTN__2EA5EC27");

            entity.HasOne(d => d.Partner).WithMany(p => p.CustomerPartnerPartners)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CUSTOMER___PARTN__2F9A1060");
        });

        modelBuilder.Entity<CustomerProductMap>(entity =>
        {
            entity.HasKey(e => new { e.FkProductId, e.FkCustomerId }).HasName("PK_CUSTOMER_PRODUCT_MAP_1");

            entity.ToTable("CUSTOMER_PRODUCT_MAP");

            entity.HasIndex(e => e.FkCustomerId, "IX_CUSTOMER_PRODUCT_MAP");

            entity.HasIndex(e => e.FkPriceListCode, "IX_CUSTOMER_PRODUCT_MAP_1");

            entity.HasIndex(e => e.FkProductId, "IX_CUSTOMER_PRODUCT_MAP_2");

            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.Body)
                .IsUnicode(false)
                .HasColumnName("BODY");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkPriceListCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_PRICE_LIST_CODE");
            entity.Property(e => e.Icon)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("ICON");
            entity.Property(e => e.IsFeatured).HasColumnName("IS_FEATURED");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.PriceEffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("PRICE_EFFECTIVE_DATE");
            entity.Property(e => e.PriceEndDate)
                .HasColumnType("datetime")
                .HasColumnName("PRICE_END_DATE");
            entity.Property(e => e.PriceUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRICE_UNIT");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
            entity.Property(e => e.WeightUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WEIGHT_UNIT");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.CustomerProductMaps)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_PRODUCT_MAP_CUSTOMER");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.CustomerProductMaps)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_PRODUCT_MAP_PRODUCT");

            entity.HasMany(d => d.FkGroups).WithMany(p => p.CustomerProductMaps)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductGroupMap",
                    r => r.HasOne<Group>().WithMany()
                        .HasForeignKey("FkGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PRODUCT_GROUP_MAP_GROUP"),
                    l => l.HasOne<CustomerProductMap>().WithMany()
                        .HasForeignKey("FkProductId", "FkCustomerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PRODUCT_GROUP_MAP_CUSTOMER_PRODUCT_MAP"),
                    j =>
                    {
                        j.HasKey("FkProductId", "FkGroupId", "FkCustomerId");
                        j.ToTable("PRODUCT_GROUP_MAP");
                        j.HasIndex(new[] { "FkProductId" }, "IX_PRODUCT_GROUP_MAP");
                        j.HasIndex(new[] { "FkCustomerId" }, "IX_PRODUCT_GROUP_MAP_1");
                        j.HasIndex(new[] { "FkGroupId" }, "IX_PRODUCT_GROUP_MAP_2");
                        j.IndexerProperty<int>("FkProductId").HasColumnName("FK_PRODUCT_ID");
                        j.IndexerProperty<int>("FkGroupId").HasColumnName("FK_GROUP_ID");
                        j.IndexerProperty<int>("FkCustomerId").HasColumnName("FK_CUSTOMER_ID");
                    });
        });

        modelBuilder.Entity<CustomerProductVarianceMap>(entity =>
        {
            entity.HasKey(e => new { e.FkVarianceId, e.FkProductId, e.FkCustomerId });

            entity.ToTable("CUSTOMER_PRODUCT_VARIANCE_MAP");

            entity.HasIndex(e => e.FkVarianceId, "CPVM_index1");

            entity.HasIndex(e => e.FkProductId, "CPVM_index2");

            entity.HasIndex(e => e.FkCustomerId, "CPVM_index3");

            entity.Property(e => e.FkVarianceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FK_VARIANCE_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FromDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FROM_DATE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.Moq).HasColumnName("MOQ");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.ToDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TO_DATE");

            entity.HasOne(d => d.CustomerProductMap).WithMany(p => p.CustomerProductVarianceMaps)
                .HasForeignKey(d => new { d.FkProductId, d.FkCustomerId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_PRODUCT_VARIANCE_MAP_CUSTOMER");

            entity.HasOne(d => d.ProductVariance).WithMany(p => p.CustomerProductVarianceMaps)
                .HasForeignKey(d => new { d.FkVarianceId, d.FkProductId })
                .HasConstraintName("FK_CUSTOMER_PRODUCT_VARIANCE_MAP_PRODUCT_VARIANCE");
        });

        modelBuilder.Entity<CustomerRemittanceAddressMap>(entity =>
        {
            entity.ToTable("CUSTOMER_REMITTANCE_ADDRESS_MAP");

            entity.HasIndex(e => e.FkCustomerId, "IX_CUSTOMER_REMITTANCE_ADDRESS_MAP_1");

            entity.HasIndex(e => e.FkRemittanceAddressId, "IX_CUSTOMER_REMITTANCE_ADDRESS_MAP_2");

            entity.HasIndex(e => e.Status, "IX_CUSTOMER_REMITTANCE_ADDRESS_MAP_3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkRemittanceAddressId).HasColumnName("FK_REMITTANCE_ADDRESS_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.CustomerRemittanceAddressMaps)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_REMITTANCE_ADDRESS_MAP_CUSTOMER");

            entity.HasOne(d => d.FkRemittanceAddress).WithMany(p => p.CustomerRemittanceAddressMaps)
                .HasForeignKey(d => d.FkRemittanceAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_REMITTANCE_ADDRESS_MAP_REMITTANCE_ADDRESS");
        });

        modelBuilder.Entity<CustomerServiceMap>(entity =>
        {
            entity.HasKey(e => new { e.FkCustomerId, e.FkServiceId });

            entity.ToTable("CUSTOMER_SERVICE_MAP");

            entity.HasIndex(e => e.FkCustomerId, "IX_CUSTOMER_SERVICE_MAP");

            entity.HasIndex(e => e.FkServiceId, "IX_CUSTOMER_SERVICE_MAP_1");

            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkServiceId).HasColumnName("FK_SERVICE_ID");
        });

        modelBuilder.Entity<CustomerShippingVendorMap>(entity =>
        {
            entity.ToTable("CUSTOMER_SHIPPING_VENDOR_MAP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkShipVendorId).HasColumnName("FK_SHIP_VENDOR_ID");
            entity.Property(e => e.IsDefault)
                .HasDefaultValue(false)
                .HasColumnName("IS_DEFAULT");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.CustomerShippingVendorMaps)
                .HasForeignKey(d => d.FkCustomerId)
                .HasConstraintName("FK_CUSTOMER_SHIPPING_VENDOR_MAP_CUSTOMER");

            entity.HasOne(d => d.FkShipVendor).WithMany(p => p.CustomerShippingVendorMaps)
                .HasForeignKey(d => d.FkShipVendorId)
                .HasConstraintName("FK_CUSTOMER_SHIPPING_VENDOR_MAP_SHIPPING_VENDOR");
        });

        modelBuilder.Entity<CustomerSubscriptionMap>(entity =>
        {
            entity.HasKey(e => new { e.FkCustomerId, e.FkSubscriptionId });

            entity.ToTable("CUSTOMER_SUBSCRIPTION_MAP");

            entity.HasIndex(e => e.FkCustomerId, "IX_CUSTOMER_SUBSCRIPTION_MAP");

            entity.HasIndex(e => e.FkSubscriptionId, "IX_CUSTOMER_SUBSCRIPTION_MAP_1");

            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkSubscriptionId).HasColumnName("FK_SUBSCRIPTION_ID");
            entity.Property(e => e.Col1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COL_1");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.CustomerSubscriptionMaps)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_SUBSCRIPTION_MAP_CUSTOMER");

            entity.HasOne(d => d.FkSubscription).WithMany(p => p.CustomerSubscriptionMaps)
                .HasForeignKey(d => d.FkSubscriptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_SUBSCRIPTION_MAP_SUBSCRIPTION");
        });

        modelBuilder.Entity<CustomerTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CUSTOMER_TEMP");

            entity.Property(e => e.AccountType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("account_type");
            entity.Property(e => e.Classification)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("classification");
            entity.Property(e => e.CollectorId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("collector_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CreditCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("credit_code");
            entity.Property(e => e.CreditLimit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("credit_limit");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("date_modified");
            entity.Property(e => e.Gn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("GN");
            entity.Property(e => e.IsPriced)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("is_priced");
            entity.Property(e => e.Language)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("language");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("legacy_id");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("modified_by");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PoNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("po_number");
            entity.Property(e => e.PreviousBalance)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("previous_balance");
            entity.Property(e => e.PriceClass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("price_class");
            entity.Property(e => e.Pricezone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pricezone");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.Region)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("region");
            entity.Property(e => e.SalesRepId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sales_rep_id");
            entity.Property(e => e.StatementType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("statement_type");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TaxCategory)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tax_category");
            entity.Property(e => e.Tel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("timestamp");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<CustomerType>(entity =>
        {
            entity.ToTable("CUSTOMER_TYPE");

            entity.HasIndex(e => e.CreatedBy, "IX_CUSTOMER_TYPE_1");

            entity.HasIndex(e => e.ModifiedBy, "IX_CUSTOMER_TYPE_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Comment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COMMENT");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.GroupCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("GROUP_CODE");
            entity.Property(e => e.GroupName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GROUP_NAME");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.CustomerTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_CUSTOMER_TYPE_USER_1");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.CustomerTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_CUSTOMER_TYPE_USER_2");
        });

        modelBuilder.Entity<CustomerUserMap>(entity =>
        {
            entity.HasKey(e => new { e.FkCustomerId, e.FkUserId });

            entity.ToTable("CUSTOMER_USER_MAP");

            entity.HasIndex(e => e.FkCustomerId, "IX_CUSTOMER_USER_MAP");

            entity.HasIndex(e => e.FkRoleId, "IX_CUSTOMER_USER_MAP_1");

            entity.HasIndex(e => e.FkUserId, "IX_CUSTOMER_USER_MAP_2");

            entity.HasIndex(e => new { e.FkCustomerId, e.FkUserId, e.FkRoleId }, "IX_CUSTOMER_USER_MAP_3").IsUnique();

            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.Column1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COLUMN_1");
            entity.Property(e => e.Column2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COLUMN_2");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkRoleId).HasColumnName("FK_ROLE_ID");
            entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");
            entity.Property(e => e.IsReadOnly)
                .HasDefaultValue(false)
                .HasColumnName("IS_READ_ONLY");
            entity.Property(e => e.IsSelected).HasColumnName("IS_SELECTED");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ID");
            entity.Property(e => e.LegacyId2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ID_2");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.CustomerUserMaps)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_USER_MAP_CUSTOMER");

            entity.HasOne(d => d.FkRole).WithMany(p => p.CustomerUserMaps)
                .HasForeignKey(d => d.FkRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_USER_MAP_ROLE");

            entity.HasOne(d => d.FkUser).WithMany(p => p.CustomerUserMaps)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_USER_MAP_USER");
        });

        modelBuilder.Entity<CustomerUserRolePermissionMap>(entity =>
        {
            entity.HasKey(e => new { e.FkCustomerId, e.FkUserId, e.FkRoleId, e.FkPermissionId });

            entity.ToTable("CUSTOMER_USER_ROLE_PERMISSION_MAP");

            entity.HasIndex(e => e.FkCustomerId, "IX_CUSTOMER_USER_ROLE_PERMISSION_MAP");

            entity.HasIndex(e => e.FkUserId, "IX_CUSTOMER_USER_ROLE_PERMISSION_MAP_1");

            entity.HasIndex(e => e.FkRoleId, "IX_CUSTOMER_USER_ROLE_PERMISSION_MAP_2");

            entity.HasIndex(e => e.FkPermissionId, "IX_CUSTOMER_USER_ROLE_PERMISSION_MAP_3");

            entity.HasIndex(e => new { e.FkCustomerId, e.FkUserId, e.FkPermissionId }, "IX_CUSTOMER_USER_ROLE_PERMISSION_MAP_4");

            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.FkRoleId).HasColumnName("FK_ROLE_ID");
            entity.Property(e => e.FkPermissionId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_PERMISSION_ID");

            entity.HasOne(d => d.RolePermissionMap).WithMany(p => p.CustomerUserRolePermissionMaps)
                .HasForeignKey(d => new { d.FkRoleId, d.FkPermissionId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_USER_ROLE_PERMISSION_MAP_ROLE_PERMISSION_MAP");

            entity.HasOne(d => d.CustomerUserMap).WithMany(p => p.CustomerUserRolePermissionMaps)
                .HasPrincipalKey(p => new { p.FkCustomerId, p.FkUserId, p.FkRoleId })
                .HasForeignKey(d => new { d.FkCustomerId, d.FkUserId, d.FkRoleId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CUSTOMER_USER_ROLE_PERMISSION_MAP_CUSTOMER_USER_MAP");
        });

        modelBuilder.Entity<DegreeDay>(entity =>
        {
            entity.ToTable("DEGREE_DAY");

            entity.HasIndex(e => e.FkRegionId, "IX_DEGREE_DAY_1");

            entity.HasIndex(e => e.DegreeDaySum, "IX_DEGREE_DAY_2");

            entity.HasIndex(e => e.LocalDay, "IX_DEGREE_DAY_3");

            entity.HasIndex(e => e.LocalYear, "IX_DEGREE_DAY_4");

            entity.HasIndex(e => e.LocalDate, "IX_DEGREE_DAY_5");

            entity.HasIndex(e => e.HeatingDegreeDays, "IX_DEGREE_DAY_6");

            entity.HasIndex(e => e.DateCreated, "IX_DEGREE_DAY_7");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CurrentSeason)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CURRENT_SEASON");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DegreeDaySum).HasColumnName("DEGREE_DAY_SUM");
            entity.Property(e => e.FkRegionId).HasColumnName("FK_REGION_ID");
            entity.Property(e => e.HeatingDegreeDays).HasColumnName("HEATING_DEGREE_DAYS");
            entity.Property(e => e.LocalDate)
                .HasColumnType("datetime")
                .HasColumnName("LOCAL_DATE");
            entity.Property(e => e.LocalDay).HasColumnName("LOCAL_DAY");
            entity.Property(e => e.LocalMonth).HasColumnName("LOCAL_MONTH");
            entity.Property(e => e.LocalYear).HasColumnName("LOCAL_YEAR");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.DegreeDayCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_DEGREE_DAY_USER_1");

            entity.HasOne(d => d.FkRegion).WithMany(p => p.DegreeDays)
                .HasForeignKey(d => d.FkRegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DEGREE_DAY_REGION");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.DegreeDayModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_DEGREE_DAY_USER_2");
        });

        modelBuilder.Entity<DeliveryQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DELIVERY__3214EC27A1123726");

            entity.ToTable("DELIVERY_QUEUE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreditHoldStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CREDIT_HOLD_STATUS");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkRecurrenceId).HasColumnName("FK_RECURRENCE_ID");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.DeliveryQueueCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DELIVERY___CREAT__05C3D225");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.DeliveryQueues)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DELIVERY___FK_CU__07AC1A97");

            entity.HasOne(d => d.FkRecurrence).WithMany(p => p.DeliveryQueues)
                .HasForeignKey(d => d.FkRecurrenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DELIVERY___FK_RE__09946309");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.DeliveryQueueModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__DELIVERY___MODIF__0B7CAB7B");
        });

        modelBuilder.Entity<DeliveryQueueOperation>(entity =>
        {
            entity.ToTable("DELIVERY_QUEUE_OPERATION");

            entity.HasIndex(e => e.CreatedBy, "IX_DELIVERY_QUEUE_OPERATION");

            entity.HasIndex(e => e.FkRegionId, "IX_Table_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.FkRegionId).HasColumnName("FK_REGION_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.DeliveryQueueOperations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DELIVERY_QUEUE_OPERATION_USER");

            entity.HasOne(d => d.FkRegion).WithMany(p => p.DeliveryQueueOperations)
                .HasForeignKey(d => d.FkRegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DELIVERY_QUEUE_OPERATION_REGION");
        });

        modelBuilder.Entity<DeliveryQueueOperationMap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DELIVERY_QUEUE_OPERATION_MAP");

            entity.HasIndex(e => e.FkDeliveryQueueOperationId, "IX_DELIVERY_QUEUE_OPERATION_MAP");

            entity.HasIndex(e => e.FkDeliveryQueueId, "IX_Table_1_2");

            entity.Property(e => e.FkDeliveryQueueId).HasColumnName("FK_DELIVERY_QUEUE_ID");
            entity.Property(e => e.FkDeliveryQueueOperationId).HasColumnName("FK_DELIVERY_QUEUE_OPERATION_ID");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.FkDeliveryQueue).WithMany()
                .HasForeignKey(d => d.FkDeliveryQueueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DELIVERY_QUEUE_OPERATION_MAP_DELIVERY_QUEUE");

            entity.HasOne(d => d.FkDeliveryQueueOperation).WithMany()
                .HasForeignKey(d => d.FkDeliveryQueueOperationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DELIVERY_QUEUE_OPERATION_MAP_DELIVERY_QUEUE_OPERATION");
        });

        modelBuilder.Entity<DumpCustomerTable>(entity =>
        {
            entity.ToTable("DUMP_CUSTOMER_TABLE");

            entity.HasIndex(e => e.CustomerLegacyId, "IX_DUMP_CUSTOMER_TABLE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcquisitionCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ACQUISITION_CODE");
            entity.Property(e => e.AffinityCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("AFFINITY_CODE");
            entity.Property(e => e.AutoPap).HasColumnName("AUTO_PAP");
            entity.Property(e => e.Budget)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("BUDGET");
            entity.Property(e => e.CurrentBucket)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("CURRENT_BUCKET");
            entity.Property(e => e.CustomerLegacyId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_LEGACY_ID");
            entity.Property(e => e.Debut)
                .HasColumnType("datetime")
                .HasColumnName("DEBUT");
            entity.Property(e => e.DeferredBucket)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("DEFERRED_BUCKET");
            entity.Property(e => e.DeliveryInvoice).HasColumnName("DELIVERY_INVOICE");
            entity.Property(e => e.ExemptionLicense)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EXEMPTION_LICENSE");
            entity.Property(e => e.Facture)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("FACTURE");
            entity.Property(e => e.Interest)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("INTEREST");
            entity.Property(e => e.IsServiceInvoice).HasColumnName("IS_SERVICE_INVOICE");
            entity.Property(e => e.IsSmpInvoice).HasColumnName("IS_SMP_INVOICE");
            entity.Property(e => e.MonthlyAmount)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("MONTHLY_AMOUNT");
            entity.Property(e => e.MonthsForBudgetPlan)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("MONTHS_FOR_BUDGET_PLAN");
            entity.Property(e => e.PrevDeferredBucket)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PREV_DEFERRED_BUCKET");
            entity.Property(e => e.PrintEquip).HasColumnName("PRINT_EQUIP");
            entity.Property(e => e.PrintPartPlan).HasColumnName("PRINT_PART_PLAN");
            entity.Property(e => e.PrintServiceCharge).HasColumnName("PRINT_SERVICE_CHARGE");
            entity.Property(e => e.Province)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PROVINCE");
            entity.Property(e => e.PurchaseOrderMandatory)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("PURCHASE_ORDER_MANDATORY");
            entity.Property(e => e.Remittance)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("REMITTANCE");
            entity.Property(e => e.SelectCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SELECT_CODE");
            entity.Property(e => e.SpecialFlag).HasColumnName("SPECIAL_FLAG");
        });

        modelBuilder.Entity<DumpCustomerTableDetail>(entity =>
        {
            entity.ToTable("DUMP_CUSTOMER_TABLE_DETAILS");

            entity.HasIndex(e => e.FkDumpCustomerTableId, "IX_DUMP_CUSTOMER_TABLE_DETAILS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DocType).HasColumnName("DOC_TYPE");
            entity.Property(e => e.FkDumpCustomerTableId).HasColumnName("FK_DUMP_CUSTOMER_TABLE_ID");
            entity.Property(e => e.MediaType).HasColumnName("MEDIA_TYPE");
            entity.Property(e => e.Params)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("PARAMS");

            entity.HasOne(d => d.FkDumpCustomerTable).WithMany(p => p.DumpCustomerTableDetails)
                .HasForeignKey(d => d.FkDumpCustomerTableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DUMP_CUSTOMER_TABLE_DETAILS_DUMP_CUSTOMER_TABLE");
        });

        modelBuilder.Entity<EdiTransactLog>(entity =>
        {
            entity.ToTable("EDI_TRANSACT_LOG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EdiData)
                .IsUnicode(false)
                .HasColumnName("EDI_DATA");
            entity.Property(e => e.IsParsingSuccess).HasColumnName("IS_PARSING_SUCCESS");
            entity.Property(e => e.OrderId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORDER_ID");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
            entity.Property(e => e.TransactType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TRANSACT_TYPE");
        });

        modelBuilder.Entity<Edisequence>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EDISequence");

            entity.Property(e => e.EdisequenceNumber).HasColumnName("EDISequenceNumber");
        });

        modelBuilder.Entity<EntityEnum>(entity =>
        {
            entity.ToTable("ENTITY_ENUMS");

            entity.HasIndex(e => e.Entity, "IX_ENTITY_ENUMS");

            entity.HasIndex(e => e.ColumnName, "IX_ENTITY_ENUMS_1");

            entity.HasIndex(e => e.DataType, "IX_ENTITY_ENUMS_2");

            entity.HasIndex(e => e.Value, "IX_ENTITY_ENUMS_3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("COLUMN_NAME");
            entity.Property(e => e.DataType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DATA_TYPE");
            entity.Property(e => e.Entity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENTITY");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EQUIPMEN__3214EC2779283716");

            entity.ToTable("EQUIPMENT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssetOwner)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ASSET_OWNER");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DateOfManufacture)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DATE_OF_MANUFACTURE");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.LastServiceDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_SERVICE_DATE");
            entity.Property(e => e.LocationDescription)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("LOCATION_DESCRIPTION");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MANUFACTURER");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.SerialNo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SERIAL_NO");
            entity.Property(e => e.Size).HasColumnName("SIZE");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Type)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EquipmentCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EQUIPMENT__CREAT__131DCD43");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.Equipment)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EQUIPMENT__FK_CU__150615B5");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.Equipment)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EQUIPMENT__FK_CU__15FA39EE");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.EquipmentModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__EQUIPMENT__MODIF__18D6A699");
        });

        modelBuilder.Entity<EquipmentServiceRequestMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EQUIPMEN__3214EC27C0EC543F");

            entity.ToTable("EQUIPMENT_SERVICE_REQUEST_MAP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkCustomerAddressAttributesId).HasColumnName("FK_CUSTOMER_ADDRESS_ATTRIBUTES_ID");
            entity.Property(e => e.FkEquipmentId).HasColumnName("FK_EQUIPMENT_ID");
            entity.Property(e => e.FkServiceRequestId).HasColumnName("FK_SERVICE_REQUEST_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EquipmentServiceRequestMapCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EQUIPMENT__CREAT__1ABEEF0B");

            entity.HasOne(d => d.FkCustomerAddressAttributes).WithMany(p => p.EquipmentServiceRequestMaps)
                .HasForeignKey(d => d.FkCustomerAddressAttributesId)
                .HasConstraintName("FK__EQUIPMENT__FK_CU__1CA7377D");

            entity.HasOne(d => d.FkEquipment).WithMany(p => p.EquipmentServiceRequestMaps)
                .HasForeignKey(d => d.FkEquipmentId)
                .HasConstraintName("FK__EQUIPMENT__FK_EQ__1E8F7FEF");

            entity.HasOne(d => d.FkServiceRequest).WithMany(p => p.EquipmentServiceRequestMaps)
                .HasForeignKey(d => d.FkServiceRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EQUIPMENT__FK_SE__2077C861");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.EquipmentServiceRequestMapModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__EQUIPMENT__MODIF__226010D3");
        });

        modelBuilder.Entity<EquipmentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EQUIPMEN__3214EC27F7F4CD0E");

            entity.ToTable("EQUIPMENT_TYPE");

            entity.HasIndex(e => e.Type, "IX_EQUIPMENT_TYPE_1");

            entity.HasIndex(e => e.Description, "IX_EQUIPMENT_TYPE_2");

            entity.HasIndex(e => e.Category, "IX_EQUIPMENT_TYPE_3");

            entity.HasIndex(e => e.DateCreated, "IX_EQUIPMENT_TYPE_4");

            entity.HasIndex(e => e.CreatedBy, "IX_EQUIPMENT_TYPE_5");

            entity.HasIndex(e => e.DateModified, "IX_EQUIPMENT_TYPE_6");

            entity.HasIndex(e => e.ModifiedBy, "IX_EQUIPMENT_TYPE_7");

            entity.HasIndex(e => e.ForTesting, "IX_EQUIPMENT_TYPE_8");

            entity.HasIndex(e => e.SerialNumberRequired, "IX_EQUIPMENT_TYPE_9");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Category)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.ForTesting).HasColumnName("FOR_TESTING");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.SerialNumberRequired).HasColumnName("SERIAL_NUMBER_REQUIRED");
            entity.Property(e => e.Type)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EquipmentTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__EQUIPMENT__CREAT__24485945");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.EquipmentTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__EQUIPMENT__MODIF__2630A1B7");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EVENT");

            entity.HasIndex(e => e.FkProductionScheduleId, "IX_EVENT");

            entity.Property(e => e.FkProductionScheduleId).HasColumnName("FK_PRODUCTION_SCHEDULE_ID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("NAME");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.FkProductionSchedule).WithMany()
                .HasForeignKey(d => d.FkProductionScheduleId)
                .HasConstraintName("FK_EVENT_PRODUCTION_SCHEDULE");
        });

        modelBuilder.Entity<ExceptionCodeReference>(entity =>
        {
            entity.ToTable("EXCEPTION_CODE_REFERENCE");

            entity.HasIndex(e => e.ExceptionCode, "IX_EXCEPTION_CODE_REFERENCE_1");

            entity.HasIndex(e => e.ExceptionDescription, "IX_EXCEPTION_CODE_REFERENCE_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ExceptionCode).HasColumnName("EXCEPTION_CODE");
            entity.Property(e => e.ExceptionDescription)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EXCEPTION_DESCRIPTION");
        });

        modelBuilder.Entity<Family>(entity =>
        {
            entity.ToTable("FAMILY");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID");
        });

        modelBuilder.Entity<FillLocation>(entity =>
        {
            entity.ToTable("FILL_LOCATION");

            entity.HasIndex(e => e.Name, "IX_FILL_LOCATION_1");

            entity.HasIndex(e => e.Code, "IX_FILL_LOCATION_2");

            entity.HasIndex(e => e.Status, "IX_FILL_LOCATION_3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<Form>(entity =>
        {
            entity.ToTable("FORM");

            entity.HasIndex(e => e.FkCustomerId, "IX_FORM");

            entity.HasIndex(e => e.FormCode, "IX_FORM_1");

            entity.HasIndex(e => e.Name, "IX_FORM_2");

            entity.HasIndex(e => e.DateCreated, "IX_FORM_3");

            entity.HasIndex(e => e.CreatedBy, "IX_FORM_4");

            entity.HasIndex(e => e.ModifiedBy, "IX_FORM_5");

            entity.HasIndex(e => e.DateModified, "IX_FORM_6");

            entity.HasIndex(e => e.FormType, "IX_FORM_7");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsFixedLength()
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FormCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FORM_CODE");
            entity.Property(e => e.FormType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FORM_TYPE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("NAME");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.FormCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FORM_USER");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.Forms)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FORM_CUSTOMER");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.FormModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_FORM_USER1");
        });

        modelBuilder.Entity<FormQuestion>(entity =>
        {
            entity.ToTable("FORM_QUESTIONS");

            entity.HasIndex(e => e.FkFormId, "IX_FORM_QUESTIONS");

            entity.HasIndex(e => e.Sequence, "IX_FORM_QUESTIONS_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkFormId).HasColumnName("FK_FORM_ID");
            entity.Property(e => e.IsRequired).HasColumnName("IS_REQUIRED");
            entity.Property(e => e.Label)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("LABEL");
            entity.Property(e => e.QuestionType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("QUESTION_TYPE");
            entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

            entity.HasOne(d => d.FkForm).WithMany(p => p.FormQuestions)
                .HasForeignKey(d => d.FkFormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FORM_QUESTIONS_FORM");
        });

        modelBuilder.Entity<FormSubQuestion>(entity =>
        {
            entity.ToTable("FORM_SUB_QUESTIONS");

            entity.HasIndex(e => e.FkQuestionId, "IX_FORM_SUB_QUESTIONS");

            entity.HasIndex(e => e.Sequence, "IX_FORM_SUB_QUESTIONS_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkQuestionId).HasColumnName("FK_QUESTION_ID");
            entity.Property(e => e.Label)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LABEL");
            entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

            entity.HasOne(d => d.FkQuestion).WithMany(p => p.FormSubQuestions)
                .HasForeignKey(d => d.FkQuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FORM_SUB_QUESTIONS_FORM_QUESTIONS");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.ToTable("GROUP");

            entity.HasIndex(e => e.FkCustomerId, "IX_GROUP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.IsCore).HasColumnName("IS_CORE");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.TemporaryCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEMPORARY_CODE");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.Groups)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GROUP_CUSTOMER");
        });

        modelBuilder.Entity<Hold>(entity =>
        {
            entity.ToTable("HOLD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreateOrderFlag).HasColumnName("CREATE_ORDER_FLAG");
            entity.Property(e => e.Deactivation)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DEACTIVATION");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.GovtRegulationsFlag).HasColumnName("GOVT_REGULATIONS_FLAG");
            entity.Property(e => e.PrintTicketFlag).HasColumnName("PRINT_TICKET_FLAG");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<Inspection>(entity =>
        {
            entity.ToTable("INSPECTION");

            entity.HasIndex(e => e.NextInspection, "IX_INSPECTION_10");

            entity.HasIndex(e => e.Condition, "IX_INSPECTION_11");

            entity.HasIndex(e => e.IsInspectionRequired, "IX_INSPECTION_12");

            entity.HasIndex(e => e.IsFollowUpNeeded, "IX_INSPECTION_13");

            entity.HasIndex(e => e.TechnicianId, "IX_INSPECTION_14");

            entity.HasIndex(e => e.InspectionNumber, "IX_INSPECTION_15");

            entity.HasIndex(e => e.Module, "IX_INSPECTION_16");

            entity.HasIndex(e => e.FkCustomerAddressId, "IX_INSPECTION_2");

            entity.HasIndex(e => e.Description, "IX_INSPECTION_3");

            entity.HasIndex(e => e.Description, "IX_INSPECTION_4");

            entity.HasIndex(e => e.DateCreated, "IX_INSPECTION_5");

            entity.HasIndex(e => e.CreatedBy, "IX_INSPECTION_6");

            entity.HasIndex(e => e.DateModified, "IX_INSPECTION_7");

            entity.HasIndex(e => e.ModifiedBy, "IX_INSPECTION_8");

            entity.HasIndex(e => e.LastInspection, "IX_INSPECTION_9");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Condition)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CONDITION");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkAssetId).HasColumnName("FK_ASSET_ID");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.IdentityColumn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IDENTITY_COLUMN");
            entity.Property(e => e.InspectionNumber)
                .HasMaxLength(50)
                .HasColumnName("INSPECTION_NUMBER");
            entity.Property(e => e.IsFollowUpNeeded).HasColumnName("IS_FOLLOW_UP_NEEDED");
            entity.Property(e => e.IsInspectionRequired).HasColumnName("IS_INSPECTION_REQUIRED");
            entity.Property(e => e.LastInspection)
                .HasColumnType("datetime")
                .HasColumnName("LAST_INSPECTION");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Module)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.NextInspection)
                .HasColumnType("datetime")
                .HasColumnName("NEXT_INSPECTION");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.TechnicianId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TECHNICIAN_ID");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.InspectionCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INSPECTION_USER_1");

            entity.HasOne(d => d.FkAsset).WithMany(p => p.Inspections)
                .HasForeignKey(d => d.FkAssetId)
                .HasConstraintName("FK_INSPECTION_ASSET");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.Inspections)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .HasConstraintName("FK_INSPECTION_CUSTOMER_ADDRESS");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.InspectionModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_INSPECTION_USER_2");
        });

        modelBuilder.Entity<InspectionHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INSPECTION_HISTORY");

            entity.HasIndex(e => e.FkInspectionId, "IX_INSPECTION_HISTORY_1");

            entity.HasIndex(e => e.IsFollowUpNeeded, "IX_INSPECTION_HISTORY_10");

            entity.HasIndex(e => e.TechnicianId, "IX_INSPECTION_HISTORY_11");

            entity.HasIndex(e => e.InspectionNumber, "IX_INSPECTION_HISTORY_12");

            entity.HasIndex(e => e.Module, "IX_INSPECTION_HISTORY_13");

            entity.HasIndex(e => e.Description, "IX_INSPECTION_HISTORY_2");

            entity.HasIndex(e => e.Notes, "IX_INSPECTION_HISTORY_3");

            entity.HasIndex(e => e.DateCreated, "IX_INSPECTION_HISTORY_4");

            entity.HasIndex(e => e.CreatedBy, "IX_INSPECTION_HISTORY_5");

            entity.HasIndex(e => e.LastInspection, "IX_INSPECTION_HISTORY_6");

            entity.HasIndex(e => e.NextInspection, "IX_INSPECTION_HISTORY_7");

            entity.HasIndex(e => e.Condition, "IX_INSPECTION_HISTORY_8");

            entity.HasIndex(e => e.IsInspectionRequired, "IX_INSPECTION_HISTORY_9");

            entity.Property(e => e.Condition)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CONDITION");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkInspectionId).HasColumnName("FK_INSPECTION_ID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InspectionNumber)
                .HasMaxLength(50)
                .HasColumnName("INSPECTION_NUMBER");
            entity.Property(e => e.IsFollowUpNeeded).HasColumnName("IS_FOLLOW_UP_NEEDED");
            entity.Property(e => e.IsInspectionRequired).HasColumnName("IS_INSPECTION_REQUIRED");
            entity.Property(e => e.LastInspection)
                .HasColumnType("datetime")
                .HasColumnName("LAST_INSPECTION");
            entity.Property(e => e.Module)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.NextInspection)
                .HasColumnType("datetime")
                .HasColumnName("NEXT_INSPECTION");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.TechnicianId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TECHNICIAN_ID");

            entity.HasOne(d => d.CreatedByNavigation).WithMany()
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INSPECTION_HISTORY_USER");

            entity.HasOne(d => d.FkInspection).WithMany()
                .HasForeignKey(d => d.FkInspectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INSPECTION_HISTORY_INSPECTION");
        });

        modelBuilder.Entity<InspectionLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INSPECTI__3214EC27FE0B670B");

            entity.ToTable("INSPECTION_LOG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkEquipmentId).HasColumnName("FK_EQUIPMENT_ID");
            entity.Property(e => e.FkInspectionId).HasColumnName("FK_INSPECTION_ID");
            entity.Property(e => e.FkServiceRequestId).HasColumnName("FK_SERVICE_REQUEST_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Module)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.NextInspectionDate)
                .HasColumnType("datetime")
                .HasColumnName("NEXT_INSPECTION_DATE");
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOTES");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.InspectionLogCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__INSPECTIO__CREAT__347EC10E");

            entity.HasOne(d => d.FkEquipment).WithMany(p => p.InspectionLogs)
                .HasForeignKey(d => d.FkEquipmentId)
                .HasConstraintName("FK__INSPECTIO__FK_EQ__36670980");

            entity.HasOne(d => d.FkServiceRequest).WithMany(p => p.InspectionLogs)
                .HasForeignKey(d => d.FkServiceRequestId)
                .HasConstraintName("FK__INSPECTIO__FK_SE__384F51F2");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.InspectionLogModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__INSPECTIO__MODIF__3A379A64");
        });

        modelBuilder.Entity<InvSequenceRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INV_SEQU__3214EC278477443C");

            entity.ToTable("INV_SEQUENCE_RECORD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Prefix)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PREFIX");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_INVENTORY_1")
                .HasFillFactor(80);

            entity.ToTable("INVENTORY");

            entity.HasIndex(e => e.LotNumber, "IX_INVENTORY_10").HasFillFactor(80);

            entity.HasIndex(e => e.Id, "IX_INVENTORY_11").HasFillFactor(80);

            entity.HasIndex(e => e.Quantity, "IX_INVENTORY_12");

            entity.HasIndex(e => e.ProductionDate, "IX_INVENTORY_13").HasFillFactor(80);

            entity.HasIndex(e => e.ExpDate, "IX_INVENTORY_14").HasFillFactor(80);

            entity.HasIndex(e => e.QuantityType, "IX_INVENTORY_15").HasFillFactor(80);

            entity.HasIndex(e => e.ModifiedBy, "IX_INVENTORY_16").HasFillFactor(80);

            entity.HasIndex(e => e.LastModifiedDate, "IX_INVENTORY_17").HasFillFactor(80);

            entity.HasIndex(e => e.FkManufacturingId, "IX_INVENTORY_18").HasFillFactor(80);

            entity.HasIndex(e => e.VendorCode, "IX_INVENTORY_19").HasFillFactor(80);

            entity.HasIndex(e => e.FkSupplierVendorId, "IX_INVENTORY_20").HasFillFactor(80);

            entity.HasIndex(e => e.FkInventoryLocationId, "IX_INVENTORY_21").HasFillFactor(80);

            entity.HasIndex(e => e.Type, "IX_INVENTORY_6").HasFillFactor(80);

            entity.HasIndex(e => e.FkProductId, "IX_INVENTORY_7").HasFillFactor(80);

            entity.HasIndex(e => e.FkMaterialId, "IX_INVENTORY_8").HasFillFactor(80);

            entity.HasIndex(e => e.CreatedBy, "IX_INVENTORY_9").HasFillFactor(80);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.ExpDate).HasColumnName("EXP_DATE");
            entity.Property(e => e.FkInventoryLocationId).HasColumnName("FK_INVENTORY_LOCATION_ID");
            entity.Property(e => e.FkLotId).HasColumnName("FK_LOT_ID");
            entity.Property(e => e.FkManufacturingId).HasColumnName("FK_MANUFACTURING_ID");
            entity.Property(e => e.FkMaterialId).HasColumnName("FK_MATERIAL_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkSupplierVendorId).HasColumnName("FK_SUPPLIER_VENDOR_ID");
            entity.Property(e => e.InventoryValue1).HasColumnName("INVENTORY_VALUE_1");
            entity.Property(e => e.InventoryValue2).HasColumnName("INVENTORY_VALUE_2");
            entity.Property(e => e.LastModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_MODIFIED_DATE");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOT_NUMBER");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.PhysicalReading).HasColumnName("PHYSICAL_READING");
            entity.Property(e => e.ProductionDate)
                .HasColumnType("datetime")
                .HasColumnName("PRODUCTION_DATE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.QuantityType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("QUANTITY_TYPE");
            entity.Property(e => e.RecordedAdjustmentDate).HasColumnName("RECORDED_ADJUSTMENT_DATE");
            entity.Property(e => e.StorageBin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STORAGE_BIN");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.VendorCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VENDOR_CODE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.InventoryCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTORY_USER2");

            entity.HasOne(d => d.FkInventoryLocation).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.FkInventoryLocationId)
                .HasConstraintName("FK_INVENTORY_LOCATION_INVENTORY");

            entity.HasOne(d => d.FkLot).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.FkLotId)
                .HasConstraintName("FK_LOT_INVENTORY");

            entity.HasOne(d => d.FkManufacturing).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.FkManufacturingId)
                .HasConstraintName("FK_INVENTORY_MANUFACTURING");

            entity.HasOne(d => d.FkMaterial).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.FkMaterialId)
                .HasConstraintName("FK_INVENTORY_MATERIAL");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.FkProductId)
                .HasConstraintName("FK_INVENTORY_PRODUCT1");

            entity.HasOne(d => d.FkSupplierVendor).WithMany(p => p.Inventories)
                .HasForeignKey(d => d.FkSupplierVendorId)
                .HasConstraintName("FK_SUPPLIER_VENDOR_INVENTORY");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.InventoryModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_INVENTORY_USER3");
        });

        modelBuilder.Entity<InventoryLocation>(entity =>
        {
            entity.ToTable("INVENTORY_LOCATION");

            entity.HasIndex(e => e.FkRegionId, "IX_INVENTORY_LOCATION");

            entity.HasIndex(e => e.CreatedBy, "IX_INVENTORY_LOCATION_1");

            entity.HasIndex(e => e.Type, "IX_INVENTORY_LOCATION_2");

            entity.HasIndex(e => e.ReferenceId, "IX_INVENTORY_LOCATION_3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Capacity).HasColumnName("CAPACITY");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.FkRegionId).HasColumnName("FK_REGION_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NsBinInternalId).HasColumnName("NS_BIN_INTERNAL_ID");
            entity.Property(e => e.NsBusinessUnit)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("NS_BUSINESS_UNIT");
            entity.Property(e => e.NsLocInternalId).HasColumnName("NS_LOC_INTERNAL_ID");
            entity.Property(e => e.NsLocation)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NS_LOCATION");
            entity.Property(e => e.NsRegion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NS_REGION");
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFERENCE_ID");
            entity.Property(e => e.State)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STATE");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("STORAGE")
                .HasColumnName("TYPE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.InventoryLocations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_USER_INVENTORY_LOCATION");

            entity.HasOne(d => d.FkRegion).WithMany(p => p.InventoryLocations)
                .HasForeignKey(d => d.FkRegionId)
                .HasConstraintName("FK_INVENTORY_LOCATION_REGION");
        });

        modelBuilder.Entity<InventoryLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(80);

            entity.ToTable("INVENTORY_LOG");

            entity.HasIndex(e => e.FkLotId, "IX_INVENTORY_22").HasFillFactor(80);

            entity.HasIndex(e => e.Quantity, "IX_INVENTORY_LOG");

            entity.HasIndex(e => e.Direction, "IX_INVENTORY_LOG_1").HasFillFactor(80);

            entity.HasIndex(e => e.LotNumber, "IX_INVENTORY_LOG_10").HasFillFactor(80);

            entity.HasIndex(e => e.FkLotId, "IX_INVENTORY_LOG_11").HasFillFactor(80);

            entity.HasIndex(e => e.FkInventoryLocationId, "IX_INVENTORY_LOG_12");

            entity.HasIndex(e => e.FkInventoryIdTransfer, "IX_INVENTORY_LOG_13");

            entity.HasIndex(e => e.Module, "IX_INVENTORY_LOG_2").HasFillFactor(80);

            entity.HasIndex(e => e.FkManufacturingId, "IX_INVENTORY_LOG_3").HasFillFactor(80);

            entity.HasIndex(e => e.FkOrderId, "IX_INVENTORY_LOG_4").HasFillFactor(80);

            entity.HasIndex(e => e.CreatedBy, "IX_INVENTORY_LOG_5").HasFillFactor(80);

            entity.HasIndex(e => e.DateCreated, "IX_INVENTORY_LOG_6").HasFillFactor(80);

            entity.HasIndex(e => e.FkInventoryId, "IX_INVENTORY_LOG_7").HasFillFactor(80);

            entity.HasIndex(e => e.ProductionDate, "IX_INVENTORY_LOG_8").HasFillFactor(80);

            entity.HasIndex(e => e.ExpDate, "IX_INVENTORY_LOG_9").HasFillFactor(80);

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.Direction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIRECTION");
            entity.Property(e => e.ExpDate).HasColumnName("EXP_DATE");
            entity.Property(e => e.ExternalReferenceId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("EXTERNAL_REFERENCE_ID");
            entity.Property(e => e.FkInventoryId).HasColumnName("FK_INVENTORY_ID");
            entity.Property(e => e.FkInventoryIdTransfer).HasColumnName("FK_INVENTORY_ID_TRANSFER");
            entity.Property(e => e.FkInventoryLocationId).HasColumnName("FK_INVENTORY_LOCATION_ID");
            entity.Property(e => e.FkLotId).HasColumnName("FK_LOT_ID");
            entity.Property(e => e.FkManufacturingId).HasColumnName("FK_MANUFACTURING_ID");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.InventoryLogNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("INVENTORY_LOG_NOTES");
            entity.Property(e => e.InventoryValue1).HasColumnName("INVENTORY_VALUE_1");
            entity.Property(e => e.InventoryValue2).HasColumnName("INVENTORY_VALUE_2");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOT_NUMBER");
            entity.Property(e => e.Module)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.PhysicalReading).HasColumnName("PHYSICAL_READING");
            entity.Property(e => e.ProductionDate)
                .HasColumnType("datetime")
                .HasColumnName("PRODUCTION_DATE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.RecordedAdjustmentDate).HasColumnName("RECORDED_ADJUSTMENT_DATE");
            entity.Property(e => e.StorageBin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STORAGE_BIN");
            entity.Property(e => e.TransactionNumber)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("TRANSACTION_NUMBER");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.InventoryLogs)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTORY_LOG_USER");

            entity.HasOne(d => d.FkInventory).WithMany(p => p.InventoryLogs)
                .HasForeignKey(d => d.FkInventoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTORY_LOG_INVENTORY");

            entity.HasOne(d => d.FkInventoryLocation).WithMany(p => p.InventoryLogs)
                .HasForeignKey(d => d.FkInventoryLocationId)
                .HasConstraintName("FK_INVENTORY_LOCATION_INVENTORY_LOG");

            entity.HasOne(d => d.FkLot).WithMany(p => p.InventoryLogs)
                .HasForeignKey(d => d.FkLotId)
                .HasConstraintName("FK_LOT_INVENTORY_LOG");

            entity.HasOne(d => d.FkManufacturing).WithMany(p => p.InventoryLogs)
                .HasForeignKey(d => d.FkManufacturingId)
                .HasConstraintName("FK_INVENTORY_LOG_MANUFACTURING");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.InventoryLogs)
                .HasForeignKey(d => d.FkOrderId)
                .HasConstraintName("FK_INVENTORY_LOG_ORDER");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.ToTable("INVOICE");

            entity.HasIndex(e => e.FkOrderId, "IX_INVOICE");

            entity.HasIndex(e => e.BillAddrCountry, "IX_INVOICE_1");

            entity.HasIndex(e => e.ShipAddrStreet, "IX_INVOICE_10");

            entity.HasIndex(e => e.ShipAddrZipcode, "IX_INVOICE_11");

            entity.HasIndex(e => e.ShipAddrName, "IX_INVOICE_12");

            entity.HasIndex(e => e.RemAddrCountry, "IX_INVOICE_13");

            entity.HasIndex(e => e.RemAddrState, "IX_INVOICE_14");

            entity.HasIndex(e => e.RemAddrCity, "IX_INVOICE_15");

            entity.HasIndex(e => e.RemAddrStreet, "IX_INVOICE_16");

            entity.HasIndex(e => e.RemAddrZipcode, "IX_INVOICE_17");

            entity.HasIndex(e => e.RemAddrName, "IX_INVOICE_18");

            entity.HasIndex(e => e.ShipAddrCode, "IX_INVOICE_19");

            entity.HasIndex(e => e.BillAddrState, "IX_INVOICE_2");

            entity.HasIndex(e => e.Notes, "IX_INVOICE_20");

            entity.HasIndex(e => e.SendNotification, "IX_INVOICE_21");

            entity.HasIndex(e => e.InvoiceMailIntegration, "IX_INVOICE_22");

            entity.HasIndex(e => e.BillAddrCity, "IX_INVOICE_3");

            entity.HasIndex(e => e.BillAddrStreet, "IX_INVOICE_4");

            entity.HasIndex(e => e.BillAddrZipcode, "IX_INVOICE_5");

            entity.HasIndex(e => e.BillAddrName, "IX_INVOICE_6");

            entity.HasIndex(e => e.ShipAddrCountry, "IX_INVOICE_7");

            entity.HasIndex(e => e.ShipAddrState, "IX_INVOICE_8");

            entity.HasIndex(e => e.ShipAddrCity, "IX_INVOICE_9");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.BillAddrCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_CITY");
            entity.Property(e => e.BillAddrCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_COUNTRY");
            entity.Property(e => e.BillAddrName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_NAME");
            entity.Property(e => e.BillAddrState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_STATE");
            entity.Property(e => e.BillAddrStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_STREET");
            entity.Property(e => e.BillAddrZipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_ZIPCODE");
            entity.Property(e => e.BillingAddrStreet2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BILLING_ADDR_STREET2");
            entity.Property(e => e.BillingAddrStreet3)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("BILLING_ADDR_STREET3");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DeliveryNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_NUMBER");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.Incoterm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INCOTERM");
            entity.Property(e => e.InvoiceMailIntegration)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INVOICE_MAIL_INTEGRATION");
            entity.Property(e => e.IsPostgrid).HasColumnName("IS_POSTGRID");
            entity.Property(e => e.IsSendgrid).HasColumnName("IS_SENDGRID");
            entity.Property(e => e.IsSidetrade).HasColumnName("IS_SIDETRADE");
            entity.Property(e => e.MailProcessed).HasColumnName("MAIL_PROCESSED");
            entity.Property(e => e.Notes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.PaymentDueDate)
                .HasColumnType("datetime")
                .HasColumnName("PAYMENT_DUE_DATE");
            entity.Property(e => e.PaymentTerms)
                .HasColumnType("datetime")
                .HasColumnName("PAYMENT_TERMS");
            entity.Property(e => e.PaymentTermsDays).HasColumnName("PAYMENT_TERMS_DAYS");
            entity.Property(e => e.PaymentTermsName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_TERMS_NAME");
            entity.Property(e => e.RemAddrCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REM_ADDR_CITY");
            entity.Property(e => e.RemAddrCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REM_ADDR_COUNTRY");
            entity.Property(e => e.RemAddrName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REM_ADDR_NAME");
            entity.Property(e => e.RemAddrState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REM_ADDR_STATE");
            entity.Property(e => e.RemAddrStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("REM_ADDR_STREET");
            entity.Property(e => e.RemAddrZipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REM_ADDR_ZIPCODE");
            entity.Property(e => e.RemitAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("REMIT_ADDRESS");
            entity.Property(e => e.RemitCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMIT_CITY");
            entity.Property(e => e.RemitName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMIT_NAME");
            entity.Property(e => e.RemitState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMIT_STATE");
            entity.Property(e => e.RemitZipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMIT_ZIPCODE");
            entity.Property(e => e.SendNotification).HasColumnName("SEND_NOTIFICATION");
            entity.Property(e => e.ShipAddrCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_CITY");
            entity.Property(e => e.ShipAddrCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_CODE");
            entity.Property(e => e.ShipAddrCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_COUNTRY");
            entity.Property(e => e.ShipAddrName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_NAME");
            entity.Property(e => e.ShipAddrState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_STATE");
            entity.Property(e => e.ShipAddrStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_STREET");
            entity.Property(e => e.ShipAddrStreet2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_STREET2");
            entity.Property(e => e.ShipAddrStreet3)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_STREET3");
            entity.Property(e => e.ShipAddrZipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_ZIPCODE");
            entity.Property(e => e.ShippedUnits).HasColumnName("SHIPPED_UNITS");
            entity.Property(e => e.ShippedUnitsUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIPPED_UNITS_UNIT");
            entity.Property(e => e.ShowCharges).HasColumnName("SHOW_CHARGES");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.TermsDiscountDays).HasColumnName("TERMS_DISCOUNT_DAYS");
            entity.Property(e => e.TermsDiscountDueDate)
                .HasColumnType("datetime")
                .HasColumnName("TERMS_DISCOUNT_DUE_DATE");
            entity.Property(e => e.TermsDiscountPercent).HasColumnName("TERMS_DISCOUNT_PERCENT");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
            entity.Property(e => e.Type)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.FkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVOICE_ORDER");
        });

        modelBuilder.Entity<InvoiceCharge>(entity =>
        {
            entity.ToTable("INVOICE_CHARGES");

            entity.HasIndex(e => e.DescriptionCd, "IX_INVOICE_CHARGES_1");

            entity.HasIndex(e => e.ChargeCode, "IX_INVOICE_CHARGES_2");

            entity.HasIndex(e => e.Id, "IX_INVOICE_CHARGES_INVOICE_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.ChargeCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CHARGE_CODE");
            entity.Property(e => e.CouponId).HasColumnName("COUPON_ID");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.DescriptionCd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION_CD");
            entity.Property(e => e.FkInvoiceDetailId).HasColumnName("FK_INVOICE_DETAIL_ID");
            entity.Property(e => e.FkInvoiceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FK_INVOICE_ID");
            entity.Property(e => e.PromotionCode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PROMOTION_CODE");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.FkInvoiceDetail).WithMany(p => p.InvoiceCharges)
                .HasForeignKey(d => d.FkInvoiceDetailId)
                .HasConstraintName("FK_INVOICE_CHARGES_INVOICE_DETAILS");

            entity.HasOne(d => d.FkInvoice).WithMany(p => p.InvoiceCharges)
                .HasForeignKey(d => d.FkInvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVOICE_CHARGES_INVOICE");
        });

        modelBuilder.Entity<InvoiceDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_INVOICE_DETAIL");

            entity.ToTable("INVOICE_DETAILS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkInvoiceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FK_INVOICE_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.InvoicedPrice).HasColumnName("INVOICED_PRICE");
            entity.Property(e => e.InvoicedQuantity)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("INVOICED_QUANTITY");
            entity.Property(e => e.InvoicedWeight).HasColumnName("INVOICED_WEIGHT");
            entity.Property(e => e.PriceModel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_MODEL");
            entity.Property(e => e.PriceType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PRICE_TYPE");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
            entity.Property(e => e.VarianceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VARIANCE_ID");

            entity.HasOne(d => d.FkInvoice).WithMany(p => p.InvoiceDetails)
                .HasForeignKey(d => d.FkInvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVOICE_DETAIL_INVOICE");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.InvoiceDetails)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVOICE_DETAIL_PRODUCT");
        });

        modelBuilder.Entity<InvoiceLineItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INVOICE___3214EC279A39E7E0");

            entity.ToTable("INVOICE_LINE_ITEM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.FkInvoiceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FK_INVOICE_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.InvoicedPrice).HasColumnName("INVOICED_PRICE");
            entity.Property(e => e.InvoicedQuantity).HasColumnName("INVOICED_QUANTITY");
            entity.Property(e => e.PriceModel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_MODEL");
            entity.Property(e => e.PriceType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PRICE_TYPE");
            entity.Property(e => e.PriceVariance)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PRICE_VARIANCE");

            entity.HasOne(d => d.FkInvoice).WithMany(p => p.InvoiceLineItems)
                .HasForeignKey(d => d.FkInvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__INVOICE_L__FK_IN__5026DB83");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.InvoiceLineItems)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__INVOICE_L__FK_PR__520F23F5");
        });

        modelBuilder.Entity<InvoicePayment>(entity =>
        {
            entity.HasKey(e => new { e.FkInvoiceId, e.PaymentId });

            entity.ToTable("INVOICE_PAYMENT");

            entity.HasIndex(e => e.FkInvoiceId, "IX_INVOICE_PAYMENT");

            entity.HasIndex(e => e.PaymentId, "IX_INVOICE_PAYMENT_1");

            entity.Property(e => e.FkInvoiceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FK_INVOICE_ID");
            entity.Property(e => e.PaymentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_ID");
            entity.Property(e => e.Balance).HasColumnName("BALANCE");
            entity.Property(e => e.PaidAmount).HasColumnName("PAID_AMOUNT");
            entity.Property(e => e.PaymentDate).HasColumnName("PAYMENT_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.TotalAmount).HasColumnName("TOTAL_AMOUNT");

            entity.HasOne(d => d.FkInvoice).WithMany(p => p.InvoicePayments)
                .HasForeignKey(d => d.FkInvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVOICE_PAYMENT_INVOICE");
        });

        modelBuilder.Entity<InvoicePaymentMap>(entity =>
        {
            entity.ToTable("INVOICE_PAYMENT_MAP");

            entity.HasIndex(e => e.FkInvoiceId, "IX_INVOICE_PAYMENT_MAP");

            entity.HasIndex(e => e.FkPaymentId, "IX_INVOICE_PAYMENT_MAP_1");

            entity.HasIndex(e => e.IsDeleted, "IX_INVOICE_PAYMENT_MAP_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.FkInvoiceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FK_INVOICE_ID");
            entity.Property(e => e.FkPaymentId).HasColumnName("FK_PAYMENT_ID");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");

            entity.HasOne(d => d.FkInvoice).WithMany(p => p.InvoicePaymentMaps)
                .HasForeignKey(d => d.FkInvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVOICE_PAYMENT_MAP_INVOICE");

            entity.HasOne(d => d.FkPayment).WithMany(p => p.InvoicePaymentMaps)
                .HasForeignKey(d => d.FkPaymentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVOICE_PAYMENT_MAP_PAYMENT");
        });

        modelBuilder.Entity<Lead>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LEAD__3214EC27373F2073");

            entity.ToTable("LEAD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountCreditStatus)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_CREDIT_STATUS");
            entity.Property(e => e.AuthorizedUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUTHORIZED_USER");
            entity.Property(e => e.AuthorizedUserDob).HasColumnName("AUTHORIZED_USER_DOB");
            entity.Property(e => e.AuthorizedUserEmail)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AUTHORIZED_USER_EMAIL");
            entity.Property(e => e.BillingCycle)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BILLING_CYCLE");
            entity.Property(e => e.BillingMethod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BILLING_METHOD");
            entity.Property(e => e.BillingSchedule)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BILLING_SCHEDULE");
            entity.Property(e => e.BillingSetup)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BILLING_SETUP");
            entity.Property(e => e.BudgetPlan)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("BUDGET_PLAN");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CONTACT_EMAIL");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CONTACT_PHONE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CreditAuthorization)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CREDIT_AUTHORIZATION");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DateOfBirth).HasColumnName("DATE_OF_BIRTH");
            entity.Property(e => e.DaysOpen)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DAYS_OPEN");
            entity.Property(e => e.DeliveryPreference)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_PREFERENCE");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.EquipmentServicePlan)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("EQUIPMENT_SERVICE_PLAN");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.LsdNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LSD_NO");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_METHOD");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_PLAN");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("POSTAL_CODE");
            entity.Property(e => e.PrimaryDeliveryAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRIMARY_DELIVERY_ADDRESS");
            entity.Property(e => e.PrimaryEnergySource)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PRIMARY_ENERGY_SOURCE");
            entity.Property(e => e.PrimaryHeatingSource)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PRIMARY_HEATING_SOURCE");
            entity.Property(e => e.PrimaryPhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PRIMARY_PHONE_NUMBER");
            entity.Property(e => e.Province)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PROVINCE");
            entity.Property(e => e.SecondaryHeatingSource)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("SECONDARY_HEATING_SOURCE");
            entity.Property(e => e.State)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("STATE");
            entity.Property(e => e.Street)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STREET");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.LeadCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LEAD__CREATED_BY__56D3D912");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.LeadModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__LEAD__MODIFIED_B__58BC2184");
        });

        modelBuilder.Entity<ListSharingDetail>(entity =>
        {
            entity.HasKey(e => new { e.FkUserListId, e.FkUserId });

            entity.ToTable("LIST_SHARING_DETAILS");

            entity.HasIndex(e => e.FkUserListId, "IX_LIST_SHARING_DETAILS");

            entity.HasIndex(e => e.FkUserId, "IX_LIST_SHARING_DETAILS_1");

            entity.Property(e => e.FkUserListId).HasColumnName("FK_USER_LIST_ID");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.NewItemCount).HasColumnName("NEW_ITEM_COUNT");

            entity.HasOne(d => d.FkUser).WithMany(p => p.ListSharingDetails)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LIST_SHAR__FK_US__3B40CD36");

            entity.HasOne(d => d.FkUserList).WithMany(p => p.ListSharingDetails)
                .HasForeignKey(d => d.FkUserListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LIST_SHAR__FK_US__5AA469F6");
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.ToTable("LOG");

            entity.HasIndex(e => e.FkUserId, "IX_LOG");

            entity.HasIndex(e => e.FkCustomerId, "IX_LOG_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Body)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BODY");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.Latitude).HasColumnName("LATITUDE");
            entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");
            entity.Property(e => e.Module)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.ModuleId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODULE_ID");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TITLE");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.Logs)
                .HasForeignKey(d => d.FkCustomerId)
                .HasConstraintName("FK_LOG_CUSTOMER");

            entity.HasOne(d => d.FkUser).WithMany(p => p.Logs)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOG_USER");
        });

        modelBuilder.Entity<LogAudience>(entity =>
        {
            entity.HasKey(e => new { e.FkLogId, e.Entity, e.EntityId });

            entity.ToTable("LOG_AUDIENCE");

            entity.HasIndex(e => e.FkLogId, "IX_LOG_AUDIENCE");

            entity.HasIndex(e => e.Entity, "IX_LOG_AUDIENCE_1");

            entity.HasIndex(e => e.EntityId, "IX_LOG_AUDIENCE_2");

            entity.Property(e => e.FkLogId).HasColumnName("FK_LOG_ID");
            entity.Property(e => e.Entity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENTITY");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENTITY_ID");

            entity.HasOne(d => d.FkLog).WithMany(p => p.LogAudiences)
                .HasForeignKey(d => d.FkLogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOG_AUDIENCE_LOG");
        });

        modelBuilder.Entity<LogGroupAudience>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.FkLogId });

            entity.ToTable("LOG_GROUP_AUDIENCE");

            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.FkLogId).HasColumnName("FK_LOG_ID");
            entity.Property(e => e.GroupName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GROUP_NAME");

            entity.HasOne(d => d.FkLog).WithMany(p => p.LogGroupAudiences)
                .HasForeignKey(d => d.FkLogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOG_GROUP_AUDIENCE_LOG");
        });

        modelBuilder.Entity<LogRoleAudience>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.FkLogId });

            entity.ToTable("LOG_ROLE_AUDIENCE");

            entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");
            entity.Property(e => e.FkLogId).HasColumnName("FK_LOG_ID");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ROLE_NAME");

            entity.HasOne(d => d.FkLog).WithMany(p => p.LogRoleAudiences)
                .HasForeignKey(d => d.FkLogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOG_ROLE_AUDIENCE_LOG");
        });

        modelBuilder.Entity<LogUserAudience>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.FkLogId });

            entity.ToTable("LOG_USER_AUDIENCE");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_ID");
            entity.Property(e => e.FkLogId).HasColumnName("FK_LOG_ID");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(110)
                .IsUnicode(false)
                .HasColumnName("DISPLAY_NAME");

            entity.HasOne(d => d.FkLog).WithMany(p => p.LogUserAudiences)
                .HasForeignKey(d => d.FkLogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOG_USER_AUDIENCE_LOG");
        });

        modelBuilder.Entity<Lot>(entity =>
        {
            entity.ToTable("LOT");

            entity.HasIndex(e => e.FkProductId, "IX_LOT");

            entity.HasIndex(e => e.CreatedBy, "IX_LOT_1");

            entity.HasIndex(e => e.ModifiedBy, "IX_LOT_2");

            entity.HasIndex(e => e.Status, "IX_LOT_3");

            entity.HasIndex(e => e.LotNumber, "IX_LOT_4");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOT_NUMBER");
            entity.Property(e => e.LotSize).HasColumnName("LOT_SIZE");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.LotCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOT_USER");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.Lots)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOT_PRODUCT");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.LotModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_LOT_USER1");
        });

        modelBuilder.Entity<LotBom>(entity =>
        {
            entity.HasKey(e => new { e.FkLotId, e.FkProductId });

            entity.ToTable("LOT_BOM");

            entity.HasIndex(e => e.FkLotId, "IX_LOT_BOM");

            entity.HasIndex(e => e.FkProductId, "IX_LOT_BOM_1");

            entity.Property(e => e.FkLotId).HasColumnName("FK_LOT_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

            entity.HasOne(d => d.FkLot).WithMany(p => p.LotBoms)
                .HasForeignKey(d => d.FkLotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOT_BOM_LOT");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.LotBoms)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOT_BOM_PRODUCT");
        });

        modelBuilder.Entity<LotBomInventoryMap>(entity =>
        {
            entity.ToTable("LOT_BOM_INVENTORY_MAP");

            entity.HasIndex(e => e.FkLotId, "IX_LOT_BOM_INVENTORY_MAP");

            entity.HasIndex(e => e.FkProductId, "IX_LOT_BOM_INVENTORY_MAP_1");

            entity.HasIndex(e => e.FkInventoryId, "IX_LOT_BOM_INVENTORY_MAP_2");

            entity.HasIndex(e => e.CreatedBy, "IX_LOT_BOM_INVENTORY_MAP_3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.FkInventoryId).HasColumnName("FK_INVENTORY_ID");
            entity.Property(e => e.FkLotId).HasColumnName("FK_LOT_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.ReservedQuantity).HasColumnName("RESERVED_QUANTITY");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.LotBomInventoryMaps)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_1_USER1");

            entity.HasOne(d => d.FkInventory).WithMany(p => p.LotBomInventoryMaps)
                .HasForeignKey(d => d.FkInventoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_1_INVENTORY");

            entity.HasOne(d => d.LotBom).WithMany(p => p.LotBomInventoryMaps)
                .HasForeignKey(d => new { d.FkLotId, d.FkProductId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOT_BOM_INVENTORY_MAP_LOT_BOM");
        });

        modelBuilder.Entity<LotLog>(entity =>
        {
            entity.ToTable("LOT_LOG");

            entity.HasIndex(e => e.FkLotId, "IX_LOT_LOG");

            entity.HasIndex(e => e.CreatedBy, "IX_LOT_LOG_1");

            entity.HasIndex(e => e.FkProductId, "IX_LOT_LOG_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.FkLotId).HasColumnName("FK_LOT_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.LotLogNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LOT_LOG_NOTES");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOT_NUMBER");
            entity.Property(e => e.LotSize).HasColumnName("LOT_SIZE");
            entity.Property(e => e.Module)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.LotLogs)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOT_LOG_USER");

            entity.HasOne(d => d.FkLot).WithMany(p => p.LotLogs)
                .HasForeignKey(d => d.FkLotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOT_LOG_LOT");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.LotLogs)
                .HasForeignKey(d => d.FkProductId)
                .HasConstraintName("FK_LOT_LOG_PRODUCT");
        });

        modelBuilder.Entity<Manufacturing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_INVENTORY");

            entity.ToTable("MANUFACTURING");

            entity.HasIndex(e => e.FkProductId, "IX_INVENTORY");

            entity.HasIndex(e => e.LastModifiedBy, "IX_INVENTORY_1");

            entity.HasIndex(e => e.CreatedBy, "IX_INVENTORY_2");

            entity.HasIndex(e => e.LotNumber, "IX_INVENTORY_3");

            entity.HasIndex(e => e.ProductionDate, "IX_INVENTORY_4");

            entity.HasIndex(e => e.BatchNumber, "IX_INVENTORY_5");

            entity.HasIndex(e => e.Status, "IX_INVENTORY_6");

            entity.HasIndex(e => e.ReleasedBy, "IX_MANUFACTURING");

            entity.HasIndex(e => e.UnrestrictedBy, "IX_MANUFACTURING_1");

            entity.HasIndex(e => e.ReleasedDate, "IX_MANUFACTURING_2");

            entity.HasIndex(e => e.UnrestrictedDate, "IX_MANUFACTURING_3");

            entity.HasIndex(e => e.FkInventoryLocationId, "IX_MANUFACTURING_4");

            entity.HasIndex(e => e.FkProductionScheduleId, "IX_MANUFACTURING_5");

            entity.HasIndex(e => e.FkLotId, "IX_MANUFACTURING_6");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BatchNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BATCH_NUMBER");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CurrentQuantity)
                .HasDefaultValue(0)
                .HasColumnName("CURRENT_QUANTITY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.EndTime)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("END_TIME");
            entity.Property(e => e.ExpDate).HasColumnName("EXP_DATE");
            entity.Property(e => e.FinalProductionQuantity).HasColumnName("FINAL_PRODUCTION_QUANTITY");
            entity.Property(e => e.FkInventoryLocationId).HasColumnName("FK_INVENTORY_LOCATION_ID");
            entity.Property(e => e.FkLotId).HasColumnName("FK_LOT_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkProductionScheduleId).HasColumnName("FK_PRODUCTION_SCHEDULE_ID");
            entity.Property(e => e.InspectedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("INSPECTED_BY");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(false)
                .HasColumnName("IS_DELETED");
            entity.Property(e => e.LastModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAST_MODIFIED_BY");
            entity.Property(e => e.LastModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("LAST_MODIFIED_DATE");
            entity.Property(e => e.LotNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LOT_NOTES");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOT_NUMBER");
            entity.Property(e => e.MovementAdjustment).HasColumnName("MOVEMENT_ADJUSTMENT");
            entity.Property(e => e.MovementNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MOVEMENT_NOTES");
            entity.Property(e => e.ProductionDate).HasColumnName("PRODUCTION_DATE");
            entity.Property(e => e.ProductionQuantity).HasColumnName("PRODUCTION_QUANTITY");
            entity.Property(e => e.QcNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("QC_NOTES");
            entity.Property(e => e.QcQuantity).HasColumnName("QC_QUANTITY");
            entity.Property(e => e.ReleaseNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("RELEASE_NOTES");
            entity.Property(e => e.ReleasedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELEASED_BY");
            entity.Property(e => e.ReleasedDate)
                .HasColumnType("datetime")
                .HasColumnName("RELEASED_DATE");
            entity.Property(e => e.ResourcesNames)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("RESOURCES_NAMES");
            entity.Property(e => e.ResourcesNumber).HasColumnName("RESOURCES_NUMBER");
            entity.Property(e => e.RestrictedQuantity).HasColumnName("RESTRICTED_QUANTITY");
            entity.Property(e => e.StartTime)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("START_TIME");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.UnrestrictedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNRESTRICTED_BY");
            entity.Property(e => e.UnrestrictedDate)
                .HasColumnType("datetime")
                .HasColumnName("UNRESTRICTED_DATE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ManufacturingCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTORY_USER");

            entity.HasOne(d => d.FkInventoryLocation).WithMany(p => p.Manufacturings)
                .HasForeignKey(d => d.FkInventoryLocationId)
                .HasConstraintName("FK_INVENTORY_LOCATION_MANUFACTURING");

            entity.HasOne(d => d.FkLot).WithMany(p => p.Manufacturings)
                .HasForeignKey(d => d.FkLotId)
                .HasConstraintName("FK_LOT_MANUFACTURING");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.Manufacturings)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INVENTORY_PRODUCT");

            entity.HasOne(d => d.FkProductionSchedule).WithMany(p => p.Manufacturings)
                .HasForeignKey(d => d.FkProductionScheduleId)
                .HasConstraintName("FK_PRODUCTION_SCHEDULE_MANUFACTURING");

            entity.HasOne(d => d.LastModifiedByNavigation).WithMany(p => p.ManufacturingLastModifiedByNavigations)
                .HasForeignKey(d => d.LastModifiedBy)
                .HasConstraintName("FK_INVENTORY_USER1");

            entity.HasOne(d => d.ReleasedByNavigation).WithMany(p => p.ManufacturingReleasedByNavigations)
                .HasForeignKey(d => d.ReleasedBy)
                .HasConstraintName("FK_MANUFACTURING_USER");

            entity.HasOne(d => d.UnrestrictedByNavigation).WithMany(p => p.ManufacturingUnrestrictedByNavigations)
                .HasForeignKey(d => d.UnrestrictedBy)
                .HasConstraintName("FK_MANUFACTURING_USER1");
        });

        modelBuilder.Entity<ManufacturingBom>(entity =>
        {
            entity.HasKey(e => new { e.FkManufacturingId, e.FkProductId });

            entity.ToTable("MANUFACTURING_BOM");

            entity.HasIndex(e => e.FkManufacturingId, "IX_MANUFACTURING_BOM");

            entity.HasIndex(e => e.FkProductId, "IX_MANUFACTURING_BOM_1");

            entity.Property(e => e.FkManufacturingId).HasColumnName("FK_MANUFACTURING_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

            entity.HasOne(d => d.FkManufacturing).WithMany(p => p.ManufacturingBoms)
                .HasForeignKey(d => d.FkManufacturingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MANUFACTURING_BOM_MANUFACTURING");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.ManufacturingBoms)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MANUFACTURING_BOM_PRODUCT");
        });

        modelBuilder.Entity<ManufacturingBomInventoryMap>(entity =>
        {
            entity.ToTable("MANUFACTURING_BOM_INVENTORY_MAP");

            entity.HasIndex(e => e.FkManufacturingId, "IX_MANUFACTURING_BOM_INVENTORY_MAP");

            entity.HasIndex(e => e.FkProductId, "IX_MANUFACTURING_BOM_INVENTORY_MAP_1");

            entity.HasIndex(e => e.FkInventoryId, "IX_MANUFACTURING_BOM_INVENTORY_MAP_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConsumedQuantity).HasColumnName("CONSUMED_QUANTITY");
            entity.Property(e => e.FkInventoryId).HasColumnName("FK_INVENTORY_ID");
            entity.Property(e => e.FkManufacturingId).HasColumnName("FK_MANUFACTURING_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.PulledQuantity).HasColumnName("PULLED_QUANTITY");
            entity.Property(e => e.ReturnedQuantity).HasColumnName("RETURNED_QUANTITY");
            entity.Property(e => e.TicketQuantity).HasColumnName("TICKET_QUANTITY");

            entity.HasOne(d => d.FkInventory).WithMany(p => p.ManufacturingBomInventoryMaps)
                .HasForeignKey(d => d.FkInventoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MANUFACTURING_BOM_INVENTORY_MAP_INVENTORY");

            entity.HasOne(d => d.ManufacturingBom).WithMany(p => p.ManufacturingBomInventoryMaps)
                .HasForeignKey(d => new { d.FkManufacturingId, d.FkProductId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MANUFACTURING_BOM_INVENTORY_MAP_MANUFACTURING_BOM");
        });

        modelBuilder.Entity<ManufacturingLog>(entity =>
        {
            entity.ToTable("MANUFACTURING_LOG");

            entity.HasIndex(e => e.FkManufacturingId, "IX_MANUFACTURING_LOG");

            entity.HasIndex(e => e.CreatedBy, "IX_MANUFACTURING_LOG_1");

            entity.HasIndex(e => e.ReleasedBy, "IX_MANUFACTURING_LOG_2");

            entity.HasIndex(e => e.FkInventoryLocationId, "IX_MANUFACTURING_LOG_3");

            entity.HasIndex(e => e.ProductionDate, "IX_MANUFACTURING_LOG_4");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.ExpDate).HasColumnName("EXP_DATE");
            entity.Property(e => e.FinalProductionQuantity).HasColumnName("FINAL_PRODUCTION_QUANTITY");
            entity.Property(e => e.FkInventoryLocationId).HasColumnName("FK_INVENTORY_LOCATION_ID");
            entity.Property(e => e.FkManufacturingId).HasColumnName("FK_MANUFACTURING_ID");
            entity.Property(e => e.LotNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LOT_NOTES");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOT_NUMBER");
            entity.Property(e => e.ManufacturingLogNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MANUFACTURING_LOG_NOTES");
            entity.Property(e => e.Module)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.MovementAdjustment).HasColumnName("MOVEMENT_ADJUSTMENT");
            entity.Property(e => e.MovementNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MOVEMENT_NOTES");
            entity.Property(e => e.ProductionDate).HasColumnName("PRODUCTION_DATE");
            entity.Property(e => e.ProductionQuantity).HasColumnName("PRODUCTION_QUANTITY");
            entity.Property(e => e.QcNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("QC_NOTES");
            entity.Property(e => e.QcQuantity).HasColumnName("QC_QUANTITY");
            entity.Property(e => e.ReleaseNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("RELEASE_NOTES");
            entity.Property(e => e.ReleasedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RELEASED_BY");
            entity.Property(e => e.RestrictedQuantity).HasColumnName("RESTRICTED_QUANTITY");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ManufacturingLogCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MANUFACTURING_LOG_USER");

            entity.HasOne(d => d.FkInventoryLocation).WithMany(p => p.ManufacturingLogs)
                .HasForeignKey(d => d.FkInventoryLocationId)
                .HasConstraintName("FK_MANUFACTURING_LOG_INVENTORY_LOCATION");

            entity.HasOne(d => d.FkManufacturing).WithMany(p => p.ManufacturingLogs)
                .HasForeignKey(d => d.FkManufacturingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MANUFACTURING_LOG_MANUFACTURING");

            entity.HasOne(d => d.ReleasedByNavigation).WithMany(p => p.ManufacturingLogReleasedByNavigations)
                .HasForeignKey(d => d.ReleasedBy)
                .HasConstraintName("FK_MANUFACTURING_LOG_USER1");
        });

        modelBuilder.Entity<MasterDataLog>(entity =>
        {
            entity.HasKey(e => e.MasterDataLogId).HasName("PK_MASTER_DATA_LOGS");

            entity.ToTable("MASTER_DATA_LOG");

            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FileName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MasterGroup>(entity =>
        {
            entity.ToTable("MASTER_GROUP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.IsCore).HasColumnName("IS_CORE");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.TemporaryCode)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("TEMPORARY_CODE");
        });

        modelBuilder.Entity<MasterRole>(entity =>
        {
            entity.ToTable("MASTER_ROLE");

            entity.HasIndex(e => e.RoleType, "IX_MASTER_ROLE_1");

            entity.HasIndex(e => e.PermissionType, "IX_MASTER_ROLE_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.IsCore).HasColumnName("IS_CORE");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.PermissionType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PERMISSION_TYPE");
            entity.Property(e => e.RoleType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ROLE_TYPE");
            entity.Property(e => e.TemporaryCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEMPORARY_CODE");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.ToTable("MATERIAL");

            entity.HasIndex(e => e.Name, "IX_MATERIAL");

            entity.HasIndex(e => e.MaterialCode, "IX_MATERIAL_1");

            entity.HasIndex(e => e.TargetPrice, "IX_MATERIAL_3");

            entity.HasIndex(e => e.ModifiedBy, "IX_MATERIAL_4");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.MaterialCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MATERIAL_CODE");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.TargetPrice).HasColumnName("TARGET_PRICE");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.Materials)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_MODIFIED_BY");
        });

        modelBuilder.Entity<MiscellaneousCharge>(entity =>
        {
            entity.ToTable("MISCELLANEOUS_CHARGE");

            entity.HasIndex(e => e.Name, "IX_MISCELLANEOUS_CHARGE_1");

            entity.HasIndex(e => e.AweCode, "IX_MISCELLANEOUS_CHARGE_10");

            entity.HasIndex(e => e.AweRecordId, "IX_MISCELLANEOUS_CHARGE_11");

            entity.HasIndex(e => e.Code, "IX_MISCELLANEOUS_CHARGE_2");

            entity.HasIndex(e => e.Description, "IX_MISCELLANEOUS_CHARGE_3");

            entity.HasIndex(e => e.DateCreated, "IX_MISCELLANEOUS_CHARGE_4");

            entity.HasIndex(e => e.CreatedBy, "IX_MISCELLANEOUS_CHARGE_5");

            entity.HasIndex(e => e.DateModified, "IX_MISCELLANEOUS_CHARGE_6");

            entity.HasIndex(e => e.ModifiedBy, "IX_MISCELLANEOUS_CHARGE_7");

            entity.HasIndex(e => e.Status, "IX_MISCELLANEOUS_CHARGE_8");

            entity.HasIndex(e => e.DefaultValue, "IX_MISCELLANEOUS_CHARGE_9");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AweCode)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("AWE_CODE");
            entity.Property(e => e.AweRecordId).HasColumnName("AWE_RECORD_ID");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DefaultValue).HasColumnName("DEFAULT_VALUE");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.MiscellaneousChargeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MISCELLANEOUS_CHARGE_USER_1");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.MiscellaneousChargeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_MISCELLANEOUS_CHARGE_USER_2");
        });

        modelBuilder.Entity<MultiFactorAuthToken>(entity =>
        {
            entity.ToTable("MULTI_FACTOR_AUTH_TOKEN");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CodeRetryCount)
                .HasDefaultValue(0)
                .HasColumnName("CODE_RETRY_COUNT");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.IsMfaEnabled).HasColumnName("IS_MFA_ENABLED");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.MultiFactorAuthTokens)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MULTI_FACTOR_AUTH_TOKEN_CUSTOMER");

            entity.HasOne(d => d.FkUser).WithMany(p => p.MultiFactorAuthTokens)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MULTI_FACTOR_AUTH_TOKEN_USER");
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.ToTable("NOTES");

            entity.HasIndex(e => e.CreatedBy, "IX_NOTES");

            entity.HasIndex(e => e.Module, "IX_NOTES_1");

            entity.HasIndex(e => e.FkCustomerId, "IX_NOTES_2");

            entity.HasIndex(e => e.FkOrderId, "IX_NOTES_3");

            entity.HasIndex(e => e.FkCustomerAddressId, "IX_NOTES_4");

            entity.HasIndex(e => e.FkRecurrenceId, "IX_NOTES_5");

            entity.HasIndex(e => e.FkServiceRequestId, "IX_NOTES_6");

            entity.HasIndex(e => e.FkInvoiceId, "IX_NOTES_7");

            entity.HasIndex(e => e.FkProductId, "IX_NOTES_8");

            entity.HasIndex(e => e.FkOrderCodeId, "IX_NOTES_9");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkInvoiceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FK_INVOICE_ID");
            entity.Property(e => e.FkOrderCodeId).HasColumnName("FK_ORDER_CODE_ID");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkRecurrenceId).HasColumnName("FK_RECURRENCE_ID");
            entity.Property(e => e.FkServiceRequestId).HasColumnName("FK_SERVICE_REQUEST_ID");
            entity.Property(e => e.Module)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.Notes)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
            entity.Property(e => e.TargetColumn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TARGET_COLUMN");
            entity.Property(e => e.Type)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Notes)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NOTES_USER");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.NotesNavigation)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_NOTES");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.Notes)
                .HasForeignKey(d => d.FkCustomerId)
                .HasConstraintName("FK_NOTES_CUSTOMER");

            entity.HasOne(d => d.FkInvoice).WithMany(p => p.NotesNavigation)
                .HasForeignKey(d => d.FkInvoiceId)
                .HasConstraintName("FK_INVOICE_NOTES");

            entity.HasOne(d => d.FkOrderCode).WithMany(p => p.Notes)
                .HasForeignKey(d => d.FkOrderCodeId)
                .HasConstraintName("FK_NOTES_ORDER_CODE");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.Notes)
                .HasForeignKey(d => d.FkOrderId)
                .HasConstraintName("FK_NOTES_ORDER");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.Notes)
                .HasForeignKey(d => d.FkProductId)
                .HasConstraintName("FK_NOTES_PRODUCT");

            entity.HasOne(d => d.FkRecurrence).WithMany(p => p.Notes)
                .HasForeignKey(d => d.FkRecurrenceId)
                .HasConstraintName("FK_RECURRENCE_NOTES");

            entity.HasOne(d => d.FkServiceRequest).WithMany(p => p.NotesNavigation)
                .HasForeignKey(d => d.FkServiceRequestId)
                .HasConstraintName("FK_SERVICE_REQUEST_NOTES");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasFillFactor(80);

            entity.ToTable("ORDER");

            entity.HasIndex(e => e.FkShipmentId, "IX_ORDER").HasFillFactor(80);

            entity.HasIndex(e => e.FkUserId, "IX_ORDER_1").HasFillFactor(80);

            entity.HasIndex(e => e.ReferenceId, "IX_ORDER_10").HasFillFactor(80);

            entity.HasIndex(e => e.DateSubmitted, "IX_ORDER_11").HasFillFactor(80);

            entity.HasIndex(e => e.DateProcessed, "IX_ORDER_12").HasFillFactor(80);

            entity.HasIndex(e => e.GroupId, "IX_ORDER_13").HasFillFactor(80);

            entity.HasIndex(e => e.ShipSiteId, "IX_ORDER_14").HasFillFactor(80);

            entity.HasIndex(e => e.OrderNumber, "IX_ORDER_15").HasFillFactor(80);

            entity.HasIndex(e => e.ShipSiteName, "IX_ORDER_16").HasFillFactor(80);

            entity.HasIndex(e => e.IsRushOrder, "IX_ORDER_17").HasFillFactor(80);

            entity.HasIndex(e => e.Comments, "IX_ORDER_18").HasFillFactor(80);

            entity.HasIndex(e => e.DateShipped, "IX_ORDER_19").HasFillFactor(80);

            entity.HasIndex(e => e.FkCustomerId, "IX_ORDER_2").HasFillFactor(80);

            entity.HasIndex(e => e.ReasonByUserid, "IX_ORDER_22").HasFillFactor(80);

            entity.HasIndex(e => e.IsService1, "IX_ORDER_23").HasFillFactor(80);

            entity.HasIndex(e => e.CancelledBy, "IX_ORDER_24").HasFillFactor(80);

            entity.HasIndex(e => e.OrderStatus, "IX_ORDER_25").HasFillFactor(80);

            entity.HasIndex(e => e.ShipAddrCode, "IX_ORDER_26").HasFillFactor(80);

            entity.HasIndex(e => e.SendNotification, "IX_ORDER_27").HasFillFactor(80);

            entity.HasIndex(e => e.InvoiceMailIntegration, "IX_ORDER_28").HasFillFactor(80);

            entity.HasIndex(e => e.UserLegacyId, "IX_ORDER_3").HasFillFactor(80);

            entity.HasIndex(e => e.Tickref, "IX_ORDER_30")
                .IsUnique()
                .HasFillFactor(80);

            entity.HasIndex(e => e.FkUserTransactionId, "IX_ORDER_4").HasFillFactor(80);

            entity.HasIndex(e => e.FkSupplierVendorId, "IX_ORDER_5").HasFillFactor(80);

            entity.HasIndex(e => e.Type, "IX_ORDER_6").HasFillFactor(80);

            entity.HasIndex(e => e.OrderSource, "IX_ORDER_7").HasFillFactor(80);

            entity.HasIndex(e => e.LegacyId, "IX_ORDER_8").HasFillFactor(80);

            entity.HasIndex(e => e.WarningBit, "IX_ORDER_9").HasFillFactor(80);

            entity.Property(e => e.Id)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.ApprovedForInvoicingBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APPROVED_FOR_INVOICING_BY");
            entity.Property(e => e.AttentionLine)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ATTENTION_LINE");
            entity.Property(e => e.AweProcessFlag).HasColumnName("AWE_PROCESS_FLAG");
            entity.Property(e => e.BillAddrCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_CITY");
            entity.Property(e => e.BillAddrContactPerson)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_CONTACT_PERSON");
            entity.Property(e => e.BillAddrCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_COUNTRY");
            entity.Property(e => e.BillAddrCountryCodeAlpha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_COUNTRY_CODE_ALPHA");
            entity.Property(e => e.BillAddrCountryCodeDigit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_COUNTRY_CODE_DIGIT");
            entity.Property(e => e.BillAddrState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_STATE");
            entity.Property(e => e.BillAddrStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_STREET");
            entity.Property(e => e.BillAddrZipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_ZIPCODE");
            entity.Property(e => e.BillingAddrStreet2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BILLING_ADDR_STREET2");
            entity.Property(e => e.BillingAddrStreet3)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("BILLING_ADDR_STREET3");
            entity.Property(e => e.CancelledBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANCELLED_BY");
            entity.Property(e => e.CcTransactionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CC_TRANSACTION_ID");
            entity.Property(e => e.Comments)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.Comments1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS1");
            entity.Property(e => e.Comments10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS10");
            entity.Property(e => e.Comments11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS11");
            entity.Property(e => e.Comments12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS12");
            entity.Property(e => e.Comments13)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS13");
            entity.Property(e => e.Comments14)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS14");
            entity.Property(e => e.Comments15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS15");
            entity.Property(e => e.Comments16)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS16");
            entity.Property(e => e.Comments17)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS17");
            entity.Property(e => e.Comments18)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS18");
            entity.Property(e => e.Comments19)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS19");
            entity.Property(e => e.Comments2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS2");
            entity.Property(e => e.Comments20)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS20");
            entity.Property(e => e.Comments3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS3");
            entity.Property(e => e.Comments4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS4");
            entity.Property(e => e.Comments5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS5");
            entity.Property(e => e.Comments6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS6");
            entity.Property(e => e.Comments7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS7");
            entity.Property(e => e.Comments8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS8");
            entity.Property(e => e.Comments9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMMENTS9");
            entity.Property(e => e.CompletedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COMPLETED_BY");
            entity.Property(e => e.CreditAuthorizationCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREDIT_AUTHORIZATION_CODE");
            entity.Property(e => e.CreditCheckedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREDIT_CHECKED_BY");
            entity.Property(e => e.CreditCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CREDIT_CODE");
            entity.Property(e => e.CustomerTerms)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_TERMS");
            entity.Property(e => e.DateAssigned)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ASSIGNED");
            entity.Property(e => e.DateBilled)
                .HasColumnType("datetime")
                .HasColumnName("DATE_BILLED");
            entity.Property(e => e.DateCancelled)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CANCELLED");
            entity.Property(e => e.DateCompleted)
                .HasColumnType("datetime")
                .HasColumnName("DATE_COMPLETED");
            entity.Property(e => e.DateDelivered)
                .HasColumnType("datetime")
                .HasColumnName("DATE_DELIVERED");
            entity.Property(e => e.DateLoaded)
                .HasColumnType("datetime")
                .HasColumnName("DATE_LOADED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DateOnboarded)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ONBOARDED");
            entity.Property(e => e.DateProcessed)
                .HasColumnType("datetime")
                .HasColumnName("DATE_PROCESSED");
            entity.Property(e => e.DateReturned)
                .HasColumnType("datetime")
                .HasColumnName("DATE_RETURNED");
            entity.Property(e => e.DateReviewed)
                .HasColumnType("datetime")
                .HasColumnName("DATE_REVIEWED");
            entity.Property(e => e.DateShipped)
                .HasColumnType("datetime")
                .HasColumnName("DATE_SHIPPED");
            entity.Property(e => e.DateSubmitted)
                .HasColumnType("datetime")
                .HasColumnName("DATE_SUBMITTED");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY_DATE");
            entity.Property(e => e.DeliveryDateNote)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_DATE_NOTE");
            entity.Property(e => e.DeliveryStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DELIVERY_STATUS");
            entity.Property(e => e.Fill)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FILL");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkCustomerIdBill).HasColumnName("FK_CUSTOMER_ID_BILL");
            entity.Property(e => e.FkCustomerIdShip).HasColumnName("FK_CUSTOMER_ID_SHIP");
            entity.Property(e => e.FkRecurrenceId).HasColumnName("FK_RECURRENCE_ID");
            entity.Property(e => e.FkShipTypeId).HasColumnName("FK_SHIP_TYPE_ID");
            entity.Property(e => e.FkShipVendorId).HasColumnName("FK_SHIP_VENDOR_ID");
            entity.Property(e => e.FkShipmentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FK_SHIPMENT_ID");
            entity.Property(e => e.FkSupplierVendorId).HasColumnName("FK_SUPPLIER_VENDOR_ID");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.FkUserTransactionId).HasColumnName("FK_USER_TRANSACTION_ID");
            entity.Property(e => e.Flags)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FLAGS");
            entity.Property(e => e.Gn)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GN");
            entity.Property(e => e.GrossPrice).HasColumnName("GROSS_PRICE");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.IntlContactEmail)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("INTL_CONTACT_EMAIL");
            entity.Property(e => e.IntlContactName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("INTL_CONTACT_NAME");
            entity.Property(e => e.IntlContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INTL_CONTACT_NUMBER");
            entity.Property(e => e.InvoiceMailIntegration)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INVOICE_MAIL_INTEGRATION");
            entity.Property(e => e.InvoicedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INVOICED_BY");
            entity.Property(e => e.IsAdminCreated).HasColumnName("IS_ADMIN_CREATED");
            entity.Property(e => e.IsAwePricing).HasColumnName("IS_AWE_PRICING");
            entity.Property(e => e.IsCreditChecked).HasColumnName("IS_CREDIT_CHECKED");
            entity.Property(e => e.IsFinalReviewed).HasColumnName("IS_FINAL_REVIEWED");
            entity.Property(e => e.IsInternationalOrder).HasColumnName("IS_INTERNATIONAL_ORDER");
            entity.Property(e => e.IsReasonByAdmin).HasColumnName("IS_REASON_BY_ADMIN");
            entity.Property(e => e.IsRepricable).HasColumnName("IS_REPRICABLE");
            entity.Property(e => e.IsRushOrder).HasColumnName("IS_RUSH_ORDER");
            entity.Property(e => e.IsService1).HasColumnName("IS_SERVICE_1");
            entity.Property(e => e.IsShippingGrouped).HasColumnName("IS_SHIPPING_GROUPED");
            entity.Property(e => e.ItemNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM_NUMBER");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ID");
            entity.Property(e => e.LegacyIdType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ID_TYPE");
            entity.Property(e => e.LegacyTotalCharged)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("LEGACY_TOTAL_CHARGED");
            entity.Property(e => e.LegacyTotalCost)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("LEGACY_TOTAL_COST");
            entity.Property(e => e.LegacyTotalMisc)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("LEGACY_TOTAL_MISC");
            entity.Property(e => e.LegacyTotalMiscTax)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("LEGACY_TOTAL_MISC_TAX");
            entity.Property(e => e.LegacyTotalTax)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("LEGACY_TOTAL_TAX");
            entity.Property(e => e.LegacyTypeId).HasColumnName("LEGACY_TYPE_ID");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORDER_NUMBER");
            entity.Property(e => e.OrderSource)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORDER_SOURCE");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORDER_STATUS");
            entity.Property(e => e.PaymentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_ID");
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_OPTION");
            entity.Property(e => e.PaymentTermCode)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_TERM_CODE");
            entity.Property(e => e.PaymentTermId).HasColumnName("PAYMENT_TERM_ID");
            entity.Property(e => e.PoNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PO_NUMBER");
            entity.Property(e => e.PresetAmount).HasColumnName("PRESET_AMOUNT");
            entity.Property(e => e.PresetVolume).HasColumnName("PRESET_VOLUME");
            entity.Property(e => e.PriceCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_CODE");
            entity.Property(e => e.Priority)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PRIORITY");
            entity.Property(e => e.Rank).HasColumnName("RANK");
            entity.Property(e => e.Reason)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("REASON");
            entity.Property(e => e.ReasonByUserid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REASON_BY_USERID");
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFERENCE_ID");
            entity.Property(e => e.RemittanceCopyToPrint).HasColumnName("REMITTANCE_COPY_TO_PRINT");
            entity.Property(e => e.RequisitionNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REQUISITION_NUMBER");
            entity.Property(e => e.ReturnCode).HasColumnName("RETURN_CODE");
            entity.Property(e => e.ReturnReason)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RETURN_REASON");
            entity.Property(e => e.SapOrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SAP_ORDER_NUMBER");
            entity.Property(e => e.SendNotification).HasColumnName("SEND_NOTIFICATION");
            entity.Property(e => e.ShipAddrCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_CITY");
            entity.Property(e => e.ShipAddrCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_CODE");
            entity.Property(e => e.ShipAddrCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_COUNTRY");
            entity.Property(e => e.ShipAddrCountryCodeAlpha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_COUNTRY_CODE_ALPHA");
            entity.Property(e => e.ShipAddrCountryCodeDigit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_COUNTRY_CODE_DIGIT");
            entity.Property(e => e.ShipAddrDeliveryCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_DELIVERY_CODE");
            entity.Property(e => e.ShipAddrDriverId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_DRIVER_ID");
            entity.Property(e => e.ShipAddrDueDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_DUE_DATE");
            entity.Property(e => e.ShipAddrForecastingProjection).HasColumnName("SHIP_ADDR_FORECASTING_PROJECTION");
            entity.Property(e => e.ShipAddrIdealVolume)
                .HasColumnType("decimal(13, 1)")
                .HasColumnName("SHIP_ADDR_IDEAL_VOLUME");
            entity.Property(e => e.ShipAddrKFactor)
                .HasColumnType("decimal(13, 4)")
                .HasColumnName("SHIP_ADDR_K_FACTOR");
            entity.Property(e => e.ShipAddrLastDeliveryDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_LAST_DELIVERY_DATE");
            entity.Property(e => e.ShipAddrLastDeliveryVolume)
                .HasColumnType("decimal(13, 1)")
                .HasColumnName("SHIP_ADDR_LAST_DELIVERY_VOLUME");
            entity.Property(e => e.ShipAddrLatitude)
                .HasColumnType("decimal(13, 8)")
                .HasColumnName("SHIP_ADDR_LATITUDE");
            entity.Property(e => e.ShipAddrLlType).HasColumnName("SHIP_ADDR_LL_TYPE");
            entity.Property(e => e.ShipAddrLongitude)
                .HasColumnType("decimal(13, 8)")
                .HasColumnName("SHIP_ADDR_LONGITUDE");
            entity.Property(e => e.ShipAddrMapCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_MAP_CODE");
            entity.Property(e => e.ShipAddrNumTanks).HasColumnName("SHIP_ADDR_NUM_TANKS");
            entity.Property(e => e.ShipAddrPrevBalance)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("SHIP_ADDR_PREV_BALANCE");
            entity.Property(e => e.ShipAddrRecepientEmail)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_RECEPIENT_EMAIL");
            entity.Property(e => e.ShipAddrRecepientName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_RECEPIENT_NAME");
            entity.Property(e => e.ShipAddrRecepientNumber)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_RECEPIENT_NUMBER");
            entity.Property(e => e.ShipAddrRegion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_REGION");
            entity.Property(e => e.ShipAddrSchedCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_SCHED_CODE");
            entity.Property(e => e.ShipAddrState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_STATE");
            entity.Property(e => e.ShipAddrStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_STREET");
            entity.Property(e => e.ShipAddrStreet2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_STREET2");
            entity.Property(e => e.ShipAddrStreet3)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_STREET3");
            entity.Property(e => e.ShipAddrTankId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_TANK_ID");
            entity.Property(e => e.ShipAddrTankSize)
                .HasColumnType("decimal(13, 1)")
                .HasColumnName("SHIP_ADDR_TANK_SIZE");
            entity.Property(e => e.ShipAddrTaxGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_TAX_GROUP");
            entity.Property(e => e.ShipAddrTruckId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_TRUCK_ID");
            entity.Property(e => e.ShipAddrZipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_ZIPCODE");
            entity.Property(e => e.ShipAddrZone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_ZONE");
            entity.Property(e => e.ShipSiteId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_SITE_ID");
            entity.Property(e => e.ShipSiteName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SHIP_SITE_NAME");
            entity.Property(e => e.TaxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAX_ID");
            entity.Property(e => e.TicketCopyToPrint).HasColumnName("TICKET_COPY_TO_PRINT");
            entity.Property(e => e.Tickref)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TICKREF");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.UrgencyFactor).HasColumnName("URGENCY_FACTOR");
            entity.Property(e => e.UserLegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_LEGACY_ID");
            entity.Property(e => e.WarningBit).HasColumnName("WARNING_BIT");

            entity.HasOne(d => d.CancelledByNavigation).WithMany(p => p.OrderCancelledByNavigations)
                .HasForeignKey(d => d.CancelledBy)
                .HasConstraintName("FK_USER_ORDER_2");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.OrderFkCustomers)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_CUSTOMER");

            entity.HasOne(d => d.FkCustomerIdBillNavigation).WithMany(p => p.OrderFkCustomerIdBillNavigations)
                .HasForeignKey(d => d.FkCustomerIdBill)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_CUSTOMER_BILL");

            entity.HasOne(d => d.FkCustomerIdShipNavigation).WithMany(p => p.OrderFkCustomerIdShipNavigations)
                .HasForeignKey(d => d.FkCustomerIdShip)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_CUSTOMER_SHIP");

            entity.HasOne(d => d.FkRecurrence).WithMany(p => p.Orders)
                .HasForeignKey(d => d.FkRecurrenceId)
                .HasConstraintName("FK__ORDER__FK_RECURR__71F1E3A2");

            entity.HasOne(d => d.FkShipType).WithMany(p => p.Orders)
                .HasForeignKey(d => d.FkShipTypeId)
                .HasConstraintName("FK_ORDER_SHIPPING_TYPES");

            entity.HasOne(d => d.FkShipVendor).WithMany(p => p.Orders)
                .HasForeignKey(d => d.FkShipVendorId)
                .HasConstraintName("FK_ORDER_SHIPPING_VENDOR");

            entity.HasOne(d => d.FkShipment).WithMany(p => p.Orders)
                .HasForeignKey(d => d.FkShipmentId)
                .HasConstraintName("FK_ORDER_SHIPMENT");

            entity.HasOne(d => d.FkSupplierVendor).WithMany(p => p.Orders)
                .HasForeignKey(d => d.FkSupplierVendorId)
                .HasConstraintName("FK_ORDER_SUPPLIER_VENDOR");

            entity.HasOne(d => d.FkUser).WithMany(p => p.OrderFkUsers)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_USER");

            entity.HasOne(d => d.ReasonByUser).WithMany(p => p.OrderReasonByUsers)
                .HasForeignKey(d => d.ReasonByUserid)
                .HasConstraintName("FK_USER_ORDER_1");

            entity.HasMany(d => d.FkShipments).WithMany(p => p.FkOrders)
                .UsingEntity<Dictionary<string, object>>(
                    "OrderShipmentMap",
                    r => r.HasOne<Shipment>().WithMany()
                        .HasForeignKey("FkShipmentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ORDER_SHIPMENT_MAP_SHIPMENT_ID"),
                    l => l.HasOne<Order>().WithMany()
                        .HasForeignKey("FkOrderId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ORDER_SHIPMENT_MAP_ORDER_ID"),
                    j =>
                    {
                        j.HasKey("FkOrderId", "FkShipmentId");
                        j.ToTable("ORDER_SHIPMENT_MAP");
                        j.IndexerProperty<string>("FkOrderId")
                            .HasMaxLength(40)
                            .IsUnicode(false)
                            .HasColumnName("FK_ORDER_ID");
                        j.IndexerProperty<string>("FkShipmentId")
                            .HasMaxLength(20)
                            .IsUnicode(false)
                            .HasColumnName("FK_SHIPMENT_ID");
                    });

            entity.HasMany(d => d.FkShippings).WithMany(p => p.FkOrders)
                .UsingEntity<Dictionary<string, object>>(
                    "OrderShippingMap",
                    r => r.HasOne<Shipping>().WithMany()
                        .HasForeignKey("FkShippingId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ORDER_SHIPPING_MAP_SHIPPING"),
                    l => l.HasOne<Order>().WithMany()
                        .HasForeignKey("FkOrderId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ORDER_SHIPPING_MAP_ORDER"),
                    j =>
                    {
                        j.HasKey("FkOrderId", "FkShippingId");
                        j.ToTable("ORDER_SHIPPING_MAP");
                        j.HasIndex(new[] { "FkOrderId" }, "IX_ORDER_SHIPPING_MAP");
                        j.HasIndex(new[] { "FkShippingId" }, "IX_ORDER_SHIPPING_MAP_1");
                        j.IndexerProperty<string>("FkOrderId")
                            .HasMaxLength(40)
                            .IsUnicode(false)
                            .HasColumnName("FK_ORDER_ID");
                        j.IndexerProperty<int>("FkShippingId").HasColumnName("FK_SHIPPING_ID");
                    });
        });

        modelBuilder.Entity<OrderAsset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ORDER_AS__3214EC27E15FAD62");

            entity.ToTable("ORDER_ASSET");

            entity.HasIndex(e => e.FkOrderId, "IX_ORDER_ASSET");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Filename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FILENAME");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Url)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.OrderAssets)
                .HasForeignKey(d => d.FkOrderId)
                .HasConstraintName("FK__ORDER_ASS__FK_OR__16B953FD");
        });

        modelBuilder.Entity<OrderCharge>(entity =>
        {
            entity.ToTable("ORDER_CHARGES");

            entity.HasIndex(e => e.FkVarianceId, "IX_ORDER_CHARGES");

            entity.HasIndex(e => e.FkOrderId, "IX_ORDER_CHARGES_1");

            entity.HasIndex(e => e.FkProductId, "IX_ORDER_CHARGES_2");

            entity.HasIndex(e => e.DescriptionAwe, "IX_ORDER_CHARGES_4");

            entity.HasIndex(e => e.ChargeRateFull, "IX_ORDER_CHARGES_5");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.ChargeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CHARGE_CODE");
            entity.Property(e => e.ChargeExemption).HasColumnName("CHARGE_EXEMPTION");
            entity.Property(e => e.ChargeRate).HasColumnName("CHARGE_RATE");
            entity.Property(e => e.ChargeRateFull).HasColumnName("CHARGE_RATE_FULL");
            entity.Property(e => e.ChargeSequence).HasColumnName("CHARGE_SEQUENCE");
            entity.Property(e => e.ChargeValue1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CHARGE_VALUE_1");
            entity.Property(e => e.Classification)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CLASSIFICATION");
            entity.Property(e => e.ConfirmedAmount).HasColumnName("CONFIRMED_AMOUNT");
            entity.Property(e => e.CouponId).HasColumnName("COUPON_ID");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.DescriptionAwe)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION_AWE");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkVarianceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FK_VARIANCE_ID");
            entity.Property(e => e.PromotionCode)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PROMOTION_CODE");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.OrderCharges)
                .HasForeignKey(d => d.FkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_CHARGES_ORDER");
        });

        modelBuilder.Entity<OrderCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ORDER_CO__3214EC270C59D574");

            entity.ToTable("ORDER_CODE");

            entity.HasIndex(e => e.Code, "IX_ORDER_CODE_1");

            entity.HasIndex(e => e.DateModified, "IX_ORDER_CODE_10");

            entity.HasIndex(e => e.Type, "IX_ORDER_CODE_2");

            entity.HasIndex(e => e.TransactionType, "IX_ORDER_CODE_3");

            entity.HasIndex(e => e.DescriptionEng, "IX_ORDER_CODE_4");

            entity.HasIndex(e => e.DescriptionFrn, "IX_ORDER_CODE_5");

            entity.HasIndex(e => e.IsRequired, "IX_ORDER_CODE_6");

            entity.HasIndex(e => e.CreatedBy, "IX_ORDER_CODE_7");

            entity.HasIndex(e => e.DateCreated, "IX_ORDER_CODE_8");

            entity.HasIndex(e => e.ModifiedBy, "IX_ORDER_CODE_9");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DescriptionEng)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION_ENG");
            entity.Property(e => e.DescriptionFrn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION_FRN");
            entity.Property(e => e.IsRequired).HasColumnName("IS_REQUIRED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TRANSACTION_TYPE");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.OrderCodeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ORDER_COD__CREAT__1995C0A8");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.OrderCodeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__ORDER_COD__MODIF__1B7E091A");
        });

        modelBuilder.Entity<OrderDelivery>(entity =>
        {
            entity.ToTable("ORDER_DELIVERY");

            entity.HasIndex(e => e.FkOrderId, "IX_ORDER_DELIVERY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bol)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BOL");
            entity.Property(e => e.DateAssignedToAwe)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ASSIGNED_TO_AWE");
            entity.Property(e => e.DateAssignedToTruck)
                .HasColumnType("datetime")
                .HasColumnName("DATE_ASSIGNED_TO_TRUCK");
            entity.Property(e => e.DateDeliveryCompleted)
                .HasColumnType("datetime")
                .HasColumnName("DATE_DELIVERY_COMPLETED");
            entity.Property(e => e.DateDeliveryStarted)
                .HasColumnType("datetime")
                .HasColumnName("DATE_DELIVERY_STARTED");
            entity.Property(e => e.DateDeparted)
                .HasColumnType("datetime")
                .HasColumnName("DATE_DEPARTED");
            entity.Property(e => e.DateDispatchedFromHost)
                .HasColumnType("datetime")
                .HasColumnName("DATE_DISPATCHED_FROM_HOST");
            entity.Property(e => e.DateLoaded)
                .HasColumnType("datetime")
                .HasColumnName("DATE_LOADED");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DriverId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DRIVER_ID");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.LegacySalesNumber).HasColumnName("LEGACY_SALES_NUMBER");
            entity.Property(e => e.MeterEndDate)
                .HasColumnType("datetime")
                .HasColumnName("METER_END_DATE");
            entity.Property(e => e.MeterNumber).HasColumnName("METER_NUMBER");
            entity.Property(e => e.MeterStartDate)
                .HasColumnType("datetime")
                .HasColumnName("METER_START_DATE");
            entity.Property(e => e.OdometerEnd).HasColumnName("ODOMETER_END");
            entity.Property(e => e.OdometerStart).HasColumnName("ODOMETER_START");
            entity.Property(e => e.Sequence)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SEQUENCE");
            entity.Property(e => e.Shift).HasColumnName("SHIFT");
            entity.Property(e => e.TotalPayments).HasColumnName("TOTAL_PAYMENTS");
            entity.Property(e => e.TruckDateArrived)
                .HasColumnType("datetime")
                .HasColumnName("TRUCK_DATE_ARRIVED");
            entity.Property(e => e.TruckId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TRUCK_ID");
            entity.Property(e => e.TruckInventory).HasColumnName("TRUCK_INVENTORY");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.OrderDeliveries)
                .HasForeignKey(d => d.FkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_DELIVERY_ORDER");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.FkProductId, e.FkOrderId, e.VarianceId });

            entity.ToTable("ORDER_DETAILS");

            entity.HasIndex(e => e.FkProductId, "IX_ORDER_DETAILS");

            entity.HasIndex(e => e.FkOrderId, "IX_ORDER_DETAILS_1");

            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.VarianceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VARIANCE_ID");
            entity.Property(e => e.ConfirmedPrice).HasColumnName("CONFIRMED_PRICE");
            entity.Property(e => e.ConfirmedQuantity).HasColumnName("CONFIRMED_QUANTITY");
            entity.Property(e => e.ConfirmedWeight).HasColumnName("CONFIRMED_WEIGHT");
            entity.Property(e => e.ItemStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM_STATUS");
            entity.Property(e => e.LegacySalesNumber).HasColumnName("LEGACY_SALES_NUMBER");
            entity.Property(e => e.OrderPrice).HasColumnName("ORDER_PRICE");
            entity.Property(e => e.OrderQuantity).HasColumnName("ORDER_QUANTITY");
            entity.Property(e => e.OrderVolume)
                .HasColumnType("decimal(13, 1)")
                .HasColumnName("ORDER_VOLUME");
            entity.Property(e => e.ShippedExtended)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SHIPPED_EXTENDED");
            entity.Property(e => e.ShippedGrossVolume)
                .HasColumnType("decimal(13, 1)")
                .HasColumnName("SHIPPED_GROSS_VOLUME");
            entity.Property(e => e.ShippedPercentFull).HasColumnName("SHIPPED_PERCENT_FULL");
            entity.Property(e => e.ShippedQuantity).HasColumnName("SHIPPED_QUANTITY");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.FkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_DETAILS_ORDER");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_DETAILS_PRODUCT");
        });

        modelBuilder.Entity<OrderDetailShipmentMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ORDER_DETAIL_SHIPMENT_MAP_1");

            entity.ToTable("ORDER_DETAIL_SHIPMENT_MAP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("EXPIRY_DATE");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkShipmentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FK_SHIPMENT_ID");
            entity.Property(e => e.FkVarianceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FK_VARIANCE_ID");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOT_NUMBER");
            entity.Property(e => e.ShippedQuantity).HasColumnName("SHIPPED_QUANTITY");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRACKING_NUMBER");

            entity.HasOne(d => d.FkShipment).WithMany(p => p.OrderDetailShipmentMaps)
                .HasForeignKey(d => d.FkShipmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_DETAIL_SHIPMENT_MAP_SHIPMENT");

            entity.HasOne(d => d.OrderDetail).WithMany(p => p.OrderDetailShipmentMaps)
                .HasForeignKey(d => new { d.FkProductId, d.FkOrderId, d.FkVarianceId })
                .HasConstraintName("FK_ORDER_DETAIL_SHIPMENT_MAP_ORDER_DETAILS");
        });

        modelBuilder.Entity<OrderDetailsAddOn>(entity =>
        {
            entity.ToTable("ORDER_DETAILS_ADD_ON");

            entity.HasIndex(e => e.OdFkOrderId, "IX_ORDER_DETAILS_ADD_ON");

            entity.HasIndex(e => e.OdFkProductId, "IX_ORDER_DETAILS_ADD_ON_1");

            entity.HasIndex(e => e.OdFkVarianceId, "IX_ORDER_DETAILS_ADD_ON_2");

            entity.HasIndex(e => e.FkProductId, "IX_ORDER_DETAILS_ADD_ON_3");

            entity.HasIndex(e => e.FkVarianceId, "IX_ORDER_DETAILS_ADD_ON_4");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkVarianceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FK_VARIANCE_ID");
            entity.Property(e => e.OdFkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("OD_FK_ORDER_ID");
            entity.Property(e => e.OdFkProductId).HasColumnName("OD_FK_PRODUCT_ID");
            entity.Property(e => e.OdFkVarianceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("OD_FK_VARIANCE_ID");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.OrderDetailsAddOns)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_DETAILS_ADD_ON_PRODUCT");

            entity.HasOne(d => d.ProductVariance).WithMany(p => p.OrderDetailsAddOns)
                .HasForeignKey(d => new { d.FkVarianceId, d.FkProductId })
                .HasConstraintName("FK_ORDER_DETAILS_ADD_ON_PRODUCT_VARIANCE");

            entity.HasOne(d => d.OrderDetail).WithMany(p => p.OrderDetailsAddOns)
                .HasForeignKey(d => new { d.OdFkProductId, d.OdFkOrderId, d.OdFkVarianceId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_DETAILS_ADD_ON_ORDER_DETAILS");
        });

        modelBuilder.Entity<OrderException>(entity =>
        {
            entity.ToTable("ORDER_EXCEPTION");

            entity.HasIndex(e => e.FkOrderId, "IX_ORDER_EXCEPTION_1");

            entity.HasIndex(e => e.FkExceptionCodeReferenceId, "IX_ORDER_EXCEPTION_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkExceptionCodeReferenceId).HasColumnName("FK_EXCEPTION_CODE_REFERENCE_ID");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.Remarks)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("REMARKS");

            entity.HasOne(d => d.FkExceptionCodeReference).WithMany(p => p.OrderExceptions)
                .HasForeignKey(d => d.FkExceptionCodeReferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_EXCEPTION_EXCEPTION_CODE_REFERENCE");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.OrderExceptions)
                .HasForeignKey(d => d.FkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_EXCEPTION_ORDER");
        });

        modelBuilder.Entity<OrderInventoryMap>(entity =>
        {
            entity.ToTable("ORDER_INVENTORY_MAP");

            entity.HasIndex(e => e.FkOrderId, "IX_ORDER_INVENTORY_MAP");

            entity.HasIndex(e => e.FkInventoryId, "IX_ORDER_INVENTORY_MAP_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConfirmedQuantity).HasColumnName("CONFIRMED_QUANTITY");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.ExpDate).HasColumnName("EXP_DATE");
            entity.Property(e => e.FkInventoryId).HasColumnName("FK_INVENTORY_ID");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.Location)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOT_NUMBER");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("NAME");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_CODE");
            entity.Property(e => e.ShippedQuantity).HasColumnName("SHIPPED_QUANTITY");

            entity.HasOne(d => d.FkInventory).WithMany(p => p.OrderInventoryMaps)
                .HasForeignKey(d => d.FkInventoryId)
                .HasConstraintName("FK_ORDER_INVENTORY_MAP_INVENTORY");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.OrderInventoryMaps)
                .HasForeignKey(d => d.FkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_INVENTORY_MAP_ORDER");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.ToTable("ORDER_ITEMS");

            entity.HasIndex(e => e.FkOrderId, "IX_ORDER_ITEMS");

            entity.HasIndex(e => e.ItemNumber, "IX_ORDER_ITEMS_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.ItemNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM_NUMBER");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.FkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_ITEMS_ORDER");
        });

        modelBuilder.Entity<OrderLineItem>(entity =>
        {
            entity.ToTable("ORDER_LINE_ITEM");

            entity.HasIndex(e => e.FkOrderId, "IX_ORDER_LINE_ITEM");

            entity.HasIndex(e => e.FkProductId, "IX_ORDER_LINE_ITEM_1");

            entity.HasIndex(e => e.FkPricingTemplateId, "IX_ORDER_LINE_ITEM_2");

            entity.HasIndex(e => e.PriceSource, "IX_ORDER_LINE_ITEM_3");

            entity.HasIndex(e => e.ReferenceBptmId, "IX_ORDER_LINE_ITEM_4");

            entity.HasIndex(e => e.ReferenceCaptmId, "IX_ORDER_LINE_ITEM_5");

            entity.HasIndex(e => e.FkPricingTemplateId, "IX_ORDER_LINE_ITEM_6");

            entity.HasIndex(e => e.FkServiceRequestId, "IX_ORDER_LINE_ITEM_7");

            entity.HasIndex(e => e.BinId, "IX_ORDER_LINE_ITEM_8");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BinId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BIN_ID");
            entity.Property(e => e.ConfirmedPrice).HasColumnName("CONFIRMED_PRICE");
            entity.Property(e => e.ConfirmedQuantity).HasColumnName("CONFIRMED_QUANTITY");
            entity.Property(e => e.ContractId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CONTRACT_ID");
            entity.Property(e => e.ContractType)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CONTRACT_TYPE");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.FkPricingTemplateId).HasColumnName("FK_PRICING_TEMPLATE_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkServiceRequestId).HasColumnName("FK_SERVICE_REQUEST_ID");
            entity.Property(e => e.LimitCost).HasColumnName("LIMIT_COST");
            entity.Property(e => e.LimitVolume).HasColumnName("LIMIT_VOLUME");
            entity.Property(e => e.OrderPrice).HasColumnName("ORDER_PRICE");
            entity.Property(e => e.OrderQuantity).HasColumnName("ORDER_QUANTITY");
            entity.Property(e => e.PriceModel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_MODEL");
            entity.Property(e => e.PriceSource)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRICE_SOURCE");
            entity.Property(e => e.PriceType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PRICE_TYPE");
            entity.Property(e => e.PriceVariance)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PRICE_VARIANCE");
            entity.Property(e => e.ProductName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_NAME");
            entity.Property(e => e.ReferenceBptmId).HasColumnName("REFERENCE_BPTM_ID");
            entity.Property(e => e.ReferenceCaptmId).HasColumnName("REFERENCE_CAPTM_ID");
            entity.Property(e => e.ReferencePpzcmId).HasColumnName("REFERENCE_PPZCM_ID");
            entity.Property(e => e.ShippedExtended)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SHIPPED_EXTENDED");
            entity.Property(e => e.ShippedGrossVolume).HasColumnName("SHIPPED_GROSS_VOLUME");
            entity.Property(e => e.ShippedPercentFull).HasColumnName("SHIPPED_PERCENT_FULL");
            entity.Property(e => e.ShippedPrice).HasColumnName("SHIPPED_PRICE");
            entity.Property(e => e.ShippedQuantity).HasColumnName("SHIPPED_QUANTITY");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.TotalCurrentCost).HasColumnName("TOTAL_CURRENT_COST");
            entity.Property(e => e.TotalLimitVolume).HasColumnName("TOTAL_LIMIT_VOLUME");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.OrderLineItems)
                .HasForeignKey(d => d.FkOrderId)
                .HasConstraintName("FK_ORDER_LINE_ITEM_ORDER");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.OrderLineItems)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_LINE_ITEM_PRODUCT");

            entity.HasOne(d => d.FkServiceRequest).WithMany(p => p.OrderLineItems)
                .HasForeignKey(d => d.FkServiceRequestId)
                .HasConstraintName("FK_SERVICE_REQUEST_ORDER_LINE_ITEM");
        });

        modelBuilder.Entity<OrderLineItemDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Table2");

            entity.ToTable("ORDER_LINE_ITEM_DETAILS");

            entity.HasIndex(e => e.FkOrderLineItemId, "IX_Table2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkOrderLineItemId).HasColumnName("FK_ORDER_LINE_ITEM_ID");
            entity.Property(e => e.PricingTypeCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRICING_TYPE_CODE");
            entity.Property(e => e.PricingTypeName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRICING_TYPE_NAME");
            entity.Property(e => e.Value).HasColumnName("VALUE");

            entity.HasOne(d => d.FkOrderLineItem).WithMany(p => p.OrderLineItemDetails)
                .HasForeignKey(d => d.FkOrderLineItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table2_ORDER_LINE_ITEM");
        });

        modelBuilder.Entity<OrderLog>(entity =>
        {
            entity.ToTable("ORDER_LOG");

            entity.HasIndex(e => e.FkOrderId, "IX_ORDER_LOG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.MessageFull)
                .IsUnicode(false)
                .HasColumnName("MESSAGE_FULL");
            entity.Property(e => e.MessageShort)
                .HasMaxLength(550)
                .IsUnicode(false)
                .HasColumnName("MESSAGE_SHORT");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.OrderLogs)
                .HasForeignKey(d => d.FkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_LOG_ORDER");
        });

        modelBuilder.Entity<OrderNotificationRecipient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ORDER_NO__3214EC270AD1E9CC");

            entity.ToTable("ORDER_NOTIFICATION_RECIPIENT");

            entity.HasIndex(e => e.FkOrderId, "IX_ORDER_NOTIFICATION_RECIPIENT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.OrderNotificationRecipients)
                .HasForeignKey(d => d.FkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ORDER_NOT__FK_OR__2E90DD8E");
        });

        modelBuilder.Entity<OrderNumber>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SAP_ORDER_NUMBER");

            entity.ToTable("ORDER_NUMBER");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkInvoiceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FK_INVOICE_ID");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.SapOrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SAP_ORDER_NUMBER");

            entity.HasOne(d => d.FkInvoice).WithMany(p => p.OrderNumbers)
                .HasForeignKey(d => d.FkInvoiceId)
                .HasConstraintName("FK_SAP_ORDER_NUMBER_INVOICE");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.OrderNumbers)
                .HasForeignKey(d => d.FkOrderId)
                .HasConstraintName("FK_SAP_ORDER_NUMBER_ORDER");
        });

        modelBuilder.Entity<OrderReturnLabel>(entity =>
        {
            entity.ToTable("ORDER_RETURN_LABEL");

            entity.HasIndex(e => e.FkOrderId, "IX_ORDER_RETURN_LABEL");

            entity.HasIndex(e => e.CreatedById, "IX_ORDER_RETURN_LABEL_1");

            entity.HasIndex(e => e.ModifiedById, "IX_ORDER_RETURN_LABEL_2");

            entity.HasIndex(e => e.Status, "IX_ORDER_RETURN_LABEL_3");

            entity.HasIndex(e => e.TrackingNumber, "IX_ORDER_RETURN_LABEL_4");

            entity.HasIndex(e => e.RequisitionNumber, "IX_ORDER_RETURN_LABEL_5");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BoxType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOX_TYPE");
            entity.Property(e => e.CarrierId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARRIER_ID");
            entity.Property(e => e.CarrierName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARRIER_NAME");
            entity.Property(e => e.ChargeAccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CHARGE_ACCOUNT");
            entity.Property(e => e.CreatedById)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY_ID");
            entity.Property(e => e.CreatedByName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY_NAME");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.ItemNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ITEM_NUMBER");
            entity.Property(e => e.Label)
                .IsUnicode(false)
                .HasColumnName("LABEL");
            entity.Property(e => e.MessageFull)
                .IsUnicode(false)
                .HasColumnName("MESSAGE_FULL");
            entity.Property(e => e.MessageShort)
                .HasMaxLength(550)
                .IsUnicode(false)
                .HasColumnName("MESSAGE_SHORT");
            entity.Property(e => e.ModifiedById)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY_ID");
            entity.Property(e => e.ModifiedByName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY_NAME");
            entity.Property(e => e.ModifiedDate)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.PackagingType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PACKAGING_TYPE");
            entity.Property(e => e.PickupType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PICKUP_TYPE");
            entity.Property(e => e.RequisitionNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REQUISITION_NUMBER");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVICE_TYPE");
            entity.Property(e => e.ShipFromCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_FROM_CITY");
            entity.Property(e => e.ShipFromCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_FROM_COUNTRY");
            entity.Property(e => e.ShipFromName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SHIP_FROM_NAME");
            entity.Property(e => e.ShipFromState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_FROM_STATE");
            entity.Property(e => e.ShipFromStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SHIP_FROM_STREET");
            entity.Property(e => e.ShipFromZip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_FROM_ZIP");
            entity.Property(e => e.ShipQuantity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_QUANTITY");
            entity.Property(e => e.ShipToCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_CITY");
            entity.Property(e => e.ShipToCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_COUNTRY");
            entity.Property(e => e.ShipToName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_NAME");
            entity.Property(e => e.ShipToRecepientName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_RECEPIENT_NAME");
            entity.Property(e => e.ShipToState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_STATE");
            entity.Property(e => e.ShipToStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_STREET");
            entity.Property(e => e.ShipToZip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_ZIP");
            entity.Property(e => e.ShipWeight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_WEIGHT");
            entity.Property(e => e.ShipWeightUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_WEIGHT_UNIT");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.SubPackagingType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUB_PACKAGING_TYPE");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRACKING_NUMBER");

            entity.HasOne(d => d.CreatedBy).WithMany(p => p.OrderReturnLabelCreatedBies)
                .HasForeignKey(d => d.CreatedById)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_RETURN_LABEL_USER");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.OrderReturnLabels)
                .HasForeignKey(d => d.FkOrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORDER_RETURN_LABEL_ORDER");

            entity.HasOne(d => d.ModifiedBy).WithMany(p => p.OrderReturnLabelModifiedBies)
                .HasForeignKey(d => d.ModifiedById)
                .HasConstraintName("FK_ORDER_RETURN_LABEL_USER1");
        });

        modelBuilder.Entity<OrnuSequenceRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ORNU_SEQ__3214EC278DC082F9");

            entity.ToTable("ORNU_SEQUENCE_RECORD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Prefix)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PREFIX");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.ToTable("PAYMENT");

            entity.HasIndex(e => e.CreatedBy, "IX_PAYMENT");

            entity.HasIndex(e => e.ModifiedBy, "IX_PAYMENT_1");

            entity.HasIndex(e => e.PaymentId, "IX_PAYMENT_2");

            entity.HasIndex(e => e.PaymentMerchant, "IX_PAYMENT_3");

            entity.HasIndex(e => e.Status, "IX_PAYMENT_4");

            entity.HasIndex(e => e.FkCustomerId, "IX_PAYMENT_5");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.BusinessUnit)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BUSINESS_UNIT");
            entity.Property(e => e.CardNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARD_NUMBER");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCashOut)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CASH_OUT");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DatePosted)
                .HasColumnType("datetime")
                .HasColumnName("DATE_POSTED");
            entity.Property(e => e.Employee)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMPLOYEE");
            entity.Property(e => e.FailureCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FAILURE_CODE");
            entity.Property(e => e.FailureMessage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FAILURE_MESSAGE");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.IsCashOnHand)
                .HasDefaultValue(false)
                .HasColumnName("IS_CASH_ON_HAND");
            entity.Property(e => e.ModeOfPayment)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MODE_OF_PAYMENT");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.PaymentId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_ID");
            entity.Property(e => e.PaymentMerchant)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_MERCHANT");
            entity.Property(e => e.PaymentMethodReferenceId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_METHOD_REFERENCE_ID");
            entity.Property(e => e.PaymentReferenceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_REFERENCE_ID");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_TYPE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.PaymentCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PAYMENT_USER");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.Payments)
                .HasForeignKey(d => d.FkCustomerId)
                .HasConstraintName("FK_CUSTOMER_PAYMENT");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.PaymentModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_PAYMENT_USER1");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PAYMENT___3214EC271D2302BD");

            entity.ToTable("PAYMENT_METHOD");

            entity.HasIndex(e => e.ModifiedBy, "IX_ASSET_12");

            entity.HasIndex(e => e.FkCustomerId, "IX_PAYMENT_METHOD_1");

            entity.HasIndex(e => e.Brand, "IX_PAYMENT_METHOD_10");

            entity.HasIndex(e => e.MaskedCardNumber, "IX_PAYMENT_METHOD_11");

            entity.HasIndex(e => e.IntegrationAccountId, "IX_PAYMENT_METHOD_12");

            entity.HasIndex(e => e.IntegrationVendor, "IX_PAYMENT_METHOD_13");

            entity.HasIndex(e => e.IntegrationPaymentMethodId, "IX_PAYMENT_METHOD_14");

            entity.HasIndex(e => e.CreatedBy, "IX_PAYMENT_METHOD_2");

            entity.HasIndex(e => e.ModifiedBy, "IX_PAYMENT_METHOD_3");

            entity.HasIndex(e => e.Type, "IX_PAYMENT_METHOD_4");

            entity.HasIndex(e => e.Name, "IX_PAYMENT_METHOD_5");

            entity.HasIndex(e => e.UsageMode, "IX_PAYMENT_METHOD_6");

            entity.HasIndex(e => e.DateCreated, "IX_PAYMENT_METHOD_7");

            entity.HasIndex(e => e.DateModified, "IX_PAYMENT_METHOD_8");

            entity.HasIndex(e => e.IsDefault, "IX_PAYMENT_METHOD_9");

            entity.HasIndex(e => e.LegacyId, "UniquePaymentMethodLegacyIDExceptNulls")
                .IsUnique()
                .HasFilter("([LEGACY_ID] IS NOT NULL)");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BRAND");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.IntegrationAccountId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INTEGRATION_ACCOUNT_ID");
            entity.Property(e => e.IntegrationPaymentMethodId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INTEGRATION_PAYMENT_METHOD_ID");
            entity.Property(e => e.IntegrationSetupIntentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INTEGRATION_SETUP_INTENT_ID");
            entity.Property(e => e.IntegrationVendor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INTEGRATION_VENDOR");
            entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ID");
            entity.Property(e => e.MaskedCardNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MASKED_CARD_NUMBER");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.UsageMode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USAGE_MODE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.PaymentMethodCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PAYMENT_M__CREAT__3DD3211E");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.PaymentMethods)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PAYMENT_M__FK_CU__3FBB6990");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.PaymentMethodModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__PAYMENT_M__MODIF__41A3B202");
        });

        modelBuilder.Entity<PaymentTerm>(entity =>
        {
            entity.ToTable("PAYMENT_TERM");

            entity.Property(e => e.PaymentTermId).HasColumnName("PAYMENT_TERM_ID");
            entity.Property(e => e.AccountCreditStatus)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_CREDIT_STATUS");
            entity.Property(e => e.PaymentCycle).HasColumnName("PAYMENT_CYCLE");
            entity.Property(e => e.PaymentPlan)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_PLAN");
            entity.Property(e => e.PaymentSchedule).HasColumnName("PAYMENT_SCHEDULE");
            entity.Property(e => e.PaymentSetup)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_SETUP");
            entity.Property(e => e.PaymentTerm1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_TERM");
            entity.Property(e => e.PaymentTermCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_TERM_CODE");
            entity.Property(e => e.PaymentTermDuration).HasColumnName("PAYMENT_TERM_DURATION");
        });

        modelBuilder.Entity<PaymentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PAYMENT___3214EC276E3BB11B");

            entity.ToTable("PAYMENT_TYPE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.PaymentTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__PAYMENT_T__CREAT__438BFA74");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.PaymentTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__PAYMENT_T__MODIF__457442E6");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.ToTable("PERMISSION");

            entity.HasIndex(e => e.Module, "IX_PERMISSION_3");

            entity.HasIndex(e => e.SubModule, "IX_PERMISSION_4");

            entity.HasIndex(e => e.FkCueProductId, "IX_PERMISSION_5");

            entity.HasIndex(e => e.WillAddB2bLogin, "IX_PERMISSION_6");

            entity.HasIndex(e => e.WillAddAdminLogin, "IX_PERMISSION_7");

            entity.HasIndex(e => e.IsClient, "Index_PERMISSION_1");

            entity.HasIndex(e => e.IsCustomer, "Index_PERMISSION_2");

            entity.Property(e => e.Id)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.ClientDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CLIENT_DESCRIPTION");
            entity.Property(e => e.ClientName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.CustomerDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_DESCRIPTION");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkCueProductId).HasColumnName("FK_CUE_PRODUCT_ID");
            entity.Property(e => e.IsClient).HasColumnName("IS_CLIENT");
            entity.Property(e => e.IsCustomer).HasColumnName("IS_CUSTOMER");
            entity.Property(e => e.Module)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.SubModule)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUB_MODULE");
            entity.Property(e => e.WillAddAdminLogin).HasColumnName("WILL_ADD_ADMIN_LOGIN");
            entity.Property(e => e.WillAddB2bLogin).HasColumnName("WILL_ADD_B2B_LOGIN");

            entity.HasOne(d => d.FkCueProduct).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.FkCueProductId)
                .HasConstraintName("FK_CUE_PRODUCT_PERMISSION");

            entity.HasMany(d => d.FkMasterRoles).WithMany(p => p.FkPermissions)
                .UsingEntity<Dictionary<string, object>>(
                    "MasterRolePermMap",
                    r => r.HasOne<MasterRole>().WithMany()
                        .HasForeignKey("FkMasterRoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MASTER_ROLE_PERM_MAP_MASTER_ROLE"),
                    l => l.HasOne<Permission>().WithMany()
                        .HasForeignKey("FkPermissionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_MASTER_ROLE_PERM_MAP_PERMISSION"),
                    j =>
                    {
                        j.HasKey("FkPermissionId", "FkMasterRoleId");
                        j.ToTable("MASTER_ROLE_PERM_MAP");
                        j.HasIndex(new[] { "FkPermissionId" }, "IX_MASTER_ROLE_PERM_MAP");
                        j.HasIndex(new[] { "FkMasterRoleId" }, "IX_MASTER_ROLE_PERM_MAP_1");
                        j.IndexerProperty<string>("FkPermissionId")
                            .HasMaxLength(6)
                            .IsUnicode(false)
                            .HasColumnName("FK_PERMISSION_ID");
                        j.IndexerProperty<int>("FkMasterRoleId").HasColumnName("FK_MASTER_ROLE_ID");
                    });
        });

        modelBuilder.Entity<PreprintReturnLabel>(entity =>
        {
            entity.ToTable("PREPRINT_RETURN_LABEL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BoxType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOX_TYPE");
            entity.Property(e => e.CarrierId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARRIER_ID");
            entity.Property(e => e.CarrierName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARRIER_NAME");
            entity.Property(e => e.ChargeAccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CHARGE_ACCOUNT");
            entity.Property(e => e.CreatedById)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY_ID");
            entity.Property(e => e.CreatedByName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY_NAME");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_DATE");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.Label)
                .IsUnicode(false)
                .HasColumnName("LABEL");
            entity.Property(e => e.MessageFull)
                .IsUnicode(false)
                .HasColumnName("MESSAGE_FULL");
            entity.Property(e => e.MessageShort)
                .HasMaxLength(550)
                .IsUnicode(false)
                .HasColumnName("MESSAGE_SHORT");
            entity.Property(e => e.ModifiedById)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY_ID");
            entity.Property(e => e.ModifiedByName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY_NAME");
            entity.Property(e => e.ModifiedDate)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_DATE");
            entity.Property(e => e.PackagingType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PACKAGING_TYPE");
            entity.Property(e => e.PickupType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PICKUP_TYPE");
            entity.Property(e => e.RequisitionNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REQUISITION_NUMBER");
            entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVICE_TYPE");
            entity.Property(e => e.ShipFromCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_FROM_CITY");
            entity.Property(e => e.ShipFromName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SHIP_FROM_NAME");
            entity.Property(e => e.ShipFromState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_FROM_STATE");
            entity.Property(e => e.ShipFromStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SHIP_FROM_STREET");
            entity.Property(e => e.ShipFromZip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_FROM_ZIP");
            entity.Property(e => e.ShipQuantity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_QUANTITY");
            entity.Property(e => e.ShipToCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_CITY");
            entity.Property(e => e.ShipToName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_NAME");
            entity.Property(e => e.ShipToRecepientName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_RECEPIENT_NAME");
            entity.Property(e => e.ShipToState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_STATE");
            entity.Property(e => e.ShipToStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_STREET");
            entity.Property(e => e.ShipToZip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_TO_ZIP");
            entity.Property(e => e.ShipWeight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_WEIGHT");
            entity.Property(e => e.ShipWeightUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_WEIGHT_UNIT");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.SubPackagingType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUB_PACKAGING_TYPE");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRACKING_NUMBER");
        });

        modelBuilder.Entity<PriceZone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRICE_ZO__3214EC271572BB21");

            entity.ToTable("PRICE_ZONE");

            entity.HasIndex(e => e.FkRegionId, "IX_PRICE_ZONE_1");

            entity.HasIndex(e => e.Code, "IX_PRICE_ZONE_2");

            entity.HasIndex(e => e.Description, "IX_PRICE_ZONE_3");

            entity.HasIndex(e => e.Comments, "IX_PRICE_ZONE_4");

            entity.HasIndex(e => e.DateCreated, "IX_PRICE_ZONE_5");

            entity.HasIndex(e => e.CreatedBy, "IX_PRICE_ZONE_6");

            entity.HasIndex(e => e.DateModified, "IX_PRICE_ZONE_7");

            entity.HasIndex(e => e.ModifiedBy, "IX_PRICE_ZONE_8");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Comments)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkRegionId).HasColumnName("FK_REGION_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.PriceZoneCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__PRICE_ZON__CREAT__4850AF91");

            entity.HasOne(d => d.FkRegion).WithMany(p => p.PriceZones)
                .HasForeignKey(d => d.FkRegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PRICE_ZON__FK_RE__4A38F803");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.PriceZoneModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__PRICE_ZON__MODIF__4C214075");
        });

        modelBuilder.Entity<PricingTemplate>(entity =>
        {
            entity.ToTable("PRICING_TEMPLATE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.PriceModel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_MODEL");
            entity.Property(e => e.TemplateType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEMPLATE_TYPE");
        });

        modelBuilder.Entity<PricingTemplateDetail>(entity =>
        {
            entity.ToTable("PRICING_TEMPLATE_DETAILS");

            entity.HasIndex(e => e.FkPricingTemplateId, "IX_PRICING_TEMPLATE_DETAILS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Desctription)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCTRIPTION");
            entity.Property(e => e.FkPricingTemplateId).HasColumnName("FK_PRICING_TEMPLATE_ID");
            entity.Property(e => e.PricingTypeCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRICING_TYPE_CODE");
            entity.Property(e => e.PricingTypeName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRICING_TYPE_NAME");

            entity.HasOne(d => d.FkPricingTemplate).WithMany(p => p.PricingTemplateDetails)
                .HasForeignKey(d => d.FkPricingTemplateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRICING_TEMPLATE_DETAILS_PRICING_TEMPLATE");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("PRODUCT");

            entity.HasIndex(e => e.ProductCode, "IX_PRODUCT").IsUnique();

            entity.HasIndex(e => e.FkFamilyId, "IX_PRODUCT_1");

            entity.HasIndex(e => e.FkSubFamilyId, "IX_PRODUCT_2");

            entity.HasIndex(e => e.LegacyId, "IX_PRODUCT_4");

            entity.HasIndex(e => e.CreatedBy, "IX_PRODUCT_5");

            entity.HasIndex(e => e.ModifiedBy, "IX_PRODUCT_6");

            entity.HasIndex(e => e.Classification, "IX_PRODUCT_7");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Allergens)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ALLERGENS");
            entity.Property(e => e.BinRequiredFlag)
                .HasDefaultValue(false)
                .HasColumnName("BIN_REQUIRED_FLAG");
            entity.Property(e => e.Body)
                .IsUnicode(false)
                .HasColumnName("BODY");
            entity.Property(e => e.Case)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CASE");
            entity.Property(e => e.CasePackQuantity).HasColumnName("CASE_PACK_QUANTITY");
            entity.Property(e => e.CaseUpc)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("CASE_UPC");
            entity.Property(e => e.CaseWeightType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CASE_WEIGHT_TYPE");
            entity.Property(e => e.Casewt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CASEWT");
            entity.Property(e => e.Characteristics)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CHARACTERISTICS");
            entity.Property(e => e.Classification)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CLASSIFICATION");
            entity.Property(e => e.CodeDating)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODE_DATING");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.DosageForm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOSAGE_FORM");
            entity.Property(e => e.Establishment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESTABLISHMENT");
            entity.Property(e => e.FkFamilyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_FAMILY_ID");
            entity.Property(e => e.FkSubFamilyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_SUB_FAMILY_ID");
            entity.Property(e => e.Gtin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GTIN");
            entity.Property(e => e.Icon)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("ICON");
            entity.Property(e => e.LastHeartbeat)
                .HasColumnType("datetime")
                .HasColumnName("LAST_HEARTBEAT");
            entity.Property(e => e.LastTransaction)
                .HasColumnType("datetime")
                .HasColumnName("LAST_TRANSACTION");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ID");
            entity.Property(e => e.MinOrderQuantity).HasColumnName("MIN_ORDER_QUANTITY");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.OtcRx)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OTC_RX");
            entity.Property(e => e.Package)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("PACKAGE");
            entity.Property(e => e.Pallet)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PALLET");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.PriceUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRICE_UNIT");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_CODE");
            entity.Property(e => e.RefrigerationText)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFRIGERATION_TEXT");
            entity.Property(e => e.SellingRestriction).HasColumnName("SELLING_RESTRICTION");
            entity.Property(e => e.ShelfLife)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHELF_LIFE");
            entity.Property(e => e.Size)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SIZE");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.StorageCondition)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STORAGE_CONDITION");
            entity.Property(e => e.Strength)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STRENGTH");
            entity.Property(e => e.TeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TE_CODE");
            entity.Property(e => e.TextOverrideFlag)
                .HasDefaultValue(false)
                .HasColumnName("TEXT_OVERRIDE_FLAG");
            entity.Property(e => e.TrademarkStatement)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TRADEMARK_STATEMENT");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Umconversions)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UMCONVERSIONS");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
            entity.Property(e => e.WeightUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WEIGHT_UNIT");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ProductCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_CREATED_BY");

            entity.HasOne(d => d.FkFamily).WithMany(p => p.Products)
                .HasForeignKey(d => d.FkFamilyId)
                .HasConstraintName("FK_PRODUCT_FAMILY");

            entity.HasOne(d => d.FkSubFamily).WithMany(p => p.Products)
                .HasForeignKey(d => d.FkSubFamilyId)
                .HasConstraintName("FK_PRODUCT_SUB_FAMILY");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.ProductModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_PRODUCT_USER");

            entity.HasMany(d => d.FkClientGroups).WithMany(p => p.FkProducts)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductClientGroupMap",
                    r => r.HasOne<ClientGroup>().WithMany()
                        .HasForeignKey("FkClientGroupId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PRODUCT_CLIENT_GROUP_MAP_CLIENT_GROUP"),
                    l => l.HasOne<Product>().WithMany()
                        .HasForeignKey("FkProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PRODUCT_CLIENT_GROUP_MAP_PRODUCT"),
                    j =>
                    {
                        j.HasKey("FkProductId", "FkClientGroupId");
                        j.ToTable("PRODUCT_CLIENT_GROUP_MAP");
                        j.HasIndex(new[] { "FkProductId" }, "IX_PRODUCT_CLIENT_GROUP_MAP");
                        j.HasIndex(new[] { "FkClientGroupId" }, "IX_PRODUCT_CLIENT_GROUP_MAP_1");
                        j.IndexerProperty<int>("FkProductId").HasColumnName("FK_PRODUCT_ID");
                        j.IndexerProperty<int>("FkClientGroupId").HasColumnName("FK_CLIENT_GROUP_ID");
                    });
        });

        modelBuilder.Entity<ProductAsset>(entity =>
        {
            entity.ToTable("PRODUCT_ASSET");

            entity.HasIndex(e => e.FkProductId, "IX_PRODUCT_ASSET");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Filename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FILENAME");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.IsDefault)
                .HasDefaultValue(false)
                .HasColumnName("IS_DEFAULT");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Url)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.ProductAssets)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCT_ASSET_PRODUCT");
        });

        modelBuilder.Entity<ProductAttributeDefinition>(entity =>
        {
            entity.ToTable("PRODUCT_ATTRIBUTE_DEFINITION");

            entity.HasIndex(e => e.ColumnName, "IX_PRODUCT_ATTRIBUTE_DEFINITION");

            entity.HasIndex(e => e.AttributeType, "IX_PRODUCT_ATTRIBUTE_DEFINITION_1");

            entity.HasIndex(e => e.Entity, "IX_PRODUCT_ATTRIBUTE_DEFINITION_2");

            entity.HasIndex(e => e.EntityType, "IX_PRODUCT_ATTRIBUTE_DEFINITION_3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AttributeDataType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE_DATA_TYPE");
            entity.Property(e => e.AttributeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE_NAME");
            entity.Property(e => e.AttributeType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE_TYPE");
            entity.Property(e => e.AttributeUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE_UNIT");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COLUMN_NAME");
            entity.Property(e => e.DefaultValue)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DEFAULT_VALUE");
            entity.Property(e => e.Entity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENTITY");
            entity.Property(e => e.EntityType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENTITY_TYPE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OptionType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPTION_TYPE");
            entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
        });

        modelBuilder.Entity<ProductAttributeValue>(entity =>
        {
            entity.ToTable("PRODUCT_ATTRIBUTE_VALUE");

            entity.HasIndex(e => e.FkProductAttributeDefinitionId, "IX_PRODUCT_ATTRIBUTE_VALUE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkProductAttributeDefinitionId).HasColumnName("FK_PRODUCT_ATTRIBUTE_DEFINITION_ID");
            entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
            entity.Property(e => e.Value)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("VALUE");

            entity.HasOne(d => d.FkProductAttributeDefinition).WithMany(p => p.ProductAttributeValues)
                .HasForeignKey(d => d.FkProductAttributeDefinitionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCT_ATTRIBUTE_VALUE_PRODUCT_ATTRIBUTE_DEFINITION");
        });

        modelBuilder.Entity<ProductClientAttribute>(entity =>
        {
            entity.HasKey(e => e.FkProductId).HasFillFactor(80);

            entity.ToTable("PRODUCT_CLIENT_ATTRIBUTE");

            entity.HasIndex(e => e.Column01, "IX_PRODUCT_CLIENT_ATTRIBUTE").HasFillFactor(80);

            entity.HasIndex(e => e.Column02, "IX_PRODUCT_CLIENT_ATTRIBUTE_1").HasFillFactor(80);

            entity.HasIndex(e => e.Column11, "IX_PRODUCT_CLIENT_ATTRIBUTE_10").HasFillFactor(80);

            entity.HasIndex(e => e.Column12, "IX_PRODUCT_CLIENT_ATTRIBUTE_11").HasFillFactor(80);

            entity.HasIndex(e => e.Column13, "IX_PRODUCT_CLIENT_ATTRIBUTE_12").HasFillFactor(80);

            entity.HasIndex(e => e.Column14, "IX_PRODUCT_CLIENT_ATTRIBUTE_13").HasFillFactor(80);

            entity.HasIndex(e => e.Column15, "IX_PRODUCT_CLIENT_ATTRIBUTE_14").HasFillFactor(80);

            entity.HasIndex(e => e.Column16, "IX_PRODUCT_CLIENT_ATTRIBUTE_15").HasFillFactor(80);

            entity.HasIndex(e => e.Column17, "IX_PRODUCT_CLIENT_ATTRIBUTE_16").HasFillFactor(80);

            entity.HasIndex(e => e.Column18, "IX_PRODUCT_CLIENT_ATTRIBUTE_17").HasFillFactor(80);

            entity.HasIndex(e => e.Column19, "IX_PRODUCT_CLIENT_ATTRIBUTE_18").HasFillFactor(80);

            entity.HasIndex(e => e.Column20, "IX_PRODUCT_CLIENT_ATTRIBUTE_19").HasFillFactor(80);

            entity.HasIndex(e => e.Column03, "IX_PRODUCT_CLIENT_ATTRIBUTE_2").HasFillFactor(80);

            entity.HasIndex(e => e.Column21, "IX_PRODUCT_CLIENT_ATTRIBUTE_20");

            entity.HasIndex(e => e.Column22, "IX_PRODUCT_CLIENT_ATTRIBUTE_21");

            entity.HasIndex(e => e.Column23, "IX_PRODUCT_CLIENT_ATTRIBUTE_22");

            entity.HasIndex(e => e.Column24, "IX_PRODUCT_CLIENT_ATTRIBUTE_23");

            entity.HasIndex(e => e.Column25, "IX_PRODUCT_CLIENT_ATTRIBUTE_24");

            entity.HasIndex(e => e.Column26, "IX_PRODUCT_CLIENT_ATTRIBUTE_25");

            entity.HasIndex(e => e.Column27, "IX_PRODUCT_CLIENT_ATTRIBUTE_26");

            entity.HasIndex(e => e.Column28, "IX_PRODUCT_CLIENT_ATTRIBUTE_27");

            entity.HasIndex(e => e.Column29, "IX_PRODUCT_CLIENT_ATTRIBUTE_28");

            entity.HasIndex(e => e.Column30, "IX_PRODUCT_CLIENT_ATTRIBUTE_29");

            entity.HasIndex(e => e.Column04, "IX_PRODUCT_CLIENT_ATTRIBUTE_3").HasFillFactor(80);

            entity.HasIndex(e => e.Column31, "IX_PRODUCT_CLIENT_ATTRIBUTE_30");

            entity.HasIndex(e => e.Column32, "IX_PRODUCT_CLIENT_ATTRIBUTE_31");

            entity.HasIndex(e => e.Column33, "IX_PRODUCT_CLIENT_ATTRIBUTE_32");

            entity.HasIndex(e => e.Column34, "IX_PRODUCT_CLIENT_ATTRIBUTE_33");

            entity.HasIndex(e => e.Column35, "IX_PRODUCT_CLIENT_ATTRIBUTE_34");

            entity.HasIndex(e => e.Column36, "IX_PRODUCT_CLIENT_ATTRIBUTE_35");

            entity.HasIndex(e => e.Column37, "IX_PRODUCT_CLIENT_ATTRIBUTE_36");

            entity.HasIndex(e => e.Column38, "IX_PRODUCT_CLIENT_ATTRIBUTE_37");

            entity.HasIndex(e => e.Column39, "IX_PRODUCT_CLIENT_ATTRIBUTE_38");

            entity.HasIndex(e => e.Column40, "IX_PRODUCT_CLIENT_ATTRIBUTE_39");

            entity.HasIndex(e => e.Column05, "IX_PRODUCT_CLIENT_ATTRIBUTE_4").HasFillFactor(80);

            entity.HasIndex(e => e.Column06, "IX_PRODUCT_CLIENT_ATTRIBUTE_5").HasFillFactor(80);

            entity.HasIndex(e => e.Column07, "IX_PRODUCT_CLIENT_ATTRIBUTE_6").HasFillFactor(80);

            entity.HasIndex(e => e.Column08, "IX_PRODUCT_CLIENT_ATTRIBUTE_7").HasFillFactor(80);

            entity.HasIndex(e => e.Column09, "IX_PRODUCT_CLIENT_ATTRIBUTE_8").HasFillFactor(80);

            entity.HasIndex(e => e.Column10, "IX_PRODUCT_CLIENT_ATTRIBUTE_9").HasFillFactor(80);

            entity.Property(e => e.FkProductId)
                .ValueGeneratedNever()
                .HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.Column01)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_01");
            entity.Property(e => e.Column02)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_02");
            entity.Property(e => e.Column03)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_03");
            entity.Property(e => e.Column04)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_04");
            entity.Property(e => e.Column05)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_05");
            entity.Property(e => e.Column06)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_06");
            entity.Property(e => e.Column07)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_07");
            entity.Property(e => e.Column08)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_08");
            entity.Property(e => e.Column09)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_09");
            entity.Property(e => e.Column10)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_10");
            entity.Property(e => e.Column11)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_11");
            entity.Property(e => e.Column12)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_12");
            entity.Property(e => e.Column13)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_13");
            entity.Property(e => e.Column14)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_14");
            entity.Property(e => e.Column15)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_15");
            entity.Property(e => e.Column16)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_16");
            entity.Property(e => e.Column17)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_17");
            entity.Property(e => e.Column18)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_18");
            entity.Property(e => e.Column19)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_19");
            entity.Property(e => e.Column20)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_20");
            entity.Property(e => e.Column21)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_21");
            entity.Property(e => e.Column22)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_22");
            entity.Property(e => e.Column23)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_23");
            entity.Property(e => e.Column24)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_24");
            entity.Property(e => e.Column25)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_25");
            entity.Property(e => e.Column26)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_26");
            entity.Property(e => e.Column27)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_27");
            entity.Property(e => e.Column28)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_28");
            entity.Property(e => e.Column29)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_29");
            entity.Property(e => e.Column30)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_30");
            entity.Property(e => e.Column31)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_31");
            entity.Property(e => e.Column32)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_32");
            entity.Property(e => e.Column33)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_33");
            entity.Property(e => e.Column34)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_34");
            entity.Property(e => e.Column35)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_35");
            entity.Property(e => e.Column36)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_36");
            entity.Property(e => e.Column37)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_37");
            entity.Property(e => e.Column38)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_38");
            entity.Property(e => e.Column39)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_39");
            entity.Property(e => e.Column40)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_40");

            entity.HasOne(d => d.FkProduct).WithOne(p => p.ProductClientAttribute)
                .HasForeignKey<ProductClientAttribute>(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCT_CLIENT_ATTRIBUTE_PRODUCT");
        });

        modelBuilder.Entity<ProductRegionMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRODUCT___3214EC277EF6B2ED");

            entity.ToTable("PRODUCT_REGION_MAP");

            entity.HasIndex(e => e.FkProductId, "IX_PRODUCT_REGION_MAP_1");

            entity.HasIndex(e => e.FkRegionId, "IX_PRODUCT_REGION_MAP_2");

            entity.HasIndex(e => e.Type, "IX_PRODUCT_REGION_MAP_3");

            entity.HasIndex(e => e.Price, "IX_PRODUCT_REGION_MAP_4");

            entity.HasIndex(e => e.Status, "IX_PRODUCT_REGION_MAP_5");

            entity.HasIndex(e => e.DateCreated, "IX_PRODUCT_REGION_MAP_6");

            entity.HasIndex(e => e.DateModified, "IX_PRODUCT_REGION_MAP_7");

            entity.HasIndex(e => e.CreatedBy, "IX_PRODUCT_REGION_MAP_8");

            entity.HasIndex(e => e.ModifiedBy, "IX_PRODUCT_REGION_MAP_9");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkRegionId).HasColumnName("FK_REGION_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ProductRegionMapCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__PRODUCT_R__CREAT__5B638405");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.ProductRegionMaps)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PRODUCT_R__FK_PR__5D4BCC77");

            entity.HasOne(d => d.FkRegion).WithMany(p => p.ProductRegionMaps)
                .HasForeignKey(d => d.FkRegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PRODUCT_R__FK_RE__5F3414E9");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.ProductRegionMapModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__PRODUCT_R__MODIF__611C5D5B");
        });

        modelBuilder.Entity<ProductVariance>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.FkProductId });

            entity.ToTable("PRODUCT_VARIANCE");

            entity.Property(e => e.Id)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsBasePrice).HasColumnName("IS_BASE_PRICE");
            entity.Property(e => e.Moq).HasColumnName("MOQ");
            entity.Property(e => e.Price).HasColumnName("PRICE");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.ProductVariances)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCT_VARIANCE_PRODUCT");
        });

        modelBuilder.Entity<ProductionSchedTicketInvMap>(entity =>
        {
            entity.ToTable("PRODUCTION_SCHED_TICKET_INV_MAP");

            entity.HasIndex(e => e.FkProductionScheduleTicketId, "IX_PRODUCTION_SCHED_TICKET_INV_MAP");

            entity.HasIndex(e => e.FkInventoryId, "IX_PRODUCTION_SCHED_TICKET_INV_MAP_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConsumedQuantity).HasColumnName("CONSUMED_QUANTITY");
            entity.Property(e => e.FkInventoryId).HasColumnName("FK_INVENTORY_ID");
            entity.Property(e => e.FkProductionScheduleTicketId).HasColumnName("FK_PRODUCTION_SCHEDULE_TICKET_ID");
            entity.Property(e => e.PulledQuantity).HasColumnName("PULLED_QUANTITY");
            entity.Property(e => e.ReturnedQuantity).HasColumnName("RETURNED_QUANTITY");
            entity.Property(e => e.TicketQuantity).HasColumnName("TICKET_QUANTITY");

            entity.HasOne(d => d.FkInventory).WithMany(p => p.ProductionSchedTicketInvMaps)
                .HasForeignKey(d => d.FkInventoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCTION_SCHED_TICKET_INV_MAP_INVENTORY");

            entity.HasOne(d => d.FkProductionScheduleTicket).WithMany(p => p.ProductionSchedTicketInvMaps)
                .HasForeignKey(d => d.FkProductionScheduleTicketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCTION_SCHED_TICKET_INV_MAP_PRODUCTION_SCHEDULE_TICKET");
        });

        modelBuilder.Entity<ProductionSchedule>(entity =>
        {
            entity.ToTable("PRODUCTION_SCHEDULE");

            entity.HasIndex(e => e.FkProductId, "IX_PRODUCTION_SCHEDULE");

            entity.HasIndex(e => e.LotNumber, "IX_PRODUCTION_SCHEDULE_1");

            entity.HasIndex(e => e.ProductionQuantity, "IX_PRODUCTION_SCHEDULE_2");

            entity.HasIndex(e => e.Status, "IX_PRODUCTION_SCHEDULE_3");

            entity.HasIndex(e => e.CreatedBy, "IX_PRODUCTION_SCHEDULE_4");

            entity.HasIndex(e => e.ModifiedBy, "IX_PRODUCTION_SCHEDULE_5");

            entity.HasIndex(e => e.DateCreated, "IX_PRODUCTION_SCHEDULE_6");

            entity.HasIndex(e => e.DateModified, "IX_PRODUCTION_SCHEDULE_7");

            entity.HasIndex(e => e.FkLotId, "IX_PRODUCTION_SCHEDULE_8");

            entity.HasIndex(e => e.FkInventoryLocationId, "IX_PRODUCTION_SCHEDULE_9");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkInventoryLocationId).HasColumnName("FK_INVENTORY_LOCATION_ID");
            entity.Property(e => e.FkLotId).HasColumnName("FK_LOT_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOT_NUMBER");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ProductionQuantity).HasColumnName("PRODUCTION_QUANTITY");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.TargetProductionDate)
                .HasColumnType("datetime")
                .HasColumnName("TARGET_PRODUCTION_DATE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ProductionScheduleCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_USER_PRODUCTION_SCHEDULE");

            entity.HasOne(d => d.FkInventoryLocation).WithMany(p => p.ProductionSchedules)
                .HasForeignKey(d => d.FkInventoryLocationId)
                .HasConstraintName("FK_INVENTORY_LOCATION_PRODUCTION_SCHEDULE");

            entity.HasOne(d => d.FkLot).WithMany(p => p.ProductionSchedules)
                .HasForeignKey(d => d.FkLotId)
                .HasConstraintName("FK_LOT_PRODUCTION_SCHEDULE");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.ProductionSchedules)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCTION_SCHEDULE_PRODUCT");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.ProductionScheduleModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_USER_PRODUCTION_SCHEDULE_1");
        });

        modelBuilder.Entity<ProductionScheduleLog>(entity =>
        {
            entity.ToTable("PRODUCTION_SCHEDULE_LOG");

            entity.HasIndex(e => e.FkProductionScheduleId, "IX_PRODUCTION_SCHEDULE_LOG");

            entity.HasIndex(e => e.CreatedBy, "IX_PRODUCTION_SCHEDULE_LOG_1");

            entity.HasIndex(e => e.FkProductId, "IX_PRODUCTION_SCHEDULE_LOG_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.FkManufacturingId).HasColumnName("FK_MANUFACTURING_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkProductionScheduleId).HasColumnName("FK_PRODUCTION_SCHEDULE_ID");
            entity.Property(e => e.LotNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOT_NUMBER");
            entity.Property(e => e.Module)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.ProductionQuantity).HasColumnName("PRODUCTION_QUANTITY");
            entity.Property(e => e.ProductionScheduleLogNotes)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PRODUCTION_SCHEDULE_LOG_NOTES");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ProductionScheduleLogs)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_1_USER");

            entity.HasOne(d => d.FkManufacturing).WithMany(p => p.ProductionScheduleLogs)
                .HasForeignKey(d => d.FkManufacturingId)
                .HasConstraintName("FK_Table_1_MANUFACTURING");

            entity.HasOne(d => d.FkProductionSchedule).WithMany(p => p.ProductionScheduleLogs)
                .HasForeignKey(d => d.FkProductionScheduleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCTION_SCHEDULE_LOG_PRODUCTION_SCHEDULE");
        });

        modelBuilder.Entity<ProductionScheduleTicket>(entity =>
        {
            entity.ToTable("PRODUCTION_SCHEDULE_TICKET");

            entity.HasIndex(e => e.FkProductionScheduleId, "IX_PRODUCTION_SCHEDULE_TICKET");

            entity.HasIndex(e => e.TicketQuantity, "IX_PRODUCTION_SCHEDULE_TICKET_1");

            entity.HasIndex(e => e.FkInventoryLocationId, "IX_PRODUCTION_SCHEDULE_TICKET_2");

            entity.HasIndex(e => e.Status, "IX_PRODUCTION_SCHEDULE_TICKET_3");

            entity.HasIndex(e => e.CreatedBy, "IX_PRODUCTION_SCHEDULE_TICKET_4");

            entity.HasIndex(e => e.ModifiedBy, "IX_PRODUCTION_SCHEDULE_TICKET_5");

            entity.HasIndex(e => e.DateCreated, "IX_PRODUCTION_SCHEDULE_TICKET_6");

            entity.HasIndex(e => e.DateModified, "IX_PRODUCTION_SCHEDULE_TICKET_7");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkInventoryLocationId).HasColumnName("FK_INVENTORY_LOCATION_ID");
            entity.Property(e => e.FkProductionScheduleId).HasColumnName("FK_PRODUCTION_SCHEDULE_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.TicketQuantity).HasColumnName("TICKET_QUANTITY");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ProductionScheduleTicketCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_USER_PRODUCTION_SCHEDULE_TICKET");

            entity.HasOne(d => d.FkInventoryLocation).WithMany(p => p.ProductionScheduleTickets)
                .HasForeignKey(d => d.FkInventoryLocationId)
                .HasConstraintName("FK_PRODUCTION_SCHEDULE_TICKET_INVENTORY_LOCATION");

            entity.HasOne(d => d.FkProductionSchedule).WithMany(p => p.ProductionScheduleTickets)
                .HasForeignKey(d => d.FkProductionScheduleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCTION_SCHEDULE_TICKET_PRODUCTION_SCHEDULE");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.ProductionScheduleTicketModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_USER_PRODUCTION_SCHEDULE_TICKET_1");
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.ToTable("PROMOTION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.IsCouponBased).HasColumnName("IS_COUPON_BASED");
            entity.Property(e => e.IsProcessExpressBuy).HasColumnName("IS_PROCESS_EXPRESS_BUY");
            entity.Property(e => e.IsProcessOrder).HasColumnName("IS_PROCESS_ORDER");
            entity.Property(e => e.IsProcessRecurring).HasColumnName("IS_PROCESS_RECURRING");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.RedemptionLimit).HasColumnName("REDEMPTION_LIMIT");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<PromotionCoupon>(entity =>
        {
            entity.ToTable("PROMOTION_COUPON");

            entity.HasIndex(e => e.FkPromotionId, "IX_PROMOTION_COUPON");

            entity.HasIndex(e => e.Code, "IX_PROMOTION_COUPON_1").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CouponRedemptionLimit).HasColumnName("COUPON_REDEMPTION_LIMIT");
            entity.Property(e => e.CustomerRedemptionLimit).HasColumnName("CUSTOMER_REDEMPTION_LIMIT");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.DiscountLevel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCOUNT_LEVEL");
            entity.Property(e => e.DiscountUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DISCOUNT_UNIT");
            entity.Property(e => e.DiscountValue).HasColumnName("DISCOUNT_VALUE");
            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.FkPromotionId).HasColumnName("FK_PROMOTION_ID");
            entity.Property(e => e.IsStackable).HasColumnName("IS_STACKABLE");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Scope)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SCOPE");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.FkPromotion).WithMany(p => p.PromotionCoupons)
                .HasForeignKey(d => d.FkPromotionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROMOTION_COUPON_PROMOTION");

            entity.HasMany(d => d.FkOrders).WithMany(p => p.FkPromotionCoupons)
                .UsingEntity<Dictionary<string, object>>(
                    "PromotionAvailmentMap",
                    r => r.HasOne<Order>().WithMany()
                        .HasForeignKey("FkOrderId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PROMOTION_AVAILMENT_MAP_ORDER"),
                    l => l.HasOne<PromotionCoupon>().WithMany()
                        .HasForeignKey("FkPromotionCouponId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PROMOTION_AVAILMENT_MAP_PROMOTION_COUPON"),
                    j =>
                    {
                        j.HasKey("FkPromotionCouponId", "FkOrderId");
                        j.ToTable("PROMOTION_AVAILMENT_MAP");
                        j.HasIndex(new[] { "FkPromotionCouponId" }, "IX_PROMOTION_AVAILMENT_MAP");
                        j.HasIndex(new[] { "FkOrderId" }, "IX_PROMOTION_AVAILMENT_MAP_1");
                        j.IndexerProperty<int>("FkPromotionCouponId").HasColumnName("FK_PROMOTION_COUPON_ID");
                        j.IndexerProperty<string>("FkOrderId")
                            .HasMaxLength(40)
                            .IsUnicode(false)
                            .HasColumnName("FK_ORDER_ID");
                    });
        });

        modelBuilder.Entity<PromotionTargetMap>(entity =>
        {
            entity.ToTable("PROMOTION_TARGET_MAP");

            entity.HasIndex(e => e.FkPromotionCouponId, "IX_PROMOTION_TARGET_MAP_4");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkPromotionCouponId).HasColumnName("FK_PROMOTION_COUPON_ID");
            entity.Property(e => e.MinEntityCountPerTag).HasColumnName("MIN_ENTITY_COUNT_PER_TAG");
            entity.Property(e => e.MinTagCount).HasColumnName("MIN_TAG_COUNT");
            entity.Property(e => e.RequireAllEntitiesPerTag).HasColumnName("REQUIRE_ALL_ENTITIES_PER_TAG");
            entity.Property(e => e.TagType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TAG_TYPE");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.FkPromotionCoupon).WithMany(p => p.PromotionTargetMaps)
                .HasForeignKey(d => d.FkPromotionCouponId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PROMOTION_TARGET_MAP_PROMOTION_COUPON");

            entity.HasMany(d => d.FkCustomers).WithMany(p => p.FkPromotionTargetMaps)
                .UsingEntity<Dictionary<string, object>>(
                    "PromotionTargetCustomerMap",
                    r => r.HasOne<Customer>().WithMany()
                        .HasForeignKey("FkCustomerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PROMOTION_TARGET_CUSTOMER_MAP_CUSTOMER"),
                    l => l.HasOne<PromotionTargetMap>().WithMany()
                        .HasForeignKey("FkPromotionTargetMapId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PROMOTION_TARGET_CUSTOMER_MAP_PROMOTION_TARGET_MAP"),
                    j =>
                    {
                        j.HasKey("FkPromotionTargetMapId", "FkCustomerId");
                        j.ToTable("PROMOTION_TARGET_CUSTOMER_MAP");
                        j.HasIndex(new[] { "FkPromotionTargetMapId" }, "IX_PROMOTION_TARGET_CUSTOMER_MAP");
                        j.HasIndex(new[] { "FkCustomerId" }, "IX_PROMOTION_TARGET_CUSTOMER_MAP_1");
                        j.IndexerProperty<int>("FkPromotionTargetMapId").HasColumnName("FK_PROMOTION_TARGET_MAP_ID");
                        j.IndexerProperty<int>("FkCustomerId").HasColumnName("FK_CUSTOMER_ID");
                    });

            entity.HasMany(d => d.FkProducts).WithMany(p => p.FkPromotionTargetMaps)
                .UsingEntity<Dictionary<string, object>>(
                    "PromotionTargetProductMap",
                    r => r.HasOne<Product>().WithMany()
                        .HasForeignKey("FkProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PROMOTION_TARGET_PRODUCT_MAP_PRODUCT"),
                    l => l.HasOne<PromotionTargetMap>().WithMany()
                        .HasForeignKey("FkPromotionTargetMapId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PROMOTION_TARGET_PRODUCT_MAP_PROMOTION_TARGET_MAP"),
                    j =>
                    {
                        j.HasKey("FkPromotionTargetMapId", "FkProductId");
                        j.ToTable("PROMOTION_TARGET_PRODUCT_MAP");
                        j.HasIndex(new[] { "FkPromotionTargetMapId" }, "IX_PROMOTION_TARGET_PRODUCT_MAP");
                        j.HasIndex(new[] { "FkProductId" }, "IX_PROMOTION_TARGET_PRODUCT_MAP_1");
                        j.IndexerProperty<int>("FkPromotionTargetMapId").HasColumnName("FK_PROMOTION_TARGET_MAP_ID");
                        j.IndexerProperty<int>("FkProductId").HasColumnName("FK_PRODUCT_ID");
                    });

            entity.HasMany(d => d.FkTags).WithMany(p => p.FkPromotionTargetMaps)
                .UsingEntity<Dictionary<string, object>>(
                    "PromotionTargetTagMap",
                    r => r.HasOne<Tag>().WithMany()
                        .HasForeignKey("FkTagId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PROMOTION_TARGET_TAG_MAP_TAG"),
                    l => l.HasOne<PromotionTargetMap>().WithMany()
                        .HasForeignKey("FkPromotionTargetMapId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PROMOTION_TARGET_TAG_MAP_PROMOTION_TARGET_MAP"),
                    j =>
                    {
                        j.HasKey("FkPromotionTargetMapId", "FkTagId");
                        j.ToTable("PROMOTION_TARGET_TAG_MAP");
                        j.HasIndex(new[] { "FkTagId" }, "IX_PROMOTION_TARGET_TAG_MAP");
                        j.HasIndex(new[] { "FkPromotionTargetMapId" }, "IX_PROMOTION_TARGET_TAG_MAP_1");
                        j.IndexerProperty<int>("FkPromotionTargetMapId").HasColumnName("FK_PROMOTION_TARGET_MAP_ID");
                        j.IndexerProperty<string>("FkTagId")
                            .HasMaxLength(70)
                            .IsUnicode(false)
                            .HasColumnName("FK_TAG_ID");
                    });

            entity.HasMany(d => d.FkUsers).WithMany(p => p.FkPromotionTargetMaps)
                .UsingEntity<Dictionary<string, object>>(
                    "PromotionTargetUserMap",
                    r => r.HasOne<User>().WithMany()
                        .HasForeignKey("FkUserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PROMOTION_TARGET_USER_MAP_USER"),
                    l => l.HasOne<PromotionTargetMap>().WithMany()
                        .HasForeignKey("FkPromotionTargetMapId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PROMOTION_TARGET_USER_MAP_PROMOTION_TARGET_MAP"),
                    j =>
                    {
                        j.HasKey("FkPromotionTargetMapId", "FkUserId");
                        j.ToTable("PROMOTION_TARGET_USER_MAP");
                        j.HasIndex(new[] { "FkPromotionTargetMapId" }, "IX_PROMOTION_TARGET_USER_MAP");
                        j.HasIndex(new[] { "FkUserId" }, "IX_PROMOTION_TARGET_USER_MAP_1");
                        j.IndexerProperty<int>("FkPromotionTargetMapId").HasColumnName("FK_PROMOTION_TARGET_MAP_ID");
                        j.IndexerProperty<string>("FkUserId")
                            .HasMaxLength(50)
                            .IsUnicode(false)
                            .HasColumnName("FK_USER_ID");
                    });
        });

        modelBuilder.Entity<RackPlusProductPriceModelMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RACK_PLU__3214EC2767D4EE8B");

            entity.ToTable("RACK_PLUS_PRODUCT_PRICE_MODEL_MAP", tb => tb.HasTrigger("RPPPMM_HISTORY_LOGGING"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateApplicable)
                .HasColumnType("datetime")
                .HasColumnName("DATE_APPLICABLE");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Factor).HasColumnName("FACTOR");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REASON");
            entity.Property(e => e.Value).HasColumnName("VALUE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.RackPlusProductPriceModelMapCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RACK_PLUS__CREAT__7CC477D0");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.RackPlusProductPriceModelMaps)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RACK_PLUS__FK_PR__7EACC042");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.RackPlusProductPriceModelMapModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__RACK_PLUS__MODIF__009508B4");
        });

        modelBuilder.Entity<Recurrence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RECURREN__3214EC27A16ED620");

            entity.ToTable("RECURRENCE");

            entity.HasIndex(e => e.FkGroupId, "IX_RECURRENCE");

            entity.HasIndex(e => e.FkCustomerAddressId, "IX_RECURRENCE_1");

            entity.HasIndex(e => e.RecurrenceStatus, "IX_RECURRENCE_2");

            entity.HasIndex(e => e.NextExecutionDate, "IX_RECURRENCE_3");

            entity.HasIndex(e => e.EndsByDate, "IX_RECURRENCE_4");

            entity.HasIndex(e => e.RepeatType, "IX_RECURRENCE_5");

            entity.HasIndex(e => e.ForecastingProjection, "IX_RECURRENCE_6");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DayGapSummer).HasColumnName("DAY_GAP_SUMMER");
            entity.Property(e => e.DayGapTrans).HasColumnName("DAY_GAP_TRANS");
            entity.Property(e => e.DayGapWinter).HasColumnName("DAY_GAP_WINTER");
            entity.Property(e => e.DdGap).HasColumnName("DD_GAP");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.EndsByDate).HasColumnName("ENDS_BY_DATE");
            entity.Property(e => e.ExecutionCount).HasColumnName("EXECUTION_COUNT");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkGroupId).HasColumnName("FK_GROUP_ID");
            entity.Property(e => e.ForecastingProjection).HasColumnName("FORECASTING_PROJECTION");
            entity.Property(e => e.IsAutomaticDelivery).HasColumnName("IS_AUTOMATIC_DELIVERY");
            entity.Property(e => e.IsContinuous).HasColumnName("IS_CONTINUOUS");
            entity.Property(e => e.KFactor).HasColumnName("K_FACTOR");
            entity.Property(e => e.KFactorSummer).HasColumnName("K_FACTOR_SUMMER");
            entity.Property(e => e.KFactorTrans).HasColumnName("K_FACTOR_TRANS");
            entity.Property(e => e.KFactorWinter).HasColumnName("K_FACTOR_WINTER");
            entity.Property(e => e.LastExecutionDate).HasColumnName("LAST_EXECUTION_DATE");
            entity.Property(e => e.NextExecutionDate).HasColumnName("NEXT_EXECUTION_DATE");
            entity.Property(e => e.NumberOfRepeats).HasColumnName("NUMBER_OF_REPEATS");
            entity.Property(e => e.RecurrenceStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RECURRENCE_STATUS");
            entity.Property(e => e.RepeatInterval)
                .HasMaxLength(12)
                .HasColumnName("REPEAT_INTERVAL");
            entity.Property(e => e.RepeatType)
                .HasMaxLength(50)
                .HasColumnName("REPEAT_TYPE");
            entity.Property(e => e.RepeatsOnDateOfMonth).HasColumnName("REPEATS_ON_DATE_OF_MONTH");
            entity.Property(e => e.RepeatsOnDayOfWeek).HasColumnName("REPEATS_ON_DAY_OF_WEEK");
            entity.Property(e => e.RepeatsOnMonthOfQuarter).HasColumnName("REPEATS_ON_MONTH_OF_QUARTER");
            entity.Property(e => e.RepeatsOnWeek).HasColumnName("REPEATS_ON_WEEK");
            entity.Property(e => e.Runout)
                .HasColumnType("datetime")
                .HasColumnName("RUNOUT");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");
            entity.Property(e => e.TankMonitor)
                .HasMaxLength(50)
                .HasColumnName("TANK_MONITOR");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.Recurrences)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .HasConstraintName("FK_CUSTOMER_ADDRESS_RECURRENCE");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.Recurrences)
                .HasForeignKey(d => d.FkCustomerId)
                .HasConstraintName("FK_RECURRENCE_CUSTOMER");

            entity.HasOne(d => d.FkGroup).WithMany(p => p.Recurrences)
                .HasForeignKey(d => d.FkGroupId)
                .HasConstraintName("FK_GROUP_RECURRENCE");
        });

        modelBuilder.Entity<RecurrenceCharge>(entity =>
        {
            entity.ToTable("RECURRENCE_CHARGES");

            entity.HasIndex(e => e.FkProductId, "IX_RECURRENCE_CHARGES");

            entity.HasIndex(e => e.FkRecurrenceId, "IX_RECURRENCE_CHARGES_1");

            entity.HasIndex(e => e.FkVarianceId, "IX_RECURRENCE_CHARGES_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkRecurrenceId).HasColumnName("FK_RECURRENCE_ID");
            entity.Property(e => e.FkVarianceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FK_VARIANCE_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.FkRecurrence).WithMany(p => p.RecurrenceCharges)
                .HasForeignKey(d => d.FkRecurrenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RECURRENCE_CHARGES_RECURRENCE");
        });

        modelBuilder.Entity<RecurrenceDetail>(entity =>
        {
            entity.HasKey(e => new { e.FkRecurrenceId, e.FkCustomerId, e.FkProductId, e.VarianceId })
                .HasName("PK_RECURRENCE_DETAILS_1")
                .HasFillFactor(80);

            entity.ToTable("RECURRENCE_DETAILS");

            entity.HasIndex(e => e.FkRecurrenceId, "IX_RECURRENCE_DETAILS").HasFillFactor(80);

            entity.HasIndex(e => e.FkProductId, "IX_RECURRENCE_DETAILS_1").HasFillFactor(80);

            entity.HasIndex(e => e.FkCustomerId, "IX_RECURRENCE_DETAILS_2").HasFillFactor(80);

            entity.HasIndex(e => e.VarianceId, "IX_RECURRENCE_DETAILS_3").HasFillFactor(80);

            entity.Property(e => e.FkRecurrenceId).HasColumnName("FK_RECURRENCE_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.VarianceId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VARIANCE_ID");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");

            entity.HasOne(d => d.FkRecurrence).WithMany(p => p.RecurrenceDetails)
                .HasForeignKey(d => d.FkRecurrenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECURRENC__FK_RE__7B7B4DDC");

            entity.HasOne(d => d.CustomerProductVarianceMap).WithMany(p => p.RecurrenceDetails)
                .HasForeignKey(d => new { d.VarianceId, d.FkProductId, d.FkCustomerId })
                .HasConstraintName("FK_RECURRENCE_DETAILS_CUSTOMER_PRODUCT_VARIANCE_MAP");
        });

        modelBuilder.Entity<RecurrenceOrderSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ORDER_SETTINGS");

            entity.ToTable("RECURRENCE_ORDER_SETTINGS");

            entity.HasIndex(e => e.FkRecurrenceId, "IX_RECURRENCE_ORDER_SETTINGS");

            entity.HasIndex(e => e.FkCustomerId, "IX_RECURRENCE_ORDER_SETTINGS_1");

            entity.HasIndex(e => e.FkCustomerIdShip, "IX_RECURRENCE_ORDER_SETTINGS_2");

            entity.HasIndex(e => e.FkCustomerIdBill, "IX_RECURRENCE_ORDER_SETTINGS_3");

            entity.HasIndex(e => e.FkUserId, "IX_RECURRENCE_ORDER_SETTINGS_4");

            entity.HasIndex(e => e.FkShipTypeId, "IX_RECURRENCE_ORDER_SETTINGS_5");

            entity.HasIndex(e => e.FkShipVendorId, "IX_RECURRENCE_ORDER_SETTINGS_6");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AttentionLine)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ATTENTION_LINE");
            entity.Property(e => e.BillAddrCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_CITY");
            entity.Property(e => e.BillAddrCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_COUNTRY");
            entity.Property(e => e.BillAddrCountryCodeAlpha)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_COUNTRY_CODE_ALPHA");
            entity.Property(e => e.BillAddrState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_STATE");
            entity.Property(e => e.BillAddrStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_STREET");
            entity.Property(e => e.BillAddrZipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_ZIPCODE");
            entity.Property(e => e.CcTransactionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CC_TRANSACTION_ID");
            entity.Property(e => e.Comments)
                .IsUnicode(false)
                .HasColumnName("COMMENTS");
            entity.Property(e => e.DateSubmitted)
                .HasColumnType("datetime")
                .HasColumnName("DATE_SUBMITTED");
            entity.Property(e => e.DeliveryDate)
                .HasColumnType("datetime")
                .HasColumnName("DELIVERY_DATE");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkCustomerIdBill).HasColumnName("FK_CUSTOMER_ID_BILL");
            entity.Property(e => e.FkCustomerIdShip).HasColumnName("FK_CUSTOMER_ID_SHIP");
            entity.Property(e => e.FkRecurrenceId).HasColumnName("FK_RECURRENCE_ID");
            entity.Property(e => e.FkShipTypeId).HasColumnName("FK_SHIP_TYPE_ID");
            entity.Property(e => e.FkShipVendorId).HasColumnName("FK_SHIP_VENDOR_ID");
            entity.Property(e => e.FkSupplierVendorId).HasColumnName("FK_SUPPLIER_VENDOR_ID");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.FkUserTransactionId).HasColumnName("FK_USER_TRANSACTION_ID");
            entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            entity.Property(e => e.IntlContactEmail)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("INTL_CONTACT_EMAIL");
            entity.Property(e => e.IntlContactName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("INTL_CONTACT_NAME");
            entity.Property(e => e.IntlContactNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INTL_CONTACT_NUMBER");
            entity.Property(e => e.IsRushOrder).HasColumnName("IS_RUSH_ORDER");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ID");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORDER_NUMBER");
            entity.Property(e => e.OrderStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORDER_STATUS");
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_OPTION");
            entity.Property(e => e.PoNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PO_NUMBER");
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFERENCE_ID");
            entity.Property(e => e.ShipAddrCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_CITY");
            entity.Property(e => e.ShipAddrCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_COUNTRY");
            entity.Property(e => e.ShipAddrCountryCodeAlpha)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_COUNTRY_CODE_ALPHA");
            entity.Property(e => e.ShipAddrRecepientName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_RECEPIENT_NAME");
            entity.Property(e => e.ShipAddrRecepientNumber)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_RECEPIENT_NUMBER");
            entity.Property(e => e.ShipAddrState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_STATE");
            entity.Property(e => e.ShipAddrStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_STREET");
            entity.Property(e => e.ShipAddrZipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_ADDR_ZIPCODE");
            entity.Property(e => e.ShipSiteId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_SITE_ID");
            entity.Property(e => e.ShipSiteName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SHIP_SITE_NAME");
            entity.Property(e => e.TaxId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAX_ID");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.UserLegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USER_LEGACY_ID");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.RecurrenceOrderSettingFkCustomers)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECURRENC__FK_CU__0A1E72EE");

            entity.HasOne(d => d.FkCustomerIdBillNavigation).WithMany(p => p.RecurrenceOrderSettingFkCustomerIdBillNavigations)
                .HasForeignKey(d => d.FkCustomerIdBill)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECURRENC__FK_CU__08362A7C");

            entity.HasOne(d => d.FkCustomerIdShipNavigation).WithMany(p => p.RecurrenceOrderSettingFkCustomerIdShipNavigations)
                .HasForeignKey(d => d.FkCustomerIdShip)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECURRENC__FK_CU__092A4EB5");

            entity.HasOne(d => d.FkRecurrence).WithMany(p => p.RecurrenceOrderSettings)
                .HasForeignKey(d => d.FkRecurrenceId)
                .HasConstraintName("FK__ORDER_SET__FK_RE__2759D01A");

            entity.HasOne(d => d.FkShipType).WithMany(p => p.RecurrenceOrderSettings)
                .HasForeignKey(d => d.FkShipTypeId)
                .HasConstraintName("FK__RECURRENC__FK_SH__0EE3280B");

            entity.HasOne(d => d.FkShipVendor).WithMany(p => p.RecurrenceOrderSettings)
                .HasForeignKey(d => d.FkShipVendorId)
                .HasConstraintName("FK__RECURRENC__FK_SH__0DEF03D2");

            entity.HasOne(d => d.FkUser).WithMany(p => p.RecurrenceOrderSettings)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RECURRENC__FK_US__11BF94B6");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__REGION__3214EC277522CBFC");

            entity.ToTable("REGION");

            entity.HasIndex(e => e.Type, "IX_REGION_1");

            entity.HasIndex(e => e.Name, "IX_REGION_2");

            entity.HasIndex(e => e.DateCreated, "IX_REGION_3");

            entity.HasIndex(e => e.DateModified, "IX_REGION_4");

            entity.HasIndex(e => e.CreatedBy, "IX_REGION_5");

            entity.HasIndex(e => e.ModifiedBy, "IX_REGION_6");

            entity.HasIndex(e => e.Description, "IX_REGION_7");

            entity.HasIndex(e => e.NsExid, "IX_REGION_8");

            entity.HasIndex(e => e.RegionCode, "UQ__REGION__5714604F15ED7BA8").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CountryCodeAlpha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_CODE_ALPHA");
            entity.Property(e => e.CountryCodeDigit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_CODE_DIGIT");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CurrentSeason)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CURRENT_SEASON");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Latitude).HasColumnName("LATITUDE");
            entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NsExid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NS_EXID");
            entity.Property(e => e.RegionCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REGION_CODE");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATE");
            entity.Property(e => e.Street)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("STREET");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZIPCODE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.RegionCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__REGION__CREATED___149C0161");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.RegionModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__REGION__MODIFIED__168449D3");
        });

        modelBuilder.Entity<RegionProductPriceMap>(entity =>
        {
            entity.ToTable("REGION_PRODUCT_PRICE_MAP", tb => tb.HasTrigger("RPPM_History_Logging"));

            entity.HasIndex(e => e.FkProductId, "IX_REGION_PRODUCT_PRICE_MAP");

            entity.HasIndex(e => e.FkRegionId, "IX_REGION_PRODUCT_PRICE_MAP_1");

            entity.HasIndex(e => e.CreatedBy, "IX_REGION_PRODUCT_PRICE_MAP_2");

            entity.HasIndex(e => e.ModifiedBy, "IX_REGION_PRODUCT_PRICE_MAP_3");

            entity.HasIndex(e => e.DateCreated, "IX_REGION_PRODUCT_PRICE_MAP_4");

            entity.HasIndex(e => e.DateModified, "IX_REGION_PRODUCT_PRICE_MAP_5");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateApplicable)
                .HasColumnType("datetime")
                .HasColumnName("DATE_APPLICABLE");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkRegionId).HasColumnName("FK_REGION_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.PriceClass)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRICE_CLASS");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REASON");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Value).HasColumnName("VALUE");
            entity.Property(e => e.Variance)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VARIANCE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.RegionProductPriceMapCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REGION_PRODUCT_PRICE_MAP_USER");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.RegionProductPriceMaps)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REGION_PRODUCT_PRICE_MAP_PRODUCT");

            entity.HasOne(d => d.FkRegion).WithMany(p => p.RegionProductPriceMaps)
                .HasForeignKey(d => d.FkRegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REGION_PRODUCT_PRICE_MAP_REGION");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.RegionProductPriceMapModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_REGION_PRODUCT_PRICE_MAP_USER1");
        });

        modelBuilder.Entity<RegionProductPriceZoneClassMap>(entity =>
        {
            entity.ToTable("REGION_PRODUCT_PRICE_ZONE_CLASS_MAP", tb => tb.HasTrigger("RPPZCM_HISTORY_LOGGING"));

            entity.HasIndex(e => e.FkProductId, "IX_REGION_PRODUCT_PRICE_ZONE_CLASS_MAP");

            entity.HasIndex(e => e.FkRegionId, "IX_REGION_PRODUCT_PRICE_ZONE_CLASS_MAP_1");

            entity.HasIndex(e => e.PriceZoneCode, "IX_REGION_PRODUCT_PRICE_ZONE_CLASS_MAP_2");

            entity.HasIndex(e => e.PriceClass, "IX_REGION_PRODUCT_PRICE_ZONE_CLASS_MAP_3");

            entity.HasIndex(e => e.CreatedBy, "IX_REGION_PRODUCT_PRICE_ZONE_CLASS_MAP_4");

            entity.HasIndex(e => e.DateCreated, "IX_REGION_PRODUCT_PRICE_ZONE_CLASS_MAP_5");

            entity.HasIndex(e => e.ModifiedBy, "IX_REGION_PRODUCT_PRICE_ZONE_CLASS_MAP_6");

            entity.HasIndex(e => e.DateModified, "IX_REGION_PRODUCT_PRICE_ZONE_CLASS_MAP_7");

            entity.HasIndex(e => e.Value, "IX_REGION_PRODUCT_PRICE_ZONE_CLASS_MAP_8");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateApplicable)
                .HasColumnType("datetime")
                .HasColumnName("DATE_APPLICABLE");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkRegionId).HasColumnName("FK_REGION_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.PriceClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_CLASS");
            entity.Property(e => e.PriceZoneCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_ZONE_CODE");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REASON");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Value).HasColumnName("VALUE");
            entity.Property(e => e.Variance)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VARIANCE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.RegionProductPriceZoneClassMapCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REGION_PRODUCT_PRICE_ZONE_CLASS_MAP_USER");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.RegionProductPriceZoneClassMaps)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REGION_PRODUCT_PRICE_ZONE_CLASS_MAP_PRODUCT");

            entity.HasOne(d => d.FkRegion).WithMany(p => p.RegionProductPriceZoneClassMaps)
                .HasForeignKey(d => d.FkRegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REGION_PRODUCT_PRICE_ZONE_CLASS_MAP_REGION");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.RegionProductPriceZoneClassMapModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_REGION_PRODUCT_PRICE_ZONE_CLASS_MAP_USER1");
        });

        modelBuilder.Entity<RegionProductWeatherMap>(entity =>
        {
            entity.ToTable("REGION_PRODUCT_WEATHER_MAP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkRegionId).HasColumnName("FK_REGION_ID");
            entity.Property(e => e.FkWeatherStationId).HasColumnName("FK_WEATHER_STATION_ID");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.RegionProductWeatherMaps)
                .HasForeignKey(d => d.FkProductId)
                .HasConstraintName("FK_REGION_PRODUCT_WEATHER_MAP_PRODUCT");

            entity.HasOne(d => d.FkRegion).WithMany(p => p.RegionProductWeatherMaps)
                .HasForeignKey(d => d.FkRegionId)
                .HasConstraintName("FK_REGION_PRODUCT_WEATHER_MAP_REGION");

            entity.HasOne(d => d.FkWeatherStation).WithMany(p => p.RegionProductWeatherMaps)
                .HasForeignKey(d => d.FkWeatherStationId)
                .HasConstraintName("FK_REGION_PRODUCT_WEATHER_MAP_WEATHER_STATION");
        });

        modelBuilder.Entity<RegionTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("REGION_TEMP");

            entity.Property(e => e.CreationDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModificationDateTime).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.RegionCode).HasMaxLength(10);
            entity.Property(e => e.RegionName).HasMaxLength(100);
        });

        modelBuilder.Entity<RegionUserMap>(entity =>
        {
            entity.HasKey(e => new { e.FkRegionId, e.FkUserId });

            entity.ToTable("REGION_USER_MAP");

            entity.HasIndex(e => e.FkRegionId, "IX_REGION_USER_MAP");

            entity.HasIndex(e => e.FkUserId, "IX_REGION_USER_MAP_1");

            entity.HasIndex(e => e.CreatedBy, "IX_REGION_USER_MAP_2");

            entity.HasIndex(e => e.DateCreated, "IX_REGION_USER_MAP_3");

            entity.Property(e => e.FkRegionId).HasColumnName("FK_REGION_ID");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.RegionUserMapCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REGION_USER_MAP_USER1");

            entity.HasOne(d => d.FkRegion).WithMany(p => p.RegionUserMaps)
                .HasForeignKey(d => d.FkRegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REGION_USER_MAP_REGION");

            entity.HasOne(d => d.FkUser).WithMany(p => p.RegionUserMapFkUsers)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REGION_USER_MAP_USER");
        });

        modelBuilder.Entity<RemittanceAddress>(entity =>
        {
            entity.ToTable("REMITTANCE_ADDRESS");

            entity.HasIndex(e => e.Zipcode, "IX_REMITTANCE_ADDRESS_1");

            entity.HasIndex(e => e.CountryCodeDigit, "IX_REMITTANCE_ADDRESS_10");

            entity.HasIndex(e => e.Name, "IX_REMITTANCE_ADDRESS_11");

            entity.HasIndex(e => e.Description, "IX_REMITTANCE_ADDRESS_12");

            entity.HasIndex(e => e.ContactPerson, "IX_REMITTANCE_ADDRESS_13");

            entity.HasIndex(e => e.Email, "IX_REMITTANCE_ADDRESS_14");

            entity.HasIndex(e => e.MobileNumber, "IX_REMITTANCE_ADDRESS_15");

            entity.HasIndex(e => e.AlternateNumber, "IX_REMITTANCE_ADDRESS_16");

            entity.HasIndex(e => e.DateCreated, "IX_REMITTANCE_ADDRESS_17");

            entity.HasIndex(e => e.CreatedBy, "IX_REMITTANCE_ADDRESS_18");

            entity.HasIndex(e => e.DateModified, "IX_REMITTANCE_ADDRESS_19");

            entity.HasIndex(e => e.State, "IX_REMITTANCE_ADDRESS_2");

            entity.HasIndex(e => e.ModifiedBy, "IX_REMITTANCE_ADDRESS_20");

            entity.HasIndex(e => e.Province, "IX_REMITTANCE_ADDRESS_21");

            entity.HasIndex(e => e.Status, "IX_REMITTANCE_ADDRESS_22");

            entity.HasIndex(e => e.City, "IX_REMITTANCE_ADDRESS_3");

            entity.HasIndex(e => e.Street, "IX_REMITTANCE_ADDRESS_4");

            entity.HasIndex(e => e.Longitude, "IX_REMITTANCE_ADDRESS_5");

            entity.HasIndex(e => e.Latitude, "IX_REMITTANCE_ADDRESS_6");

            entity.HasIndex(e => e.Country, "IX_REMITTANCE_ADDRESS_7");

            entity.HasIndex(e => e.Type, "IX_REMITTANCE_ADDRESS_8");

            entity.HasIndex(e => e.CountryCodeAlpha, "IX_REMITTANCE_ADDRESS_9");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AlternateNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALTERNATE_NUMBER");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CONTACT_PERSON");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CountryCodeAlpha)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_CODE_ALPHA");
            entity.Property(e => e.CountryCodeDigit)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_CODE_DIGIT");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");
            entity.Property(e => e.Latitude).HasColumnName("LATITUDE");
            entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MOBILE_NUMBER");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Province)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PROVINCE");
            entity.Property(e => e.State)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STATE");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Street)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("STREET");
            entity.Property(e => e.Street2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("STREET2");
            entity.Property(e => e.Street3)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("STREET3");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ZIPCODE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.RemittanceAddressCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_REMITTANCE_ADDRESS_USER_1");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.RemittanceAddressModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_REMITTANCE_ADDRESS_USER_2");
        });

        modelBuilder.Entity<RemittanceAddressRegionInventoryLocationMap>(entity =>
        {
            entity.ToTable("REMITTANCE_ADDRESS_REGION_INVENTORY_LOCATION_MAP");

            entity.HasIndex(e => e.FkRemittanceAddressId, "IX_REMITTANCE_ADDRESS_REGION_INVENTORY_LOCATION_MAP_1");

            entity.HasIndex(e => e.FkRegionId, "IX_REMITTANCE_ADDRESS_REGION_INVENTORY_LOCATION_MAP_2");

            entity.HasIndex(e => e.FkInventoryLocationId, "IX_REMITTANCE_ADDRESS_REGION_INVENTORY_LOCATION_MAP_3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkInventoryLocationId).HasColumnName("FK_INVENTORY_LOCATION_ID");
            entity.Property(e => e.FkRegionId).HasColumnName("FK_REGION_ID");
            entity.Property(e => e.FkRemittanceAddressId).HasColumnName("FK_REMITTANCE_ADDRESS_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.FkInventoryLocation).WithMany(p => p.RemittanceAddressRegionInventoryLocationMaps)
                .HasForeignKey(d => d.FkInventoryLocationId)
                .HasConstraintName("FK_REMITTANCE_ADDRESS_REGION_INVENTORY_LOCATION_MAP_INVENTORY_LOCATION");

            entity.HasOne(d => d.FkRegion).WithMany(p => p.RemittanceAddressRegionInventoryLocationMaps)
                .HasForeignKey(d => d.FkRegionId)
                .HasConstraintName("FK_REMITTANCE_ADDRESS_REGION_INVENTORY_LOCATION_MAP_REGION");

            entity.HasOne(d => d.FkRemittanceAddress).WithMany(p => p.RemittanceAddressRegionInventoryLocationMaps)
                .HasForeignKey(d => d.FkRemittanceAddressId)
                .HasConstraintName("FK_REMITTANCE_ADDRESS_REGION_INVENTORY_LOCATION_MAP_REMITTANCE_ADDRESS");
        });

        modelBuilder.Entity<ReportProductProductionCapability>(entity =>
        {
            entity.ToTable("REPORT_PRODUCT_PRODUCTION_CAPABILITY");

            entity.HasIndex(e => e.ProductCode, "IX_REPORT_PRODUCT_PRODUCTION_CAPABILITY");

            entity.HasIndex(e => e.ProductId, "IX_REPORT_PRODUCT_PRODUCTION_CAPABILITY_1");

            entity.HasIndex(e => e.ProductName, "IX_REPORT_PRODUCT_PRODUCTION_CAPABILITY_2");

            entity.HasIndex(e => e.ProductType, "IX_REPORT_PRODUCT_PRODUCTION_CAPABILITY_3");

            entity.HasIndex(e => e.IsDeleted, "IX_REPORT_PRODUCT_PRODUCTION_CAPABILITY_4");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(false)
                .HasColumnName("IS_DELETED");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_CODE");
            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_NAME");
            entity.Property(e => e.ProductType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_TYPE");
            entity.Property(e => e.TotalInventoryCount).HasColumnName("TOTAL_INVENTORY_COUNT");
            entity.Property(e => e.TotalProductionRunCapability).HasColumnName("TOTAL_PRODUCTION_RUN_CAPABILITY");
        });

        modelBuilder.Entity<Response>(entity =>
        {
            entity.ToTable("RESPONSE");

            entity.HasIndex(e => e.FkCustomerId, "IX_RESPONSE");

            entity.HasIndex(e => e.ResponseCode, "IX_RESPONSE_1");

            entity.HasIndex(e => e.FormReferenceId, "IX_RESPONSE_2");

            entity.HasIndex(e => e.DateSubmitted, "IX_RESPONSE_3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateSubmitted)
                .HasColumnType("datetime")
                .HasColumnName("DATE_SUBMITTED");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FormName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("FORM_NAME");
            entity.Property(e => e.FormReferenceId).HasColumnName("FORM_REFERENCE_ID");
            entity.Property(e => e.FormType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FORM_TYPE");
            entity.Property(e => e.RespondentContactNumber)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("RESPONDENT_CONTACT_NUMBER");
            entity.Property(e => e.RespondentEmail)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RESPONDENT_EMAIL");
            entity.Property(e => e.RespondentName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("RESPONDENT_NAME");
            entity.Property(e => e.RespondentUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("RESPONDENT_USER_ID");
            entity.Property(e => e.ResponseCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RESPONSE_CODE");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.Responses)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_1_CUSTOMER");
        });

        modelBuilder.Entity<ResponseQuestion>(entity =>
        {
            entity.ToTable("RESPONSE_QUESTIONS");

            entity.HasIndex(e => e.FkResponseId, "IX_RESPONSE_QUESTIONS");

            entity.HasIndex(e => e.Sequence, "IX_RESPONSE_QUESTIONS_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Answer)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ANSWER");
            entity.Property(e => e.Filename)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("FILENAME");
            entity.Property(e => e.FkResponseId).HasColumnName("FK_RESPONSE_ID");
            entity.Property(e => e.FormQuestionReferenceId).HasColumnName("FORM_QUESTION_REFERENCE_ID");
            entity.Property(e => e.Guid)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("GUID");
            entity.Property(e => e.IsRequired).HasColumnName("IS_REQUIRED");
            entity.Property(e => e.Label)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("LABEL");
            entity.Property(e => e.QuestionType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("QUESTION_TYPE");
            entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
            entity.Property(e => e.UrlBase)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URL_BASE");
            entity.Property(e => e.UrlContainer)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URL_CONTAINER");
            entity.Property(e => e.UrlEntity)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URL_ENTITY");

            entity.HasOne(d => d.FkResponse).WithMany(p => p.ResponseQuestions)
                .HasForeignKey(d => d.FkResponseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RESPONSE_QUESTIONS_RESPONSE");
        });

        modelBuilder.Entity<ResponseSubQuestion>(entity =>
        {
            entity.ToTable("RESPONSE_SUB_QUESTIONS");

            entity.HasIndex(e => e.FkResponseQuestionId, "IX_RESPONSE_SUB_QUESTIONS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Answer)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ANSWER");
            entity.Property(e => e.FkResponseQuestionId).HasColumnName("FK_RESPONSE_QUESTION_ID");
            entity.Property(e => e.FormSubQuestionReferenceId).HasColumnName("FORM_SUB_QUESTION_REFERENCE_ID");
            entity.Property(e => e.Label)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("LABEL");
            entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

            entity.HasOne(d => d.FkResponseQuestion).WithMany(p => p.ResponseSubQuestions)
                .HasForeignKey(d => d.FkResponseQuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RESPONSE_SUB_QUESTIONS_RESPONSE_QUESTIONS");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("ROLE");

            entity.HasIndex(e => e.FkCustomerId, "IX_ROLE");

            entity.HasIndex(e => new { e.Id, e.FkCustomerId }, "IX_ROLE_1").IsUnique();

            entity.HasIndex(e => e.RoleType, "IX_ROLE_2");

            entity.HasIndex(e => e.PermissionType, "IX_ROLE_3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.IsCore).HasColumnName("IS_CORE");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.PermissionType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PERMISSION_TYPE");
            entity.Property(e => e.RoleType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ROLE_TYPE");
            entity.Property(e => e.TemporaryCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEMPORARY_CODE");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.Roles)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ROLE_CUSTOMER");
        });

        modelBuilder.Entity<RolePermissionMap>(entity =>
        {
            entity.HasKey(e => new { e.FkRoleId, e.FkPermissionId });

            entity.ToTable("ROLE_PERMISSION_MAP");

            entity.HasIndex(e => e.FkRoleId, "IX_ROLE_PERMISSION_MAP");

            entity.HasIndex(e => e.FkPermissionId, "IX_ROLE_PERMISSION_MAP_1");

            entity.Property(e => e.FkRoleId).HasColumnName("FK_ROLE_ID");
            entity.Property(e => e.FkPermissionId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("FK_PERMISSION_ID");

            entity.HasOne(d => d.FkPermission).WithMany(p => p.RolePermissionMaps)
                .HasForeignKey(d => d.FkPermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ROLE_PERMISSION_MAP_PERMISSION");

            entity.HasOne(d => d.FkRole).WithMany(p => p.RolePermissionMaps)
                .HasForeignKey(d => d.FkRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ROLE_PERMISSION_MAP_ROLE");
        });

        modelBuilder.Entity<RppmHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RPPM_HIS__3214EC2721AD9FCA");

            entity.ToTable("RPPM_HISTORY");

            entity.HasIndex(e => e.ReferenceRppmId, "IX_RPPM_HISTORY");

            entity.HasIndex(e => e.PriceClass, "IX_RPPM_HISTORY_1");

            entity.HasIndex(e => e.Type, "IX_RPPM_HISTORY_2");

            entity.HasIndex(e => e.Value, "IX_RPPM_HISTORY_3");

            entity.HasIndex(e => e.Variance, "IX_RPPM_HISTORY_4");

            entity.HasIndex(e => e.CreatedBy, "IX_RPPM_HISTORY_5");

            entity.HasIndex(e => e.DateCreated, "IX_RPPM_HISTORY_6");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateApplicable)
                .HasColumnType("datetime")
                .HasColumnName("DATE_APPLICABLE");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.PriceClass)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PRICE_CLASS");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REASON");
            entity.Property(e => e.ReferenceRppmId).HasColumnName("REFERENCE_RPPM_ID");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Value).HasColumnName("VALUE");
            entity.Property(e => e.Variance)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VARIANCE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.RppmHistories)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RPPM_HIST__CREAT__30441BD6");
        });

        modelBuilder.Entity<RpppmmHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RPPPMM_H__3214EC274A92DD94");

            entity.ToTable("RPPPMM_HISTORY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateApplicable)
                .HasColumnType("datetime")
                .HasColumnName("DATE_APPLICABLE");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.Factor).HasColumnName("FACTOR");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REASON");
            entity.Property(e => e.ReferenceRpppmm).HasColumnName("REFERENCE_RPPPMM");
            entity.Property(e => e.Value).HasColumnName("VALUE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.RpppmmHistories)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RPPPMM_HI__CREAT__322C6448");
        });

        modelBuilder.Entity<RppzcmHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RPPZCM_H__3214EC278E597F2C");

            entity.ToTable("RPPZCM_HISTORY");

            entity.HasIndex(e => e.ReferenceRppzcmId, "IX_RPPZCM_HISTORY");

            entity.HasIndex(e => e.PriceZoneCode, "IX_RPPZCM_HISTORY_1");

            entity.HasIndex(e => e.PriceClass, "IX_RPPZCM_HISTORY_2");

            entity.HasIndex(e => e.Type, "IX_RPPZCM_HISTORY_3");

            entity.HasIndex(e => e.Value, "IX_RPPZCM_HISTORY_4");

            entity.HasIndex(e => e.Variance, "IX_RPPZCM_HISTORY_5");

            entity.HasIndex(e => e.CreatedBy, "IX_RPPZCM_HISTORY_6");

            entity.HasIndex(e => e.DateCreated, "IX_RPPZCM_HISTORY_7");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("ACTION");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateApplicable).HasColumnName("DATE_APPLICABLE");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.PriceClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_CLASS");
            entity.Property(e => e.PriceZoneCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PRICE_ZONE_CODE");
            entity.Property(e => e.Reason)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("REASON");
            entity.Property(e => e.ReferenceRppzcmId).HasColumnName("REFERENCE_RPPZCM_ID");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Value).HasColumnName("VALUE");
            entity.Property(e => e.Variance)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VARIANCE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.RppzcmHistories)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__RPPZCM_HI__CREAT__3414ACBA");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SERVICE_1");

            entity.ToTable("SERVICE");

            entity.HasIndex(e => e.ServiceCode, "IX_SERVICE_1").IsUnique();

            entity.HasIndex(e => e.Name, "IX_SERVICE_2");

            entity.HasIndex(e => e.Status, "IX_SERVICE_3");

            entity.HasIndex(e => e.LegacyId, "IX_SERVICE_4");

            entity.HasIndex(e => e.Type, "IX_SERVICE_5");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActualChargerStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACTUAL_CHARGER_STATUS");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.LastHeartbeat)
                .HasColumnType("datetime")
                .HasColumnName("LAST_HEARTBEAT");
            entity.Property(e => e.Latitude).HasColumnName("LATITUDE");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ID");
            entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.ServiceCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVICE_CODE");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("STATE");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Street)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("STREET");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ZIPCODE");
        });

        modelBuilder.Entity<ServiceAsset>(entity =>
        {
            entity.ToTable("SERVICE_ASSET");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Filename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FILENAME");
            entity.Property(e => e.FkServiceId).HasColumnName("FK_SERVICE_ID");
            entity.Property(e => e.IsDefault)
                .HasDefaultValue(false)
                .HasColumnName("IS_DEFAULT");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Url)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.HasOne(d => d.FkService).WithMany(p => p.ServiceAssets)
                .HasForeignKey(d => d.FkServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SERVICE_ASSET_SERVICE");
        });

        modelBuilder.Entity<ServiceAttributeDefinition>(entity =>
        {
            entity.HasKey(e => e.ColumnName);

            entity.ToTable("SERVICE_ATTRIBUTE_DEFINITION");

            entity.HasIndex(e => e.ServiceType, "IX_SERVICE_ATTRIBUTE_DEFINITION");

            entity.HasIndex(e => e.IsActive, "IX_SERVICE_ATTRIBUTE_DEFINITION_1");

            entity.HasIndex(e => e.IsDeleted, "IX_SERVICE_ATTRIBUTE_DEFINITION_2");

            entity.Property(e => e.ColumnName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COLUMN_NAME");
            entity.Property(e => e.AttributeDataType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE_DATA_TYPE");
            entity.Property(e => e.AttributeName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE_NAME");
            entity.Property(e => e.AttributeType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE_TYPE");
            entity.Property(e => e.AttributeUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ATTRIBUTE_UNIT");
            entity.Property(e => e.DefaultValue)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DEFAULT_VALUE");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
            entity.Property(e => e.OptionType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPTION_TYPE");
            entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("SERVICE_TYPE");
        });

        modelBuilder.Entity<ServiceAttributeValue>(entity =>
        {
            entity.HasKey(e => new { e.FkColumnName, e.Sequence });

            entity.ToTable("SERVICE_ATTRIBUTE_VALUE");

            entity.Property(e => e.FkColumnName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_COLUMN_NAME");
            entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");
            entity.Property(e => e.Value)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("VALUE");

            entity.HasOne(d => d.FkColumnNameNavigation).WithMany(p => p.ServiceAttributeValues)
                .HasForeignKey(d => d.FkColumnName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SERVICE_ATTRIBUTE_VALUE_SERVICE_ATTRIBUTE_DEFINITION");
        });

        modelBuilder.Entity<ServiceClientAttribute>(entity =>
        {
            entity.HasKey(e => e.FkServiceId);

            entity.ToTable("SERVICE_CLIENT_ATTRIBUTES");

            entity.HasIndex(e => e.Column01, "IX_SERVICE_CLIENT_ATTRIBUTES");

            entity.HasIndex(e => e.Column02, "IX_SERVICE_CLIENT_ATTRIBUTES_1");

            entity.HasIndex(e => e.Column03, "IX_SERVICE_CLIENT_ATTRIBUTES_10");

            entity.HasIndex(e => e.Column04, "IX_SERVICE_CLIENT_ATTRIBUTES_11");

            entity.HasIndex(e => e.Column05, "IX_SERVICE_CLIENT_ATTRIBUTES_12");

            entity.HasIndex(e => e.Column06, "IX_SERVICE_CLIENT_ATTRIBUTES_13");

            entity.HasIndex(e => e.Column07, "IX_SERVICE_CLIENT_ATTRIBUTES_14");

            entity.HasIndex(e => e.Column08, "IX_SERVICE_CLIENT_ATTRIBUTES_15");

            entity.HasIndex(e => e.Column09, "IX_SERVICE_CLIENT_ATTRIBUTES_16");

            entity.HasIndex(e => e.Column10, "IX_SERVICE_CLIENT_ATTRIBUTES_17");

            entity.HasIndex(e => e.Column11, "IX_SERVICE_CLIENT_ATTRIBUTES_18");

            entity.HasIndex(e => e.Column12, "IX_SERVICE_CLIENT_ATTRIBUTES_19");

            entity.HasIndex(e => e.Column13, "IX_SERVICE_CLIENT_ATTRIBUTES_2");

            entity.HasIndex(e => e.Column14, "IX_SERVICE_CLIENT_ATTRIBUTES_20");

            entity.HasIndex(e => e.Column15, "IX_SERVICE_CLIENT_ATTRIBUTES_21");

            entity.HasIndex(e => e.Column16, "IX_SERVICE_CLIENT_ATTRIBUTES_22");

            entity.HasIndex(e => e.Column17, "IX_SERVICE_CLIENT_ATTRIBUTES_23");

            entity.HasIndex(e => e.Column18, "IX_SERVICE_CLIENT_ATTRIBUTES_24");

            entity.HasIndex(e => e.Column19, "IX_SERVICE_CLIENT_ATTRIBUTES_25");

            entity.HasIndex(e => e.Column20, "IX_SERVICE_CLIENT_ATTRIBUTES_26");

            entity.HasIndex(e => e.Column21, "IX_SERVICE_CLIENT_ATTRIBUTES_27");

            entity.HasIndex(e => e.Column22, "IX_SERVICE_CLIENT_ATTRIBUTES_28");

            entity.HasIndex(e => e.Column23, "IX_SERVICE_CLIENT_ATTRIBUTES_29");

            entity.HasIndex(e => e.Column24, "IX_SERVICE_CLIENT_ATTRIBUTES_3");

            entity.HasIndex(e => e.Column25, "IX_SERVICE_CLIENT_ATTRIBUTES_4");

            entity.HasIndex(e => e.Column26, "IX_SERVICE_CLIENT_ATTRIBUTES_5");

            entity.HasIndex(e => e.Column27, "IX_SERVICE_CLIENT_ATTRIBUTES_6");

            entity.HasIndex(e => e.Column28, "IX_SERVICE_CLIENT_ATTRIBUTES_7");

            entity.HasIndex(e => e.Column29, "IX_SERVICE_CLIENT_ATTRIBUTES_8");

            entity.HasIndex(e => e.Column30, "IX_SERVICE_CLIENT_ATTRIBUTES_9");

            entity.Property(e => e.FkServiceId)
                .ValueGeneratedNever()
                .HasColumnName("FK_SERVICE_ID");
            entity.Property(e => e.Column01)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_01");
            entity.Property(e => e.Column02)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_02");
            entity.Property(e => e.Column03)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_03");
            entity.Property(e => e.Column04)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_04");
            entity.Property(e => e.Column05)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_05");
            entity.Property(e => e.Column06)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_06");
            entity.Property(e => e.Column07)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_07");
            entity.Property(e => e.Column08)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_08");
            entity.Property(e => e.Column09)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_09");
            entity.Property(e => e.Column10)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_10");
            entity.Property(e => e.Column11)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_11");
            entity.Property(e => e.Column12)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_12");
            entity.Property(e => e.Column13)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_13");
            entity.Property(e => e.Column14)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_14");
            entity.Property(e => e.Column15)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_15");
            entity.Property(e => e.Column16)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_16");
            entity.Property(e => e.Column17)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_17");
            entity.Property(e => e.Column18)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_18");
            entity.Property(e => e.Column19)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_19");
            entity.Property(e => e.Column20)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_20");
            entity.Property(e => e.Column21)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_21");
            entity.Property(e => e.Column22)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_22");
            entity.Property(e => e.Column23)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_23");
            entity.Property(e => e.Column24)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_24");
            entity.Property(e => e.Column25)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_25");
            entity.Property(e => e.Column26)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_26");
            entity.Property(e => e.Column27)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_27");
            entity.Property(e => e.Column28)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_28");
            entity.Property(e => e.Column29)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_29");
            entity.Property(e => e.Column30)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("COLUMN_30");
        });

        modelBuilder.Entity<ServicePrice>(entity =>
        {
            entity.ToTable("SERVICE_PRICE");

            entity.HasIndex(e => e.FkServiceId, "IX_SERVICE_PRICE");

            entity.HasIndex(e => e.Name, "IX_SERVICE_PRICE_1");

            entity.HasIndex(e => e.Price, "IX_SERVICE_PRICE_2");

            entity.HasIndex(e => e.IsActive, "IX_SERVICE_PRICE_3");

            entity.HasIndex(e => e.Uom, "IX_SERVICE_PRICE_4");

            entity.HasIndex(e => e.IsBasePrice, "IX_SERVICE_PRICE_5");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkServiceId).HasColumnName("FK_SERVICE_ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.IsBasePrice).HasColumnName("IS_BASE_PRICE");
            entity.Property(e => e.IsPublic).HasColumnName("IS_PUBLIC");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Uom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UOM");

            entity.HasOne(d => d.FkService).WithMany(p => p.ServicePrices)
                .HasForeignKey(d => d.FkServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SERVICE_PRICE_SERVICE");
        });

        modelBuilder.Entity<ServiceRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SERVICE___3214EC275332AC47");

            entity.ToTable("SERVICE_REQUEST");

            entity.HasIndex(e => e.ServiceRequestSource, "IX_SERVICE_REQUEST_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConfirmedPrice).HasColumnName("CONFIRMED_PRICE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_ADDRESS");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.InitialPrice).HasColumnName("INITIAL_PRICE");
            entity.Property(e => e.IsAdminCreated).HasColumnName("IS_ADMIN_CREATED");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Notes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            entity.Property(e => e.Reason)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("REASON");
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REFERENCE_ID");
            entity.Property(e => e.RegionId).HasColumnName("REGION_ID");
            entity.Property(e => e.ServiceDate)
                .HasColumnType("datetime")
                .HasColumnName("SERVICE_DATE");
            entity.Property(e => e.ServiceRequestSource)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SERVICE_REQUEST_SOURCE");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.TankId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TANK_ID");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.WithProtectionPlan).HasColumnName("WITH_PROTECTION_PLAN");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ServiceRequestCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SERVICE_R__CREAT__38D961D7");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.ServiceRequests)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .HasConstraintName("FK__SERVICE_R__FK_CU__3AC1AA49");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.ServiceRequests)
                .HasForeignKey(d => d.FkCustomerId)
                .HasConstraintName("FK__SERVICE_R__FK_CU__3BB5CE82");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.ServiceRequests)
                .HasForeignKey(d => d.FkProductId)
                .HasConstraintName("FK__SERVICE_R__FK_PR__3E923B2D");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.ServiceRequestModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__SERVICE_R__MODIF__407A839F");
        });

        modelBuilder.Entity<ServiceRequestFormResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SERVICE___3214EC27DBCEBA25");

            entity.ToTable("SERVICE_REQUEST_FORM_RESPONSES");

            entity.HasIndex(e => e.DateCreated, "IX_SERVICE_REQUEST_FORM_RESPONSES_1");

            entity.HasIndex(e => e.CreatedBy, "IX_SERVICE_REQUEST_FORM_RESPONSES_2");

            entity.HasIndex(e => e.DateModified, "IX_SERVICE_REQUEST_FORM_RESPONSES_3");

            entity.HasIndex(e => e.ModifiedBy, "IX_SERVICE_REQUEST_FORM_RESPONSES_4");

            entity.HasIndex(e => e.FkServiceRequestId, "IX_SERVICE_REQUEST_FORM_RESPONSES_5");

            entity.HasIndex(e => e.FkFormsId, "IX_SERVICE_REQUEST_FORM_RESPONSES_6");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkFormsId).HasColumnName("FK_FORMS_ID");
            entity.Property(e => e.FkResponseId).HasColumnName("FK_RESPONSE_ID");
            entity.Property(e => e.FkServiceRequestId).HasColumnName("FK_SERVICE_REQUEST_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");

            entity.HasOne(d => d.FkServiceRequest).WithMany(p => p.ServiceRequestFormResponses)
                .HasForeignKey(d => d.FkServiceRequestId)
                .HasConstraintName("FK__SERVICE_R__FK_SE__4262CC11");
        });

        modelBuilder.Entity<ServiceRequestSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SERVICE___3214EC277C34117D");

            entity.ToTable("SERVICE_REQUEST_SCHEDULE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ArrivalTime)
                .HasPrecision(0)
                .HasColumnName("ARRIVAL_TIME");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DepartureTime)
                .HasPrecision(0)
                .HasColumnName("DEPARTURE_TIME");
            entity.Property(e => e.FkServiceRequestId).HasColumnName("FK_SERVICE_REQUEST_ID");
            entity.Property(e => e.ReferenceUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFERENCE_USER_ID");
            entity.Property(e => e.Schedule)
                .HasColumnType("datetime")
                .HasColumnName("SCHEDULE");
            entity.Property(e => e.TimeElapsed)
                .HasPrecision(0)
                .HasColumnName("TIME_ELAPSED");

            entity.HasOne(d => d.FkServiceRequest).WithMany(p => p.ServiceRequestSchedules)
                .HasForeignKey(d => d.FkServiceRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SERVICE_R__FK_SE__444B1483");
        });

        modelBuilder.Entity<SetupEnumeration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SETUP_EN__3214EC275A51CC97");

            entity.ToTable("SETUP_ENUMERATIONS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.SetupEnumerations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__SETUP_ENU__CREAT__46335CF5");
        });

        modelBuilder.Entity<SetupEnumerationsCustomerMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SETUP_EN__3214EC27E1168806");

            entity.ToTable("SETUP_ENUMERATIONS_CUSTOMER_MAP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.SetupEnumerationsId).HasColumnName("SETUP_ENUMERATIONS_ID");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.SetupEnumerationsCustomerMaps)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__SETUP_ENU__CREAT__481BA567");
        });

        modelBuilder.Entity<Shipment>(entity =>
        {
            entity.ToTable("SHIPMENT");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.CarrierId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARRIER_ID");
            entity.Property(e => e.CarrierName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARRIER_NAME");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.PackagingType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PACKAGING_TYPE");
            entity.Property(e => e.PickupType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PICKUP_TYPE");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("SERVICE_TYPE");
            entity.Property(e => e.ShipmentDate)
                .HasColumnType("datetime")
                .HasColumnName("SHIPMENT_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
        });

        modelBuilder.Entity<Shipping>(entity =>
        {
            entity.ToTable("SHIPPING");

            entity.HasIndex(e => e.FkUserId, "IX_SHIPPING");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BoxType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BOX_TYPE");
            entity.Property(e => e.CarrierId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARRIER_ID");
            entity.Property(e => e.CarrierName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CARRIER_NAME");
            entity.Property(e => e.ChargeAccount)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CHARGE_ACCOUNT");
            entity.Property(e => e.CreatedByName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY_NAME");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.Label)
                .IsUnicode(false)
                .HasColumnName("LABEL");
            entity.Property(e => e.LabelZpl).HasColumnName("LABEL_ZPL");
            entity.Property(e => e.MasterTrackingNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MASTER_TRACKING_NUMBER");
            entity.Property(e => e.PackagingType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PACKAGING_TYPE");
            entity.Property(e => e.PickupType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PICKUP_TYPE");
            entity.Property(e => e.ServiceType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SERVICE_TYPE");
            entity.Property(e => e.ShipQuantity).HasColumnName("SHIP_QUANTITY");
            entity.Property(e => e.ShipWeight).HasColumnName("SHIP_WEIGHT");
            entity.Property(e => e.ShipWeightUnit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SHIP_WEIGHT_UNIT");
            entity.Property(e => e.ShipmentDate)
                .HasColumnType("datetime")
                .HasColumnName("SHIPMENT_DATE");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.SubPackagingType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUB_PACKAGING_TYPE");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRACKING_NUMBER");

            entity.HasOne(d => d.FkUser).WithMany(p => p.Shippings)
                .HasForeignKey(d => d.FkUserId)
                .HasConstraintName("FK_SHIPPING_USER");
        });

        modelBuilder.Entity<ShippingType>(entity =>
        {
            entity.ToTable("SHIPPING_TYPES");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLIENT_CODE");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkShipVendorId).HasColumnName("FK_SHIP_VENDOR_ID");
            entity.Property(e => e.VendorCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VENDOR_CODE");

            entity.HasOne(d => d.FkShipVendor).WithMany(p => p.ShippingTypes)
                .HasForeignKey(d => d.FkShipVendorId)
                .HasConstraintName("FK_SHIPPING_TYPES_SHIPPING_VENDOR");
        });

        modelBuilder.Entity<ShippingVendor>(entity =>
        {
            entity.ToTable("SHIPPING_VENDOR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.VendorName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("VENDOR_NAME");
        });

        modelBuilder.Entity<Statement>(entity =>
        {
            entity.ToTable("STATEMENT");

            entity.HasIndex(e => e.CreatedBy, "IX_STATEMENT");

            entity.HasIndex(e => e.DateCreated, "IX_STATEMENT_1");

            entity.HasIndex(e => e.FkBatchId, "IX_STATEMENT_2");

            entity.HasIndex(e => e.FkBrandId, "IX_STATEMENT_3");

            entity.HasIndex(e => e.FkCustomerId, "IX_STATEMENT_4");

            entity.HasIndex(e => e.ControlNumber, "IX_STATEMENT_5");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmountDue)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("AMOUNT_DUE");
            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APPROVED_BY");
            entity.Property(e => e.BillAddrCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_CITY");
            entity.Property(e => e.BillAddrCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_COUNTRY");
            entity.Property(e => e.BillAddrState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_STATE");
            entity.Property(e => e.BillAddrStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_STREET");
            entity.Property(e => e.BillAddrZipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_ZIPCODE");
            entity.Property(e => e.BranchAddrCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BRANCH_ADDR_CITY");
            entity.Property(e => e.BranchAddrCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BRANCH_ADDR_COUNTRY");
            entity.Property(e => e.BranchAddrState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BRANCH_ADDR_STATE");
            entity.Property(e => e.BranchAddrStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BRANCH_ADDR_STREET");
            entity.Property(e => e.BranchAddrZipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BRANCH_ADDR_ZIPCODE");
            entity.Property(e => e.ControlNumber)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CONTROL_NUMBER");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateApproved)
                .HasColumnType("datetime")
                .HasColumnName("DATE_APPROVED");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DatePdfGenerated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_PDF_GENERATED");
            entity.Property(e => e.FkBatchId).HasColumnName("FK_BATCH_ID");
            entity.Property(e => e.FkBrandId).HasColumnName("FK_BRAND_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.PaymentDueBy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_DUE_BY");
            entity.Property(e => e.PdfGeneratedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PDF_GENERATED_BY");
            entity.Property(e => e.PeriodFrom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PERIOD_FROM");
            entity.Property(e => e.PeriodTo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PERIOD_TO");
            entity.Property(e => e.RemitAddrCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMIT_ADDR_CITY");
            entity.Property(e => e.RemitAddrCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMIT_ADDR_COUNTRY");
            entity.Property(e => e.RemitAddrState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REMIT_ADDR_STATE");
            entity.Property(e => e.RemitAddrStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("REMIT_ADDR_STREET");
            entity.Property(e => e.RemitAddrZipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REMIT_ADDR_ZIPCODE");
            entity.Property(e => e.StatementType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATEMENT_TYPE");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STATUS");

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.StatementApprovedByNavigations)
                .HasForeignKey(d => d.ApprovedBy)
                .HasConstraintName("FK_STATEMENT_USER2");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StatementCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STATEMENT_USER");

            entity.HasOne(d => d.FkBatch).WithMany(p => p.Statements)
                .HasForeignKey(d => d.FkBatchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STATEMENT_BATCH");

            entity.HasOne(d => d.FkBrand).WithMany(p => p.Statements)
                .HasForeignKey(d => d.FkBrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STATEMENT_BRAND");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.Statements)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STATEMENT_CUSTOMER");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.StatementModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_STATEMENT_USER1");

            entity.HasOne(d => d.PdfGeneratedByNavigation).WithMany(p => p.StatementPdfGeneratedByNavigations)
                .HasForeignKey(d => d.PdfGeneratedBy)
                .HasConstraintName("FK_STATEMENT_USER3");
        });

        modelBuilder.Entity<StatementDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Table_1");

            entity.ToTable("STATEMENT_DETAILS");

            entity.HasIndex(e => e.FkStatementId, "IX_Table_1");

            entity.HasIndex(e => e.DateCreated, "IX_Table_1_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkInvoiceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FK_INVOICE_ID");
            entity.Property(e => e.FkOrderId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FK_ORDER_ID");
            entity.Property(e => e.FkPaymentId).HasColumnName("FK_PAYMENT_ID");
            entity.Property(e => e.FkStatementId).HasColumnName("FK_STATEMENT_ID");
            entity.Property(e => e.Module)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.ReferenceNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REFERENCE_NUMBER");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("TOTAL");
            entity.Property(e => e.TransactionDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TRANSACTION_DATE");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("UNIT_PRICE");
            entity.Property(e => e.Volume)
                .HasColumnType("decimal(16, 2)")
                .HasColumnName("VOLUME");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StatementDetails)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_1_USER8");

            entity.HasOne(d => d.FkInvoice).WithMany(p => p.StatementDetails)
                .HasForeignKey(d => d.FkInvoiceId)
                .HasConstraintName("FK_Table_1_INVOICE");

            entity.HasOne(d => d.FkOrder).WithMany(p => p.StatementDetails)
                .HasForeignKey(d => d.FkOrderId)
                .HasConstraintName("FK_Table_1_ORDER");

            entity.HasOne(d => d.FkPayment).WithMany(p => p.StatementDetails)
                .HasForeignKey(d => d.FkPaymentId)
                .HasConstraintName("FK_Table_1_PAYMENT");
        });

        modelBuilder.Entity<StatementSubscriptionMap>(entity =>
        {
            entity.ToTable("STATEMENT_SUBSCRIPTION_MAP");

            entity.HasIndex(e => e.FkStatementId, "IX_STATEMENT_SUBSCRIPTION_MAP");

            entity.HasIndex(e => e.FkSubscriptionId, "IX_STATEMENT_SUBSCRIPTION_MAP_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateProcessed)
                .HasColumnType("datetime")
                .HasColumnName("DATE_PROCESSED");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FkStatementId).HasColumnName("FK_STATEMENT_ID");
            entity.Property(e => e.FkSubscriptionId).HasColumnName("FK_SUBSCRIPTION_ID");

            entity.HasOne(d => d.FkStatement).WithMany(p => p.StatementSubscriptionMaps)
                .HasForeignKey(d => d.FkStatementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STATEMENT_SUBSCRIPTION_MAP_STATEMENT");

            entity.HasOne(d => d.FkSubscription).WithMany(p => p.StatementSubscriptionMaps)
                .HasForeignKey(d => d.FkSubscriptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STATEMENT_SUBSCRIPTION_MAP_SUBSCRIPTION");
        });

        modelBuilder.Entity<StatementType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__STATEMEN__3214EC275846CCC7");

            entity.ToTable("STATEMENT_TYPE");

            entity.HasIndex(e => e.Code, "IX_STATEMENT_TYPE_1");

            entity.HasIndex(e => e.DaysBeforeDue, "IX_STATEMENT_TYPE_10");

            entity.HasIndex(e => e.Status, "IX_STATEMENT_TYPE_11");

            entity.HasIndex(e => e.Type, "IX_STATEMENT_TYPE_2");

            entity.HasIndex(e => e.Description, "IX_STATEMENT_TYPE_3");

            entity.HasIndex(e => e.DateCreated, "IX_STATEMENT_TYPE_4");

            entity.HasIndex(e => e.CreatedBy, "IX_STATEMENT_TYPE_5");

            entity.HasIndex(e => e.DateModified, "IX_STATEMENT_TYPE_6");

            entity.HasIndex(e => e.ModifiedBy, "IX_STATEMENT_TYPE_7");

            entity.HasIndex(e => e.ProcessType, "IX_STATEMENT_TYPE_8");

            entity.HasIndex(e => e.IsDailyInterestCalc, "IX_STATEMENT_TYPE_9");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DaysBeforeDue).HasColumnName("DAYS_BEFORE_DUE");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.IsDailyInterestCalc).HasColumnName("IS_DAILY_INTEREST_CALC");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.ProcessType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PROCESS_TYPE");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.StatementTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__STATEMENT__CREAT__4BEC364B");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.StatementTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__STATEMENT__MODIF__4DD47EBD");
        });

        modelBuilder.Entity<SubFamily>(entity =>
        {
            entity.ToTable("SUB_FAMILY");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID");
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.ToTable("SUBSCRIPTION");

            entity.HasIndex(e => e.IsPostgrid, "IX_SUBSCRIPTION");

            entity.HasIndex(e => e.IsSendgrid, "IX_SUBSCRIPTION_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.IsPostgrid).HasColumnName("IS_POSTGRID");
            entity.Property(e => e.IsSendgrid).HasColumnName("IS_SENDGRID");
            entity.Property(e => e.IsSidetrade).HasColumnName("IS_SIDETRADE");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.SubscriptionCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SUBSCRIPTION_CODE");
        });

        modelBuilder.Entity<SupplierVendor>(entity =>
        {
            entity.ToTable("SUPPLIER_VENDOR");

            entity.HasIndex(e => e.ContactFirstName, "IX_SUPPLIER_VENDOR");

            entity.HasIndex(e => e.ContactLastName, "IX_SUPPLIER_VENDOR_1");

            entity.HasIndex(e => e.Name, "IX_SUPPLIER_VENDOR_2");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CONTACT_EMAIL");
            entity.Property(e => e.ContactFirstName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONTACT_FIRST_NAME");
            entity.Property(e => e.ContactLastName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CONTACT_LAST_NAME");
            entity.Property(e => e.ContactNumber1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTACT_NUMBER_1");
            entity.Property(e => e.ContactNumber2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTACT_NUMBER_2");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.VendorNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VENDOR_NUMBER");
            entity.Property(e => e.Website)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("WEBSITE");
        });

        modelBuilder.Entity<SupplierVendorAddress>(entity =>
        {
            entity.ToTable("SUPPLIER_VENDOR_ADDRESS");

            entity.HasIndex(e => e.FkSupplierVendorId, "IX_SUPPLIER_VENDOR_ADDRESS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CountryCodeAlpha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_CODE_ALPHA");
            entity.Property(e => e.CountryCodeDigit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_CODE_DIGIT");
            entity.Property(e => e.FkSupplierVendorId).HasColumnName("FK_SUPPLIER_VENDOR_ID");
            entity.Property(e => e.IsPrimary).HasColumnName("IS_PRIMARY");
            entity.Property(e => e.Latitude).HasColumnName("LATITUDE");
            entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATE");
            entity.Property(e => e.Street)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("STREET");
            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ZIP");

            entity.HasOne(d => d.FkSupplierVendor).WithMany(p => p.SupplierVendorAddresses)
                .HasForeignKey(d => d.FkSupplierVendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUPPLIER_VENDOR_ADDRESS_SUPPLIER_VENDOR");
        });

        modelBuilder.Entity<SupplierVendorMaterialMap>(entity =>
        {
            entity.HasKey(e => new { e.FkSupplierVendorId, e.FkMaterialId });

            entity.ToTable("SUPPLIER_VENDOR_MATERIAL_MAP");

            entity.HasIndex(e => e.FkSupplierVendorId, "IX_SUPPLIER_VENDOR_MATERIAL_MAP");

            entity.HasIndex(e => e.FkMaterialId, "IX_SUPPLIER_VENDOR_MATERIAL_MAP_1");

            entity.HasIndex(e => e.Price, "IX_SUPPLIER_VENDOR_MATERIAL_MAP_2");

            entity.HasIndex(e => e.VendorCode, "IX_SUPPLIER_VENDOR_MATERIAL_MAP_3");

            entity.HasIndex(e => e.IsPrimary, "IX_SUPPLIER_VENDOR_MATERIAL_MAP_4");

            entity.Property(e => e.FkSupplierVendorId).HasColumnName("FK_SUPPLIER_VENDOR_ID");
            entity.Property(e => e.FkMaterialId).HasColumnName("FK_MATERIAL_ID");
            entity.Property(e => e.IsPrimary).HasColumnName("IS_PRIMARY");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.VendorCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VENDOR_CODE");

            entity.HasOne(d => d.FkMaterial).WithMany(p => p.SupplierVendorMaterialMaps)
                .HasForeignKey(d => d.FkMaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUPPLIER_VENDOR_MATERIAL_MAP_MATERIAL");

            entity.HasOne(d => d.FkSupplierVendor).WithMany(p => p.SupplierVendorMaterialMaps)
                .HasForeignKey(d => d.FkSupplierVendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUPPLIER_VENDOR_MATERIAL_MAP_SUPPLIER_VENDOR");
        });

        modelBuilder.Entity<SupplierVendorProductMap>(entity =>
        {
            entity.HasKey(e => new { e.FkSupplierVendorId, e.FkProductId });

            entity.ToTable("SUPPLIER_VENDOR_PRODUCT_MAP");

            entity.HasIndex(e => e.FkSupplierVendorId, "IX_SUPPLIER_VENDOR_PRODUCT_MAP");

            entity.HasIndex(e => e.FkProductId, "IX_SUPPLIER_VENDOR_PRODUCT_MAP_1");

            entity.Property(e => e.FkSupplierVendorId).HasColumnName("FK_SUPPLIER_VENDOR_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.IsPrimary).HasColumnName("IS_PRIMARY");
            entity.Property(e => e.KitNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KIT_NUMBER");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.VendorCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VENDOR_CODE");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.SupplierVendorProductMaps)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUPPLIER_VENDOR_PRODUCT_MAP_PRODUCT");

            entity.HasOne(d => d.FkSupplierVendor).WithMany(p => p.SupplierVendorProductMaps)
                .HasForeignKey(d => d.FkSupplierVendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUPPLIER_VENDOR_PRODUCT_MAP_SUPPLIER_VENDOR");
        });

        modelBuilder.Entity<SupplierVendorProductVarianceMap>(entity =>
        {
            entity.HasKey(e => new { e.FkProductId, e.FkSupplierVendorId, e.VarianceId });

            entity.ToTable("SUPPLIER_VENDOR_PRODUCT_VARIANCE_MAP");

            entity.HasIndex(e => e.FkProductId, "IX_SUPPLIER_VENDOR_PRODUCT_VARIANCE_MAP");

            entity.HasIndex(e => e.FkSupplierVendorId, "IX_SUPPLIER_VENDOR_PRODUCT_VARIANCE_MAP_1");

            entity.HasIndex(e => e.VarianceId, "IX_SUPPLIER_VENDOR_PRODUCT_VARIANCE_MAP_2");

            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.FkSupplierVendorId).HasColumnName("FK_SUPPLIER_VENDOR_ID");
            entity.Property(e => e.VarianceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VARIANCE_ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.PricePerVariance).HasColumnName("PRICE_PER_VARIANCE");
            entity.Property(e => e.QuantityPerVariance).HasColumnName("QUANTITY_PER_VARIANCE");
            entity.Property(e => e.UnitPrice).HasColumnName("UNIT_PRICE");

            entity.HasOne(d => d.SupplierVendorProductMap).WithMany(p => p.SupplierVendorProductVarianceMaps)
                .HasForeignKey(d => new { d.FkProductId, d.FkSupplierVendorId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUPPLIER_VENDOR_PRODUCT_VARIANCE_MAP_SUPPLIER_VENDOR_PRODUCT_MAP");
        });

        modelBuilder.Entity<TableCustomization>(entity =>
        {
            entity.HasKey(e => new { e.FkUserId, e.TableId, e.FkCustomerId });

            entity.ToTable("TABLE_CUSTOMIZATION");

            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.TableId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TABLE_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.Settings)
                .IsUnicode(false)
                .HasColumnName("SETTINGS");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.TableCustomizations)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TABLE_CUSTOMIZATION_CUSTOMER");

            entity.HasOne(d => d.FkUser).WithMany(p => p.TableCustomizations)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TABLE_CUSTOMIZATION_USER");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TAG_1");

            entity.ToTable("TAG");

            entity.Property(e => e.Id)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("ID");
        });

        modelBuilder.Entity<TagEntityMap>(entity =>
        {
            entity.HasKey(e => new { e.FkTagId, e.Type, e.EntityId });

            entity.ToTable("TAG_ENTITY_MAP");

            entity.HasIndex(e => e.FkTagId, "IX_TAG_ENTITY_MAP");

            entity.HasIndex(e => e.Type, "IX_TAG_ENTITY_MAP_1");

            entity.HasIndex(e => e.EntityId, "IX_TAG_ENTITY_MAP_2");

            entity.Property(e => e.FkTagId)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("FK_TAG_ID");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.EntityId).HasColumnName("ENTITY_ID");

            entity.HasOne(d => d.FkTag).WithMany(p => p.TagEntityMaps)
                .HasForeignKey(d => d.FkTagId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TAG_ENTITY_MAP_TAG");
        });

        modelBuilder.Entity<TankTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TANK_TEMP");

            entity.Property(e => e.Codelivr)
                .HasMaxLength(255)
                .HasColumnName("codelivr");
            entity.Property(e => e.Date1).HasColumnName("date1");
            entity.Property(e => e.DelId)
                .HasMaxLength(255)
                .HasColumnName("DelID");
            entity.Property(e => e.IdealVolume)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ideal_volume");
            entity.Property(e => e.K1)
                .HasMaxLength(255)
                .HasColumnName("k1");
            entity.Property(e => e.Location).HasMaxLength(255);
            entity.Property(e => e.SerialNumber).HasMaxLength(255);
            entity.Property(e => e.TankMonitor).HasMaxLength(255);
            entity.Property(e => e.TankMonitorCode).HasMaxLength(255);
            entity.Property(e => e.TankSize)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tank_size");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.Vol1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("vol1");
        });

        modelBuilder.Entity<Tax>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TAX__3214EC27037F4CAE");

            entity.ToTable("TAX");

            entity.HasIndex(e => e.FkRegionId, "IX_TAX");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(13, 2)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkRegionId).HasColumnName("FK_REGION_ID");
            entity.Property(e => e.Gp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GP");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Rate)
                .HasColumnType("decimal(13, 5)")
                .HasColumnName("RATE");
            entity.Property(e => e.TaxCategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TAX_CATEGORY");
            entity.Property(e => e.TaxCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TAX_CODE");
            entity.Property(e => e.TaxGroup).HasColumnName("TAX_GROUP");
            entity.Property(e => e.TaxLevel).HasColumnName("TAX_LEVEL");
            entity.Property(e => e.TaxNumber).HasColumnName("TAX_NUMBER");
            entity.Property(e => e.TaxType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TAX_TYPE");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Unit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UNIT");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaxCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__TAX__CREATED_BY__58520D30");

            entity.HasOne(d => d.FkRegion).WithMany(p => p.Taxes)
                .HasForeignKey(d => d.FkRegionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REGION_TAX");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TaxModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__TAX__MODIFIED_BY__5A3A55A2");
        });

        modelBuilder.Entity<TaxCategory>(entity =>
        {
            entity.ToTable("TAX_CATEGORY");

            entity.HasIndex(e => e.DateCreated, "IX_TAX_CATEGORY");

            entity.HasIndex(e => e.CreatedBy, "IX_TAX_CATEGORY_1");

            entity.HasIndex(e => e.Category, "IX_TAX_CATEGORY_2").IsUnique();

            entity.HasIndex(e => e.ModifiedBy, "IX_TAX_CATEGORY_3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Category)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION_EN");
            entity.Property(e => e.DescriptionFr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION_FR");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaxCategoryCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TAX_CATEGORY_USER");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TaxCategoryModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_TAX_CATEGORY_USER1");
        });

        modelBuilder.Entity<TaxClass>(entity =>
        {
            entity.ToTable("TAX_CLASS");

            entity.HasIndex(e => e.Class, "IX_TAX_CLASS").IsUnique();

            entity.HasIndex(e => e.DateCreated, "IX_TAX_CLASS_1");

            entity.HasIndex(e => e.CreatedBy, "IX_TAX_CLASS_2");

            entity.HasIndex(e => e.ModifiedBy, "IX_TAX_CLASS_3");

            entity.HasIndex(e => e.DescriptionAwe, "IX_TAX_CLASS_4");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Class)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CLASS");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DescriptionAwe)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION_AWE");
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION_EN");
            entity.Property(e => e.DescriptionFr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION_FR");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaxClassCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TAX_CLASS_USER");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TaxClassModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_TAX_CLASS_USER1");
        });

        modelBuilder.Entity<TaxExemption>(entity =>
        {
            entity.ToTable("TAX_EXEMPTION");

            entity.HasIndex(e => e.DateCreated, "IX_TAX_EXEMPTION");

            entity.HasIndex(e => e.CreatedBy, "IX_TAX_EXEMPTION_1");

            entity.HasIndex(e => e.ModifiedBy, "IX_TAX_EXEMPTION_2");

            entity.HasIndex(e => e.ExemptionCode, "IX_TAX_EXEMPTION_3").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION_EN");
            entity.Property(e => e.DescriptionFr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION_FR");
            entity.Property(e => e.ExemptionCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EXEMPTION_CODE");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaxExemptionCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TAX_EXEMPTION_USER");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TaxExemptionModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_TAX_EXEMPTION_USER1");
        });

        modelBuilder.Entity<TaxExemptionEntityMap>(entity =>
        {
            entity.ToTable("TAX_EXEMPTION_ENTITY_MAP");

            entity.HasIndex(e => e.DateCreated, "IX_TAX_EXEMPTION_ENTITY_MAP");

            entity.HasIndex(e => e.CreatedBy, "IX_TAX_EXEMPTION_ENTITY_MAP_1");

            entity.HasIndex(e => e.ModifiedBy, "IX_TAX_EXEMPTION_ENTITY_MAP_2");

            entity.HasIndex(e => e.Module, "IX_TAX_EXEMPTION_ENTITY_MAP_3");

            entity.HasIndex(e => e.FkProductId, "IX_TAX_EXEMPTION_ENTITY_MAP_4");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.ExemptionRate).HasColumnName("EXEMPTION_RATE");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.LegacyExpiryDate).HasColumnName("LEGACY_EXPIRY_DATE");
            entity.Property(e => e.License)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LICENSE");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Module)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.TaxClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TAX_CLASS");
            entity.Property(e => e.TaxExemptionCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TAX_EXEMPTION_CODE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaxExemptionEntityMapCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_1_USER6");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.TaxExemptionEntityMaps)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .HasConstraintName("FK_Table_1_CUSTOMER_ADDRESS1");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.TaxExemptionEntityMaps)
                .HasForeignKey(d => d.FkProductId)
                .HasConstraintName("FK_TAX_EXEMPTION_ENTITY_MAP_PRODUCT");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TaxExemptionEntityMapModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_Table_1_USER7");

            entity.HasOne(d => d.TaxClassNavigation).WithMany(p => p.TaxExemptionEntityMaps)
                .HasPrincipalKey(p => p.Class)
                .HasForeignKey(d => d.TaxClass)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_1_TAX_CLASS1");

            entity.HasOne(d => d.TaxExemptionCodeNavigation).WithMany(p => p.TaxExemptionEntityMaps)
                .HasPrincipalKey(p => p.ExemptionCode)
                .HasForeignKey(d => d.TaxExemptionCode)
                .HasConstraintName("FK_Table_1_TAX_EXEMPTION");
        });

        modelBuilder.Entity<TaxHistory>(entity =>
        {
            entity.ToTable("TAX_HISTORY");

            entity.HasIndex(e => e.FkTaxId, "IX_TAX_HISTORY");

            entity.HasIndex(e => e.CreatedBy, "IX_TAX_HISTORY_1");

            entity.HasIndex(e => e.DateCreated, "IX_TAX_HISTORY_2");

            entity.HasIndex(e => e.Module, "IX_TAX_HISTORY_3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkTaxId).HasColumnName("FK_TAX_ID");
            entity.Property(e => e.Gp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GP");
            entity.Property(e => e.Module)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.Rate).HasColumnName("RATE");
            entity.Property(e => e.TaxCategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TAX_CATEGORY");
            entity.Property(e => e.TaxCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TAX_CODE");
            entity.Property(e => e.TaxGroup).HasColumnName("TAX_GROUP");
            entity.Property(e => e.TaxLevel).HasColumnName("TAX_LEVEL");
            entity.Property(e => e.TaxNumber).HasColumnName("TAX_NUMBER");
            entity.Property(e => e.TaxType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TAX_TYPE");
            entity.Property(e => e.Unit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UNIT");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaxHistories)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TAX_HISTORY_USER");

            entity.HasOne(d => d.FkTax).WithMany(p => p.TaxHistories)
                .HasForeignKey(d => d.FkTaxId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TAX_HISTORY_TAX");
        });

        modelBuilder.Entity<TaxRate>(entity =>
        {
            entity.ToTable("TAX_RATE");

            entity.HasIndex(e => e.DateCreated, "IX_TAX_RATE");

            entity.HasIndex(e => e.CreatedBy, "IX_TAX_RATE_1");

            entity.HasIndex(e => e.FkProductId, "IX_TAX_RATE_2");

            entity.HasIndex(e => e.ModifiedBy, "IX_TAX_RATE_3");

            entity.HasIndex(e => e.TaxCategory, "IX_TAX_RATE_4");

            entity.HasIndex(e => e.TaxClass, "IX_TAX_RATE_5");

            entity.HasIndex(e => e.StateShortForm, "IX_TAX_RATE_6");

            entity.HasIndex(e => e.StateLongForm, "IX_TAX_RATE_7");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ApplicabilityBits)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("APPLICABILITY_BITS");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.RateCurrent).HasColumnName("RATE_CURRENT");
            entity.Property(e => e.RatePrevious).HasColumnName("RATE_PREVIOUS");
            entity.Property(e => e.RateType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RATE_TYPE");
            entity.Property(e => e.StateLongForm)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("STATE_LONG_FORM");
            entity.Property(e => e.StateShortForm)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("STATE_SHORT_FORM");
            entity.Property(e => e.TaxCategory)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TAX_CATEGORY");
            entity.Property(e => e.TaxClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TAX_CLASS");
            entity.Property(e => e.TaxLevel).HasColumnName("TAX_LEVEL");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaxRateCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_1_USER4");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.TaxRates)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_1_PRODUCT1");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TaxRateModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_Table_1_USER5");

            entity.HasOne(d => d.TaxCategoryNavigation).WithMany(p => p.TaxRates)
                .HasPrincipalKey(p => p.Category)
                .HasForeignKey(d => d.TaxCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_1_TAX_CATEGORY");

            entity.HasOne(d => d.TaxClassNavigation).WithMany(p => p.TaxRates)
                .HasPrincipalKey(p => p.Class)
                .HasForeignKey(d => d.TaxClass)
                .HasConstraintName("FK_Table_1_TAX_CLASS");
        });

        modelBuilder.Entity<TaxRebate>(entity =>
        {
            entity.ToTable("TAX_REBATE");

            entity.HasIndex(e => e.RebateCode, "IX_TAX_REBATE_1");

            entity.HasIndex(e => e.DescriptionEn, "IX_TAX_REBATE_2");

            entity.HasIndex(e => e.DescriptionFr, "IX_TAX_REBATE_3");

            entity.HasIndex(e => e.CreatedBy, "IX_TAX_REBATE_4");

            entity.HasIndex(e => e.DateCreated, "IX_TAX_REBATE_5");

            entity.HasIndex(e => e.ModifiedBy, "IX_TAX_REBATE_6");

            entity.HasIndex(e => e.DateModified, "IX_TAX_REBATE_7");

            entity.HasIndex(e => e.DescriptionAwe, "IX_TAX_REBATE_8");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.DescriptionAwe)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION_AWE");
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION_EN");
            entity.Property(e => e.DescriptionFr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION_FR");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.RebateCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REBATE_CODE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaxRebateCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TAX_REBATE_USER_1");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TaxRebateModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_TAX_REBATE_USER_2");
        });

        modelBuilder.Entity<TaxRebateEntityMap>(entity =>
        {
            entity.ToTable("TAX_REBATE_ENTITY_MAP");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkCustomerAddressId).HasColumnName("FK_CUSTOMER_ADDRESS_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.LegacyExpiryDate).HasColumnName("LEGACY_EXPIRY_DATE");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Module)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MODULE");
            entity.Property(e => e.RebateRate).HasColumnName("REBATE_RATE");
            entity.Property(e => e.RebateType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REBATE_TYPE");
            entity.Property(e => e.TaxClass)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("TAX_CLASS");
            entity.Property(e => e.TaxRebateCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TAX_REBATE_CODE");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaxRebateEntityMapCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TAX_REBATE_ENTITY_MAP_USER_1");

            entity.HasOne(d => d.FkCustomerAddress).WithMany(p => p.TaxRebateEntityMaps)
                .HasForeignKey(d => d.FkCustomerAddressId)
                .HasConstraintName("FK_TAX_REBATE_ENTITY_MAP_CUSTOMER_ADDRESS");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.TaxRebateEntityMaps)
                .HasForeignKey(d => d.FkCustomerId)
                .HasConstraintName("FK_TAX_REBATE_ENTITY_MAP_CUSTOMER");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.TaxRebateEntityMaps)
                .HasForeignKey(d => d.FkProductId)
                .HasConstraintName("FK_TAX_REBATE_ENTITY_MAP_PRODUCT");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TaxRebateEntityMapModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_TAX_REBATE_ENTITY_MAP_USER_2");

            entity.HasOne(d => d.TaxClassNavigation).WithMany(p => p.TaxRebateEntityMaps)
                .HasPrincipalKey(p => p.Class)
                .HasForeignKey(d => d.TaxClass)
                .HasConstraintName("FK_TAX_REBATE_ENTITY_MAP_TAX_CLASS");
        });

        modelBuilder.Entity<TempCustomerRegion>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__TEMP_CUS__357D4CF8F3C601E3");

            entity.ToTable("TEMP_CUSTOMER_REGION");

            entity.Property(e => e.Code)
                .ValueGeneratedNever()
                .HasColumnName("code");
            entity.Property(e => e.Region)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("region");
        });

        modelBuilder.Entity<TickSequenceRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TICK_SEQ__3214EC2702D4515E");

            entity.ToTable("TICK_SEQUENCE_RECORD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Prefix)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PREFIX");
        });

        modelBuilder.Entity<Timezone>(entity =>
        {
            entity.ToTable("TIMEZONE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DaylightAbbreviation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DAYLIGHT_ABBREVIATION");
            entity.Property(e => e.DaylightValue).HasColumnName("DAYLIGHT_VALUE");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.StandardAbbreviation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STANDARD_ABBREVIATION");
            entity.Property(e => e.StandardValue).HasColumnName("STANDARD_VALUE");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.ToTable("TRANSACTION");

            entity.HasIndex(e => e.TransactionCode, "IX_TRANSACTION");

            entity.HasIndex(e => e.FkUserActivityId, "IX_TRANSACTION_1");

            entity.HasIndex(e => e.BillAddrCity, "IX_TRANSACTION_10");

            entity.HasIndex(e => e.BillAddrCountry, "IX_TRANSACTION_11");

            entity.HasIndex(e => e.BillAddrState, "IX_TRANSACTION_12");

            entity.HasIndex(e => e.BillAddrStreet, "IX_TRANSACTION_13");

            entity.HasIndex(e => e.BillAddrZipcode, "IX_TRANSACTION_14");

            entity.HasIndex(e => e.AccountUserLegacyId, "IX_TRANSACTION_15");

            entity.HasIndex(e => e.FkCustomerId, "IX_TRANSACTION_2");

            entity.HasIndex(e => e.Status, "IX_TRANSACTION_3");

            entity.HasIndex(e => e.LegacyId, "IX_TRANSACTION_4");

            entity.HasIndex(e => e.TranAddrCity, "IX_TRANSACTION_5");

            entity.HasIndex(e => e.TranAddrCountry, "IX_TRANSACTION_6");

            entity.HasIndex(e => e.TranAddrState, "IX_TRANSACTION_7");

            entity.HasIndex(e => e.TranAddrStreet, "IX_TRANSACTION_8");

            entity.HasIndex(e => e.TranAddrZipcode, "IX_TRANSACTION_9");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountUserLegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACCOUNT_USER_LEGACY_ID");
            entity.Property(e => e.BillAddrCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_CITY");
            entity.Property(e => e.BillAddrCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_COUNTRY");
            entity.Property(e => e.BillAddrState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_STATE");
            entity.Property(e => e.BillAddrStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_STREET");
            entity.Property(e => e.BillAddrZipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BILL_ADDR_ZIPCODE");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkAccountId).HasColumnName("FK_ACCOUNT_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkUserActivityId).HasColumnName("FK_USER_ACTIVITY_ID");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ID");
            entity.Property(e => e.PaymentBalance).HasColumnName("PAYMENT_BALANCE");
            entity.Property(e => e.ServiceFee).HasColumnName("SERVICE_FEE");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.TranAddrCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRAN_ADDR_CITY");
            entity.Property(e => e.TranAddrCountry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRAN_ADDR_COUNTRY");
            entity.Property(e => e.TranAddrState)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRAN_ADDR_STATE");
            entity.Property(e => e.TranAddrStreet)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TRAN_ADDR_STREET");
            entity.Property(e => e.TranAddrZipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRAN_ADDR_ZIPCODE");
            entity.Property(e => e.TransactionCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRANSACTION_CODE");

            entity.HasOne(d => d.FkAccount).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.FkAccountId)
                .HasConstraintName("FK_TRANSACTION_ACCOUNT");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.FkCustomerId)
                .HasConstraintName("FK_TRANSACTION_CUSTOMER");

            entity.HasOne(d => d.FkUserActivity).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.FkUserActivityId)
                .HasConstraintName("FK_TRANSACTION_USER_ACTIVITY");

            entity.HasOne(d => d.FkUser).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSACTION_USER");
        });

        modelBuilder.Entity<TransactionDetail>(entity =>
        {
            entity.ToTable("TRANSACTION_DETAILS");

            entity.HasIndex(e => e.FkServiceId, "IX_TRANSACTION_DETAILS");

            entity.HasIndex(e => e.FkTransactionId, "IX_TRANSACTION_DETAILS_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.FkServiceId).HasColumnName("FK_SERVICE_ID");
            entity.Property(e => e.FkTransactionId).HasColumnName("FK_TRANSACTION_ID");
            entity.Property(e => e.PriceAmount).HasColumnName("PRICE_AMOUNT");
            entity.Property(e => e.PriceName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRICE_NAME");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.TotalCost).HasColumnName("TOTAL_COST");

            entity.HasOne(d => d.FkService).WithMany(p => p.TransactionDetails)
                .HasForeignKey(d => d.FkServiceId)
                .HasConstraintName("FK_TRANSACTION_DETAILS_SERVICE");

            entity.HasOne(d => d.FkTransaction).WithMany(p => p.TransactionDetails)
                .HasForeignKey(d => d.FkTransactionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSACTION_DETAILS_TRANSACTION");
        });

        modelBuilder.Entity<TransactionType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TRANSACT__3214EC278CCD8BB9");

            entity.ToTable("TRANSACTION_TYPE");

            entity.HasIndex(e => e.Code, "IX_TRANSACTION_TYPE_1");

            entity.HasIndex(e => e.Name, "IX_TRANSACTION_TYPE_2");

            entity.HasIndex(e => e.Description, "IX_TRANSACTION_TYPE_3");

            entity.HasIndex(e => e.DateCreated, "IX_TRANSACTION_TYPE_4");

            entity.HasIndex(e => e.CreatedBy, "IX_TRANSACTION_TYPE_5");

            entity.HasIndex(e => e.DateModified, "IX_TRANSACTION_TYPE_6");

            entity.HasIndex(e => e.ModifiedBy, "IX_TRANSACTION_TYPE_7");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAME");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TransactionTypeCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__TRANSACTI__CREAT__7C8F6DA6");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TransactionTypeModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__TRANSACTI__MODIF__7E77B618");
        });

        modelBuilder.Entity<Upload>(entity =>
        {
            entity.ToTable("UPLOAD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Filename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FILENAME");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
            entity.Property(e => e.TotalRows).HasColumnName("TOTAL_ROWS");
            entity.Property(e => e.UploadType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPLOAD_TYPE");
            entity.Property(e => e.UploadedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPLOADED_BY");
        });

        modelBuilder.Entity<UploadHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UPLOAD_H__3214EC276BEB3B14");

            entity.ToTable("UPLOAD_HISTORY");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.Filename)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Guid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("GUID");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");
            entity.Property(e => e.TotalRows).HasColumnName("TOTAL_ROWS");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.UploadedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPLOADED_BY");
            entity.Property(e => e.Url)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("URL");
            entity.Property(e => e.UrlBase)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URL_BASE");
            entity.Property(e => e.UrlContainer)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URL_CONTAINER");
            entity.Property(e => e.UrlEntity)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URL_ENTITY");
        });

        modelBuilder.Entity<UploadRow>(entity =>
        {
            entity.ToTable("UPLOAD_ROW");

            entity.HasIndex(e => e.FkUploadHistoryId, "IX_UPLOAD_ROW");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FkUploadHistoryId).HasColumnName("FK_UPLOAD_HISTORY_ID");
            entity.Property(e => e.IsSuccessful).HasColumnName("IS_SUCCESSFUL");
            entity.Property(e => e.Message)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.UploadAction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UPLOAD_ACTION");

            entity.HasOne(d => d.FkUploadHistory).WithMany(p => p.UploadRows)
                .HasForeignKey(d => d.FkUploadHistoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UPLOAD_ROW_UPLOAD_HISTORY");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("USER");

            entity.HasIndex(e => e.CreatedBy, "IX_USER");

            entity.HasIndex(e => e.ModifiedBy, "IX_USER_1");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.AlternateNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ALTERNATE_NUMBER");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEPARTMENT");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("IMAGE_URL");
            entity.Property(e => e.IsFirstTimeLogin).HasColumnName("IS_FIRST_TIME_LOGIN");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.Middlename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MIDDLENAME");
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MOBILE_NUMBER");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("POSITION");
            entity.Property(e => e.SiteUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SITE_USER_ID");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.InverseCreatedByNavigation)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK_USER_USER");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.InverseModifiedByNavigation)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_USER_USER_1");
        });

        modelBuilder.Entity<UserActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_USER_TRANSACTION");

            entity.ToTable("USER_ACTIVITY");

            entity.HasIndex(e => e.FkUserId, "IX_USER_TRANSACTION");

            entity.HasIndex(e => e.EntityId, "IX_USER_TRANSACTION_1");

            entity.HasIndex(e => e.SubEntityId, "IX_USER_TRANSACTION_2");

            entity.HasIndex(e => e.Type, "IX_USER_TRANSACTION_3");

            entity.HasIndex(e => e.Status, "IX_USER_TRANSACTION_4");

            entity.HasIndex(e => e.CustomerId, "IX_USER_TRANSACTION_5");

            entity.HasIndex(e => e.Code, "IX_USER_TRANSACTION_6").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChargeStartTime)
                .HasColumnType("datetime")
                .HasColumnName("CHARGE_START_TIME");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateStopped)
                .HasColumnType("datetime")
                .HasColumnName("DATE_STOPPED");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("DEVICE_ID");
            entity.Property(e => e.EntityId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENTITY_ID");
            entity.Property(e => e.EntityLegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENTITY_LEGACY_ID");
            entity.Property(e => e.EntityType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENTITY_TYPE");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.LegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LEGACY_ID");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            entity.Property(e => e.PaymentId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_ID");
            entity.Property(e => e.PaymentOption)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PAYMENT_OPTION");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.SubEntityId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SUB_ENTITY_ID");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");

            entity.HasOne(d => d.FkUser).WithMany(p => p.UserActivities)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER");
        });

        modelBuilder.Entity<UserActivityLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_USER_TRANSACTION_DETAILS");

            entity.ToTable("USER_ACTIVITY_LOGS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.FkApiDumpId).HasColumnName("FK_API_DUMP_ID");
            entity.Property(e => e.FkUserTransactionId).HasColumnName("FK_USER_TRANSACTION_ID");
            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MESSAGE");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT");
            entity.Property(e => e.Value).HasColumnName("VALUE");

            entity.HasOne(d => d.FkApiDump).WithMany(p => p.UserActivityLogs)
                .HasForeignKey(d => d.FkApiDumpId)
                .HasConstraintName("FK_API_DUMP");
        });

        modelBuilder.Entity<UserAddress>(entity =>
        {
            entity.ToTable("USER_ADDRESS");

            entity.HasIndex(e => e.FkUserId, "IX_USER_ADDRESS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Building)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BUILDING");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CITY");
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COUNTRY_CODE");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.IsPrimary).HasColumnName("IS_PRIMARY");
            entity.Property(e => e.Latitude).HasColumnName("LATITUDE");
            entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STATE");
            entity.Property(e => e.Street)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STREET");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
            entity.Property(e => e.Unit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UNIT");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZIPCODE");

            entity.HasOne(d => d.FkUser).WithMany(p => p.UserAddresses)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_ADDRESS_USER");
        });

        modelBuilder.Entity<UserGroupMap>(entity =>
        {
            entity.HasKey(e => new { e.FkUserId, e.FkCustomerId, e.FkGroupId });

            entity.ToTable("USER_GROUP_MAP");

            entity.HasIndex(e => e.FkUserId, "IX_USER_GROUP_MAP");

            entity.HasIndex(e => e.FkCustomerId, "IX_USER_GROUP_MAP_1");

            entity.HasIndex(e => e.FkGroupId, "IX_USER_GROUP_MAP_2");

            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkGroupId).HasColumnName("FK_GROUP_ID");
            entity.Property(e => e.IsDefault).HasColumnName("IS_DEFAULT");

            entity.HasOne(d => d.FkGroup).WithMany(p => p.UserGroupMaps)
                .HasForeignKey(d => d.FkGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_GROUP_MAP_GROUP");

            entity.HasOne(d => d.CustomerUserMap).WithMany(p => p.UserGroupMaps)
                .HasForeignKey(d => new { d.FkCustomerId, d.FkUserId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_GROUP_MAP_USER");
        });

        modelBuilder.Entity<UserIpAddress>(entity =>
        {
            entity.HasKey(e => e.FkUserId);

            entity.ToTable("USER_IP_ADDRESS");

            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.Ip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IP");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");

            entity.HasOne(d => d.FkUser).WithOne(p => p.UserIpAddress)
                .HasForeignKey<UserIpAddress>(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_IP_ADDRESS_USER");
        });

        modelBuilder.Entity<UserList>(entity =>
        {
            entity.ToTable("USER_LIST");

            entity.HasIndex(e => e.FkUserId, "IX_USER_LIST");

            entity.HasIndex(e => e.FkCustomerId, "IX_USER_LIST_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.NewItemCount).HasColumnName("NEW_ITEM_COUNT");
            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.UserListCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__USER_LIST__CREAT__51300E55");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.UserLists)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_LIST_CUSTOMER");

            entity.HasOne(d => d.FkUser).WithMany(p => p.UserListFkUsers)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_LIST_USER");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.UserListModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__USER_LIST__MODIF__5224328E");
        });

        modelBuilder.Entity<UserLogMap>(entity =>
        {
            entity.HasKey(e => new { e.FkUserId, e.FkLogId });

            entity.ToTable("USER_LOG_MAP");

            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.FkLogId).HasColumnName("FK_LOG_ID");
            entity.Property(e => e.IsRead).HasColumnName("IS_READ");

            entity.HasOne(d => d.FkLog).WithMany(p => p.UserLogMaps)
                .HasForeignKey(d => d.FkLogId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_LOG_MAP_LOG");

            entity.HasOne(d => d.FkUser).WithMany(p => p.UserLogMaps)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_LOG_MAP_USER");
        });

        modelBuilder.Entity<UserProductList>(entity =>
        {
            entity.HasKey(e => new { e.FkUserListId, e.FkProductId });

            entity.ToTable("USER_PRODUCT_LIST");

            entity.HasIndex(e => e.FkUserListId, "IX_USER_PRODUCT_LIST");

            entity.HasIndex(e => e.FkProductId, "IX_USER_PRODUCT_LIST_1");

            entity.Property(e => e.FkUserListId).HasColumnName("FK_USER_LIST_ID");
            entity.Property(e => e.FkProductId).HasColumnName("FK_PRODUCT_ID");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

            entity.HasOne(d => d.FkProduct).WithMany(p => p.UserProductLists)
                .HasForeignKey(d => d.FkProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_PRODUCT_LIST_PRODUCT");

            entity.HasOne(d => d.FkUserList).WithMany(p => p.UserProductLists)
                .HasForeignKey(d => d.FkUserListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_PRODUCT_LIST_USER_LIST");
        });

        modelBuilder.Entity<UserSetting>(entity =>
        {
            entity.HasKey(e => e.FkUserId);

            entity.ToTable("USER_SETTINGS");

            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.EmailNotification).HasColumnName("EMAIL_NOTIFICATION");
            entity.Property(e => e.MfaEmail).HasColumnName("MFA_EMAIL");
            entity.Property(e => e.MfaSms).HasColumnName("MFA_SMS");
            entity.Property(e => e.SmsNotification).HasColumnName("SMS_NOTIFICATION");

            entity.HasOne(d => d.FkUser).WithOne(p => p.UserSetting)
                .HasForeignKey<UserSetting>(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_SETTINGS_USER");
        });

        modelBuilder.Entity<UserToken>(entity =>
        {
            entity.HasKey(e => new { e.FkUserId, e.Token, e.FkCustomerId });

            entity.ToTable("USER_TOKEN");

            entity.HasIndex(e => e.FkUserId, "IX_USER_TOKEN");

            entity.HasIndex(e => e.Token, "IX_USER_TOKEN_1");

            entity.Property(e => e.FkUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FK_USER_ID");
            entity.Property(e => e.Token)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("TOKEN");
            entity.Property(e => e.FkCustomerId).HasColumnName("FK_CUSTOMER_ID");
            entity.Property(e => e.IsLoggedIn).HasColumnName("IS_LOGGED_IN");

            entity.HasOne(d => d.FkCustomer).WithMany(p => p.UserTokens)
                .HasForeignKey(d => d.FkCustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_TOKEN_CUSTOMER");

            entity.HasOne(d => d.FkUser).WithMany(p => p.UserTokens)
                .HasForeignKey(d => d.FkUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USER_TOKEN_USER");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VEHICLE__3214EC276DC1FF7B");

            entity.ToTable("VEHICLE");

            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.Barcode1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BARCODE_1");
            entity.Property(e => e.Barcode2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BARCODE_2");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.CustomerLegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_LEGACY_ID");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.LastFuelDtm)
                .HasColumnType("datetime")
                .HasColumnName("LAST_FUEL_DTM");
            entity.Property(e => e.LastUnfueledDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("LAST_UNFUELED_DESCRIPTION");
            entity.Property(e => e.LastUnfueledDtm)
                .HasColumnType("datetime")
                .HasColumnName("LAST_UNFUELED_DTM");
            entity.Property(e => e.LastUnfueledReason).HasColumnName("LAST_UNFUELED_REASON");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Odometer)
                .HasColumnType("decimal(8, 1)")
                .HasColumnName("ODOMETER");
            entity.Property(e => e.PlateNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PLATE_NUMBER");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_CODE");
            entity.Property(e => e.Ref1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REF_1");
            entity.Property(e => e.Ref2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REF_2");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.StatusLastModified)
                .HasColumnType("datetime")
                .HasColumnName("STATUS_LAST_MODIFIED");
            entity.Property(e => e.TankSize)
                .HasColumnType("decimal(5, 1)")
                .HasColumnName("TANK_SIZE");
            entity.Property(e => e.UsageCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USAGE_CODE");
            entity.Property(e => e.Xref)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("XREF");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.VehicleCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__VEHICLE__CREATED__1372D2FE");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.VehicleModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__VEHICLE__MODIFIE__1466F737");
        });

        modelBuilder.Entity<ViewCategoryHierarchyDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_CATEGORY_HIERARCHY_DETAILS");

            entity.Property(e => e.CategoryHierarchyId)
                .HasMaxLength(4000)
                .HasColumnName("CATEGORY_HIERARCHY_ID");
            entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");
            entity.Property(e => e.CategoryLevelId).HasColumnName("CATEGORY_LEVEL_ID");
            entity.Property(e => e.CategoryLevelName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CATEGORY_LEVEL_NAME");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CATEGORY_NAME");
            entity.Property(e => e.IsDeleted).HasColumnName("IS_DELETED");
        });

        modelBuilder.Entity<ViewTagCustomerMapDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_TAG_CUSTOMER_MAP_DETAILS");

            entity.Property(e => e.CustomerLegacyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_LEGACY_ID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.EntityId).HasColumnName("ENTITY_ID");
            entity.Property(e => e.TagId)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("TAG_ID");
            entity.Property(e => e.TagType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TAG_TYPE");
        });

        modelBuilder.Entity<ViewTagEntityMapDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_TAG_ENTITY_MAP_DETAILS");

            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUSTOMER_NAME");
            entity.Property(e => e.EntityId).HasColumnName("ENTITY_ID");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_CODE");
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_NAME");
            entity.Property(e => e.TagId)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("TAG_ID");
            entity.Property(e => e.TagType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TAG_TYPE");
        });

        modelBuilder.Entity<ViewTagProductMapDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VIEW_TAG_PRODUCT_MAP_DETAILS");

            entity.Property(e => e.EntityId).HasColumnName("ENTITY_ID");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_CODE");
            entity.Property(e => e.ProductName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PRODUCT_NAME");
            entity.Property(e => e.TagId)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("TAG_ID");
            entity.Property(e => e.TagType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TAG_TYPE");
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.ToTable("WAREHOUSE");

            entity.HasIndex(e => e.Name, "IX_WAREHOUSE");

            entity.HasIndex(e => e.CreatedBy, "IX_WAREHOUSE_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Warehouses)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WAREHOUSE_USER");
        });

        modelBuilder.Entity<WeatherStation>(entity =>
        {
            entity.ToTable("WEATHER_STATION");

            entity.HasIndex(e => e.StationName, "IX_WEATHER_STATION").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.StationId)
                .HasMaxLength(10)
                .HasColumnName("STATION_ID");
            entity.Property(e => e.StationName)
                .HasMaxLength(50)
                .HasColumnName("STATION_NAME");
        });

        modelBuilder.Entity<Zone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ZONE__3214EC27A43A6B91");

            entity.ToTable("ZONE");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Area)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AREA");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("CODE");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CREATED_BY");
            entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasColumnName("DATE_CREATED");
            entity.Property(e => e.DateModified)
                .HasColumnType("datetime")
                .HasColumnName("DATE_MODIFIED");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FkRegionId).HasColumnName("FK_REGION_ID");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MODIFIED_BY");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("STATUS");
        });

        modelBuilder.Entity<ZoneTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ZONE_TEMP");

            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Region)
                .HasMaxLength(100)
                .HasColumnName("REGION");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
