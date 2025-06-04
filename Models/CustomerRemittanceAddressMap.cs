using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerRemittanceAddressMap
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public int FkRemittanceAddressId { get; set; }

    public string? Status { get; set; }

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual RemittanceAddress FkRemittanceAddress { get; set; } = null!;
}
