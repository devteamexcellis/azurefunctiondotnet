using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class UploadHistory
{
    public int Id { get; set; }

    public string Filename { get; set; } = null!;

    public string? Url { get; set; }

    public string UploadedBy { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public string Code { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Guid { get; set; }

    public string? UrlBase { get; set; }

    public string? UrlEntity { get; set; }

    public string? UrlContainer { get; set; }

    public int? TotalRows { get; set; }

    public virtual ICollection<UploadRow> UploadRows { get; set; } = new List<UploadRow>();
}
