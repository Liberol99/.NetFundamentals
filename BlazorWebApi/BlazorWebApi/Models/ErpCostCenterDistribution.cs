using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCostCenterDistribution
    {
        public int RecId { get; set; }
        public long? InventoryId { get; set; }
        public long? ServiceId { get; set; }
        public int? CostCenterId { get; set; }
        public int? AccountId { get; set; }
        public long? GlreceiptId { get; set; }
        public long? GlreceiptItemId { get; set; }
        public string? Explanation { get; set; }
        public byte? DistributionType { get; set; }
        public decimal? DistributionRate { get; set; }
        public decimal? DistributionAmount { get; set; }
        public byte[]? Condition { get; set; }
        public short? SourceModule { get; set; }
        public long? SourceId { get; set; }
        public long? SourceItemId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? ItemType { get; set; }
        public int? DetailCostCenterId { get; set; }
        public byte? CostDistributionType { get; set; }
        public long? ResourceId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ProcessId { get; set; }

        public virtual ErpGlaccount? Account { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpCostCenter? DetailCostCenter { get; set; }
        public virtual ErpGlreceipt? Glreceipt { get; set; }
        public virtual ErpGlreceiptItem? GlreceiptItem { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpService? Service { get; set; }
    }
}
