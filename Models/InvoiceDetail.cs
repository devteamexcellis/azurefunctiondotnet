using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class InvoiceDetail
{
    public int Id { get; set; }

    public string FkInvoiceId { get; set; } = null!;

    public int FkProductId { get; set; }

    public DateTime? Timestamp { get; set; }

    public string? VarianceId { get; set; }

    public decimal InvoicedQuantity { get; set; }

    public double InvoicedPrice { get; set; }

    public double? InvoicedWeight { get; set; }

    public string? PriceModel { get; set; }

    public string? PriceType { get; set; }

    public virtual Invoice FkInvoice { get; set; } = null!;

    public virtual Product FkProduct { get; set; } = null!;

    public virtual ICollection<InvoiceCharge> InvoiceCharges { get; set; } = new List<InvoiceCharge>();
}
