using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class StatementType
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public string? ProcessType { get; set; }

    public bool? IsDailyInterestCalc { get; set; }

    public int? DaysBeforeDue { get; set; }

    public string Status { get; set; } = null!;

    public virtual User? CreatedByNavigation { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }
}
