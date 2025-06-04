using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class AccountCustomerAddressMap
{
    public int FkAccountId { get; set; }

    public int FkCustomerAddressId { get; set; }

    public int FkCustomerId { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual CustomerAddress CustomerAddress { get; set; } = null!;

    public virtual ICollection<CustomerAddressAccountServiceMap> CustomerAddressAccountServiceMaps { get; set; } = new List<CustomerAddressAccountServiceMap>();

    public virtual ICollection<CustomerAddressAccountUserMap> CustomerAddressAccountUserMaps { get; set; } = new List<CustomerAddressAccountUserMap>();
}
