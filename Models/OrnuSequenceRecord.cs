using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrnuSequenceRecord
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Prefix { get; set; } = null!;
}
