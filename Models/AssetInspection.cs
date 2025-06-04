using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class AssetInspection
{
    public int Id { get; set; }

    public int FkAssetId { get; set; }

    public string? Description { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? LastInspection { get; set; }

    public DateTime? NextInspection { get; set; }

    public string? Condition { get; set; }

    public bool? IsInspectionRequired { get; set; }

    public bool? IsFollowUpNeeded { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Asset FkAsset { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
