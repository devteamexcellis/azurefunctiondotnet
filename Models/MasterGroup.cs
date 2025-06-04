using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class MasterGroup
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? TemporaryCode { get; set; }

    public bool IsCore { get; set; }
}
