using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class PromotionCoupon
{
    public int Id { get; set; }

    public int FkPromotionId { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int? CouponRedemptionLimit { get; set; }

    public string? Scope { get; set; }

    public int? CustomerRedemptionLimit { get; set; }

    public double? DiscountValue { get; set; }

    public string? DiscountUnit { get; set; }

    public string? DiscountLevel { get; set; }

    public bool? IsStackable { get; set; }

    public virtual Promotion FkPromotion { get; set; } = null!;

    public virtual ICollection<PromotionTargetMap> PromotionTargetMaps { get; set; } = new List<PromotionTargetMap>();

    public virtual ICollection<Order> FkOrders { get; set; } = new List<Order>();
}
