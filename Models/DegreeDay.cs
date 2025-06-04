using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class DegreeDay
{
    public int Id { get; set; }

    public int FkRegionId { get; set; }

    public int? LocalDay { get; set; }

    public int? LocalYear { get; set; }

    public DateTime? LocalDate { get; set; }

    public double? HeatingDegreeDays { get; set; }

    public double? DegreeDaySum { get; set; }

    public DateTime DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string? CreatedBy { get; set; }

    public int? LocalMonth { get; set; }

    public string? CurrentSeason { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual Region FkRegion { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
