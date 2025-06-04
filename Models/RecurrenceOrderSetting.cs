using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class RecurrenceOrderSetting
{
    public int Id { get; set; }

    public int? FkRecurrenceId { get; set; }

    public int FkCustomerId { get; set; }

    public int FkCustomerIdShip { get; set; }

    public int FkCustomerIdBill { get; set; }

    public string FkUserId { get; set; } = null!;

    public int? FkShipTypeId { get; set; }

    public int? FkShipVendorId { get; set; }

    public string? PoNumber { get; set; }

    public string BillAddrCountry { get; set; } = null!;

    public string BillAddrState { get; set; } = null!;

    public string BillAddrCity { get; set; } = null!;

    public string BillAddrStreet { get; set; } = null!;

    public string BillAddrZipcode { get; set; } = null!;

    public string ShipAddrCountry { get; set; } = null!;

    public string ShipAddrState { get; set; } = null!;

    public string ShipAddrCity { get; set; } = null!;

    public string ShipAddrStreet { get; set; } = null!;

    public string ShipAddrZipcode { get; set; } = null!;

    public string? Comments { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? AttentionLine { get; set; }

    public string? PaymentOption { get; set; }

    public string? CcTransactionId { get; set; }

    public string? BillAddrCountryCodeAlpha { get; set; }

    public string? ShipAddrCountryCodeAlpha { get; set; }

    public string? UserLegacyId { get; set; }

    public DateTime? Timestamp { get; set; }

    public DateTime? DateSubmitted { get; set; }

    public string? OrderStatus { get; set; }

    public string? ShipSiteName { get; set; }

    public int? FkUserTransactionId { get; set; }

    public string? LegacyId { get; set; }

    public int? FkSupplierVendorId { get; set; }

    public string? Type { get; set; }

    public string? ShipAddrRecepientName { get; set; }

    public string? ReferenceId { get; set; }

    public string? ShipAddrRecepientNumber { get; set; }

    public int? GroupId { get; set; }

    public string? ShipSiteId { get; set; }

    public string? OrderNumber { get; set; }

    public bool? IsRushOrder { get; set; }

    public string? IntlContactName { get; set; }

    public string? IntlContactNumber { get; set; }

    public string? IntlContactEmail { get; set; }

    public string? TaxId { get; set; }

    public virtual Customer FkCustomer { get; set; } = null!;

    public virtual Customer FkCustomerIdBillNavigation { get; set; } = null!;

    public virtual Customer FkCustomerIdShipNavigation { get; set; } = null!;

    public virtual Recurrence? FkRecurrence { get; set; }

    public virtual ShippingType? FkShipType { get; set; }

    public virtual ShippingVendor? FkShipVendor { get; set; }

    public virtual User FkUser { get; set; } = null!;
}
