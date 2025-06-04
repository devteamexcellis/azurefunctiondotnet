using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ContentAsset
{
    public int Id { get; set; }

    public string? ContentType { get; set; }

    public string? HtmlContentUrl { get; set; }

    public string? Title { get; set; }

    public string? Filename { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public string? DataType { get; set; }
}
