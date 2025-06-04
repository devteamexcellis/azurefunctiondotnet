using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Timezone
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string StandardAbbreviation { get; set; } = null!;

    public int StandardValue { get; set; }

    public string DaylightAbbreviation { get; set; } = null!;

    public int DaylightValue { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
