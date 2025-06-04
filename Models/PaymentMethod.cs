using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class PaymentMethod
{
    public int Id { get; set; }

    public int FkCustomerId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? ModifiedBy { get; set; }

    public string? LegacyId { get; set; }

    public string? Type { get; set; }

    public string? Name { get; set; }

    public string? UsageMode { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public bool? IsDefault { get; set; }

    public string? Brand { get; set; }

    public string? MaskedCardNumber { get; set; }

    public string? IntegrationAccountId { get; set; }

    public string? IntegrationVendor { get; set; }

    public string? IntegrationPaymentMethodId { get; set; }

    public string? IntegrationSetupIntentId { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
