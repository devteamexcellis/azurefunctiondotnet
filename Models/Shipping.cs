using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Shipping
{
    public int Id { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public DateTime? ShipmentDate { get; set; }

    public string? Status { get; set; }

    public string? CarrierId { get; set; }

    public string? CarrierName { get; set; }

    public string? ServiceType { get; set; }

    public string? PickupType { get; set; }

    public string? PackagingType { get; set; }

    public string? SubPackagingType { get; set; }

    public string? BoxType { get; set; }

    public int? ShipQuantity { get; set; }

    public double? ShipWeight { get; set; }

    public string? ShipWeightUnit { get; set; }

    public string? Label { get; set; }

    public string? TrackingNumber { get; set; }

    public string? ChargeAccount { get; set; }

    public string? FkUserId { get; set; }

    public string? CreatedByName { get; set; }

    public string? MasterTrackingNumber { get; set; }

    public string? LabelZpl { get; set; }

    public virtual User? FkUser { get; set; }

    public virtual ICollection<Order> FkOrders { get; set; } = new List<Order>();
}
