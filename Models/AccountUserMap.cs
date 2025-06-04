using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class AccountUserMap
{
    public int FkAccountId { get; set; }

    public string FkUserId { get; set; } = null!;

    public int FkCustomerId { get; set; }

    public int? FkRoleId { get; set; }

    public string? LegacyId { get; set; }

    public string? Status { get; set; }

    public string? Spot { get; set; }

    public string? Location { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public virtual Account Account { get; set; } = null!;

    public virtual ICollection<CustomerAddressAccountUserMap> CustomerAddressAccountUserMaps { get; set; } = new List<CustomerAddressAccountUserMap>();

    public virtual CustomerUserMap CustomerUserMap { get; set; } = null!;

    public virtual Role? Role { get; set; }
}
