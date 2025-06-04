using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class EquipmentServiceRequestMap
{
    public int Id { get; set; }

    public int FkServiceRequestId { get; set; }

    public int? FkEquipmentId { get; set; }

    public int? FkCustomerAddressAttributesId { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual CustomerAddress? FkCustomerAddressAttributes { get; set; }

    public virtual Equipment? FkEquipment { get; set; }

    public virtual ServiceRequest FkServiceRequest { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
