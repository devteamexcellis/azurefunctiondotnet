using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class RppzcmHistory
{
    public int Id { get; set; }

    public int ReferenceRppzcmId { get; set; }

    public string? PriceZoneCode { get; set; }

    public string? PriceClass { get; set; }

    public string? Type { get; set; }

    public double? Value { get; set; }

    public string? Variance { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? Reason { get; set; }

    public DateOnly? DateApplicable { get; set; }

    public string? Action { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;
}
