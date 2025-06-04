using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class InventoryLocation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? Type { get; set; }

    public string? ReferenceId { get; set; }

    public int? FkRegionId { get; set; }

    public double? Capacity { get; set; }

    public int? NsBinInternalId { get; set; }

    public int? NsLocInternalId { get; set; }

    public string? NsBusinessUnit { get; set; }

    public string? City { get; set; }

    public string? NsRegion { get; set; }

    public string? State { get; set; }

    public string? NsLocation { get; set; }

    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();

    public virtual User? CreatedByNavigation { get; set; }

    public virtual Region? FkRegion { get; set; }

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<InventoryLog> InventoryLogs { get; set; } = new List<InventoryLog>();

    public virtual ICollection<ManufacturingLog> ManufacturingLogs { get; set; } = new List<ManufacturingLog>();

    public virtual ICollection<Manufacturing> Manufacturings { get; set; } = new List<Manufacturing>();

    public virtual ICollection<ProductionScheduleTicket> ProductionScheduleTickets { get; set; } = new List<ProductionScheduleTicket>();

    public virtual ICollection<ProductionSchedule> ProductionSchedules { get; set; } = new List<ProductionSchedule>();

    public virtual ICollection<RemittanceAddressRegionInventoryLocationMap> RemittanceAddressRegionInventoryLocationMaps { get; set; } = new List<RemittanceAddressRegionInventoryLocationMap>();
}
