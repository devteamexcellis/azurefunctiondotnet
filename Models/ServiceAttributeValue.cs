using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ServiceAttributeValue
{
    public string FkColumnName { get; set; } = null!;

    public int Sequence { get; set; }

    public string? Value { get; set; }

    public virtual ServiceAttributeDefinition FkColumnNameNavigation { get; set; } = null!;
}
