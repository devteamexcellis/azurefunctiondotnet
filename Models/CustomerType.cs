using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CustomerType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Comment { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? Code { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<Customer> FkCustomers { get; set; } = new List<Customer>();
}
