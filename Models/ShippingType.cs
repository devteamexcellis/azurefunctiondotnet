using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ShippingType
{
    public int Id { get; set; }

    public int? FkShipVendorId { get; set; }

    public string VendorCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? ClientCode { get; set; }

    public virtual ShippingVendor? FkShipVendor { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<RecurrenceOrderSetting> RecurrenceOrderSettings { get; set; } = new List<RecurrenceOrderSetting>();
}
