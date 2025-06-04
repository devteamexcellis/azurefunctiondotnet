using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ManufacturingLog
{
    public int Id { get; set; }

    public int FkManufacturingId { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string ManufacturingLogNotes { get; set; } = null!;

    public string Module { get; set; } = null!;

    public string? Status { get; set; }

    public int? FkInventoryLocationId { get; set; }

    public string? LotNumber { get; set; }

    public DateOnly? ExpDate { get; set; }

    public int? ProductionQuantity { get; set; }

    public int? FinalProductionQuantity { get; set; }

    public int? QcQuantity { get; set; }

    public int? RestrictedQuantity { get; set; }

    public string? LotNotes { get; set; }

    public string? QcNotes { get; set; }

    public string? MovementNotes { get; set; }

    public int? MovementAdjustment { get; set; }

    public string? ReleasedBy { get; set; }

    public string? ReleaseNotes { get; set; }

    public DateOnly? ProductionDate { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual InventoryLocation? FkInventoryLocation { get; set; }

    public virtual Manufacturing FkManufacturing { get; set; } = null!;

    public virtual User? ReleasedByNavigation { get; set; }
}
