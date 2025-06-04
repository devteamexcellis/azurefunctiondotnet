using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class ExceptionCodeReference
{
    public int Id { get; set; }

    public int ExceptionCode { get; set; }

    public string ExceptionDescription { get; set; } = null!;

    public virtual ICollection<OrderException> OrderExceptions { get; set; } = new List<OrderException>();
}
