using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpOrderReceiptItem
    {
        public ErpOrderReceiptItem()
        {
            ErpBankCreditItems = new HashSet<ErpBankCreditItem>();
            ErpBoxItems = new HashSet<ErpBoxItem>();
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpInventoryAllocations = new HashSet<ErpInventoryAllocation>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpOrderReceiptItemAttachments = new HashSet<ErpOrderReceiptItemAttachment>();
            ErpOrderReceiptItemVariants = new HashSet<ErpOrderReceiptItemVariant>();
            ErpRequirements = new HashSet<ErpRequirement>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderProgresses = new HashSet<ErpWorkOrderProgress>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            InverseParentItem = new HashSet<ErpOrderReceiptItem>();
        }

        public long RecId { get; set; }
        public long? OrderReceiptId { get; set; }
        public short? ReceiptType { get; set; }
        public short? ReceiptSubType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public int? WarehouseId { get; set; }
        public int? WorkplaceId { get; set; }
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
        public string? SpecialCode { get; set; }
        public long? InventoryAssortmentId { get; set; }
        public int? CostCenterId { get; set; }
        public long? PaymentPlanId { get; set; }
        public long? MarkId { get; set; }
        public long? ModelId { get; set; }
        public long? RecipeId { get; set; }
        public long? LabRecipeId { get; set; }
        public long? PatternRecipeId { get; set; }
        public int? RouteId { get; set; }
        public long? BoxId { get; set; }
        public string? Explanation { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? CustomerOrderNo { get; set; }
        public string? PartyNo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? NetQuantity { get; set; }
        public decimal? NetQuantityEntry { get; set; }
        public decimal? LotQuantity { get; set; }
        public decimal? PackageQuantity { get; set; }
        public decimal? GrossQuantity { get; set; }
        public decimal? ReceivedQuantity { get; set; }
        public decimal? WorkOrderQuantity { get; set; }
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
        public decimal? CostPrice { get; set; }
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
        public byte? CreatedBySystem { get; set; }
        public long? InventoryCampaignId { get; set; }
        public long? ContractItemId { get; set; }
        public long? QuotationReceiptItemId { get; set; }
        public long? DemandReceiptItemId { get; set; }
        public long? WorkOrderReceiptItemId { get; set; }
        public int? QualityTypeId { get; set; }
        public int? CtspId { get; set; }
        public short? ComplimentaryType { get; set; }
        public decimal? ReturnedQuantity { get; set; }
        public decimal? Forex2Rate { get; set; }
        public decimal? UnitPrice2 { get; set; }
        public decimal? ItemTotal2 { get; set; }
        public decimal? Forex3Rate { get; set; }
        public decimal? UnitPrice3 { get; set; }
        public decimal? ItemTotal3 { get; set; }
        public byte? IsTaxExempted { get; set; }
        public byte? IsReserved { get; set; }
        public byte? IsClosed { get; set; }
        public string? ClosedExplanation { get; set; }
        public DateTime? ClosedAt { get; set; }
        public int? ClosedBy { get; set; }
        public byte? IsWclosed { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsSendOkc { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public byte? ControlCode { get; set; }
        public byte? IsCancelled { get; set; }
        public string? CancelledExplanation { get; set; }
        public byte? IsWcancelled { get; set; }
        public long? ResourceId { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }
        public long? InitialCostId { get; set; }
        public string? ApprovedExplanation { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public long? CatalogSerialCardId { get; set; }
        public long? ReferenceWorkOrderId { get; set; }
        public decimal? UdOtv { get; set; }
        public long? WorkOrderId { get; set; }
        public string? UdLook1 { get; set; }
        public string? UdLook2 { get; set; }
        public string? UdLook3 { get; set; }

        public virtual ErpBox? Box { get; set; }
        public virtual ErpInventorySerialCard? CatalogSerialCard { get; set; }
        public virtual ErpContractItem? ContractItem { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual MetaCtsp? Ctsp { get; set; }
        public virtual ErpDemandReceiptItem? DemandReceiptItem { get; set; }
        public virtual ErpDiscount? Discount { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpExpense? Expense { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInitialCost? InitialCost { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryAssortment? InventoryAssortment { get; set; }
        public virtual ErpInventoryCampaign? InventoryCampaign { get; set; }
        public virtual ErpLabRecipe? LabRecipe { get; set; }
        public virtual ErpMark? Mark { get; set; }
        public virtual ErpModel? Model { get; set; }
        public virtual ErpOrderReceipt? OrderReceipt { get; set; }
        public virtual ErpPackaging? Packaging { get; set; }
        public virtual ErpOrderReceiptItem? ParentItem { get; set; }
        public virtual ErpLabRecipe? PatternRecipe { get; set; }
        public virtual ErpPaymentPlan? PaymentPlan { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpQualityType? QualityType { get; set; }
        public virtual ErpQuotationReceiptItem? QuotationReceiptItem { get; set; }
        public virtual ErpRecipe? Recipe { get; set; }
        public virtual ErpWorkOrder? ReferenceWorkOrder { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpRoute? Route { get; set; }
        public virtual ErpService? ServiceCard { get; set; }
        public virtual MetaUnitSetItem? Unit { get; set; }
        public virtual ErpEmployee? UsedEmployee { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderReceiptItem { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpBankCreditItem> ErpBankCreditItems { get; set; }
        public virtual ICollection<ErpBoxItem> ErpBoxItems { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpInventoryAllocation> ErpInventoryAllocations { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpOrderReceiptItemAttachment> ErpOrderReceiptItemAttachments { get; set; }
        public virtual ICollection<ErpOrderReceiptItemVariant> ErpOrderReceiptItemVariants { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirements { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
        public virtual ICollection<ErpWorkOrderProgress> ErpWorkOrderProgresses { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> InverseParentItem { get; set; }
    }
}
