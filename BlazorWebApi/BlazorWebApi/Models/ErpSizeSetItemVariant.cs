using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpSizeSetItemVariant
    {
        public long RecId { get; set; }
        public long? SizeSetItemId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public int? VariantId { get; set; }
        public string? SizeDescription { get; set; }
        public string? SvalueText { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpSizeSetItem? SizeSetItem { get; set; }
        public virtual ErpVariantItem? Variant { get; set; }
    }
}
