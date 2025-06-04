using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class BlockCustomerMap
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public int? FkCustomerAddressId { get; set; }

    public int FkBlockId { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public string Status { get; set; } = null!;

    public virtual User? CreatedByNavigation { get; set; }

    public virtual Block FkBlock { get; set; } = null!;

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual CustomerAddress? FkCustomerAddress { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }
}
