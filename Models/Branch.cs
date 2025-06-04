using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Branch
{
    public int Id { get; set; }

    public int FkRegionId { get; set; }

    public string Name { get; set; } = null!;

    public string BranchCode { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public string? WeatherStation { get; set; }

    public virtual ICollection<BranchProductTemplateMap> BranchProductTemplateMaps { get; set; } = new List<BranchProductTemplateMap>();

    public virtual ICollection<BranchUserMap> BranchUserMaps { get; set; } = new List<BranchUserMap>();

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual Region FkRegion { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
