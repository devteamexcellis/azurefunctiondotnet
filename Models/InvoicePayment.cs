using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class InvoicePayment
{
    public string FkInvoiceId { get; set; } = null!;

    public string PaymentId { get; set; } = null!;

    public DateOnly PaymentDate { get; set; }

    public double PaidAmount { get; set; }

    public double? TotalAmount { get; set; }

    public double Balance { get; set; }

    public string? Status { get; set; }

    public virtual Invoice FkInvoice { get; set; } = null!;
}
