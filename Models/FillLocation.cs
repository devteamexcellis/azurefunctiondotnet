using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class FillLocation
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<CustomerAddressAttribute> CustomerAddressAttributes { get; set; } = new List<CustomerAddressAttribute>();
}
