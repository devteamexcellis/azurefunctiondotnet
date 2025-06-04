using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class UserLogMap
{
    public string FkUserId { get; set; } = null!;

    public int FkLogId { get; set; }

    public bool IsRead { get; set; }

    public virtual Log FkLog { get; set; } = null!;

    public virtual User FkUser { get; set; } = null!;
}
