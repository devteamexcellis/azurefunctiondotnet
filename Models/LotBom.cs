using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class LotBom
{
    public int FkLotId { get; set; }

    public int FkProductId { get; set; }

    public int Quantity { get; set; }

    public virtual Lot FkLot { get; set; } = null!;

    public virtual Product FkProduct { get; set; } = null!;

    public virtual ICollection<LotBomInventoryMap> LotBomInventoryMaps { get; set; } = new List<LotBomInventoryMap>();
}
