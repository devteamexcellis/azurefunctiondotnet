using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ServicePrice
{
    public int Id { get; set; }

    public int FkServiceId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Uom { get; set; } = null!;

    public double Price { get; set; }

    public bool IsActive { get; set; }

    public bool IsBasePrice { get; set; }

    public bool IsPublic { get; set; }

    public virtual Service FkService { get; set; } = null!;
}
