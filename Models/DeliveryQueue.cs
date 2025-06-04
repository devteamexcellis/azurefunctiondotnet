using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class DeliveryQueue
{
    public int Id { get; set; }

    public int FkCustomerAddressId { get; set; }

    public int FkRecurrenceId { get; set; }

    public string? CreditHoldStatus { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual CustomerAddress FkCustomerAddress { get; set; } = null!;

    public virtual Recurrence FkRecurrence { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
