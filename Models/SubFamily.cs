using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class SubFamily
{
    public string Id { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
