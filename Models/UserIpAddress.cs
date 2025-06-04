using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class UserIpAddress
{
    public string FkUserId { get; set; } = null!;

    public string Ip { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public virtual User FkUser { get; set; } = null!;
}
