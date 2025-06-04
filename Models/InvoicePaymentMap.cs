using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class InvoicePaymentMap
{
    public int Id { get; set; }

    public string FkInvoiceId { get; set; } = null!;

    public int FkPaymentId { get; set; }

    public double Amount { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Invoice FkInvoice { get; set; } = null!;

    public virtual Payment FkPayment { get; set; } = null!;
}
