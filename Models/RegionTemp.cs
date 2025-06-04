using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class RegionTemp
{
    public string RegionCode { get; set; } = null!;

    public string RegionName { get; set; } = null!;

    public DateTime CreationDateTime { get; set; }

    public DateTime? ModificationDateTime { get; set; }

    public string? ModifiedBy { get; set; }
}
