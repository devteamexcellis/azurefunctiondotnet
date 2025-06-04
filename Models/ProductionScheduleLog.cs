using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ProductionScheduleLog
{
    public int Id { get; set; }

    public int FkProductionScheduleId { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? ProductionScheduleLogNotes { get; set; }

    public string Module { get; set; } = null!;

    public int? FkProductId { get; set; }

    public string? LotNumber { get; set; }

    public int? ProductionQuantity { get; set; }

    public string? Status { get; set; }

    public int? FkManufacturingId { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Manufacturing? FkManufacturing { get; set; }

    public virtual ProductionSchedule FkProductionSchedule { get; set; } = null!;
}
