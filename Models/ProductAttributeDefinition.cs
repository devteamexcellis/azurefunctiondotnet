using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ProductAttributeDefinition
{
    public int Id { get; set; }

    public string Entity { get; set; } = null!;

    public string? EntityType { get; set; }

    public string ColumnName { get; set; } = null!;

    public string AttributeType { get; set; } = null!;

    public string? AttributeDataType { get; set; }

    public string? AttributeName { get; set; }

    public string? AttributeUnit { get; set; }

    public string? OptionType { get; set; }

    public int? Sequence { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DefaultValue { get; set; }

    public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; } = new List<ProductAttributeValue>();
}
