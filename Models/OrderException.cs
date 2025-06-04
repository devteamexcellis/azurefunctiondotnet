using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrderException
{
    public int Id { get; set; }

    public string FkOrderId { get; set; } = null!;

    public int FkExceptionCodeReferenceId { get; set; }

    public string? Remarks { get; set; }

    public virtual ExceptionCodeReference FkExceptionCodeReference { get; set; } = null!;

    public virtual Order FkOrder { get; set; } = null!;
}
