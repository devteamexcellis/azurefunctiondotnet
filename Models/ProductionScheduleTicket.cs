using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ProductionScheduleTicket
{
    public int Id { get; set; }

    public int FkProductionScheduleId { get; set; }

    public int TicketQuantity { get; set; }

    public int? FkInventoryLocationId { get; set; }

    public string Status { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual InventoryLocation? FkInventoryLocation { get; set; }

    public virtual ProductionSchedule FkProductionSchedule { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<ProductionSchedTicketInvMap> ProductionSchedTicketInvMaps { get; set; } = new List<ProductionSchedTicketInvMap>();
}
