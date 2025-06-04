using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerIntegrationDetail
{
    public int Id { get; set; }

    public int FkCustomerIntegrationId { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool? IsB2b { get; set; }

    public bool? IsAdminPortal { get; set; }

    public int? Sequence { get; set; }

    public string? Module { get; set; }

    public string? Value2 { get; set; }

    public double? Value3 { get; set; }

    public string? Value4 { get; set; }

    public string? Action { get; set; }

    public bool? IsDefault { get; set; }

    public string? Link { get; set; }

    public string? Link2 { get; set; }

    public virtual CustomerIntegration FkCustomerIntegration { get; set; } = null!;
}
