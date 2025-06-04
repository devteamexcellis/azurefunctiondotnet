using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerNotesTemp
{
    public DateOnly? Date { get; set; }

    public string? CreatedBy { get; set; }

    public string? Module { get; set; }

    public string? CustomerId { get; set; }

    public string? OrderId { get; set; }

    public string? Notes { get; set; }
}
