using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class SetupEnumerationsCustomerMap
{
    public int Id { get; set; }

    public int SetupEnumerationsId { get; set; }

    public int CustomerId { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public virtual User? CreatedByNavigation { get; set; }
}
