using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class UserToken
{
    public string FkUserId { get; set; } = null!;

    public string Token { get; set; } = null!;

    public int FkCustomerId { get; set; }

    public bool IsLoggedIn { get; set; }

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual User FkUser { get; set; } = null!;
}
