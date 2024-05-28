using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryAllocation
    {
        public ErpInventoryAllocation()
        {
            ErpInventorySerialTransactions = new HashSet<ErpInventorySerialTransaction>();
            ErpWorkOrderProductions = new HashSet<ErpWorkOrderProduction>();
        }

        public long RecId { get; set; }
        public byte? ItemType { get; set; }
        public byte? AllocationType { get; set; }
        public string? PartyNo { get; set; }
        public long? CurrentAccountId { get; set; }
        public short? InventoryReceiptType { get; set; }
        public short? InventoryReceiptSubType { get; set; }
        public long? InventoryReceiptItemId { get; set; }
        public long? InInventoryReceiptItemId { get; set; }
        public long? DemandReceiptItemId { get; set; }
        public long? WorkOrderProductionId { get; set; }
        public short? OrderReceiptType { get; set; }
        public long? OrderReceiptItemId { get; set; }
        public short? ReturnType { get; set; }
        public long? RequirementId { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public long? WorkOrderItemId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? GrossQuantity { get; set; }
        public decimal? WastageQuantity { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? IsCancelled { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public long? SerialCardId { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpDemandReceiptItem? DemandReceiptItem { get; set; }
        public virtual ErpInventoryReceiptItem? InInventoryReceiptItem { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryReceiptItem? InventoryReceiptItem { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpOrderReceiptItem? OrderReceiptItem { get; set; }
        public virtual ErpRequirement? Requirement { get; set; }
        public virtual ErpInventorySerialCard? SerialCard { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderItem { get; set; }
        public virtual ErpWorkOrderProduction? WorkOrderProduction { get; set; }
        public virtual ICollection<ErpInventorySerialTransaction> ErpInventorySerialTransactions { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductions { get; set; }
    }
}
