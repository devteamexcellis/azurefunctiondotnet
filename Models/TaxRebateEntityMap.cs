using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class TaxRebateEntityMap
{
    public int Id { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string Module { get; set; } = null!;

    public int? FkCustomerId { get; set; }

    public int? FkCustomerAddressId { get; set; }

    public string? TaxClass { get; set; }

    public string? TaxRebateCode { get; set; }

    public double RebateRate { get; set; }

    public int? FkProductId { get; set; }

    public string? RebateType { get; set; }

    public DateOnly? LegacyExpiryDate { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Customer? FkCustomer { get; set; }

    public virtual CustomerAddress? FkCustomerAddress { get; set; }

    public virtual Product? FkProduct { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual TaxClass? TaxClassNavigation { get; set; }
}
