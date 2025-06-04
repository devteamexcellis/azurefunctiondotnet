using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class LogUserAudience
{
    public int FkLogId { get; set; }

    public string UserId { get; set; } = null!;

    public string? DisplayName { get; set; }

    public virtual Log FkLog { get; set; } = null!;
}
