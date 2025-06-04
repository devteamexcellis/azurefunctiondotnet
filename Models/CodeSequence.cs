using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CodeSequence
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public long Value { get; set; }

    public string? Prefix { get; set; }
}
