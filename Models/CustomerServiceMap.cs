using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerServiceMap
{
    public int FkCustomerId { get; set; }

    public int FkServiceId { get; set; }

    public virtual ICollection<AccountServiceMap> AccountServiceMaps { get; set; } = new List<AccountServiceMap>();
}
