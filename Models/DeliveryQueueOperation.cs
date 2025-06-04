using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class DeliveryQueueOperation
{
    public int Id { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public string Status { get; set; } = null!;

    public int FkRegionId { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Region FkRegion { get; set; } = null!;
}
