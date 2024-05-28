using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpExpoItem
    {
        public ErpExpoItem()
        {
            ErpExpoImportClosings = new HashSet<ErpExpoImportClosing>();
            ErpExpoItemDetails = new HashSet<ErpExpoItemDetail>();
            ErpExpoItemVariants = new HashSet<ErpExpoItemVariant>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            InverseParentItem = new HashSet<ErpExpoItem>();
        }

        public long RecId { get; set; }
        public long? ExpoId { get; set; }
        public byte? ItemType { get; set; }
        public long? ParentItemId { get; set; }
        public int? ItemOrderNo { get; set; }
        public long? InventoryId { get; set; }
        public int? UnitId { get; set; }
        public long? ServiceCardId { get; set; }
        public int? ProjectId { get; set; }
        public long? EmployeeId { get; set; }
        public long? PackagingId { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public long? PaymentPlanId { get; set; }
        public byte? ControlCode { get; set; }
        public string? SpecialCode { get; set; }
        public string? CustomerOrderNo { get; set; }
        public string? Explanation { get; set; }
        public decimal? PackageQuantity { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? GrossQuantity { get; set; }
        public decimal? NetQuantity { get; set; }
        public decimal? FobunitPrice { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? ItemTotal { get; set; }
        public decimal? DiscountsTotal { get; set; }
        public decimal? ExpensesTotal { get; set; }
        public decimal? NetItemTotal { get; set; }
        public byte? VatIncluded { get; set; }
        public decimal? VatRate { get; set; }
        public byte? CalcType { get; set; }
        public int? DiscountId { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public int? ExpenseId { get; set; }
        public decimal? ExpenseRate { get; set; }
        public decimal? ExpenseAmount { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? VatBaseAmount { get; set; }
        public decimal? ExciseTaxRate { get; set; }
        public decimal? ExciseTaxAmount { get; set; }
        public long? WorkOrderId { get; set; }
        public int? CtspId { get; set; }
        public long? ImportExpoId { get; set; }
        public long? PackingListId { get; set; }
        public long? PackingListItemId { get; set; }
        public long? WorkOrderItemId { get; set; }
        public long? OrderReceiptItemId { get; set; }
        public long? OrderReceiptId { get; set; }
        public long? InventoryReceiptItemId { get; set; }
        public long? InventoryReceiptId { get; set; }
        public long? InvoiceId { get; set; }
        public decimal? ReferencePrice { get; set; }
        public decimal? LocalReferenceAmount { get; set; }
        public decimal? LocalAmount { get; set; }
        public decimal? CustomTaxRate { get; set; }
        public decimal? CustomTaxAmount { get; set; }
        public decimal? AdditionCustomTaxRate { get; set; }
        public decimal? AdditionCustomTaxAmount { get; set; }
        public decimal? AntiDampingTaxRate { get; set; }
        public decimal? AntiDampingTaxAmount { get; set; }
        public decimal? TotalLocalAmount { get; set; }
        public decimal? CostUnitPrice { get; set; }
        public decimal? StampDutyAmount { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual MetaCtsp? Ctsp { get; set; }
        public virtual ErpDiscount? Discount { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpExpense? Expense { get; set; }
        public virtual ErpExpo? Expo { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpExpo? ImportExpo { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryReceipt? InventoryReceipt { get; set; }
        public virtual ErpInventoryReceiptItem? InventoryReceiptItem { get; set; }
        public virtual ErpInvoice? Invoice { get; set; }
        public virtual ErpOrderReceipt? OrderReceipt { get; set; }
        public virtual ErpOrderReceiptItem? OrderReceiptItem { get; set; }
        public virtual ErpPackaging? Packaging { get; set; }
        public virtual ErpPackingList? PackingList { get; set; }
        public virtual ErpPackingListItem? PackingListItem { get; set; }
        public virtual ErpExpoItem? ParentItem { get; set; }
        public virtual ErpPaymentPlan? PaymentPlan { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpService? ServiceCard { get; set; }
        public virtual MetaUnitSetItem? Unit { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderItem { get; set; }
        public virtual ICollection<ErpExpoImportClosing> ErpExpoImportClosings { get; set; }
        public virtual ICollection<ErpExpoItemDetail> ErpExpoItemDetails { get; set; }
        public virtual ICollection<ErpExpoItemVariant> ErpExpoItemVariants { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpExpoItem> InverseParentItem { get; set; }
    }
}
