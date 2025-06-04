using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrderInventoryMap
{
    public int Id { get; set; }

    public string FkOrderId { get; set; } = null!;

    public string? LotNumber { get; set; }

    public string? ProductCode { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Location { get; set; }

    public DateOnly? ExpDate { get; set; }

    public int? ConfirmedQuantity { get; set; }

    public int? ShippedQuantity { get; set; }

    public int? FkInventoryId { get; set; }

    public virtual Inventory? FkInventory { get; set; }

    public virtual Order FkOrder { get; set; } = null!;
}
