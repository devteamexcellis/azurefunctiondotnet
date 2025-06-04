using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrderItem
{
    public int Id { get; set; }

    public string FkOrderId { get; set; } = null!;

    public string ItemNumber { get; set; } = null!;

    public virtual Order FkOrder { get; set; } = null!;
}
