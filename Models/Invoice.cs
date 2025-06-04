using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Invoice
{
    public string Id { get; set; } = null!;

    public string FkOrderId { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public DateTime? PaymentTerms { get; set; }

    public DateTime? PaymentDueDate { get; set; }

    public int? PaymentTermsDays { get; set; }

    public double? TermsDiscountPercent { get; set; }

    public DateTime? TermsDiscountDueDate { get; set; }

    public int? TermsDiscountDays { get; set; }

    public string? DeliveryNumber { get; set; }

    public string? Incoterm { get; set; }

    public int? ShippedUnits { get; set; }

    public string? ShippedUnitsUnit { get; set; }

    public string? RemitName { get; set; }

    public string? RemitAddress { get; set; }

    public string? RemitState { get; set; }

    public string? RemitCity { get; set; }

    public string? RemitZipcode { get; set; }

    public bool? ShowCharges { get; set; }

    public string? PaymentTermsName { get; set; }

    public string? Type { get; set; }

    public bool? MailProcessed { get; set; }

    public string? BillAddrCountry { get; set; }

    public string? BillAddrState { get; set; }

    public string? BillAddrCity { get; set; }

    public string? BillAddrStreet { get; set; }

    public string? BillAddrZipcode { get; set; }

    public string? BillAddrName { get; set; }

    public string? ShipAddrCountry { get; set; }

    public string? ShipAddrState { get; set; }

    public string? ShipAddrCity { get; set; }

    public string? ShipAddrStreet { get; set; }

    public string? ShipAddrZipcode { get; set; }

    public string? ShipAddrName { get; set; }

    public string? RemAddrCountry { get; set; }

    public string? RemAddrState { get; set; }

    public string? RemAddrCity { get; set; }

    public string? RemAddrStreet { get; set; }

    public string? RemAddrZipcode { get; set; }

    public string? RemAddrName { get; set; }

    public string? ShipAddrCode { get; set; }

    public string? Notes { get; set; }

    public bool? SendNotification { get; set; }

    public string? InvoiceMailIntegration { get; set; }

    public bool? IsPostgrid { get; set; }

    public bool? IsSendgrid { get; set; }

    public bool? IsSidetrade { get; set; }

    public string? BillingAddrStreet2 { get; set; }

    public string? BillingAddrStreet3 { get; set; }

    public string? ShipAddrStreet2 { get; set; }

    public string? ShipAddrStreet3 { get; set; }

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    public virtual Order FkOrder { get; set; } = null!;

    public virtual ICollection<InvoiceCharge> InvoiceCharges { get; set; } = new List<InvoiceCharge>();

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; } = new List<InvoiceDetail>();

    public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; } = new List<InvoiceLineItem>();

    public virtual ICollection<InvoicePaymentMap> InvoicePaymentMaps { get; set; } = new List<InvoicePaymentMap>();

    public virtual ICollection<InvoicePayment> InvoicePayments { get; set; } = new List<InvoicePayment>();

    public virtual ICollection<Note> NotesNavigation { get; set; } = new List<Note>();

    public virtual ICollection<OrderNumber> OrderNumbers { get; set; } = new List<OrderNumber>();

    public virtual ICollection<StatementDetail> StatementDetails { get; set; } = new List<StatementDetail>();
}
