using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWorkOrderProductionVariant
    {
        public long RecId { get; set; }
        public long? WorkOrderProductionId { get; set; }
        public long? InventoryId { get; set; }
        public long? WorkOrderItemVariantId { get; set; }
        public int? SubNo { get; set; }
        public decimal? Quantity { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? InsertedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpWorkOrderItemVariant? WorkOrderItemVariant { get; set; }
        public virtual ErpWorkOrderProduction? WorkOrderProduction { get; set; }
    }
}
