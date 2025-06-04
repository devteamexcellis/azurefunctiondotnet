using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ProductVariance
{
    public string Id { get; set; } = null!;

    public int FkProductId { get; set; }

    public int? Moq { get; set; }

    public bool IsActive { get; set; }

    public double? Price { get; set; }

    public bool? IsBasePrice { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<CartDetailsAddOn> CartDetailsAddOns { get; set; } = new List<CartDetailsAddOn>();

    public virtual ICollection<CustomerProductVarianceMap> CustomerProductVarianceMaps { get; set; } = new List<CustomerProductVarianceMap>();

    public virtual Product FkProduct { get; set; } = null!;

    public virtual ICollection<OrderDetailsAddOn> OrderDetailsAddOns { get; set; } = new List<OrderDetailsAddOn>();
}
