using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class RackPlusProductPriceModelMap
{
    public int Id { get; set; }

    public int FkProductId { get; set; }

    public double? Factor { get; set; }

    public double Value { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string Code { get; set; } = null!;

    public DateTime? DateApplicable { get; set; }

    public string? Reason { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Product FkProduct { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
