using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryWarehouse
    {
        public long RecId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public int? WarehouseId { get; set; }
        public int? DefaultWarehouseLocationId { get; set; }
        public decimal? OptimumQuantity { get; set; }
        public decimal? MinimumQuantity { get; set; }
        public decimal? MinimumOrderQuantity { get; set; }
        public byte? ControlType { get; set; }
        public byte? McontrolType { get; set; }
        public byte? OptimumControlType { get; set; }
        public byte? IsAction { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? LocationControlType { get; set; }

        public virtual ErpWarehouseLocation? DefaultWarehouseLocation { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
    }
}
