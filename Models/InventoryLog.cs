using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class InventoryLog
{
    public int Id { get; set; }

    public double Quantity { get; set; }

    public string Direction { get; set; } = null!;

    public string Module { get; set; } = null!;

    public int? FkManufacturingId { get; set; }

    public string? FkOrderId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? Notes { get; set; }

    public int FkInventoryId { get; set; }

    public DateTime? ProductionDate { get; set; }

    public DateOnly? ExpDate { get; set; }

    public string? LotNumber { get; set; }

    public string? InventoryLogNotes { get; set; }

    public int? FkLotId { get; set; }

    public int? FkInventoryLocationId { get; set; }

    public int? FkInventoryIdTransfer { get; set; }

    public double? InventoryValue1 { get; set; }

    public double? InventoryValue2 { get; set; }

    public string? StorageBin { get; set; }

    public double? PhysicalReading { get; set; }

    public DateOnly? RecordedAdjustmentDate { get; set; }

    public string? TransactionNumber { get; set; }

    public string? ExternalReferenceId { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Inventory FkInventory { get; set; } = null!;

    public virtual InventoryLocation? FkInventoryLocation { get; set; }

    public virtual Lot? FkLot { get; set; }

    public virtual Manufacturing? FkManufacturing { get; set; }

    public virtual Order? FkOrder { get; set; }
}
