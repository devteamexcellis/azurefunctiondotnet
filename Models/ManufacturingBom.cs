using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ManufacturingBom
{
    public int FkManufacturingId { get; set; }

    public int FkProductId { get; set; }

    public int Quantity { get; set; }

    public virtual Manufacturing FkManufacturing { get; set; } = null!;

    public virtual Product FkProduct { get; set; } = null!;

    public virtual ICollection<ManufacturingBomInventoryMap> ManufacturingBomInventoryMaps { get; set; } = new List<ManufacturingBomInventoryMap>();
}
