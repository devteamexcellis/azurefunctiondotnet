using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Statement
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string StatementType { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateApproved { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? DatePdfGenerated { get; set; }

    public string? PdfGeneratedBy { get; set; }

    public int FkBrandId { get; set; }

    public int FkBatchId { get; set; }

    public string PeriodFrom { get; set; } = null!;

    public string PeriodTo { get; set; } = null!;

    public string BillAddrCountry { get; set; } = null!;

    public string BillAddrCity { get; set; } = null!;

    public string BillAddrZipcode { get; set; } = null!;

    public string BillAddrStreet { get; set; } = null!;

    public string BillAddrState { get; set; } = null!;

    public string RemitAddrCountry { get; set; } = null!;

    public string RemitAddrCity { get; set; } = null!;

    public string RemitAddrZipcode { get; set; } = null!;

    public string RemitAddrStreet { get; set; } = null!;

    public string RemitAddrState { get; set; } = null!;

    public string BranchAddrCountry { get; set; } = null!;

    public string BranchAddrCity { get; set; } = null!;

    public string BranchAddrZipcode { get; set; } = null!;

    public string BranchAddrStreet { get; set; } = null!;

    public string BranchAddrState { get; set; } = null!;

    public decimal AmountDue { get; set; }

    public string PaymentDueBy { get; set; } = null!;

    public string ControlNumber { get; set; } = null!;

    public virtual User? ApprovedByNavigation { get; set; }

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Batch FkBatch { get; set; } = null!;

    public virtual Brand FkBrand { get; set; } = null!;

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual User? PdfGeneratedByNavigation { get; set; }

    public virtual ICollection<StatementSubscriptionMap> StatementSubscriptionMaps { get; set; } = new List<StatementSubscriptionMap>();
}
