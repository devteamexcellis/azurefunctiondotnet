using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class CaAttributesProjection
{
    public int Id { get; set; }

    public int FkCustomerAddressAttributesId { get; set; }

    public virtual CustomerAddressAttribute FkCustomerAddressAttributes { get; set; } = null!;
}
