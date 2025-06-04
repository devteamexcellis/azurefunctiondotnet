using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class DumpCustomerTableDetail
{
    public int Id { get; set; }

    public int FkDumpCustomerTableId { get; set; }

    public int? DocType { get; set; }

    public int? MediaType { get; set; }

    public string? Params { get; set; }

    public virtual DumpCustomerTable FkDumpCustomerTable { get; set; } = null!;
}
