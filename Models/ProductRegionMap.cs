using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ProductRegionMap
{
    public int Id { get; set; }

    public int FkProductId { get; set; }

    public int FkRegionId { get; set; }

    public string? Type { get; set; }

    public double? Price { get; set; }

    public string? Status { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual Product FkProduct { get; set; } = null!;

    public virtual Region FkRegion { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
