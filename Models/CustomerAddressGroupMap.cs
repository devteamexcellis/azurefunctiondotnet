using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerAddressGroupMap
{
    public int FkCustomerAddressId { get; set; }

    public int FkGroupId { get; set; }

    public string? LegacyId { get; set; }

    public virtual CustomerAddress FkCustomerAddress { get; set; } = null!;

    public virtual Group FkGroup { get; set; } = null!;
}
