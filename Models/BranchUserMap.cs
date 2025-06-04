using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class BranchUserMap
{
    public int FkBranchId { get; set; }

    public string FkUserId { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public virtual Branch FkBranch { get; set; } = null!;

    public virtual User FkUser { get; set; } = null!;
}
