using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ServiceAsset
{
    public int Id { get; set; }

    public int FkServiceId { get; set; }

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Url { get; set; }

    public string Filename { get; set; } = null!;

    public bool? IsDefault { get; set; }

    public virtual Service FkService { get; set; } = null!;
}
