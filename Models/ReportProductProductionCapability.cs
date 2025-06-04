using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ReportProductProductionCapability
{
    public int Id { get; set; }

    public string ProductCode { get; set; } = null!;

    public int ProductId { get; set; }

    public string ProductType { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public int? TotalInventoryCount { get; set; }

    public int? TotalProductionRunCapability { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? DateCreated { get; set; }
}
