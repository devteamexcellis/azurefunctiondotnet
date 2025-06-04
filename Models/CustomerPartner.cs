using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerPartner
{
    public int FkCustomerId { get; set; }

    public string Role { get; set; } = null!;

    public int PartnerId { get; set; }

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual Customer Partner { get; set; } = null!;
}
