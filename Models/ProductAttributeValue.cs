using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ProductAttributeValue
{
    public int Id { get; set; }

    public int FkProductAttributeDefinitionId { get; set; }

    public int Sequence { get; set; }

    public string? Value { get; set; }

    public virtual ProductAttributeDefinition FkProductAttributeDefinition { get; set; } = null!;
}
