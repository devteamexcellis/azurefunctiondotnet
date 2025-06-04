using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class TaxRebate
{
    public int Id { get; set; }

    public string RebateCode { get; set; } = null!;

    public string? DescriptionEn { get; set; }

    public string? DescriptionFr { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string? DescriptionAwe { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
