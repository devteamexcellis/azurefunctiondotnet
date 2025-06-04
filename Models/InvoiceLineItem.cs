using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class InvoiceLineItem
{
    public int Id { get; set; }

    public string FkInvoiceId { get; set; } = null!;

    public int FkProductId { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? PriceModel { get; set; }

    public string? PriceType { get; set; }

    public string? PriceVariance { get; set; }

    public double? InvoicedQuantity { get; set; }

    public double? InvoicedPrice { get; set; }

    public virtual Invoice FkInvoice { get; set; } = null!;

    public virtual Product FkProduct { get; set; } = null!;
}
