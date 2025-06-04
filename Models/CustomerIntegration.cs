using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerIntegration
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Url { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public DateTime? LastRun { get; set; }

    public string? Domain { get; set; }

    public string? ClientSecret { get; set; }

    public string? ClientId { get; set; }

    public string? AccountNumber { get; set; }

    public string? BasicAuthHeaderKey { get; set; }

    public string? BasicAuthHeaderValue { get; set; }

    public string? Module { get; set; }

    public string? Col01 { get; set; }

    public string? Col02 { get; set; }

    public virtual ICollection<CustomerIntegrationDetail> CustomerIntegrationDetails { get; set; } = new List<CustomerIntegrationDetail>();

    public virtual Customer FkCustomer { get; set; } = null!;
}
