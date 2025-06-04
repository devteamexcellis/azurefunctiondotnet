using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Permission
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool? IsClient { get; set; }

    public string? ClientName { get; set; }

    public string? ClientDescription { get; set; }

    public bool? IsCustomer { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerDescription { get; set; }

    public string? Module { get; set; }

    public string? SubModule { get; set; }

    public int? FkCueProductId { get; set; }

    public bool? WillAddB2bLogin { get; set; }

    public bool? WillAddAdminLogin { get; set; }

    public virtual CueProduct? FkCueProduct { get; set; }

    public virtual ICollection<RolePermissionMap> RolePermissionMaps { get; set; } = new List<RolePermissionMap>();

    public virtual ICollection<MasterRole> FkMasterRoles { get; set; } = new List<MasterRole>();
}
