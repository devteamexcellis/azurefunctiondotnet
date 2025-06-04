using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class AccountServiceMap
{
    public int FkAccountId { get; set; }

    public int FkServiceId { get; set; }

    public int FkCustomerId { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual ICollection<CustomerAddressAccountServiceMap> CustomerAddressAccountServiceMaps { get; set; } = new List<CustomerAddressAccountServiceMap>();

    public virtual CustomerServiceMap CustomerServiceMap { get; set; } = null!;
}
