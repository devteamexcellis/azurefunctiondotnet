using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerTemp
{
    public string? LegacyId { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public string? Tel { get; set; }

    public DateTime? Timestamp { get; set; }

    public DateTime? DateModified { get; set; }

    public string? Classification { get; set; }

    public int? Rank { get; set; }

    public string? PoNumber { get; set; }

    public decimal? PreviousBalance { get; set; }

    public string? Language { get; set; }

    public string? Pricezone { get; set; }

    public string? PriceClass { get; set; }

    public string? StatementType { get; set; }

    public decimal? CreditLimit { get; set; }

    public string? AccountType { get; set; }

    public string? Region { get; set; }

    public string? CreditCode { get; set; }

    public string? Gn { get; set; }

    public string? TaxCategory { get; set; }

    public string? IsPriced { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public string? SalesRepId { get; set; }

    public string? CollectorId { get; set; }
}
