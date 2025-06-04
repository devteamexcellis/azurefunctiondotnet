using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class LotLog
{
    public int Id { get; set; }

    public int FkLotId { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string LotLogNotes { get; set; } = null!;

    public string Module { get; set; } = null!;

    public int? FkProductId { get; set; }

    public string? LotNumber { get; set; }

    public int? LotSize { get; set; }

    public string? Status { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Lot FkLot { get; set; } = null!;

    public virtual Product? FkProduct { get; set; }
}
