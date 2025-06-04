using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Hold
{
    public int Id { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public string? Deactivation { get; set; }

    public bool? PrintTicketFlag { get; set; }

    public bool? CreateOrderFlag { get; set; }

    public bool? GovtRegulationsFlag { get; set; }

    public string? Type { get; set; }
}
