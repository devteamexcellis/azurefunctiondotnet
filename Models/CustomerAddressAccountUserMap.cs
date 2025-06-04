using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerAddressAccountUserMap
{
    public int FkAccountId { get; set; }

    public int FkCustomerAddressId { get; set; }

    public int FkCustomerId { get; set; }

    public string FkUserId { get; set; } = null!;

    public virtual AccountCustomerAddressMap AccountCustomerAddressMap { get; set; } = null!;

    public virtual AccountUserMap AccountUserMap { get; set; } = null!;
}
