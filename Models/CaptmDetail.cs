using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CaptmDetail
{
    public int Id { get; set; }

    public int FkCaptmId { get; set; }

    public string PricingTypeName { get; set; } = null!;

    public string PricingTypeCode { get; set; } = null!;

    public double Value { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual CustomerAddressProductTemplateMap FkCaptm { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
