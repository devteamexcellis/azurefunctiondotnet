using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class RecurrenceDetail
{
    public int FkRecurrenceId { get; set; }

    public int FkCustomerId { get; set; }

    public int FkProductId { get; set; }

    public string VarianceId { get; set; } = null!;

    public double Quantity { get; set; }

    public DateTime Timestamp { get; set; }

    public virtual CustomerProductVarianceMap CustomerProductVarianceMap { get; set; } = null!;

    public virtual Recurrence FkRecurrence { get; set; } = null!;
}
