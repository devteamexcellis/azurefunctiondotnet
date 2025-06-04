using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ApiDump
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string? RequestOrigin { get; set; }

    public string Message { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public virtual ICollection<UserActivityLog> UserActivityLogs { get; set; } = new List<UserActivityLog>();
}
