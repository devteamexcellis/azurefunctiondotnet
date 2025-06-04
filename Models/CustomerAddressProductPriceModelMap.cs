using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerAddressProductPriceModelMap
{
    public int Id { get; set; }

    public int FkProductId { get; set; }

    public int FkCustomerAddressId { get; set; }

    public string PriceModel { get; set; } = null!;

    public string Type { get; set; } = null!;

    public double Value { get; set; }

    public string Variance { get; set; } = null!;

    public string? ContractId { get; set; }

    public DateOnly? ContractStartDate { get; set; }

    public DateOnly? ContractEndDate { get; set; }

    public string? ContractLimitType { get; set; }

    public double? ContractLimitAmount { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public DateTime? NcpDateApplicable { get; set; }

    public int? RpppmmReferenceId { get; set; }

    public int? RppmReferenceId { get; set; }

    public int? RppzcmReferenceId { get; set; }

    public string? PriceSource { get; set; }

    public string? Reason { get; set; }

    public string? Status { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual CustomerAddress FkCustomerAddress { get; set; } = null!;

    public virtual Product FkProduct { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
