using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerShippingVendorMap
{
    public int Id { get; set; }

    public int? FkCustomerId { get; set; }

    public int? FkShipVendorId { get; set; }

    public bool? IsDefault { get; set; }

    public virtual Customer? FkCustomer { get; set; }

    public virtual ShippingVendor? FkShipVendor { get; set; }
}
