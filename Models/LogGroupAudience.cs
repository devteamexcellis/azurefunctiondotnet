using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class LogGroupAudience
{
    public int FkLogId { get; set; }

    public int GroupId { get; set; }

    public string? GroupName { get; set; }

    public virtual Log FkLog { get; set; } = null!;
}
