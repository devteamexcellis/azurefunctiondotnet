using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Role
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsCore { get; set; }

    public string? TemporaryCode { get; set; }

    public string? RoleType { get; set; }

    public string? PermissionType { get; set; }

    public virtual ICollection<AccountUserMap> AccountUserMaps { get; set; } = new List<AccountUserMap>();

    public virtual ICollection<CustomerUserMap> CustomerUserMaps { get; set; } = new List<CustomerUserMap>();

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual ICollection<RolePermissionMap> RolePermissionMaps { get; set; } = new List<RolePermissionMap>();
}
