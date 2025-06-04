using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerUserRolePermissionMap
{
    public int FkCustomerId { get; set; }

    public string FkUserId { get; set; } = null!;

    public int FkRoleId { get; set; }

    public string FkPermissionId { get; set; } = null!;

    public virtual CustomerUserMap CustomerUserMap { get; set; } = null!;

    public virtual RolePermissionMap RolePermissionMap { get; set; } = null!;
}
