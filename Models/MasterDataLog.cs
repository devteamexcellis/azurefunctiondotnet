using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class MasterDataLog
{
    public int MasterDataLogId { get; set; }

    public DateTime Date { get; set; }

    public string FileName { get; set; } = null!;

    public int ExcelRowCount { get; set; }

    public int InsertCount { get; set; }

    public int UpdateCount { get; set; }

    public int DeleteCount { get; set; }

    public int ErrorCount { get; set; }

    public int NoChangeCount { get; set; }
}
