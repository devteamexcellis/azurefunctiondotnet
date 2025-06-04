using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class TaxHistory
{
    public int Id { get; set; }

    public int FkTaxId { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string Module { get; set; } = null!;

    public int? TaxNumber { get; set; }

    public int? TaxGroup { get; set; }

    public int? TaxLevel { get; set; }

    public string? TaxType { get; set; }

    public string? TaxCode { get; set; }

    public string? Gp { get; set; }

    public double? Rate { get; set; }

    public double? Amount { get; set; }

    public string? Unit { get; set; }

    public string? TaxCategory { get; set; }

    public string? Description { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Tax FkTax { get; set; } = null!;
}
