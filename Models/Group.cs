using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Group
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsCore { get; set; }

    public string? TemporaryCode { get; set; }

    public DateTime? DateCreated { get; set; }

    public virtual ICollection<CustomerAddressGroupMap> CustomerAddressGroupMaps { get; set; } = new List<CustomerAddressGroupMap>();

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual ICollection<Recurrence> Recurrences { get; set; } = new List<Recurrence>();

    public virtual ICollection<UserGroupMap> UserGroupMaps { get; set; } = new List<UserGroupMap>();

    public virtual ICollection<CustomerProductMap> CustomerProductMaps { get; set; } = new List<CustomerProductMap>();
}
