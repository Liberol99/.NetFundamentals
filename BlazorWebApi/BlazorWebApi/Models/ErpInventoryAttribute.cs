using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryAttribute
    {
        public long RecId { get; set; }
        public long? InventoryId { get; set; }
        public long? GroupId { get; set; }
        public int? AttributeSetId { get; set; }
        public long? AttributeSetItemId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpInventoryAttributeSet? AttributeSet { get; set; }
        public virtual ErpInventoryAttributeSetItem? AttributeSetItem { get; set; }
        public virtual ErpInventoryGroup? Group { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
    }
}
