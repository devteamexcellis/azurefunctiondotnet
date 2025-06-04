using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ListSharingDetail
{
    public int FkUserListId { get; set; }

    public string FkUserId { get; set; } = null!;

    public int? NewItemCount { get; set; }

    public virtual User FkUser { get; set; } = null!;

    public virtual UserList FkUserList { get; set; } = null!;
}
