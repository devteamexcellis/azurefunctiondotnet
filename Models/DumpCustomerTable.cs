using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class DumpCustomerTable
{
    public int Id { get; set; }

    public string CustomerLegacyId { get; set; } = null!;

    public string? AcquisitionCode { get; set; }

    public string? AffinityCode { get; set; }

    public bool? AutoPap { get; set; }

    public string? Interest { get; set; }

    public string? PurchaseOrderMandatory { get; set; }

    public string? Remittance { get; set; }

    public string? Budget { get; set; }

    public DateTime? Debut { get; set; }

    public decimal? DeferredBucket { get; set; }

    public decimal? PrevDeferredBucket { get; set; }

    public decimal? CurrentBucket { get; set; }

    public decimal? MonthlyAmount { get; set; }

    public string? Facture { get; set; }

    public bool? PrintEquip { get; set; }

    public bool? PrintPartPlan { get; set; }

    public bool? IsSmpInvoice { get; set; }

    public bool? IsServiceInvoice { get; set; }

    public int? DeliveryInvoice { get; set; }

    public bool? PrintServiceCharge { get; set; }

    public string? SelectCode { get; set; }

    public int? SpecialFlag { get; set; }

    public string? Province { get; set; }

    public string? ExemptionLicense { get; set; }

    public decimal? MonthsForBudgetPlan { get; set; }

    public virtual ICollection<DumpCustomerTableDetail> DumpCustomerTableDetails { get; set; } = new List<DumpCustomerTableDetail>();
}
