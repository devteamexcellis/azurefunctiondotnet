using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Upload
{
    public int Id { get; set; }

    public int? FkCustomerId { get; set; }

    public string? UploadedBy { get; set; }

    public string Filename { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public string UploadType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public int? TotalRows { get; set; }
}
