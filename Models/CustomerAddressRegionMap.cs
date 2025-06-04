using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerAddressRegionMap
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public int FkCustomerAddressId { get; set; }

    public int FkRegionId { get; set; }

    public string Status { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public string? ModifiedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual CustomerAddress FkCustomerAddress { get; set; } = null!;

    public virtual Region FkRegion { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
