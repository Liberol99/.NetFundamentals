﻿using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDemandReceiptItem
    {
        public ErpDemandReceiptItem()
        {
            ErpDemandReceiptItemVariants = new HashSet<ErpDemandReceiptItemVariant>();
            ErpInventoryAllocations = new HashSet<ErpInventoryAllocation>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            InverseParentItem = new HashSet<ErpDemandReceiptItem>();
            InverseSourceDemandReceiptItem = new HashSet<ErpDemandReceiptItem>();
            InverseWarehouseDemandReceiptItem = new HashSet<ErpDemandReceiptItem>();
        }

        public long RecId { get; set; }
        public long? DemandReceiptId { get; set; }
        public short? ReceiptType { get; set; }
        public short? ReceiptUpType { get; set; }
        public short? ReceiptSubType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public int? WarehouseId { get; set; }
        public int? WorkplaceId { get; set; }
        public byte? ItemType { get; set; }
        public byte? ItemStatus { get; set; }
        public long? ParentItemId { get; set; }
        public int? ItemOrderNo { get; set; }
        public long? InventoryId { get; set; }
        public int? UnitId { get; set; }
        public long? ServiceCardId { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? ProjectId { get; set; }
        public long? EmployeeId { get; set; }
        public long? UsedEmployeeId { get; set; }
        public long? PackagingId { get; set; }
        public int? CostCenterId { get; set; }
        public long? PaymentPlanId { get; set; }
        public long? MarkId { get; set; }
        public long? ModelId { get; set; }
        public string? SpecialCode { get; set; }
        public string? Explanation { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? PartyNo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? NetQuantity { get; set; }
        public decimal? NetQuantityEntry { get; set; }
        public decimal? LotQuantity { get; set; }
        public decimal? PackageQuantity { get; set; }
        public decimal? GrossQuantity { get; set; }
        public decimal? OrderedQuantity { get; set; }
        public decimal? UsedQuantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexUnitPrice { get; set; }
        public byte? VatIncluded { get; set; }
        public decimal? VatRate { get; set; }
        public decimal? VatRateAccommodation { get; set; }
        public byte? CalcType { get; set; }
        public int? DiscountId { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountVatIncluded { get; set; }
        public int? ExpenseId { get; set; }
        public decimal? ExpenseRate { get; set; }
        public decimal? ExpenseAmount { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? VatAmountAccommodation { get; set; }
        public decimal? VatBaseAmount { get; set; }
        public decimal? ExciseTaxRate { get; set; }
        public decimal? ExciseTaxAmount { get; set; }
        public decimal? CommunicationTaxRate { get; set; }
        public decimal? CommunicationTaxAmount { get; set; }
        public decimal? ItemTotal { get; set; }
        public decimal? ItemTotalVatIncluded { get; set; }
        public decimal? DiscountsTotal { get; set; }
        public decimal? DiscountsTotalVatIncluded { get; set; }
        public decimal? ExpensesTotal { get; set; }
        public decimal? NetUnitPrice { get; set; }
        public decimal? DistributedDiscount { get; set; }
        public decimal? DistributedDiscountVatIncluded { get; set; }
        public decimal? DistributedExpense { get; set; }
        public decimal? NetItemTotal { get; set; }
        public decimal? NetUnitPriceForex { get; set; }
        public decimal? VatAmountForex { get; set; }
        public decimal? VatAmountAccommodationForex { get; set; }
        public decimal? VatBaseAmountForex { get; set; }
        public decimal? ItemTotalForex { get; set; }
        public decimal? ItemTotalVatIncludedForex { get; set; }
        public decimal? DiscountsTotalForex { get; set; }
        public decimal? DiscountsTotalVatIncludedForex { get; set; }
        public decimal? ExpensesTotalForex { get; set; }
        public decimal? DistributedDiscountForex { get; set; }
        public decimal? DistributedDiscountVatIncludedForex { get; set; }
        public decimal? DistributedExpenseForex { get; set; }
        public decimal? NetItemTotalForex { get; set; }
        public decimal? Forex2Rate { get; set; }
        public decimal? UnitPrice2 { get; set; }
        public decimal? ItemTotal2 { get; set; }
        public decimal? Forex3Rate { get; set; }
        public decimal? UnitPrice3 { get; set; }
        public decimal? ItemTotal3 { get; set; }
        public byte? CreatedBySystem { get; set; }
        public long? WorkOrderReceiptItemId { get; set; }
        public long? WarehouseDemandReceiptItemId { get; set; }
        public long? SourceDemandReceiptItemId { get; set; }
        public byte? IsTaxExempted { get; set; }
        public byte? IsClosed { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public byte? ControlCode { get; set; }
        public byte? IsCancelled { get; set; }
        public string? CancelledExplanation { get; set; }
        public long? ResourceId { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public int? OutWarehouseId { get; set; }
        public int? WarehouseLocationId { get; set; }
        public long? WorkOrderId { get; set; }

        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpDemandReceipt? DemandReceipt { get; set; }
        public virtual ErpDiscount? Discount { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpExpense? Expense { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpMark? Mark { get; set; }
        public virtual ErpModel? Model { get; set; }
        public virtual ErpWarehouse? OutWarehouse { get; set; }
        public virtual ErpPackaging? Packaging { get; set; }
        public virtual ErpDemandReceiptItem? ParentItem { get; set; }
        public virtual ErpPaymentPlan? PaymentPlan { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpService? ServiceCard { get; set; }
        public virtual ErpDemandReceiptItem? SourceDemandReceiptItem { get; set; }
        public virtual MetaUnitSetItem? Unit { get; set; }
        public virtual ErpEmployee? UsedEmployee { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpDemandReceiptItem? WarehouseDemandReceiptItem { get; set; }
        public virtual ErpWarehouseLocation? WarehouseLocation { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderReceiptItem { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpDemandReceiptItemVariant> ErpDemandReceiptItemVariants { get; set; }
        public virtual ICollection<ErpInventoryAllocation> ErpInventoryAllocations { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> InverseParentItem { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> InverseSourceDemandReceiptItem { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> InverseWarehouseDemandReceiptItem { get; set; }
    }
}