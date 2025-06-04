using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Batch
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Module { get; set; } = null!;

    public virtual ICollection<Statement> Statements { get; set; } = new List<Statement>();
}
