using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CueProduct
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
