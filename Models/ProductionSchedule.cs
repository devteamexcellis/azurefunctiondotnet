using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ProductionSchedule
{
    public int Id { get; set; }

    public int FkProductId { get; set; }

    public string LotNumber { get; set; } = null!;

    public int ProductionQuantity { get; set; }

    public string Status { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public int? FkLotId { get; set; }

    public DateTime? TargetProductionDate { get; set; }

    public int? FkInventoryLocationId { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual InventoryLocation? FkInventoryLocation { get; set; }

    public virtual Lot? FkLot { get; set; }

    public virtual Product FkProduct { get; set; } = null!;

    public virtual ICollection<Manufacturing> Manufacturings { get; set; } = new List<Manufacturing>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<ProductionScheduleLog> ProductionScheduleLogs { get; set; } = new List<ProductionScheduleLog>();

    public virtual ICollection<ProductionScheduleTicket> ProductionScheduleTickets { get; set; } = new List<ProductionScheduleTicket>();
}
