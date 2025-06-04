using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrderLineItemDetail
{
    public int Id { get; set; }

    public int FkOrderLineItemId { get; set; }

    public string PricingTypeName { get; set; } = null!;

    public string PricingTypeCode { get; set; } = null!;

    public double Value { get; set; }

    public virtual OrderLineItem FkOrderLineItem { get; set; } = null!;
}
