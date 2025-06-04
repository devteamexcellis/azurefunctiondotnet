using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class LogRoleAudience
{
    public int FkLogId { get; set; }

    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public virtual Log FkLog { get; set; } = null!;
}
