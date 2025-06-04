using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class EquipmentType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Category { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public bool ForTesting { get; set; }

    public bool SerialNumberRequired { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }
}
