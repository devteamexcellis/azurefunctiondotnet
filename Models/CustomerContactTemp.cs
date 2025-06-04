using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerContactTemp
{
    public string? Account { get; set; }

    public string? ContactId { get; set; }

    public bool? IsPrimary { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? EMail { get; set; }

    public string? Phone { get; set; }
}
