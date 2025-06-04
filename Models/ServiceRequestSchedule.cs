using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ServiceRequestSchedule
{
    public int Id { get; set; }

    public int FkServiceRequestId { get; set; }

    public string ReferenceUserId { get; set; } = null!;

    public DateTime Schedule { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public TimeOnly? ArrivalTime { get; set; }

    public TimeOnly? DepartureTime { get; set; }

    public TimeOnly? TimeElapsed { get; set; }

    public virtual ServiceRequest FkServiceRequest { get; set; } = null!;
}
