using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerEnrollmentLog
{
    public int Id { get; set; }

    public DateTime Timestamp { get; set; }

    public string? FkUserId { get; set; }

    public string Name { get; set; } = null!;

    public virtual User? FkUser { get; set; }
}
