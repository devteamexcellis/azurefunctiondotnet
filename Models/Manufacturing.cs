using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Manufacturing
{
    public int Id { get; set; }

    public int FkProductId { get; set; }

    public DateOnly ProductionDate { get; set; }

    public string? LotNumber { get; set; }

    public DateOnly ExpDate { get; set; }

    public int ProductionQuantity { get; set; }

    public int? QcQuantity { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public DateTime DateCreated { get; set; }

    public int? CurrentQuantity { get; set; }

    public bool? IsDeleted { get; set; }

    public string? LotNotes { get; set; }

    public string? QcNotes { get; set; }

    public string? BatchNumber { get; set; }

    public string Status { get; set; } = null!;

    public string? MovementNotes { get; set; }

    public int? MovementAdjustment { get; set; }

    public int? RestrictedQuantity { get; set; }

    public string? ReleasedBy { get; set; }

    public string? UnrestrictedBy { get; set; }

    public DateTime? ReleasedDate { get; set; }

    public DateTime? UnrestrictedDate { get; set; }

    public string? ReleaseNotes { get; set; }

    public int? FkInventoryLocationId { get; set; }

    public int? FinalProductionQuantity { get; set; }

    public int? FkProductionScheduleId { get; set; }

    public int? FkLotId { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public int? ResourcesNumber { get; set; }

    public string? ResourcesNames { get; set; }

    public string? InspectedBy { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual InventoryLocation? FkInventoryLocation { get; set; }

    public virtual Lot? FkLot { get; set; }

    public virtual Product FkProduct { get; set; } = null!;

    public virtual ProductionSchedule? FkProductionSchedule { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<InventoryLog> InventoryLogs { get; set; } = new List<InventoryLog>();

    public virtual User? LastModifiedByNavigation { get; set; }

    public virtual ICollection<ManufacturingBom> ManufacturingBoms { get; set; } = new List<ManufacturingBom>();

    public virtual ICollection<ManufacturingLog> ManufacturingLogs { get; set; } = new List<ManufacturingLog>();

    public virtual ICollection<ProductionScheduleLog> ProductionScheduleLogs { get; set; } = new List<ProductionScheduleLog>();

    public virtual User? ReleasedByNavigation { get; set; }

    public virtual User? UnrestrictedByNavigation { get; set; }
}
