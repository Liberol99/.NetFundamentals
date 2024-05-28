using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryAlternative
    {
        public long RecId { get; set; }
        public long? InventoryId { get; set; }
        public long? AlternativeId { get; set; }
        public decimal? Factor { get; set; }
        public decimal? Divisor { get; set; }
        public decimal? WasteRate { get; set; }
        public short? Priority { get; set; }
        public int? UnitId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpInventory? Alternative { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryUnitItemSize? Unit { get; set; }
    }
}
