using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class MasterRole
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? TemporaryCode { get; set; }

    public bool? IsCore { get; set; }

    public string? RoleType { get; set; }

    public string? PermissionType { get; set; }

    public virtual ICollection<Permission> FkPermissions { get; set; } = new List<Permission>();
}
