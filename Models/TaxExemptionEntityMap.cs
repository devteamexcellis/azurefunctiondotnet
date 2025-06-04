using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class TaxExemptionEntityMap
{
    public int Id { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public string Module { get; set; } = null!;

    public int? FkCustomerId { get; set; }

    public int? FkCustomerAddressId { get; set; }

    public string TaxClass { get; set; } = null!;

    public string? TaxExemptionCode { get; set; }

    public double ExemptionRate { get; set; }

    public int? FkProductId { get; set; }

    public string? License { get; set; }

    public DateOnly? LegacyExpiryDate { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual CustomerAddress? FkCustomerAddress { get; set; }

    public virtual Product? FkProduct { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual TaxClass TaxClassNavigation { get; set; } = null!;

    public virtual TaxExemption? TaxExemptionCodeNavigation { get; set; }
}
