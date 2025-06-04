using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string CueId { get; set; } = null!;

    public string? LegacyId { get; set; }

    public string? FkPriceListCode { get; set; }

    public int? FkTimezoneId { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public string? ContactNumber { get; set; }

    public string? Duns { get; set; }

    public int? MinOrderValue { get; set; }

    public string? PaymentTerms { get; set; }

    public string? TpiAccount { get; set; }

    public string? ClientGroupType { get; set; }

    public DateTime? Timestamp { get; set; }

    public DateTime? DateModified { get; set; }

    public string? Regional { get; set; }

    public bool? IsPublic { get; set; }

    public bool? HasEmailTemplate { get; set; }

    public bool? HasTwilio { get; set; }

    public string? Classification { get; set; }

    public int? Rank { get; set; }

    public string? PoNumber { get; set; }

    public string? TaxGroup { get; set; }

    public decimal? PrevBalance { get; set; }

    public decimal? FirstVolumeDiscount { get; set; }

    public decimal? FirstLevelDiscount { get; set; }

    public string? PromptPayDiscountType { get; set; }

    public decimal? PromptPayDiscount { get; set; }

    public int? PromptPayDays { get; set; }

    public int? TicketCopyToPrint { get; set; }

    public int? RemittanceCopyToPrint { get; set; }

    public string? Language { get; set; }

    public string? OrderType { get; set; }

    public int? ContractType { get; set; }

    public decimal? ContractPrice { get; set; }

    public DateTime? ContractStart { get; set; }

    public DateTime? ContractEnd { get; set; }

    public decimal? ContractRemainingVol { get; set; }

    public decimal? ContractRemainingAmt { get; set; }

    public decimal? Volume { get; set; }

    public string? CreditCode { get; set; }

    public string? Gn { get; set; }

    public string? Corp { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public string? BillingCycle { get; set; }

    public string? BillingSchedule { get; set; }

    public string? BillingSetup { get; set; }

    public string? AccountCreditStatus { get; set; }

    public string? BudgetPlan { get; set; }

    public int? FkBranchId { get; set; }

    public string? Province { get; set; }

    public string? CollectorId { get; set; }

    public int? RegionId { get; set; }

    public string? PriceZone { get; set; }

    public string? PriceClass { get; set; }

    public string? StatementType { get; set; }

    public double? CreditLimit { get; set; }

    public string? AccountType { get; set; }

    public string? SalesRepId { get; set; }

    public int? PaymentTermId { get; set; }

    public string? TaxCategory { get; set; }

    public bool? IsTaxExempted { get; set; }

    public string? PricingCode { get; set; }

    public string? PricingMethod { get; set; }

    public bool? IsPriced { get; set; }

    public bool? IsLead { get; set; }

    public bool? IsForCreditAuthorization { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? BusinessEntity { get; set; }

    public string? NatureOfBusiness { get; set; }

    public int? YearsOfOperation { get; set; }

    public string? CustomerSource { get; set; }

    public string? RebateCode { get; set; }

    public int? FkSubscriptionId { get; set; }

    public string? InvoiceMailIntegration { get; set; }

    public double? CurrentBalance { get; set; }

    public string? LegacySalesRepId { get; set; }

    public string? LegacyCollectorId { get; set; }

    public string? AcquisitionCode { get; set; }

    public string? LegacyClassification { get; set; }

    public string? LegacySalesRepName { get; set; }

    public string? LegacyCollectorName { get; set; }

    public string? SyncStatus { get; set; }

    public string? SyncRemarks { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();

    public virtual ICollection<Alert> Alerts { get; set; } = new List<Alert>();

    public virtual ICollection<ArRecord> ArRecords { get; set; } = new List<ArRecord>();

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    public virtual ICollection<BlockCustomerMap> BlockCustomerMaps { get; set; } = new List<BlockCustomerMap>();

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<CustomerAddressRegionMap> CustomerAddressRegionMaps { get; set; } = new List<CustomerAddressRegionMap>();

    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();

    public virtual ICollection<CustomerContact> CustomerContacts { get; set; } = new List<CustomerContact>();

    public virtual ICollection<CustomerIntegration> CustomerIntegrations { get; set; } = new List<CustomerIntegration>();

    public virtual ICollection<CustomerPartner> CustomerPartnerFkCustomers { get; set; } = new List<CustomerPartner>();

    public virtual ICollection<CustomerPartner> CustomerPartnerPartners { get; set; } = new List<CustomerPartner>();

    public virtual ICollection<CustomerProductMap> CustomerProductMaps { get; set; } = new List<CustomerProductMap>();

    public virtual ICollection<CustomerRemittanceAddressMap> CustomerRemittanceAddressMaps { get; set; } = new List<CustomerRemittanceAddressMap>();

    public virtual ICollection<CustomerShippingVendorMap> CustomerShippingVendorMaps { get; set; } = new List<CustomerShippingVendorMap>();

    public virtual ICollection<CustomerSubscriptionMap> CustomerSubscriptionMaps { get; set; } = new List<CustomerSubscriptionMap>();

    public virtual ICollection<CustomerUserMap> CustomerUserMaps { get; set; } = new List<CustomerUserMap>();

    public virtual ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();

    public virtual Branch? FkBranch { get; set; }

    public virtual Subscription? FkSubscription { get; set; }

    public virtual Timezone? FkTimezone { get; set; }

    public virtual ICollection<Form> Forms { get; set; } = new List<Form>();

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<MultiFactorAuthToken> MultiFactorAuthTokens { get; set; } = new List<MultiFactorAuthToken>();

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual ICollection<Order> OrderFkCustomerIdBillNavigations { get; set; } = new List<Order>();

    public virtual ICollection<Order> OrderFkCustomerIdShipNavigations { get; set; } = new List<Order>();

    public virtual ICollection<Order> OrderFkCustomers { get; set; } = new List<Order>();

    public virtual ICollection<PaymentMethod> PaymentMethods { get; set; } = new List<PaymentMethod>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<RecurrenceOrderSetting> RecurrenceOrderSettingFkCustomerIdBillNavigations { get; set; } = new List<RecurrenceOrderSetting>();

    public virtual ICollection<RecurrenceOrderSetting> RecurrenceOrderSettingFkCustomerIdShipNavigations { get; set; } = new List<RecurrenceOrderSetting>();

    public virtual ICollection<RecurrenceOrderSetting> RecurrenceOrderSettingFkCustomers { get; set; } = new List<RecurrenceOrderSetting>();

    public virtual ICollection<Recurrence> Recurrences { get; set; } = new List<Recurrence>();

    public virtual ICollection<Response> Responses { get; set; } = new List<Response>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<ServiceRequest> ServiceRequests { get; set; } = new List<ServiceRequest>();

    public virtual ICollection<Statement> Statements { get; set; } = new List<Statement>();

    public virtual ICollection<TableCustomization> TableCustomizations { get; set; } = new List<TableCustomization>();

    public virtual ICollection<TaxRebateEntityMap> TaxRebateEntityMaps { get; set; } = new List<TaxRebateEntityMap>();

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public virtual ICollection<UserList> UserLists { get; set; } = new List<UserList>();

    public virtual ICollection<UserToken> UserTokens { get; set; } = new List<UserToken>();

    public virtual ICollection<ClientGroup> FkClientGroups { get; set; } = new List<ClientGroup>();

    public virtual ICollection<CustomerGroup> FkCustomerGroups { get; set; } = new List<CustomerGroup>();

    public virtual ICollection<CustomerType> FkCustomerTypes { get; set; } = new List<CustomerType>();

    public virtual ICollection<PromotionTargetMap> FkPromotionTargetMaps { get; set; } = new List<PromotionTargetMap>();
}
