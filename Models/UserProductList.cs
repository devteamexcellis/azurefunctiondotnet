using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class UserProductList
{
    public int FkUserListId { get; set; }

    public int FkProductId { get; set; }

    public int Quantity { get; set; }

    public virtual Product FkProduct { get; set; } = null!;

    public virtual UserList FkUserList { get; set; } = null!;
}
