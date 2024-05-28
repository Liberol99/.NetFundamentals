using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWorkOrderCostDistribution
    {
        public long RecId { get; set; }
        public long? WorkOrderId { get; set; }
        public long? InventoryId { get; set; }
        public short? CostType { get; set; }
        public short? CostYear { get; set; }
        public short? CostMonth { get; set; }
        public decimal? Amount { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexAmount { get; set; }
        public DateTime? CostDate { get; set; }
        public string? Explanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
    }
}
