using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerProductVarianceMap
{
    public string FkVarianceId { get; set; } = null!;

    public int FkProductId { get; set; }

    public int FkCustomerId { get; set; }

    public double? Price { get; set; }

    public string? FromDate { get; set; }

    public string? ToDate { get; set; }

    public bool IsActive { get; set; }

    public int? Moq { get; set; }

    public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();

    public virtual CustomerProductMap CustomerProductMap { get; set; } = null!;

    public virtual ProductVariance ProductVariance { get; set; } = null!;

    public virtual ICollection<RecurrenceDetail> RecurrenceDetails { get; set; } = new List<RecurrenceDetail>();
}
