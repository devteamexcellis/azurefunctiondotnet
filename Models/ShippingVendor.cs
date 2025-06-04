using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ShippingVendor
{
    public int Id { get; set; }

    public string VendorName { get; set; } = null!;

    public virtual ICollection<CustomerShippingVendorMap> CustomerShippingVendorMaps { get; set; } = new List<CustomerShippingVendorMap>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<RecurrenceOrderSetting> RecurrenceOrderSettings { get; set; } = new List<RecurrenceOrderSetting>();

    public virtual ICollection<ShippingType> ShippingTypes { get; set; } = new List<ShippingType>();
}
