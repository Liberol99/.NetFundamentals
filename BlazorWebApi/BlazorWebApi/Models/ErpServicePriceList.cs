using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpServicePriceList
    {
        public long RecId { get; set; }
        public byte? IsPriceDiscount { get; set; }
        public long? ServiceId { get; set; }
        public string? ServiceSpecial { get; set; }
        public string? ServicePriceGroup { get; set; }
        public string? ServiceCampaignCode { get; set; }
        public long? ServiceGroupId { get; set; }
        public string? ServiceGroupSpecial { get; set; }
        public byte? ItemType { get; set; }
        public byte? PriceType { get; set; }
        public string? PriceCode { get; set; }
        public string? CampaignCode { get; set; }
        public string? Explanation { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Price { get; set; }
        public long? UnitSetItemId { get; set; }
        public byte? VatIncluded { get; set; }
        public int? ForexId { get; set; }
        public long? CurrAccId { get; set; }
        public string? CurrAccSpecial { get; set; }
        public string? CurrAccDiscountGroup { get; set; }
        public long? CurrAccGroupId { get; set; }
        public string? CurrAccGroupSpecial { get; set; }
        public int? DepartmentId { get; set; }
        public long? PaymentPlanId { get; set; }
        public int? ProjectId { get; set; }
        public short? DeliveryPeriod { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? EndTime { get; set; }
        public short? Priority { get; set; }
        public string? Formula { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? IsPriceIncluded { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCurrentAccount? CurrAcc { get; set; }
        public virtual ErpCurrentAccountGroup? CurrAccGroup { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpPaymentPlan? PaymentPlan { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpService? Service { get; set; }
        public virtual ErpServiceGroup? ServiceGroup { get; set; }
        public virtual ErpServiceUnitItemSize? UnitSetItem { get; set; }
    }
}
