using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Log
{
    public int Id { get; set; }

    public string FkUserId { get; set; } = null!;

    public int? FkCustomerId { get; set; }

    public DateTime Timestamp { get; set; }

    public string Title { get; set; } = null!;

    public string Body { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Module { get; set; } = null!;

    public string? ModuleId { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public virtual Customer? FkCustomer { get; set; }

    public virtual User FkUser { get; set; } = null!;

    public virtual ICollection<LogAudience> LogAudiences { get; set; } = new List<LogAudience>();

    public virtual ICollection<LogGroupAudience> LogGroupAudiences { get; set; } = new List<LogGroupAudience>();

    public virtual ICollection<LogRoleAudience> LogRoleAudiences { get; set; } = new List<LogRoleAudience>();

    public virtual ICollection<LogUserAudience> LogUserAudiences { get; set; } = new List<LogUserAudience>();

    public virtual ICollection<UserLogMap> UserLogMaps { get; set; } = new List<UserLogMap>();
}
