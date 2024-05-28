using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWorkOrderItemReceipt
    {
        public long RecId { get; set; }
        public long? WorkOrderReceiptItemId { get; set; }
        public long? InventoryReceiptItemId { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpInventoryReceiptItem? InventoryReceiptItem { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderReceiptItem { get; set; }
    }
}
