using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class RppmHistory
{
    public int Id { get; set; }

    public int ReferenceRppmId { get; set; }

    public string? PriceClass { get; set; }

    public string? Type { get; set; }

    public double? Value { get; set; }

    public string? Variance { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? Reason { get; set; }

    public DateTime? DateApplicable { get; set; }

    public string? Action { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;
}
