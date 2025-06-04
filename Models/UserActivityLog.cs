using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class UserActivityLog
{
    public int Id { get; set; }

    public int FkUserTransactionId { get; set; }

    public int? FkApiDumpId { get; set; }

    public string Type { get; set; } = null!;

    public double? Value { get; set; }

    public string? Unit { get; set; }

    public string? Message { get; set; }

    public DateTime DateCreated { get; set; }

    public virtual ApiDump? FkApiDump { get; set; }
}
