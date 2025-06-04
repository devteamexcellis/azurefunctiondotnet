using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerAddressProductSetting
{
    public int Id { get; set; }

    public int FkCustomerAddressId { get; set; }

    public int FkProductId { get; set; }

    public int? LegacyRack { get; set; }

    public int? LegacyMethod { get; set; }

    public string? LegacyMiscCharge { get; set; }

    public string? LegacyFillLocationId { get; set; }

    public virtual CustomerAddress FkCustomerAddress { get; set; } = null!;

    public virtual Product FkProduct { get; set; } = null!;
}
