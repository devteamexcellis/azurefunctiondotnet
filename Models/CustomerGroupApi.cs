using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerGroupApi
{
    public int Id { get; set; }

    public int FkCustomerGroupId { get; set; }

    public string? Type { get; set; }

    public string? Name { get; set; }

    public string? Domain { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? ClientSecret { get; set; }

    public string? ClientId { get; set; }

    public DateTime? LastRun { get; set; }

    public string? Scope { get; set; }

    public string? Column01 { get; set; }

    public virtual CustomerGroup FkCustomerGroup { get; set; } = null!;
}
