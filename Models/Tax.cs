using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Tax
{
    public int Id { get; set; }

    public int? TaxNumber { get; set; }

    public int? TaxGroup { get; set; }

    public int? TaxLevel { get; set; }

    public string? TaxType { get; set; }

    public string? Gp { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Amount { get; set; }

    public string? TaxCode { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public int FkRegionId { get; set; }

    public string? Type { get; set; }

    public string? Unit { get; set; }

    public string? TaxCategory { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual Region FkRegion { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<TaxHistory> TaxHistories { get; set; } = new List<TaxHistory>();
}
