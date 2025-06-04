using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class TransactionDetail
{
    public int Id { get; set; }

    public int FkTransactionId { get; set; }

    public int? FkServiceId { get; set; }

    public string PriceName { get; set; } = null!;

    public double PriceAmount { get; set; }

    public double TotalCost { get; set; }

    public DateTime DateCreated { get; set; }

    public double? Quantity { get; set; }

    public virtual Service? FkService { get; set; }

    public virtual Transaction FkTransaction { get; set; } = null!;
}
