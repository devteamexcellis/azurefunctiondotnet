using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class RemittanceAddressRegionInventoryLocationMap
{
    public int Id { get; set; }

    public int? FkRemittanceAddressId { get; set; }

    public int? FkRegionId { get; set; }

    public int? FkInventoryLocationId { get; set; }

    public string? Status { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual InventoryLocation? FkInventoryLocation { get; set; }

    public virtual Region? FkRegion { get; set; }

    public virtual RemittanceAddress? FkRemittanceAddress { get; set; }
}
