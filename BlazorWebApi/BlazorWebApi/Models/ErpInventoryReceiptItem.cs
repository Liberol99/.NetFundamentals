using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryReceiptItem
    {
        public ErpInventoryReceiptItem()
        {
            ErpBoxItems = new HashSet<ErpBoxItem>();
            ErpBoxes = new HashSet<ErpBox>();
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpFixedAssetExpenses = new HashSet<ErpFixedAssetExpense>();
            ErpInventories = new HashSet<ErpInventory>();
            ErpInventoryAllocationInInventoryReceiptItems = new HashSet<ErpInventoryAllocation>();
            ErpInventoryAllocationInventoryReceiptItems = new HashSet<ErpInventoryAllocation>();
            ErpInventoryReceiptItemAttachments = new HashSet<ErpInventoryReceiptItemAttachment>();
            ErpInventoryReceiptItemPayments = new HashSet<ErpInventoryReceiptItemPayment>();
            ErpInventoryReceiptItemVariants = new HashSet<ErpInventoryReceiptItemVariant>();
            ErpInventoryReceiptShipments = new HashSet<ErpInventoryReceiptShipment>();
            ErpInventorySerialTransactionReceiptItems = new HashSet<ErpInventorySerialTransaction>();
            ErpInventorySerialTransactionTransferOutReceiptItems = new HashSet<ErpInventorySerialTransaction>();
            ErpInventoryTaxUsagePurchaseInventoryReceiptItems = new HashSet<ErpInventoryTaxUsage>();
            ErpInventoryTaxUsageSalesInventoryReceiptItems = new HashSet<ErpInventoryTaxUsage>();
            ErpQualityControlReceipts = new HashSet<ErpQualityControlReceipt>();
            ErpQualityControls = new HashSet<ErpQualityControl>();
            ErpWorkOrderItemReceipts = new HashSet<ErpWorkOrderItemReceipt>();
            InverseInvoiceItem = new HashSet<ErpInventoryReceiptItem>();
            InverseManufactureReceiptItem = new HashSet<ErpInventoryReceiptItem>();
            InverseParentItem = new HashSet<ErpInventoryReceiptItem>();
            InverseReservedReceiptItem = new HashSet<ErpInventoryReceiptItem>();
            InverseReturnReceiptItem = new HashSet<ErpInventoryReceiptItem>();
            InverseTransferOutReceiptItem = new HashSet<ErpInventoryReceiptItem>();
        }

        public long RecId { get; set; }
        public long? InventoryReceiptId { get; set; }
        public short? ReceiptType { get; set; }
        public short? ReceiptSubType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public byte? HasNegativeEffect { get; set; }
        public byte? HasDontTotalEffect { get; set; }
        public int? WorkplaceId { get; set; }
        public int? DepartmentId { get; set; }
        public int? CashId { get; set; }
        public int? InWarehouseId { get; set; }
        public int? OutWarehouseId { get; set; }
        public int? InWarehouseLocationId { get; set; }
        public int? OutWarehouseLocationId { get; set; }
        public byte? ItemType { get; set; }
        public long? ParentItemId { get; set; }
        public int? ItemOrderNo { get; set; }
        public long? InventoryId { get; set; }
        public int? UnitId { get; set; }
        public long? ServiceCardId { get; set; }
        public int? ProjectId { get; set; }
        public long? EmployeeId { get; set; }
        public long? UsedEmployeeId { get; set; }
        public long? PackagingId { get; set; }
        public long? RecipeId { get; set; }
        public long? LabRecipeId { get; set; }
        public long? PatternRecipeId { get; set; }
        public int? RouteId { get; set; }
        public long? InventoryAssortmentId { get; set; }
        public int? CostCenterId { get; set; }
        public long? PaymentPlanId { get; set; }
        public long? MarkId { get; set; }
        public long? ModelId { get; set; }
        public long? CustomerId { get; set; }
        public int? ReturnTypeId { get; set; }
        public string? SpecialCode { get; set; }
        public short? ComplimentaryType { get; set; }
        public string? Explanation { get; set; }
        public long? ExplanationCode { get; set; }
        public short? SeatNo { get; set; }
        public DateTime? PackingStartTime { get; set; }
        public DateTime? PackedTime { get; set; }
        public byte? IsPacked { get; set; }
        public string? CustomerOrderNo { get; set; }
        public short? EntryCount { get; set; }
        public short? CheckPrintCount { get; set; }
        public byte? IsMarched { get; set; }
        public string? PartyNo { get; set; }
        public int? PackageNo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? NetQuantity { get; set; }
        public decimal? NetQuantityEntry { get; set; }
        public decimal? LotQuantity { get; set; }
        public decimal? PackageQuantity { get; set; }
        public decimal? GrossQuantity { get; set; }
        public decimal? UsedQuantity { get; set; }
        public decimal? ReturnedQuantity { get; set; }
        public decimal? OpeningQuantity { get; set; }
        public decimal? InflowQuantity { get; set; }
        public decimal? OutflowQuantity { get; set; }
        public decimal? TransferInflowQuantity { get; set; }
        public decimal? TransferOutflowQuantity { get; set; }
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
        public decimal? PreviousCostPrice { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? CostForexPrice { get; set; }
        public decimal? CostPrice2 { get; set; }
        public decimal? CostPrice3 { get; set; }
        public decimal? DistributedDiscount { get; set; }
        public decimal? DistributedDiscountVatIncluded { get; set; }
        public decimal? DistributedExpense { get; set; }
        public decimal? NetItemTotal { get; set; }
        public decimal? NetUnitPriceForex { get; set; }
        public decimal? VatAmountForex { get; set; }
        public decimal? VatAmountAccommodationForex { get; set; }
        public decimal? VatBaseAmountForex { get; set; }
        public decimal? DiscountAmountForex { get; set; }
        public decimal? DiscountVatIncludedForex { get; set; }
        public decimal? ItemTotalForex { get; set; }
        public decimal? ItemTotalVatIncludedForex { get; set; }
        public decimal? DiscountsTotalForex { get; set; }
        public decimal? DiscountsTotalVatIncludedForex { get; set; }
        public decimal? ExpensesTotalForex { get; set; }
        public decimal? DistributedDiscountForex { get; set; }
        public decimal? DistributedDiscountVatIncludedForex { get; set; }
        public decimal? DistributedExpenseForex { get; set; }
        public decimal? NetItemTotalForex { get; set; }
        public byte? CreatedBySystem { get; set; }
        public string? PackagingNo { get; set; }
        public string? PackageMark { get; set; }
        public int? ProcessId { get; set; }
        public long? InventoryCampaignId { get; set; }
        public long? ManufactureReceiptItemId { get; set; }
        public long? ReturnReceiptItemId { get; set; }
        public long? ReturnReceiptItemIdP { get; set; }
        public long? TransferOutReceiptItemId { get; set; }
        public long? OrderReceiptItemId { get; set; }
        public long? DemandReceiptItemId { get; set; }
        public long? WorkOrderReceiptItemId { get; set; }
        public int? QualityTypeId { get; set; }
        public long? BoxId { get; set; }
        public long? InvoiceItemId { get; set; }
        public long? ReservedReceiptItemId { get; set; }
        public decimal? ReservedQuantity { get; set; }
        public int? CtspId { get; set; }
        public byte? IsTaxExempted { get; set; }
        public byte? IsPrinted { get; set; }
        public byte? IsClosed { get; set; }
        public byte? IsQcapproved { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsSendOkc { get; set; }
        public byte? IsTrasnfered { get; set; }
        public byte? IsMerged { get; set; }
        public byte? IsSecondHandSale { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public byte? ControlCode { get; set; }
        public string? VatListField01 { get; set; }
        public string? VatListField02 { get; set; }
        public string? VatListField03 { get; set; }
        public string? VatListField04 { get; set; }
        public string? VatListField05 { get; set; }
        public decimal? WithholdingAmount1 { get; set; }
        public decimal? WithholdingAmount2 { get; set; }
        public decimal? WithholdingAmount1Forex { get; set; }
        public decimal? WithholdingAmount2Forex { get; set; }
        public short? WithholdingType { get; set; }
        public byte? WithholdingFactor { get; set; }
        public byte? WithholdingDivisor { get; set; }
        public byte? ExpenseTotalIsEffective { get; set; }
        public decimal? Forex2Rate { get; set; }
        public decimal? UnitPrice2 { get; set; }
        public decimal? ItemTotal2 { get; set; }
        public decimal? Forex3Rate { get; set; }
        public decimal? UnitPrice3 { get; set; }
        public decimal? ItemTotal3 { get; set; }
        public byte? IsCancelled { get; set; }
        public string? CancelledExplanation { get; set; }
        public byte? DeliveryType { get; set; }
        public short? PackageType { get; set; }
        public byte? TransportType { get; set; }
        public short? CountingType { get; set; }
        public long? ResourceId { get; set; }
        public byte? IsTransportReceipt { get; set; }
        public long? CurrentAccountReceiptItemId { get; set; }
        public string? IncomingEinvoiceItemName { get; set; }
        public string? EinvoiceTaxExemptionReasonCode { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }
        public string? ApprovedExplanation { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public long? GiftVoucherId { get; set; }
        public long? ExpoItemId { get; set; }
        public long? ExpoId { get; set; }
        public byte? ExpoType { get; set; }
        public byte? IsShippedLater { get; set; }
        public long? CostOrderReceiptId { get; set; }
        public long? CostInventoryId { get; set; }
        public decimal? QcrejectedQuantity { get; set; }
        public int? QcrejectedWarehouseId { get; set; }
        public string? UdMasrafYeri { get; set; }
        public string? UdGiderMerkezi { get; set; }
        public long? WorkOrderId { get; set; }
        public decimal? ProcessTime { get; set; }

        public virtual ErpBox? Box { get; set; }
        public virtual ErpCash? Cash { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpInventory? CostInventory { get; set; }
        public virtual ErpOrderReceipt? CostOrderReceipt { get; set; }
        public virtual MetaCtsp? Ctsp { get; set; }
        public virtual ErpCurrentAccountReceiptItem? CurrentAccountReceiptItem { get; set; }
        public virtual ErpCurrentAccount? Customer { get; set; }
        public virtual ErpDemandReceiptItem? DemandReceiptItem { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpDiscount? Discount { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpExpense? Expense { get; set; }
        public virtual ErpExpo? Expo { get; set; }
        public virtual ErpExpoItem? ExpoItem { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGiftVoucher? GiftVoucher { get; set; }
        public virtual ErpWarehouse? InWarehouse { get; set; }
        public virtual ErpWarehouseLocation? InWarehouseLocation { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryAssortment? InventoryAssortment { get; set; }
        public virtual ErpInventoryCampaign? InventoryCampaign { get; set; }
        public virtual ErpInventoryReceipt? InventoryReceipt { get; set; }
        public virtual ErpInventoryReceiptItem? InvoiceItem { get; set; }
        public virtual ErpLabRecipe? LabRecipe { get; set; }
        public virtual ErpInventoryReceiptItem? ManufactureReceiptItem { get; set; }
        public virtual ErpMark? Mark { get; set; }
        public virtual ErpModel? Model { get; set; }
        public virtual ErpOrderReceiptItem? OrderReceiptItem { get; set; }
        public virtual ErpWarehouse? OutWarehouse { get; set; }
        public virtual ErpWarehouseLocation? OutWarehouseLocation { get; set; }
        public virtual ErpPackaging? Packaging { get; set; }
        public virtual ErpInventoryReceiptItem? ParentItem { get; set; }
        public virtual ErpLabRecipe? PatternRecipe { get; set; }
        public virtual ErpPaymentPlan? PaymentPlan { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpWarehouse? QcrejectedWarehouse { get; set; }
        public virtual ErpQualityType? QualityType { get; set; }
        public virtual ErpRecipe? Recipe { get; set; }
        public virtual ErpInventoryReceiptItem? ReservedReceiptItem { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpInventoryReceiptItem? ReturnReceiptItem { get; set; }
        public virtual ErpReturnType? ReturnType { get; set; }
        public virtual ErpRoute? Route { get; set; }
        public virtual ErpService? ServiceCard { get; set; }
        public virtual ErpInventoryReceiptItem? TransferOutReceiptItem { get; set; }
        public virtual MetaUnitSetItem? Unit { get; set; }
        public virtual ErpEmployee? UsedEmployee { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderReceiptItem { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpBoxItem> ErpBoxItems { get; set; }
        public virtual ICollection<ErpBox> ErpBoxes { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpFixedAssetExpense> ErpFixedAssetExpenses { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpInventoryAllocation> ErpInventoryAllocationInInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryAllocation> ErpInventoryAllocationInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemAttachment> ErpInventoryReceiptItemAttachments { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemPayment> ErpInventoryReceiptItemPayments { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemVariant> ErpInventoryReceiptItemVariants { get; set; }
        public virtual ICollection<ErpInventoryReceiptShipment> ErpInventoryReceiptShipments { get; set; }
        public virtual ICollection<ErpInventorySerialTransaction> ErpInventorySerialTransactionReceiptItems { get; set; }
        public virtual ICollection<ErpInventorySerialTransaction> ErpInventorySerialTransactionTransferOutReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryTaxUsage> ErpInventoryTaxUsagePurchaseInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryTaxUsage> ErpInventoryTaxUsageSalesInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpQualityControlReceipt> ErpQualityControlReceipts { get; set; }
        public virtual ICollection<ErpQualityControl> ErpQualityControls { get; set; }
        public virtual ICollection<ErpWorkOrderItemReceipt> ErpWorkOrderItemReceipts { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> InverseInvoiceItem { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> InverseManufactureReceiptItem { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> InverseParentItem { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> InverseReservedReceiptItem { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> InverseReturnReceiptItem { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> InverseTransferOutReceiptItem { get; set; }
    }
}
