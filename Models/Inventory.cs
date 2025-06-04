using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Inventory
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public int? FkProductId { get; set; }

    public int? FkMaterialId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? LotNumber { get; set; }

    public double Quantity { get; set; }

    public string? Notes { get; set; }

    public DateTime? ProductionDate { get; set; }

    public DateOnly? ExpDate { get; set; }

    public string? QuantityType { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public int? FkManufacturingId { get; set; }

    public string? VendorCode { get; set; }

    public int? FkSupplierVendorId { get; set; }

    public int? FkInventoryLocationId { get; set; }

    public int? FkLotId { get; set; }

    public double? InventoryValue1 { get; set; }

    public double? InventoryValue2 { get; set; }

    public string? StorageBin { get; set; }

    public double? PhysicalReading { get; set; }

    public DateOnly? RecordedAdjustmentDate { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual InventoryLocation? FkInventoryLocation { get; set; }

    public virtual Lot? FkLot { get; set; }

    public virtual Manufacturing? FkManufacturing { get; set; }

    public virtual Material? FkMaterial { get; set; }

    public virtual Product? FkProduct { get; set; }

    public virtual SupplierVendor? FkSupplierVendor { get; set; }

    public virtual ICollection<InventoryLog> InventoryLogs { get; set; } = new List<InventoryLog>();

    public virtual ICollection<LotBomInventoryMap> LotBomInventoryMaps { get; set; } = new List<LotBomInventoryMap>();

    public virtual ICollection<ManufacturingBomInventoryMap> ManufacturingBomInventoryMaps { get; set; } = new List<ManufacturingBomInventoryMap>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<OrderInventoryMap> OrderInventoryMaps { get; set; } = new List<OrderInventoryMap>();

    public virtual ICollection<ProductionSchedTicketInvMap> ProductionSchedTicketInvMaps { get; set; } = new List<ProductionSchedTicketInvMap>();
}
