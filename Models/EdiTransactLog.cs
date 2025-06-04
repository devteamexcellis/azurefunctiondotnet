using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class EdiTransactLog
{
    public int Id { get; set; }

    public string? OrderId { get; set; }

    public string? TransactType { get; set; }

    public DateTime? Timestamp { get; set; }

    public string? EdiData { get; set; }

    public bool? IsParsingSuccess { get; set; }
}
