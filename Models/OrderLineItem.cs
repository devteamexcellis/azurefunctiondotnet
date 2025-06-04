using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class OrderLineItem
{
    public int Id { get; set; }

    public string? FkOrderId { get; set; }

    public int FkProductId { get; set; }

    public int? FkPricingTemplateId { get; set; }

    public DateTime DateCreated { get; set; }

    public string? PriceModel { get; set; }

    public string? ContractId { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public double? LimitCost { get; set; }

    public double? TotalCurrentCost { get; set; }

    public double? LimitVolume { get; set; }

    public double? TotalLimitVolume { get; set; }

    public double? OrderQuantity { get; set; }

    public double? ConfirmedQuantity { get; set; }

    public double? ShippedQuantity { get; set; }

    public double OrderPrice { get; set; }

    public double? ConfirmedPrice { get; set; }

    public double? ShippedPrice { get; set; }

    public string PriceSource { get; set; } = null!;

    public int? ReferenceBptmId { get; set; }

    public int? ReferenceCaptmId { get; set; }

    public double? ShippedGrossVolume { get; set; }

    public int? ShippedPercentFull { get; set; }

    public string? ShippedExtended { get; set; }

    public int? FkServiceRequestId { get; set; }

    public string? PriceType { get; set; }

    public string? PriceVariance { get; set; }

    public string? ContractType { get; set; }

    public int? ReferencePpzcmId { get; set; }

    public string? ProductName { get; set; }

    public string? BinId { get; set; }

    public virtual Order? FkOrder { get; set; }

    public virtual Product FkProduct { get; set; } = null!;

    public virtual ServiceRequest? FkServiceRequest { get; set; }

    public virtual ICollection<OrderLineItemDetail> OrderLineItemDetails { get; set; } = new List<OrderLineItemDetail>();
}
