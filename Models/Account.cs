using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Account
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public string? LegacyId { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? ContactNumber { get; set; }

    public string? ContactPerson { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public string CreatedBy { get; set; } = null!;

    public bool IsPublic { get; set; }

    public virtual ICollection<AccountCustomerAddressMap> AccountCustomerAddressMaps { get; set; } = new List<AccountCustomerAddressMap>();

    public virtual ICollection<AccountServiceMap> AccountServiceMaps { get; set; } = new List<AccountServiceMap>();

    public virtual ICollection<AccountUserMap> AccountUserMaps { get; set; } = new List<AccountUserMap>();

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
