using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class MiscellaneousCharge
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public string Status { get; set; } = null!;

    public double DefaultValue { get; set; }

    public int? AweRecordId { get; set; }

    public string? AweCode { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
