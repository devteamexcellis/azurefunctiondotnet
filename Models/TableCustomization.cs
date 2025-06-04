using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class TableCustomization
{
    public string TableId { get; set; } = null!;

    public string FkUserId { get; set; } = null!;

    public int FkCustomerId { get; set; }

    public string? Settings { get; set; }

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual User FkUser { get; set; } = null!;
}
