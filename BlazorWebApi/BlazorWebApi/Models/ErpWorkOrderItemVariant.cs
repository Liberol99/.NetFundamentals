using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWorkOrderItemVariant
    {
        public ErpWorkOrderItemVariant()
        {
            ErpInventoryReceiptItemVariants = new HashSet<ErpInventoryReceiptItemVariant>();
            ErpOrderReceiptItemVariants = new HashSet<ErpOrderReceiptItemVariant>();
            ErpWorkOrderProductionVariants = new HashSet<ErpWorkOrderProductionVariant>();
        }

        public long RecId { get; set; }
        public long? WorkOrderItemId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public long? OrderReceiptItemVariantId { get; set; }
        public int? SubNo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? AdditionalQuantity { get; set; }
        public decimal? ReducedQuantity { get; set; }
        public decimal? ShippedQty { get; set; }
        public decimal? UnitPrice { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsCancelled { get; set; }
        public string? CancelledExplanation { get; set; }
        public byte? IsClosed { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpOrderReceiptItemVariant? OrderReceiptItemVariant { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderItem { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemVariant> ErpInventoryReceiptItemVariants { get; set; }
        public virtual ICollection<ErpOrderReceiptItemVariant> ErpOrderReceiptItemVariants { get; set; }
        public virtual ICollection<ErpWorkOrderProductionVariant> ErpWorkOrderProductionVariants { get; set; }
    }
}
