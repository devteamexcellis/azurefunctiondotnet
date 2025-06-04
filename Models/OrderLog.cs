using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrderLog
{
    public int Id { get; set; }

    public string FkOrderId { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string MessageShort { get; set; } = null!;

    public string MessageFull { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public virtual Order FkOrder { get; set; } = null!;
}
