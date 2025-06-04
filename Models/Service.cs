using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Service
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string ServiceCode { get; set; } = null!;

    public string? LegacyId { get; set; }

    public string Type { get; set; } = null!;

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public byte[]? State { get; set; }

    public string? Zipcode { get; set; }

    public string? Country { get; set; }

    public string? ActualChargerStatus { get; set; }

    public DateTime? LastHeartbeat { get; set; }

    public virtual ICollection<ServiceAsset> ServiceAssets { get; set; } = new List<ServiceAsset>();

    public virtual ICollection<ServicePrice> ServicePrices { get; set; } = new List<ServicePrice>();

    public virtual ICollection<TransactionDetail> TransactionDetails { get; set; } = new List<TransactionDetail>();
}
