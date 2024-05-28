using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpOrderReceiptItemVariant
    {
        public ErpOrderReceiptItemVariant()
        {
            ErpBoxItemVariants = new HashSet<ErpBoxItemVariant>();
            ErpInventoryReceiptItemVariants = new HashSet<ErpInventoryReceiptItemVariant>();
            ErpWorkOrderItemVariants = new HashSet<ErpWorkOrderItemVariant>();
        }

        public long RecId { get; set; }
        public long? OrderReceiptItemId { get; set; }
        public short? ReceiptType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public byte? ItemType { get; set; }
        public int? WarehouseId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? NetUnitPrice { get; set; }
        public decimal? ReceivedQuantity { get; set; }
        public long? ContractItemVariantId { get; set; }
        public long? DemandReceiptItemVariantId { get; set; }
        public long? QuotationReceiptItemVariantId { get; set; }
        public decimal? WorkOrderQuantity { get; set; }
        public byte? IsWclosed { get; set; }
        public byte? IsWcancelled { get; set; }
        public long? WorkOrderItemVariantId { get; set; }
        public byte? IsReserved { get; set; }
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
        public Guid? UniqueId { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }

        public virtual ErpContractItemVariant? ContractItemVariant { get; set; }
        public virtual ErpDemandReceiptItemVariant? DemandReceiptItemVariant { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpOrderReceiptItem? OrderReceiptItem { get; set; }
        public virtual ErpQuotationReceiptItemVariant? QuotationReceiptItemVariant { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpWorkOrderItemVariant? WorkOrderItemVariant { get; set; }
        public virtual ICollection<ErpBoxItemVariant> ErpBoxItemVariants { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemVariant> ErpInventoryReceiptItemVariants { get; set; }
        public virtual ICollection<ErpWorkOrderItemVariant> ErpWorkOrderItemVariants { get; set; }
    }
}
