using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class PricingTemplate
{
    public int Id { get; set; }

    public string TemplateType { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string PriceModel { get; set; } = null!;

    public virtual ICollection<BranchProductTemplateMap> BranchProductTemplateMaps { get; set; } = new List<BranchProductTemplateMap>();

    public virtual ICollection<CustomerAddressProductTemplateMap> CustomerAddressProductTemplateMaps { get; set; } = new List<CustomerAddressProductTemplateMap>();

    public virtual ICollection<PricingTemplateDetail> PricingTemplateDetails { get; set; } = new List<PricingTemplateDetail>();
}
