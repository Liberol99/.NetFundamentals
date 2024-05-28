using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryWorkStudy
    {
        public long RecId { get; set; }
        public long? InventoryId { get; set; }
        public int? ProcessId { get; set; }
        public long? ResourceId { get; set; }
        public int? ItemOrderNo { get; set; }
        public byte? ProductionType { get; set; }
        public byte? ProductionSubType { get; set; }
        public int? ProductionProcessId { get; set; }
        public byte? ProductionInOut { get; set; }
        public int? Variant1Id { get; set; }
        public int? Variant2Id { get; set; }
        public decimal? Quantity { get; set; }
        public string? Segment { get; set; }
        public decimal? StandartTime1 { get; set; }
        public decimal? StandartTime2 { get; set; }
        public decimal? StandartTime3 { get; set; }
        public decimal? StandartTimeActual { get; set; }
        public decimal? StandartTimeInitial { get; set; }
        public decimal? StandartTimeDistribution { get; set; }
        public decimal? ScissorsCount { get; set; }
        public long? CurrentAccountId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpProcess? ProductionProcess { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpVariantItem? Variant1 { get; set; }
        public virtual ErpVariantItem? Variant2 { get; set; }
    }
}
