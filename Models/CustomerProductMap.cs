using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerProductMap
{
    public int FkProductId { get; set; }

    public int FkCustomerId { get; set; }

    public string? FkPriceListCode { get; set; }

    public string? Name { get; set; }

    public string? Body { get; set; }

    public string? Description { get; set; }

    public string? Icon { get; set; }

    public string? Status { get; set; }

    public double? Price { get; set; }

    public string? PriceUnit { get; set; }

    public double? Weight { get; set; }

    public string? WeightUnit { get; set; }

    public DateTime? PriceEffectiveDate { get; set; }

    public DateTime? PriceEndDate { get; set; }

    public bool? IsFeatured { get; set; }

    public virtual ICollection<CustomerProductVarianceMap> CustomerProductVarianceMaps { get; set; } = new List<CustomerProductVarianceMap>();

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual Product FkProduct { get; set; } = null!;

    public virtual ICollection<Group> FkGroups { get; set; } = new List<Group>();
}
