using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Promotion
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Status { get; set; } = null!;

    public int? RedemptionLimit { get; set; }

    public string? Type { get; set; }

    public string? Code { get; set; }

    public bool IsProcessOrder { get; set; }

    public bool IsProcessExpressBuy { get; set; }

    public bool IsProcessRecurring { get; set; }

    public bool IsCouponBased { get; set; }

    public virtual ICollection<PromotionCoupon> PromotionCoupons { get; set; } = new List<PromotionCoupon>();
}
