using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Zone
{
    public int Id { get; set; }

    public int FkRegionId { get; set; }

    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public string? Area { get; set; }

    public string? Status { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }
}
