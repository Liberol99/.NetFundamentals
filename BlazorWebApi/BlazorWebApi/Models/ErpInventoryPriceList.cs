using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryPriceList
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public byte? IsPriceDiscount { get; set; }
        public long? InventoryId { get; set; }
        public string? InventorySpecial { get; set; }
        public string? InventoryPriceGroup { get; set; }
        public string? InventoryCampaignCode { get; set; }
        public long? InventoryVariantId { get; set; }
        public long? InventoryGroupId { get; set; }
        public string? InventoryGroupSpecial { get; set; }
        public byte? ItemType { get; set; }
        public byte? PriceType { get; set; }
        public string? PriceCode { get; set; }
        public string? CampaignCode { get; set; }
        public string? Explanation { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Price { get; set; }
        public decimal? VatRate { get; set; }
        public int? UnitSetItemId { get; set; }
        public byte? VatIncluded { get; set; }
        public int? ForexId { get; set; }
        public int? WorkplaceId { get; set; }
        public long? CurrAccId { get; set; }
        public string? CurrAccSpecial { get; set; }
        public string? CurrAccDiscountGroup { get; set; }
        public long? CurrAccGroupId { get; set; }
        public string? CurrAccGroupSpecial { get; set; }
        public int? DepartmentId { get; set; }
        public long? CustomerId { get; set; }
        public long? PaymentPlanId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProcessId { get; set; }
        public long? WorkOrderId { get; set; }
        public int? RouteId { get; set; }
        public int? WarehouseId { get; set; }
        public long? MarkId { get; set; }
        public long? ModelId { get; set; }
        public long? CertificationId { get; set; }
        public short? DeliveryPeriod { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? EndTime { get; set; }
        public short? Priority { get; set; }
        public string? Formula { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }
        public byte? InOutType { get; set; }
        public int? InventoryCategoryId { get; set; }
        public int? CurrentAccountCategoryId { get; set; }

        public virtual ErpCertification? Certification { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrAcc { get; set; }
        public virtual ErpCurrentAccountGroup? CurrAccGroup { get; set; }
        public virtual ErpCurrentAccountCategory? CurrentAccountCategory { get; set; }
        public virtual ErpCurrentAccount? Customer { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpCategory? InventoryCategory { get; set; }
        public virtual ErpInventoryGroup? InventoryGroup { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpMark? Mark { get; set; }
        public virtual ErpModel? Model { get; set; }
        public virtual ErpPaymentPlan? PaymentPlan { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpRoute? Route { get; set; }
        public virtual ErpInventoryUnitItemSize? UnitSetItem { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
