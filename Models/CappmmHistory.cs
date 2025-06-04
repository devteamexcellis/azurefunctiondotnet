using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CappmmHistory
{
    public int Id { get; set; }

    public int ReferenceCappmmId { get; set; }

    public string? PriceModel { get; set; }

    public string? Type { get; set; }

    public double? Value { get; set; }

    public string? Variance { get; set; }

    public string? ContractId { get; set; }

    public DateOnly? ContractStartDate { get; set; }

    public DateOnly? ContractEndDate { get; set; }

    public string? ContractLimitType { get; set; }

    public double? ContractLimitAmount { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? Reason { get; set; }

    public DateOnly? DateApplicable { get; set; }

    public string? Action { get; set; }

    public string? PriceSource { get; set; }

    public DateTime? NcpDateApplicable { get; set; }

    public int? RpppmmReferenceId { get; set; }

    public int? RppmReferenceId { get; set; }

    public int? RppzcmReferenceId { get; set; }

    public string? Status { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;
}
