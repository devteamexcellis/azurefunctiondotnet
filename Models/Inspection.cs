using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Inspection
{
    public int Id { get; set; }

    public int? FkAssetId { get; set; }

    public int? FkCustomerAddressId { get; set; }

    public string? Description { get; set; }

    public string? Notes { get; set; }

    public DateTime? DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? LastInspection { get; set; }

    public DateTime? NextInspection { get; set; }

    public string? Condition { get; set; }

    public bool? IsInspectionRequired { get; set; }

    public bool? IsFollowUpNeeded { get; set; }

    public string? TechnicianId { get; set; }

    public string? InspectionNumber { get; set; }

    public string Module { get; set; } = null!;

    public string IdentityColumn { get; set; } = null!;

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Asset? FkAsset { get; set; }

    public virtual CustomerAddress? FkCustomerAddress { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }
}
