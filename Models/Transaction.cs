using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Transaction
{
    public int Id { get; set; }

    public string TransactionCode { get; set; } = null!;

    public int? FkUserActivityId { get; set; }

    public int? FkCustomerId { get; set; }

    public int? FkAccountId { get; set; }

    public string FkUserId { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public string Status { get; set; } = null!;

    public string? LegacyId { get; set; }

    public string? AccountUserLegacyId { get; set; }

    public string BillAddrCountry { get; set; } = null!;

    public string BillAddrZipcode { get; set; } = null!;

    public string BillAddrState { get; set; } = null!;

    public string BillAddrCity { get; set; } = null!;

    public string BillAddrStreet { get; set; } = null!;

    public string TranAddrCountry { get; set; } = null!;

    public string TranAddrZipcode { get; set; } = null!;

    public string TranAddrState { get; set; } = null!;

    public string TranAddrCity { get; set; } = null!;

    public string TranAddrStreet { get; set; } = null!;

    public int? PaymentBalance { get; set; }

    public double? ServiceFee { get; set; }

    public virtual Account? FkAccount { get; set; }

    public virtual Customer? FkCustomer { get; set; }

    public virtual User FkUser { get; set; } = null!;

    public virtual UserActivity? FkUserActivity { get; set; }

    public virtual ICollection<TransactionDetail> TransactionDetails { get; set; } = new List<TransactionDetail>();
}
