using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class BranchProductTemplateMap
{
    public int Id { get; set; }

    public int FkBranchId { get; set; }

    public int FkProductId { get; set; }

    public int? FkPricingTemplateId { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string PriceModel { get; set; } = null!;

    public string PriceType { get; set; } = null!;

    public string PriceName { get; set; } = null!;

    public double LandingCost { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<BptmDetail> BptmDetails { get; set; } = new List<BptmDetail>();

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Branch FkBranch { get; set; } = null!;

    public virtual PricingTemplate? FkPricingTemplate { get; set; }

    public virtual Product FkProduct { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
