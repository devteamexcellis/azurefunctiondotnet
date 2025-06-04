using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Form
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public string FormType { get; set; } = null!;

    public string FormCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual ICollection<FormQuestion> FormQuestions { get; set; } = new List<FormQuestion>();

    public virtual User? ModifiedByNavigation { get; set; }
}
