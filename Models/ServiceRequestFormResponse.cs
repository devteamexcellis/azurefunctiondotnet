using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ServiceRequestFormResponse
{
    public int Id { get; set; }

    public int? FkResponseId { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public int? FkServiceRequestId { get; set; }

    public int? FkFormsId { get; set; }

    public virtual ServiceRequest? FkServiceRequest { get; set; }
}
