using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrderCharge
{
    public int Id { get; set; }

    public string FkOrderId { get; set; } = null!;

    public int? FkProductId { get; set; }

    public string? FkVarianceId { get; set; }

    public string Type { get; set; } = null!;

    public double Amount { get; set; }

    public string? Description { get; set; }

    public string? PromotionCode { get; set; }

    public int? CouponId { get; set; }

    public double? ConfirmedAmount { get; set; }

    public string? Classification { get; set; }

    public string? ChargeCode { get; set; }

    public double? ChargeRate { get; set; }

    public double? ChargeExemption { get; set; }

    public string? ChargeValue1 { get; set; }

    public int? ChargeSequence { get; set; }

    public string? DescriptionAwe { get; set; }

    public double? ChargeRateFull { get; set; }

    public virtual Order FkOrder { get; set; } = null!;
}
