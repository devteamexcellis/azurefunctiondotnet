using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class TagEntityMap
{
    public string FkTagId { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int EntityId { get; set; }

    public virtual Tag FkTag { get; set; } = null!;
}
