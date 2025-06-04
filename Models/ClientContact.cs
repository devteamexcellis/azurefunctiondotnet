using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ClientContact
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string Type { get; set; } = null!;
}
