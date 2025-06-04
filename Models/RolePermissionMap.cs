using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class RolePermissionMap
{
    public int FkRoleId { get; set; }

    public string FkPermissionId { get; set; } = null!;

    public virtual ICollection<CustomerUserRolePermissionMap> CustomerUserRolePermissionMaps { get; set; } = new List<CustomerUserRolePermissionMap>();

    public virtual Permission FkPermission { get; set; } = null!;

    public virtual Role FkRole { get; set; } = null!;
}
