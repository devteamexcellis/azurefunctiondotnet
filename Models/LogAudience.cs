using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class LogAudience
{
    public int FkLogId { get; set; }

    public string Entity { get; set; } = null!;

    public string EntityId { get; set; } = null!;

    public virtual Log FkLog { get; set; } = null!;
}
