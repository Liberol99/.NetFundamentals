using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBoxItemVariant
    {
        public long RecId { get; set; }
        public long? BoxItemId { get; set; }
        public long? InventoryVariantId { get; set; }
        public long? SerialCardId { get; set; }
        public long? InventoryReceiptShipmentId { get; set; }
        public long? OrderReceiptItemVariantId { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public long? InventoryReceiptItemVariantId { get; set; }

        public virtual ErpBoxItem? BoxItem { get; set; }
        public virtual ErpInventoryReceiptItemVariant? InventoryReceiptItemVariant { get; set; }
        public virtual ErpInventoryReceiptShipment? InventoryReceiptShipment { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpOrderReceiptItemVariant? OrderReceiptItemVariant { get; set; }
        public virtual ErpInventorySerialCard? SerialCard { get; set; }
    }
}
