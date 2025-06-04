using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerAddressProductPriceModelMapTemp
{
    public int? FkProductId { get; set; }

    public int? FkCustomerAddressId { get; set; }

    public string? PriceModel { get; set; }

    public string? Type { get; set; }

    public double? Value { get; set; }

    public string? Variance { get; set; }

    public DateOnly? ContractStartDate { get; set; }

    public DateOnly? ContractEndDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string? Status { get; set; }
}
