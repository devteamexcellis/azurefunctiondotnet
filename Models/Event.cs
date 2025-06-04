using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Event
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public int? FkProductionScheduleId { get; set; }

    public string? Name { get; set; }

    public virtual ProductionSchedule? FkProductionSchedule { get; set; }
}
