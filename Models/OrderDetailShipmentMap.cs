using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrderDetailShipmentMap
{
    public int Id { get; set; }

    public string FkOrderId { get; set; } = null!;

    public int FkProductId { get; set; }

    public string? FkVarianceId { get; set; }

    public string FkShipmentId { get; set; } = null!;

    public DateTime? Timestamp { get; set; }

    public string? TrackingNumber { get; set; }

    public int? ShippedQuantity { get; set; }

    public string? LotNumber { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public virtual Shipment FkShipment { get; set; } = null!;

    public virtual OrderDetail? OrderDetail { get; set; }
}
