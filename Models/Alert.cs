using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Alert
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public string Name { get; set; } = null!;

    public string Status { get; set; } = null!;

    public bool IsCore { get; set; }

    public string Description { get; set; } = null!;

    public string NotificationTitle { get; set; } = null!;

    public string NotificationBody { get; set; } = null!;

    public int ProductId { get; set; }

    public string Code { get; set; } = null!;

    public virtual Customer FkCustomer { get; set; } = null!;
}
