using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class UploadRow
{
    public int Id { get; set; }

    public bool IsSuccessful { get; set; }

    public string? UploadAction { get; set; }

    public string? Message { get; set; }

    public int FkUploadHistoryId { get; set; }

    public virtual UploadHistory FkUploadHistory { get; set; } = null!;
}
