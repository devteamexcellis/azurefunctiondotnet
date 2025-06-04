using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class StatementDetail
{
    public int Id { get; set; }

    public int FkStatementId { get; set; }

    public string Module { get; set; } = null!;

    public string? FkInvoiceId { get; set; }

    public int? FkPaymentId { get; set; }

    public string? FkOrderId { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string TransactionDate { get; set; } = null!;

    public string ReferenceNumber { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal? Volume { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal Total { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Invoice? FkInvoice { get; set; }

    public virtual Order? FkOrder { get; set; }

    public virtual Payment? FkPayment { get; set; }
}
