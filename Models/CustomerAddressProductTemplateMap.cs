using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerAddressProductTemplateMap
{
    public int Id { get; set; }

    public int FkCustomerAddresId { get; set; }

    public int FkProductId { get; set; }

    public int? FkPricingTemplateId { get; set; }

    public string? ContractId { get; set; }

    public string? ContractType { get; set; }

    public double? ContractVolume { get; set; }

    public DateOnly? EndDate { get; set; }

    public DateOnly? StartDate { get; set; }

    public double? LimitCost { get; set; }

    public double? TotalCurrentCost { get; set; }

    public double? LimitVolume { get; set; }

    public double? TotalCurrentVolume { get; set; }

    public double LandingCost { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public string PriceName { get; set; } = null!;

    public string PriceModel { get; set; } = null!;

    public string PriceType { get; set; } = null!;

    public string? Status { get; set; }

    public virtual ICollection<CaptmDetail> CaptmDetails { get; set; } = new List<CaptmDetail>();

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual CustomerAddress FkCustomerAddres { get; set; } = null!;

    public virtual PricingTemplate? FkPricingTemplate { get; set; }

    public virtual Product FkProduct { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
