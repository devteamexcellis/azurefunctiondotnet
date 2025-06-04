using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class EntityEnum
{
    public int Id { get; set; }

    public string? Entity { get; set; }

    public string ColumnName { get; set; } = null!;

    public string DataType { get; set; } = null!;

    public string? Value { get; set; }
}
