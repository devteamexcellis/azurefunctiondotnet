using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? City { get; set; }

    public string? Street { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }

    public string? CountryCodeDigit { get; set; }

    public string? CountryCodeAlpha { get; set; }

    public string? ContactName { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactNumber { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<CustomerGroupApi> CustomerGroupApis { get; set; } = new List<CustomerGroupApi>();

    public virtual ICollection<Customer> FkCustomers { get; set; } = new List<Customer>();

    public virtual ICollection<User> FkUsers { get; set; } = new List<User>();
}
