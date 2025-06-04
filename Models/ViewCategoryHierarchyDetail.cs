using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ViewCategoryHierarchyDetail
{
    public string? CategoryHierarchyId { get; set; }

    public short CategoryLevelId { get; set; }

    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string CategoryLevelName { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
