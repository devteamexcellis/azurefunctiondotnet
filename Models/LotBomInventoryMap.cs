using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class LotBomInventoryMap
{
    public int Id { get; set; }

    public int FkLotId { get; set; }

    public int FkProductId { get; set; }

    public int FkInventoryId { get; set; }

    public int ReservedQuantity { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Inventory FkInventory { get; set; } = null!;

    public virtual LotBom LotBom { get; set; } = null!;
}
