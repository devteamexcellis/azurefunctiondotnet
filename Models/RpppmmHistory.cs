using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class RpppmmHistory
{
    public int Id { get; set; }

    public int ReferenceRpppmm { get; set; }

    public double? Factor { get; set; }

    public DateTime? DateApplicable { get; set; }

    public double? Value { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? Reason { get; set; }

    public string? Action { get; set; }

    public string? Code { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;
}
