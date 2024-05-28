using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpResourceInventory
    {
        public long RecId { get; set; }
        public byte? UsageType { get; set; }
        public long? ResourceId { get; set; }
        public string? Explanation { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryGroupId { get; set; }
        public decimal? Quantity { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryGroup? InventoryGroup { get; set; }
        public virtual ErpResource? Resource { get; set; }
    }
}
