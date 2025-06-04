using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrderCode
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? TransactionType { get; set; }

    public string DescriptionEng { get; set; } = null!;

    public string? DescriptionFrn { get; set; }

    public bool? IsRequired { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();
}
