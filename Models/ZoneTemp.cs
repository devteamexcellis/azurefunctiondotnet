using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ZoneTemp
{
    public string Region { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string? Description { get; set; }
}
