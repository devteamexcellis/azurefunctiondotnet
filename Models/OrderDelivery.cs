using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrderDelivery
{
    public int Id { get; set; }

    public string FkOrderId { get; set; } = null!;

    public DateTime? DateAssignedToTruck { get; set; }

    public int? Shift { get; set; }

    public string? Sequence { get; set; }

    public DateTime? MeterStartDate { get; set; }

    public DateTime? MeterEndDate { get; set; }

    public double? OdometerStart { get; set; }

    public int? MeterNumber { get; set; }

    public double? TotalPayments { get; set; }

    public double? TruckInventory { get; set; }

    public int? DepotId { get; set; }

    public string? Bol { get; set; }

    public DateTime? DateAssignedToAwe { get; set; }

    public DateTime? DateDispatchedFromHost { get; set; }

    public DateTime? TruckDateArrived { get; set; }

    public DateTime? DateDeliveryStarted { get; set; }

    public DateTime? DateDeliveryCompleted { get; set; }

    public DateTime? DateDeparted { get; set; }

    public string? TruckId { get; set; }

    public string? DriverId { get; set; }

    public int? LegacySalesNumber { get; set; }

    public double? OdometerEnd { get; set; }

    public DateTime? DateLoaded { get; set; }

    public virtual Order FkOrder { get; set; } = null!;
}
