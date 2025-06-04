using System;
using System.Collections.Generic;

namespace excellis.Models;

public partial class Recurrence
{
    public int Id { get; set; }

    public int? FkCustomerId { get; set; }

    public string? CreatedBy { get; set; }

    public string? RepeatType { get; set; }

    public string? RepeatInterval { get; set; }

    public short? RepeatsOnDayOfWeek { get; set; }

    public short? RepeatsOnWeek { get; set; }

    public short? RepeatsOnDateOfMonth { get; set; }

    public short? RepeatsOnMonthOfQuarter { get; set; }

    public DateOnly? EndsByDate { get; set; }

    public int? NumberOfRepeats { get; set; }

    public bool? IsContinuous { get; set; }

    public DateOnly? LastExecutionDate { get; set; }

    public int? ExecutionCount { get; set; }

    public DateOnly? NextExecutionDate { get; set; }

    public string RecurrenceStatus { get; set; } = null!;

    public DateTime Timestamp { get; set; }

    public int? FkGroupId { get; set; }

    public int? FkCustomerAddressId { get; set; }

    public string? Type { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? KFactor { get; set; }

    public string? TankMonitor { get; set; }

    public bool? IsAutomaticDelivery { get; set; }

    public int? DayGapSummer { get; set; }

    public int? DayGapWinter { get; set; }

    public int? DayGapTrans { get; set; }

    public double? KFactorSummer { get; set; }

    public double? KFactorWinter { get; set; }

    public double? KFactorTrans { get; set; }

    public double? ForecastingProjection { get; set; }

    public DateTime? Runout { get; set; }

    public int? DdGap { get; set; }

    public virtual ICollection<DeliveryQueue> DeliveryQueues { get; set; } = new List<DeliveryQueue>();

    public virtual Customer? FkCustomer { get; set; }

    public virtual CustomerAddress? FkCustomerAddress { get; set; }

    public virtual Group? FkGroup { get; set; }

    public virtual ICollection<Note> Notes { get; set; } = new List<Note>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<RecurrenceCharge> RecurrenceCharges { get; set; } = new List<RecurrenceCharge>();

    public virtual ICollection<RecurrenceDetail> RecurrenceDetails { get; set; } = new List<RecurrenceDetail>();

    public virtual ICollection<RecurrenceOrderSetting> RecurrenceOrderSettings { get; set; } = new List<RecurrenceOrderSetting>();
}
