using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Lot
{
    public int Id { get; set; }

    public int FkProductId { get; set; }

    public int LotSize { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string Status { get; set; } = null!;

    public string? LotNumber { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Product FkProduct { get; set; } = null!;

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<InventoryLog> InventoryLogs { get; set; } = new List<InventoryLog>();

    public virtual ICollection<LotBom> LotBoms { get; set; } = new List<LotBom>();

    public virtual ICollection<LotLog> LotLogs { get; set; } = new List<LotLog>();

    public virtual ICollection<Manufacturing> Manufacturings { get; set; } = new List<Manufacturing>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<ProductionSchedule> ProductionSchedules { get; set; } = new List<ProductionSchedule>();
}
