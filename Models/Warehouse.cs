using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Warehouse
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;
}
