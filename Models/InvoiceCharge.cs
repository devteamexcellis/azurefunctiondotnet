using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class InvoiceCharge
{
    public int Id { get; set; }

    public string FkInvoiceId { get; set; } = null!;

    public int? FkInvoiceDetailId { get; set; }

    public string Type { get; set; } = null!;

    public double Amount { get; set; }

    public string? Description { get; set; }

    public string? PromotionCode { get; set; }

    public int? CouponId { get; set; }

    public string? DescriptionCd { get; set; }

    public string? ChargeCode { get; set; }

    public virtual Invoice FkInvoice { get; set; } = null!;

    public virtual InvoiceDetail? FkInvoiceDetail { get; set; }
}
