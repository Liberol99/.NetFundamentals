using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBoxItem
    {
        public ErpBoxItem()
        {
            ErpBoxItemVariants = new HashSet<ErpBoxItemVariant>();
            ErpInventoryReceiptShipments = new HashSet<ErpInventoryReceiptShipment>();
        }

        public long RecId { get; set; }
        public long? BoxId { get; set; }
        public short? ItemOrderNo { get; set; }
        public long? InventoryId { get; set; }
        public long? SerialCardId { get; set; }
        public long? InventoryReceiptShipmentId { get; set; }
        public long? OrderReceiptItemId { get; set; }
        public long? InBoxId { get; set; }
        public string? Explanation { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Quantity2 { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public long? InventoryReceiptItemId { get; set; }

        public virtual ErpBox? Box { get; set; }
        public virtual ErpBox? InBox { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryReceiptItem? InventoryReceiptItem { get; set; }
        public virtual ErpInventoryReceiptShipment? InventoryReceiptShipment { get; set; }
        public virtual ErpOrderReceiptItem? OrderReceiptItem { get; set; }
        public virtual ErpInventorySerialCard? SerialCard { get; set; }
        public virtual ICollection<ErpBoxItemVariant> ErpBoxItemVariants { get; set; }
        public virtual ICollection<ErpInventoryReceiptShipment> ErpInventoryReceiptShipments { get; set; }
    }
}
