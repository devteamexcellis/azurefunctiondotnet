using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CartDetail
{
    public string FkUserId { get; set; } = null!;

    public int FkCustomerId { get; set; }

    public int FkProductId { get; set; }

    public string VarianceId { get; set; } = null!;

    public double Quantity { get; set; }

    public DateTime Timestamp { get; set; }

    public virtual Cart Cart { get; set; } = null!;

    public virtual ICollection<CartDetailsAddOn> CartDetailsAddOns { get; set; } = new List<CartDetailsAddOn>();

    public virtual CustomerProductVarianceMap CustomerProductVarianceMap { get; set; } = null!;
}
