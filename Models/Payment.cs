using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Payment
{
    public int Id { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public string Status { get; set; } = null!;

    public double Amount { get; set; }

    public string? PaymentId { get; set; }

    public string? PaymentMerchant { get; set; }

    public string? Notes { get; set; }

    public string? ModeOfPayment { get; set; }

    public string? PaymentMethodReferenceId { get; set; }

    public string? PaymentReferenceId { get; set; }

    public int? FkCustomerId { get; set; }

    public DateTime? DatePosted { get; set; }

    public string? FailureCode { get; set; }

    public string? FailureMessage { get; set; }

    public bool? IsCashOnHand { get; set; }

    public DateTime? DateCashOut { get; set; }

    public string? BusinessUnit { get; set; }

    public string? Employee { get; set; }

    public string? PaymentType { get; set; }

    public string? CardNumber { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Customer? FkCustomer { get; set; }

    public virtual ICollection<InvoicePaymentMap> InvoicePaymentMaps { get; set; } = new List<InvoicePaymentMap>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<StatementDetail> StatementDetails { get; set; } = new List<StatementDetail>();
}
