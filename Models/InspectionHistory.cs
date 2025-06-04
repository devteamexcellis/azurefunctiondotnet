using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class InspectionHistory
{
    public int Id { get; set; }

    public int FkInspectionId { get; set; }

    public string? Description { get; set; }

    public string? Notes { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? LastInspection { get; set; }

    public DateTime? NextInspection { get; set; }

    public string? Condition { get; set; }

    public bool? IsInspectionRequired { get; set; }

    public bool? IsFollowUpNeeded { get; set; }

    public string? TechnicianId { get; set; }

    public string? InspectionNumber { get; set; }

    public string Module { get; set; } = null!;

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Inspection FkInspection { get; set; } = null!;
}
