using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ViewTagProductMapDetail
{
    public string TagId { get; set; } = null!;

    public string TagType { get; set; } = null!;

    public int EntityId { get; set; }

    public string? ProductCode { get; set; }

    public string ProductName { get; set; } = null!;
}
