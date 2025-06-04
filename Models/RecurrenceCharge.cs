using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class RecurrenceCharge
{
    public int Id { get; set; }

    public int FkRecurrenceId { get; set; }

    public int? FkProductId { get; set; }

    public string? FkVarianceId { get; set; }

    public string Type { get; set; } = null!;

    public double Amount { get; set; }

    public string? Description { get; set; }

    public string? Name { get; set; }

    public virtual Recurrence FkRecurrence { get; set; } = null!;
}
