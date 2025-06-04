using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ArRecord
{
    public string Id { get; set; } = null!;

    public int FkCustomerId { get; set; }

    public DateTime DateCreatedDtm { get; set; }

    public string DateCreatedString { get; set; } = null!;

    public string TransactionType { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Balance { get; set; }

    public string? ReferenceIdString { get; set; }

    public int? ReferenceIdInt { get; set; }

    public decimal? Amount { get; set; }

    public virtual Customer FkCustomer { get; set; } = null!;
}
