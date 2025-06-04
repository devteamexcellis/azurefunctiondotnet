using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class PromotionTargetMap
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public int FkPromotionCouponId { get; set; }

    public string? TagType { get; set; }

    public int? MinTagCount { get; set; }

    public bool? RequireAllEntitiesPerTag { get; set; }

    public int? MinEntityCountPerTag { get; set; }

    public virtual PromotionCoupon FkPromotionCoupon { get; set; } = null!;

    public virtual ICollection<Customer> FkCustomers { get; set; } = new List<Customer>();

    public virtual ICollection<Product> FkProducts { get; set; } = new List<Product>();

    public virtual ICollection<Tag> FkTags { get; set; } = new List<Tag>();

    public virtual ICollection<User> FkUsers { get; set; } = new List<User>();
}
