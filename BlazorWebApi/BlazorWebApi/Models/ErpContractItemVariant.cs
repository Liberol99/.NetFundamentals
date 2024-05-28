using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpContractItemVariant
    {
        public ErpContractItemVariant()
        {
            ErpOrderReceiptItemVariants = new HashSet<ErpOrderReceiptItemVariant>();
        }

        public long RecId { get; set; }
        public long? ReceiptItemId { get; set; }
        public short? ReceiptType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public byte? ItemType { get; set; }
        public long? InventoryId { get; set; }
        public int? WarehouseId { get; set; }
        public long? InventoryVariantId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? NetUnitPrice { get; set; }
        public decimal? ReceivedQuantity { get; set; }
        public byte? IsApproved { get; set; }
        public byte? IsClosed { get; set; }
        public byte? IsCancelled { get; set; }
        public string? CancelledExplanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpContractItem? ReceiptItem { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ICollection<ErpOrderReceiptItemVariant> ErpOrderReceiptItemVariants { get; set; }
    }
}
