using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryReceiptShipment
    {
        public ErpInventoryReceiptShipment()
        {
            ErpBoxItemVariants = new HashSet<ErpBoxItemVariant>();
            ErpBoxItems = new HashSet<ErpBoxItem>();
            ErpBoxes = new HashSet<ErpBox>();
        }

        public long RecId { get; set; }
        public long? InventoryReceiptItemId { get; set; }
        public long? InventoryReceiptItemVariantId { get; set; }
        public int? WarehouseLocationId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public long? BoxId { get; set; }
        public long? BoxItemId { get; set; }
        public long? SerialCardId { get; set; }
        public long? EmployeeId { get; set; }
        public byte? IsReceiptCreated { get; set; }
        public int? VehicleId { get; set; }
        public int? ItemOrderNo { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? ShipmentQuantity { get; set; }
        public decimal? BoxedQuantity { get; set; }
        public int? PackageNo { get; set; }
        public decimal? PackageQuantity { get; set; }

        public virtual ErpBox? Box { get; set; }
        public virtual ErpBoxItem? BoxItem { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryReceiptItem? InventoryReceiptItem { get; set; }
        public virtual ErpInventoryReceiptItemVariant? InventoryReceiptItemVariant { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpInventorySerialCard? SerialCard { get; set; }
        public virtual ErpVehicle? Vehicle { get; set; }
        public virtual ErpWarehouseLocation? WarehouseLocation { get; set; }
        public virtual ICollection<ErpBoxItemVariant> ErpBoxItemVariants { get; set; }
        public virtual ICollection<ErpBoxItem> ErpBoxItems { get; set; }
        public virtual ICollection<ErpBox> ErpBoxes { get; set; }
    }
}
