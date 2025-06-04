using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class UserList
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public string FkUserId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public DateTime? DateModified { get; set; }

    public int? NewItemCount { get; set; }

    public string? ModifiedBy { get; set; }

    public string CreatedBy { get; set; } = null!;

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual User FkUser { get; set; } = null!;

    public virtual ICollection<ListSharingDetail> ListSharingDetails { get; set; } = new List<ListSharingDetail>();

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<UserProductList> UserProductLists { get; set; } = new List<UserProductList>();
}
