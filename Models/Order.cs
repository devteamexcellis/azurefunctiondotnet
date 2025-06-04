using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Order
{
    public string Id { get; set; } = null!;

    public int FkCustomerId { get; set; }

    public int FkCustomerIdShip { get; set; }

    public int FkCustomerIdBill { get; set; }

    public string FkUserId { get; set; } = null!;

    public string? FkShipmentId { get; set; }

    public int? FkShipTypeId { get; set; }

    public int? FkShipVendorId { get; set; }

    public DateTime Timestamp { get; set; }

    public string? PoNumber { get; set; }

    public DateTime? DateModified { get; set; }

    public string OrderStatus { get; set; } = null!;

    public string BillAddrCountry { get; set; } = null!;

    public string BillAddrState { get; set; } = null!;

    public string BillAddrCity { get; set; } = null!;

    public string BillAddrStreet { get; set; } = null!;

    public string BillAddrZipcode { get; set; } = null!;

    public string ShipAddrCountry { get; set; } = null!;

    public string ShipAddrState { get; set; } = null!;

    public string ShipAddrCity { get; set; } = null!;

    public string ShipAddrStreet { get; set; } = null!;

    public string ShipAddrZipcode { get; set; } = null!;

    public string? DeliveryStatus { get; set; }

    public string? Comments { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public DateTime DateSubmitted { get; set; }

    public string? AttentionLine { get; set; }

    public string? SapOrderNumber { get; set; }

    public string? PaymentOption { get; set; }

    public string? CcTransactionId { get; set; }

    public int? FkRecurrenceId { get; set; }

    public string? BillAddrCountryCodeAlpha { get; set; }

    public string? BillAddrCountryCodeDigit { get; set; }

    public string? ShipAddrCountryCodeDigit { get; set; }

    public string? ShipAddrCountryCodeAlpha { get; set; }

    public string? UserLegacyId { get; set; }

    public int? FkUserTransactionId { get; set; }

    public string? CreditAuthorizationCode { get; set; }

    public string? LegacyId { get; set; }

    public int? FkSupplierVendorId { get; set; }

    public string? Type { get; set; }

    public string? OrderSource { get; set; }

    public DateTime? DateProcessed { get; set; }

    public bool? WarningBit { get; set; }

    public string? ReferenceId { get; set; }

    public bool? IsShippingGrouped { get; set; }

    public string? ShipAddrRecepientName { get; set; }

    public string? ShipAddrRecepientNumber { get; set; }

    public int? GroupId { get; set; }

    public string? ShipSiteId { get; set; }

    public string? OrderNumber { get; set; }

    public string? ShipSiteName { get; set; }

    public bool? IsRushOrder { get; set; }

    public DateTime? DateShipped { get; set; }

    public string? RequisitionNumber { get; set; }

    public string? IntlContactName { get; set; }

    public string? IntlContactNumber { get; set; }

    public string? IntlContactEmail { get; set; }

    public string? TaxId { get; set; }

    public string? ItemNumber { get; set; }

    public bool? IsInternationalOrder { get; set; }

    public string? Reason { get; set; }

    public string? ReasonByUserid { get; set; }

    public bool? IsReasonByAdmin { get; set; }

    public bool? IsService1 { get; set; }

    public string? PaymentId { get; set; }

    public string? ShipAddrRecepientEmail { get; set; }

    public string? PriceCode { get; set; }

    public string? ShipAddrRegion { get; set; }

    public string? ShipAddrZone { get; set; }

    public string? ShipAddrMapCode { get; set; }

    public string? LegacyIdType { get; set; }

    public int? Rank { get; set; }

    public int? TicketCopyToPrint { get; set; }

    public int? RemittanceCopyToPrint { get; set; }

    public string? CustomerTerms { get; set; }

    public string? ShipAddrTaxGroup { get; set; }

    public string? ShipAddrTankId { get; set; }

    public int? LegacyTypeId { get; set; }

    public string? BillAddrContactPerson { get; set; }

    public string? Comments1 { get; set; }

    public string? Comments2 { get; set; }

    public string? Comments3 { get; set; }

    public string? Comments4 { get; set; }

    public string? Comments5 { get; set; }

    public string? Comments6 { get; set; }

    public string? Comments7 { get; set; }

    public string? Comments8 { get; set; }

    public string? Comments9 { get; set; }

    public string? Comments10 { get; set; }

    public string? Comments11 { get; set; }

    public string? Comments12 { get; set; }

    public string? Comments13 { get; set; }

    public string? Comments14 { get; set; }

    public string? Comments15 { get; set; }

    public string? Comments16 { get; set; }

    public string? Comments17 { get; set; }

    public string? Comments18 { get; set; }

    public string? Comments19 { get; set; }

    public string? Comments20 { get; set; }

    public int? PaymentTermId { get; set; }

    public string? Fill { get; set; }

    public string? Flags { get; set; }

    public decimal? ShipAddrTankSize { get; set; }

    public int? ShipAddrNumTanks { get; set; }

    public decimal? ShipAddrIdealVolume { get; set; }

    public string? ShipAddrSchedCode { get; set; }

    public string? ShipAddrDeliveryCode { get; set; }

    public decimal? ShipAddrKFactor { get; set; }

    public int? ShipAddrForecastingProjection { get; set; }

    public string? ShipAddrDueDate { get; set; }

    public string? ShipAddrLastDeliveryDate { get; set; }

    public decimal? ShipAddrLastDeliveryVolume { get; set; }

    public decimal? ShipAddrPrevBalance { get; set; }

    public string? ShipAddrTruckId { get; set; }

    public string? ShipAddrDriverId { get; set; }

    public decimal? LegacyTotalCost { get; set; }

    public decimal? LegacyTotalTax { get; set; }

    public decimal? LegacyTotalMisc { get; set; }

    public decimal? LegacyTotalMiscTax { get; set; }

    public decimal? LegacyTotalCharged { get; set; }

    public DateTime? DateReturned { get; set; }

    public int? ReturnCode { get; set; }

    public string? ReturnReason { get; set; }

    public decimal? ShipAddrLongitude { get; set; }

    public decimal? ShipAddrLatitude { get; set; }

    public int? ShipAddrLlType { get; set; }

    public string? Gn { get; set; }

    public string? Priority { get; set; }

    public string? CancelledBy { get; set; }

    public DateTime? DateReviewed { get; set; }

    public DateTime? DateAssigned { get; set; }

    public DateTime? DateLoaded { get; set; }

    public DateTime? DateOnboarded { get; set; }

    public DateTime? DateCompleted { get; set; }

    public DateTime? DateBilled { get; set; }

    public DateTime? DateCancelled { get; set; }

    public bool? IsRepricable { get; set; }

    public string? DeliveryDateNote { get; set; }

    public bool? AweProcessFlag { get; set; }

    public bool? IsCreditChecked { get; set; }

    public bool? IsFinalReviewed { get; set; }

    public bool? IsAdminCreated { get; set; }

    public string? Tickref { get; set; }

    public string? ShipAddrCode { get; set; }

    public string? PaymentTermCode { get; set; }

    public double? GrossPrice { get; set; }

    public int? UrgencyFactor { get; set; }

    public string? CreditCode { get; set; }

    public DateTime? DateDelivered { get; set; }

    public double? PresetAmount { get; set; }

    public double? PresetVolume { get; set; }

    public bool? IsAwePricing { get; set; }

    public bool? SendNotification { get; set; }

    public string? InvoiceMailIntegration { get; set; }

    public string? BillingAddrStreet2 { get; set; }

    public string? BillingAddrStreet3 { get; set; }

    public string? ShipAddrStreet2 { get; set; }

    public string? ShipAddrStreet3 { get; set; }

    public string? CreditCheckedBy { get; set; }

    public string? CompletedBy { get; set; }

    public string? ApprovedForInvoicingBy { get; set; }

    public string? InvoicedBy { get; set; }

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    public virtual User? CancelledByNavigation { get; set; }

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual Customer FkCustomerIdBillNavigation { get; set; } = null!;

    public virtual Customer FkCustomerIdShipNavigation { get; set; } = null!;

    public virtual Recurrence? FkRecurrence { get; set; }

    public virtual ShippingType? FkShipType { get; set; }

    public virtual ShippingVendor? FkShipVendor { get; set; }

    public virtual Shipment? FkShipment { get; set; }

    public virtual SupplierVendor? FkSupplierVendor { get; set; }

    public virtual User FkUser { get; set; } = null!;

    public virtual ICollection<InventoryLog> InventoryLogs { get; set; } = new List<InventoryLog>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual ICollection<OrderAsset> OrderAssets { get; set; } = new List<OrderAsset>();

    public virtual ICollection<OrderCharge> OrderCharges { get; set; } = new List<OrderCharge>();

    public virtual ICollection<OrderDelivery> OrderDeliveries { get; set; } = new List<OrderDelivery>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    public virtual ICollection<OrderException> OrderExceptions { get; set; } = new List<OrderException>();

    public virtual ICollection<OrderInventoryMap> OrderInventoryMaps { get; set; } = new List<OrderInventoryMap>();

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<OrderLineItem> OrderLineItems { get; set; } = new List<OrderLineItem>();

    public virtual ICollection<OrderLog> OrderLogs { get; set; } = new List<OrderLog>();

    public virtual ICollection<OrderNotificationRecipient> OrderNotificationRecipients { get; set; } = new List<OrderNotificationRecipient>();

    public virtual ICollection<OrderNumber> OrderNumbers { get; set; } = new List<OrderNumber>();

    public virtual ICollection<OrderReturnLabel> OrderReturnLabels { get; set; } = new List<OrderReturnLabel>();

    public virtual User? ReasonByUser { get; set; }

    public virtual ICollection<StatementDetail> StatementDetails { get; set; } = new List<StatementDetail>();

    public virtual ICollection<PromotionCoupon> FkPromotionCoupons { get; set; } = new List<PromotionCoupon>();

    public virtual ICollection<Shipment> FkShipments { get; set; } = new List<Shipment>();

    public virtual ICollection<Shipping> FkShippings { get; set; } = new List<Shipping>();
}
