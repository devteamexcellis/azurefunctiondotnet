using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class DeliveryQueueOperationMap
{
    public int FkDeliveryQueueOperationId { get; set; }

    public int FkDeliveryQueueId { get; set; }

    public string Status { get; set; } = null!;

    public string? FkOrderId { get; set; }

    public virtual DeliveryQueue FkDeliveryQueue { get; set; } = null!;

    public virtual DeliveryQueueOperation FkDeliveryQueueOperation { get; set; } = null!;
}
