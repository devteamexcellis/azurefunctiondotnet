using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class RegionUserMap
{
    public int FkRegionId { get; set; }

    public string FkUserId { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Region FkRegion { get; set; } = null!;

    public virtual User FkUser { get; set; } = null!;
}
