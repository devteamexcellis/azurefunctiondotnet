using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrderDetail
{
    public int FkProductId { get; set; }

    public string FkOrderId { get; set; } = null!;

    public string VarianceId { get; set; } = null!;

    public double OrderQuantity { get; set; }

    public int? ConfirmedQuantity { get; set; }

    public double? OrderPrice { get; set; }

    public double? ConfirmedPrice { get; set; }

    public double? ConfirmedWeight { get; set; }

    public DateTime? Timestamp { get; set; }

    public string? ItemStatus { get; set; }

    public int? ShippedQuantity { get; set; }

    public decimal? OrderVolume { get; set; }

    public int? LegacySalesNumber { get; set; }

    public decimal? ShippedGrossVolume { get; set; }

    public int? ShippedPercentFull { get; set; }

    public string? ShippedExtended { get; set; }

    public virtual Order FkOrder { get; set; } = null!;

    public virtual Product FkProduct { get; set; } = null!;

    public virtual ICollection<OrderDetailShipmentMap> OrderDetailShipmentMaps { get; set; } = new List<OrderDetailShipmentMap>();

    public virtual ICollection<OrderDetailsAddOn> OrderDetailsAddOns { get; set; } = new List<OrderDetailsAddOn>();
}
