using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class StatementSubscriptionMap
{
    public int Id { get; set; }

    public int FkStatementId { get; set; }

    public int FkSubscriptionId { get; set; }

    public string? Email { get; set; }

    public DateTime? DateProcessed { get; set; }

    public virtual Statement FkStatement { get; set; } = null!;

    public virtual Subscription FkSubscription { get; set; } = null!;
}
