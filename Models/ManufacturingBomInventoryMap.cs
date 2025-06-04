using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ManufacturingBomInventoryMap
{
    public int FkManufacturingId { get; set; }

    public int FkProductId { get; set; }

    public int FkInventoryId { get; set; }

    public int TicketQuantity { get; set; }

    public int? PulledQuantity { get; set; }

    public int? ConsumedQuantity { get; set; }

    public int? ReturnedQuantity { get; set; }

    public int Id { get; set; }

    public virtual Inventory FkInventory { get; set; } = null!;

    public virtual ManufacturingBom ManufacturingBom { get; set; } = null!;
}
