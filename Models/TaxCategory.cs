using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class TaxCategory
{
    public int Id { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string? DescriptionEn { get; set; }

    public string? DescriptionFr { get; set; }

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<TaxRate> TaxRates { get; set; } = new List<TaxRate>();
}
