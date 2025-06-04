using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class TaxRate
{
    public int Id { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public int FkProductId { get; set; }

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public string TaxCategory { get; set; } = null!;

    public string? TaxClass { get; set; }

    public string RateType { get; set; } = null!;

    public double RateCurrent { get; set; }

    public double? RatePrevious { get; set; }

    public int TaxLevel { get; set; }

    public string? StateShortForm { get; set; }

    public string? StateLongForm { get; set; }

    public string? ApplicabilityBits { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Product FkProduct { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual TaxCategory TaxCategoryNavigation { get; set; } = null!;

    public virtual TaxClass? TaxClassNavigation { get; set; }
}
