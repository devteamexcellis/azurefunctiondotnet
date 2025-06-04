using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class MultiFactorAuthToken
{
    public string Id { get; set; } = null!;

    public string FkUserId { get; set; } = null!;

    public int FkCustomerId { get; set; }

    public DateTime DateCreated { get; set; }

    public string? Code { get; set; }

    public int? CodeRetryCount { get; set; }

    public bool IsMfaEnabled { get; set; }

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual User FkUser { get; set; } = null!;
}
