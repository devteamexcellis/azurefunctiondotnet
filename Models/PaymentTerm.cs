using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class PaymentTerm
{
    public int PaymentTermId { get; set; }

    public string PaymentTermCode { get; set; } = null!;

    public string PaymentTerm1 { get; set; } = null!;

    public int? PaymentSchedule { get; set; }

    public int? PaymentCycle { get; set; }

    public string? PaymentSetup { get; set; }

    public string? AccountCreditStatus { get; set; }

    public string? PaymentPlan { get; set; }

    public int? PaymentTermDuration { get; set; }
}
