using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpTestItem
    {
        public long RecId { get; set; }
        public long? TestId { get; set; }
        public long? InventoryId { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? InUse { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpTest? Test { get; set; }
    }
}
