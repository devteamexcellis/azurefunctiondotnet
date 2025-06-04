using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ViewTagCustomerMapDetail
{
    public string TagId { get; set; } = null!;

    public string TagType { get; set; } = null!;

    public int EntityId { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerLegacyId { get; set; }
}
