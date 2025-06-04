using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Cart
{
    public string FkUserId { get; set; } = null!;

    public int FkCustomerId { get; set; }

    public DateTime? DateModified { get; set; }

    public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual User FkUser { get; set; } = null!;
}
