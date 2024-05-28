using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpQualityControlReceiptItem
    {
        public ErpQualityControlReceiptItem()
        {
            InverseParentItem = new HashSet<ErpQualityControlReceiptItem>();
        }

        public long RecId { get; set; }
        public long? QualityControlReceiptId { get; set; }
        public short? ReceiptType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public byte? ItemType { get; set; }
        public long? ParentItemId { get; set; }
        public int? ItemOrderNo { get; set; }
        public int? ProjectId { get; set; }
        public long? EmployeeId { get; set; }
        public long? WorkOrderId { get; set; }
        public long? InventoryId { get; set; }
        public int? ProcessId { get; set; }
        public string? Explanation { get; set; }
        public string? FaultyPlace { get; set; }
        public long? FaultyCardId { get; set; }
        public decimal? FaultyQuantity { get; set; }
        public byte? IsMajor { get; set; }
        public byte? IsMinor { get; set; }
        public byte? IsCritical { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpFaultyCard? FaultyCard { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpQualityControlReceiptItem? ParentItem { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpQualityControlReceipt? QualityControlReceipt { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ICollection<ErpQualityControlReceiptItem> InverseParentItem { get; set; }
    }
}
