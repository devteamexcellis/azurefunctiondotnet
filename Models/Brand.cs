using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Brand
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Statement> Statements { get; set; } = new List<Statement>();
}
