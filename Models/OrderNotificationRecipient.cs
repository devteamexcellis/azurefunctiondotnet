using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrderNotificationRecipient
{
    public int Id { get; set; }

    public string FkOrderId { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual Order FkOrder { get; set; } = null!;
}
