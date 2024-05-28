using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWarehouseLocationTotal
    {
        public long RecId { get; set; }
        public int? WarehouseLocationId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? PlannedQuantity { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpWarehouseLocation? WarehouseLocation { get; set; }
    }
}
