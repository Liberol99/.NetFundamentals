using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventorySerialTransaction
    {
        public long RecId { get; set; }
        public byte? ItemType { get; set; }
        public byte? HasNegativeEffect { get; set; }
        public int? InWarehouseId { get; set; }
        public int? OutWarehouseId { get; set; }
        public int? InWarehouseLocationId { get; set; }
        public int? OutWarehouseLocationId { get; set; }
        public long? TransferOutReceiptItemId { get; set; }
        public long? SerialCardId { get; set; }
        public short? TransactionType { get; set; }
        public long? ReceiptItemId { get; set; }
        public long? InventoryAllocationId { get; set; }
        public long? WorkOrderProductionId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsApproved { get; set; }
        public byte? IsCancelled { get; set; }
        public string? CancelledExplanation { get; set; }
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

        public virtual ErpWarehouse? InWarehouse { get; set; }
        public virtual ErpWarehouseLocation? InWarehouseLocation { get; set; }
        public virtual ErpInventoryAllocation? InventoryAllocation { get; set; }
        public virtual ErpWarehouse? OutWarehouse { get; set; }
        public virtual ErpWarehouseLocation? OutWarehouseLocation { get; set; }
        public virtual ErpInventoryReceiptItem? ReceiptItem { get; set; }
        public virtual ErpInventorySerialCard? SerialCard { get; set; }
        public virtual ErpInventoryReceiptItem? TransferOutReceiptItem { get; set; }
        public virtual ErpWorkOrderProduction? WorkOrderProduction { get; set; }
    }
}
