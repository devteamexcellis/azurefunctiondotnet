using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class UserSetting
{
    public string FkUserId { get; set; } = null!;

    public bool EmailNotification { get; set; }

    public bool SmsNotification { get; set; }

    public bool MfaEmail { get; set; }

    public bool MfaSms { get; set; }

    public virtual User FkUser { get; set; } = null!;
}
