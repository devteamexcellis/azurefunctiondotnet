using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrderReturnLabel
{
    public int Id { get; set; }

    public string FkOrderId { get; set; } = null!;

    public string? TrackingNumber { get; set; }

    public string ChargeAccount { get; set; } = null!;

    public string CreatedById { get; set; } = null!;

    public string? CreatedByName { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? ModifiedById { get; set; }

    public string? ModifiedByName { get; set; }

    public string? ModifiedDate { get; set; }

    public string Status { get; set; } = null!;

    public string? Label { get; set; }

    public string CarrierId { get; set; } = null!;

    public string CarrierName { get; set; } = null!;

    public string? ServiceType { get; set; }

    public string? PickupType { get; set; }

    public string? PackagingType { get; set; }

    public string? SubPackagingType { get; set; }

    public string? BoxType { get; set; }

    public string? ShipQuantity { get; set; }

    public string? ShipWeight { get; set; }

    public string? ShipWeightUnit { get; set; }

    public string? ShipFromState { get; set; }

    public string? ShipFromCity { get; set; }

    public string? ShipFromZip { get; set; }

    public string? ShipFromStreet { get; set; }

    public string? ShipToState { get; set; }

    public string? ShipToCity { get; set; }

    public string? ShipToZip { get; set; }

    public string? ShipToStreet { get; set; }

    public string? ShipFromName { get; set; }

    public string? ShipToName { get; set; }

    public string? MessageShort { get; set; }

    public string? ShipToRecepientName { get; set; }

    public string? MessageFull { get; set; }

    public string? RequisitionNumber { get; set; }

    public string? ShipFromCountry { get; set; }

    public string? ShipToCountry { get; set; }

    public string? ItemNumber { get; set; }

    public virtual User CreatedBy { get; set; } = null!;

    public virtual Order FkOrder { get; set; } = null!;

    public virtual User? ModifiedBy { get; set; }
}
