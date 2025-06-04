using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class InspectionLog
{
    public int Id { get; set; }

    public string? Module { get; set; }

    public int FkInspectionId { get; set; }

    public int? FkServiceRequestId { get; set; }

    public int? FkEquipmentId { get; set; }

    public string? Description { get; set; }

    public string? Notes { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public DateTime? NextInspectionDate { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Equipment? FkEquipment { get; set; }

    public virtual ServiceRequest? FkServiceRequest { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }
}
