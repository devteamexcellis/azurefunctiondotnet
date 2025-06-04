using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class BillOfMaterial
{
    public double Version { get; set; }

    public int FkParentProductId { get; set; }

    public int FkChildProductId { get; set; }

    public int Quantity { get; set; }

    public virtual Product FkChildProduct { get; set; } = null!;

    public virtual Product FkParentProduct { get; set; } = null!;
}
