using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class UserActivity
{
    public int Id { get; set; }

    public string FkUserId { get; set; } = null!;

    public int? CustomerId { get; set; }

    public string? EntityType { get; set; }

    public string? EntityId { get; set; }

    public string? SubEntityId { get; set; }

    public string? DeviceId { get; set; }

    public string Type { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string Code { get; set; } = null!;

    public DateTime? DateStopped { get; set; }

    public string? LegacyId { get; set; }

    public DateTime? ChargeStartTime { get; set; }

    public string? Location { get; set; }

    public string? EntityLegacyId { get; set; }

    public string? PaymentOption { get; set; }

    public string? PaymentId { get; set; }

    public virtual User FkUser { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
