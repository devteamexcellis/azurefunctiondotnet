using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerAddressAccountServiceMap
{
    public int FkAccountId { get; set; }

    public int FkCustomerAddressId { get; set; }

    public int FkCustomerId { get; set; }

    public int FkServiceId { get; set; }

    public virtual AccountCustomerAddressMap AccountCustomerAddressMap { get; set; } = null!;

    public virtual AccountServiceMap AccountServiceMap { get; set; } = null!;
}
