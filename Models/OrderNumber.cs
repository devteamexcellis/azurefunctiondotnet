using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrderNumber
{
    public int Id { get; set; }

    public string? FkOrderId { get; set; }

    public string? FkInvoiceId { get; set; }

    public string SapOrderNumber { get; set; } = null!;

    public virtual Invoice? FkInvoice { get; set; }

    public virtual Order? FkOrder { get; set; }
}
