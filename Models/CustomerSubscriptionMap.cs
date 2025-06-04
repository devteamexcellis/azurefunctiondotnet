using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerSubscriptionMap
{
    public int FkCustomerId { get; set; }

    public int FkSubscriptionId { get; set; }

    public string? Col1 { get; set; }

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual Subscription FkSubscription { get; set; } = null!;
}
