using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class PriceZone
{
    public int Id { get; set; }

    public int FkRegionId { get; set; }

    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Comments { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual Region FkRegion { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
