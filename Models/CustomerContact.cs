using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerContact
{
    public int Id { get; set; }

    public bool IsPrimary { get; set; }

    public int FkCustomerId { get; set; }

    public string Firstname { get; set; } = null!;

    public string? Middlename { get; set; }

    public string Lastname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string ContactNumber { get; set; } = null!;

    public string? AlternateNumber { get; set; }

    public virtual Customer FkCustomer { get; set; } = null!;
}
