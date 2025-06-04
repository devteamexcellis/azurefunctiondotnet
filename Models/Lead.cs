using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Lead
{
    public int Id { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? ModifiedBy { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public string Email { get; set; } = null!;

    public string PrimaryPhoneNumber { get; set; } = null!;

    public string PrimaryDeliveryAddress { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Province { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string? CreditAuthorization { get; set; }

    public string? DeliveryPreference { get; set; }

    public string? EquipmentServicePlan { get; set; }

    public string? PrimaryEnergySource { get; set; }

    public string? PrimaryHeatingSource { get; set; }

    public string? SecondaryHeatingSource { get; set; }

    public string? PaymentPlan { get; set; }

    public string? BillingMethod { get; set; }

    public string? PaymentMethod { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactPhone { get; set; }

    public string? BillingCycle { get; set; }

    public string? BillingSchedule { get; set; }

    public string? BillingSetup { get; set; }

    public string? AccountCreditStatus { get; set; }

    public string? BudgetPlan { get; set; }

    public string? AuthorizedUser { get; set; }

    public DateOnly? AuthorizedUserDob { get; set; }

    public string? AuthorizedUserEmail { get; set; }

    public string? Type { get; set; }

    public string? LsdNo { get; set; }

    public string? DaysOpen { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Street { get; set; }

    public string? State { get; set; }

    public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? ModifiedByNavigation { get; set; }
}
