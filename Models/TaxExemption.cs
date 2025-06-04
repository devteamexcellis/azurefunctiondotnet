using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class TaxExemption
{
    public int Id { get; set; }

    public string ExemptionCode { get; set; } = null!;

    public string? DescriptionEn { get; set; }

    public string? DescriptionFr { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<TaxExemptionEntityMap> TaxExemptionEntityMaps { get; set; } = new List<TaxExemptionEntityMap>();
}
