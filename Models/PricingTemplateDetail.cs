using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class PricingTemplateDetail
{
    public int Id { get; set; }

    public int FkPricingTemplateId { get; set; }

    public string PricingTypeCode { get; set; } = null!;

    public string PricingTypeName { get; set; } = null!;

    public string? Desctription { get; set; }

    public virtual PricingTemplate FkPricingTemplate { get; set; } = null!;
}
