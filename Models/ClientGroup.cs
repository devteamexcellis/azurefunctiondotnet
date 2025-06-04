using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ClientGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Customer> FkCustomers { get; set; } = new List<Customer>();

    public virtual ICollection<Product> FkProducts { get; set; } = new List<Product>();
}
