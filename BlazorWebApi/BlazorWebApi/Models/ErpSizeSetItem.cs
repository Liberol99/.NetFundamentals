using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpSizeSetItem
    {
        public ErpSizeSetItem()
        {
            ErpSizeSetItemVariants = new HashSet<ErpSizeSetItemVariant>();
        }

        public long RecId { get; set; }
        public long? SizeSetId { get; set; }
        public long? InventoryId { get; set; }
        public byte? SizeSetType { get; set; }
        public long? SizeSetParameterId { get; set; }
        public string? Explanation { get; set; }
        public string? Shrinkage { get; set; }
        public string? SvalueText { get; set; }
        public decimal? ShrinkageWidth { get; set; }
        public decimal? ShrinkageLength { get; set; }
        public long? WorkOrderId { get; set; }
        public int? ProcessId { get; set; }
        public int? SubNo { get; set; }
        public int? ItemOrderNo { get; set; }
        public byte? IsPercentage { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpSizeSet? SizeSet { get; set; }
        public virtual ErpSizeSetParameter? SizeSetParameter { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ICollection<ErpSizeSetItemVariant> ErpSizeSetItemVariants { get; set; }
    }
}
