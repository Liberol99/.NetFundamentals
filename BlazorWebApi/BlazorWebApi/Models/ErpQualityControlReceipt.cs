using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpQualityControlReceipt
    {
        public ErpQualityControlReceipt()
        {
            ErpQualityControlReceiptAttachments = new HashSet<ErpQualityControlReceiptAttachment>();
            ErpQualityControlReceiptItems = new HashSet<ErpQualityControlReceiptItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public short? ReceiptType { get; set; }
        public string? ReceiptNo { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public DateTime? ReceiptTime { get; set; }
        public string? DocumentNo { get; set; }
        public long? CurrentAccountId { get; set; }
        public string? AccessCode { get; set; }
        public int? ProjectId { get; set; }
        public long? EmployeeId { get; set; }
        public long? WorkOrderId { get; set; }
        public long? WorkOrderItemId { get; set; }
        public long? InventoryId { get; set; }
        public int? ProcessId { get; set; }
        public decimal? ControlQuantity { get; set; }
        public decimal? MinorQuantity { get; set; }
        public decimal? MajorQuantity { get; set; }
        public decimal? CriticalQuantity { get; set; }
        public byte? Status { get; set; }
        public string? Explanation { get; set; }
        public long? InventoryReceiptId { get; set; }
        public long? InventoryReceiptItemId { get; set; }
        public byte? IsPrinted { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public byte? IsClosed { get; set; }
        public byte? IsCancelled { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public short? ControlType { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public string? CancelledExplanation { get; set; }
        public string? ApprovedExplanation { get; set; }
        public string? DocumentSerialNo { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryReceipt? InventoryReceipt { get; set; }
        public virtual ErpInventoryReceiptItem? InventoryReceiptItem { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderItem { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpQualityControlReceiptAttachment> ErpQualityControlReceiptAttachments { get; set; }
        public virtual ICollection<ErpQualityControlReceiptItem> ErpQualityControlReceiptItems { get; set; }
    }
}
