using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Vehicle
{
    public string Id { get; set; } = null!;

    public string? CustomerLegacyId { get; set; }

    public string? Barcode1 { get; set; }

    public string? Barcode2 { get; set; }

    public string? PlateNumber { get; set; }

    public string Description { get; set; } = null!;

    public string ProductCode { get; set; } = null!;

    public decimal? TankSize { get; set; }

    public string? UsageCode { get; set; }

    public DateTime? LastFuelDtm { get; set; }

    public decimal? Odometer { get; set; }

    public string? Xref { get; set; }

    public string? Status { get; set; }

    public DateTime? StatusLastModified { get; set; }

    public int? LastUnfueledReason { get; set; }

    public string? LastUnfueledDescription { get; set; }

    public DateTime? LastUnfueledDtm { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }
}
