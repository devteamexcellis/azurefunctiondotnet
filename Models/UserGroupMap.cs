using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class UserGroupMap
{
    public string FkUserId { get; set; } = null!;

    public int FkCustomerId { get; set; }

    public int FkGroupId { get; set; }

    public bool? IsDefault { get; set; }

    public virtual CustomerUserMap CustomerUserMap { get; set; } = null!;

    public virtual Group FkGroup { get; set; } = null!;
}
