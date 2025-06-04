using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class SetupEnumeration
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Type { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public string? Code { get; set; }

    public virtual User? CreatedByNavigation { get; set; }
}
