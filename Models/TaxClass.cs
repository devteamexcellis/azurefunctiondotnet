using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class TaxClass
{
    public int Id { get; set; }

    public string Class { get; set; } = null!;

    public string? DescriptionEn { get; set; }

    public string? DescriptionFr { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public string? DescriptionAwe { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<TaxExemptionEntityMap> TaxExemptionEntityMaps { get; set; } = new List<TaxExemptionEntityMap>();

    public virtual ICollection<TaxRate> TaxRates { get; set; } = new List<TaxRate>();

    public virtual ICollection<TaxRebateEntityMap> TaxRebateEntityMaps { get; set; } = new List<TaxRebateEntityMap>();
}
