using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Attachment
{
    public long Id { get; set; }

    public string Module { get; set; } = null!;

    public int? FkCustomerId { get; set; }

    public string? FkOrderId { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Url { get; set; }

    public string? FileName { get; set; }

    public double? FileSize { get; set; }

    public byte[]? FileBinary { get; set; }

    public string? FkInvoiceId { get; set; }

    public int? FkServiceRequestId { get; set; }

    public int? FkLeadId { get; set; }

    public string? Guid { get; set; }

    public string? UrlBase { get; set; }

    public string? UrlContainer { get; set; }

    public string? UrlEntity { get; set; }

    public int? FkInspectionId { get; set; }

    public bool? IsPrimary { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? FkStatementId { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Customer? FkCustomer { get; set; }

    public virtual Inspection? FkInspection { get; set; }

    public virtual Invoice? FkInvoice { get; set; }

    public virtual Lead? FkLead { get; set; }

    public virtual Order? FkOrder { get; set; }

    public virtual ServiceRequest? FkServiceRequest { get; set; }

    public virtual Statement? FkStatement { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }
}
