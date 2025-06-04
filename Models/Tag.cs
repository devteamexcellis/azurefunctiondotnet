using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Tag
{
    public string Id { get; set; } = null!;

    public virtual ICollection<TagEntityMap> TagEntityMaps { get; set; } = new List<TagEntityMap>();

    public virtual ICollection<PromotionTargetMap> FkPromotionTargetMaps { get; set; } = new List<PromotionTargetMap>();
}
