using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Note
{
    public int Id { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string Module { get; set; } = null!;

    public int? FkCustomerId { get; set; }

    public string? FkOrderId { get; set; }

    public string Notes { get; set; } = null!;

    public int? Sequence { get; set; }

    public string? TargetColumn { get; set; }

    public int? FkCustomerAddressId { get; set; }

    public int? FkRecurrenceId { get; set; }

    public int? FkServiceRequestId { get; set; }

    public string? FkInvoiceId { get; set; }

    public string? Type { get; set; }

    public int? FkProductId { get; set; }

    public int? FkOrderCodeId { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Customer? FkCustomer { get; set; }

    public virtual CustomerAddress? FkCustomerAddress { get; set; }

    public virtual Invoice? FkInvoice { get; set; }

    public virtual Order? FkOrder { get; set; }

    public virtual OrderCode? FkOrderCode { get; set; }

    public virtual Product? FkProduct { get; set; }

    public virtual Recurrence? FkRecurrence { get; set; }

    public virtual ServiceRequest? FkServiceRequest { get; set; }
}
