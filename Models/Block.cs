using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Block
{
    public int Id { get; set; }

    public string BlockCode { get; set; } = null!;

    public string? Description { get; set; }

    public string? Message { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual ICollection<BlockCustomerMap> BlockCustomerMaps { get; set; } = new List<BlockCustomerMap>();

    public virtual User? CreatedByNavigation { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }
}
