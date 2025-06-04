using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Shipment
{
    public string Id { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public DateTime? DateModified { get; set; }

    public DateTime ShipmentDate { get; set; }

    public string Status { get; set; } = null!;

    public string CarrierName { get; set; } = null!;

    public string CarrierId { get; set; } = null!;

    public string? ServiceType { get; set; }

    public string? PackagingType { get; set; }

    public string? PickupType { get; set; }

    public virtual ICollection<OrderDetailShipmentMap> OrderDetailShipmentMaps { get; set; } = new List<OrderDetailShipmentMap>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Order> FkOrders { get; set; } = new List<Order>();
}
