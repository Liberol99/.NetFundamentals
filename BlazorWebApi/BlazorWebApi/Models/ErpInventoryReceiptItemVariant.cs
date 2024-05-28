using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryReceiptItemVariant
    {
        public ErpInventoryReceiptItemVariant()
        {
            ErpBoxItemVariants = new HashSet<ErpBoxItemVariant>();
            ErpInventoryReceiptShipments = new HashSet<ErpInventoryReceiptShipment>();
            InverseReservedReceiptItemVariant = new HashSet<ErpInventoryReceiptItemVariant>();
            InverseReturnReceiptItemVariant = new HashSet<ErpInventoryReceiptItemVariant>();
            InverseTransferOutReceiptItemVariant = new HashSet<ErpInventoryReceiptItemVariant>();
        }

        public long RecId { get; set; }
        public long? InventoryReceiptItemId { get; set; }
        public short? ReceiptType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public byte? ItemType { get; set; }
        public byte? HasNegativeEffect { get; set; }
        public int? InWarehouseId { get; set; }
        public int? OutWarehouseId { get; set; }
        public int? InWarehouseLocationId { get; set; }
        public int? OutWarehouseLocationId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? OpeningQuantity { get; set; }
        public decimal? InflowQuantity { get; set; }
        public decimal? OutflowQuantity { get; set; }
        public decimal? TransferInflowQuantity { get; set; }
        public decimal? TransferOutflowQuantity { get; set; }
        public decimal? ReturnedQuantity { get; set; }
        public decimal? NetUnitPrice { get; set; }
        public decimal? CostPrice { get; set; }
        public long? ReturnReceiptItemVariantId { get; set; }
        public long? ReturnReceiptItemVariantIdP { get; set; }
        public long? TransferOutReceiptItemVariantId { get; set; }
        public long? OrderReceiptItemVariantId { get; set; }
        public long? DemandReceiptItemVariantId { get; set; }
        public long? WorkOrderItemVariantId { get; set; }
        public byte? IsQcapproved { get; set; }
        public byte? IsApproved { get; set; }
        public byte? IsClosed { get; set; }
        public byte? IsCancelled { get; set; }
        public string? CancelledExplanation { get; set; }
        public byte? IsTransportReceipt { get; set; }
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
        public byte? IsShippedLater { get; set; }
        public long? ReservedReceiptItemVariantId { get; set; }
        public decimal? QcrejectedQuantity { get; set; }
        public int? QcrejectedWarehouseId { get; set; }
        public byte? IsMerged { get; set; }

        public virtual ErpDemandReceiptItemVariant? DemandReceiptItemVariant { get; set; }
        public virtual ErpWarehouse? InWarehouse { get; set; }
        public virtual ErpWarehouseLocation? InWarehouseLocation { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryReceiptItem? InventoryReceiptItem { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpOrderReceiptItemVariant? OrderReceiptItemVariant { get; set; }
        public virtual ErpWarehouse? OutWarehouse { get; set; }
        public virtual ErpWarehouseLocation? OutWarehouseLocation { get; set; }
        public virtual ErpWarehouse? QcrejectedWarehouse { get; set; }
        public virtual ErpInventoryReceiptItemVariant? ReservedReceiptItemVariant { get; set; }
        public virtual ErpInventoryReceiptItemVariant? ReturnReceiptItemVariant { get; set; }
        public virtual ErpInventoryReceiptItemVariant? TransferOutReceiptItemVariant { get; set; }
        public virtual ErpWorkOrderItemVariant? WorkOrderItemVariant { get; set; }
        public virtual ICollection<ErpBoxItemVariant> ErpBoxItemVariants { get; set; }
        public virtual ICollection<ErpInventoryReceiptShipment> ErpInventoryReceiptShipments { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemVariant> InverseReservedReceiptItemVariant { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemVariant> InverseReturnReceiptItemVariant { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemVariant> InverseTransferOutReceiptItemVariant { get; set; }
    }
}
