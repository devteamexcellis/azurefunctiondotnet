using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Subscription
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsPostgrid { get; set; }

    public bool IsSendgrid { get; set; }

    public bool? IsSidetrade { get; set; }

    public string? SubscriptionCode { get; set; }

    public virtual ICollection<CustomerSubscriptionMap> CustomerSubscriptionMaps { get; set; } = new List<CustomerSubscriptionMap>();

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<StatementSubscriptionMap> StatementSubscriptionMaps { get; set; } = new List<StatementSubscriptionMap>();
}
