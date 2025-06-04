using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerUserMap
{
    public int FkCustomerId { get; set; }

    public string FkUserId { get; set; } = null!;

    public int FkRoleId { get; set; }

    public bool IsDefault { get; set; }

    public bool IsSelected { get; set; }

    public bool? IsReadOnly { get; set; }

    public string? LegacyId { get; set; }

    public string? Status { get; set; }

    public string? LegacyId2 { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public string? Column1 { get; set; }

    public string? Column2 { get; set; }

    public virtual ICollection<AccountUserMap> AccountUserMaps { get; set; } = new List<AccountUserMap>();

    public virtual ICollection<CustomerUserRolePermissionMap> CustomerUserRolePermissionMaps { get; set; } = new List<CustomerUserRolePermissionMap>();

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual Role FkRole { get; set; } = null!;

    public virtual User FkUser { get; set; } = null!;

    public virtual ICollection<UserGroupMap> UserGroupMaps { get; set; } = new List<UserGroupMap>();
}
