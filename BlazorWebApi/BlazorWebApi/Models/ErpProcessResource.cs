using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpProcessResource
    {
        public int RecId { get; set; }
        public int? ProcessId { get; set; }
        public long? ResourceId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryGroupId { get; set; }
        public int? TimeUnit { get; set; }
        public int? SetupTime { get; set; }
        public int? ProcessTime { get; set; }
        public int? PreProcessTime { get; set; }
        public int? PostProcessTime { get; set; }
        public int? Qctime { get; set; }
        public decimal? LotQuantity { get; set; }
        public decimal? MinimumQuantity { get; set; }
        public decimal? MaximumQuantity { get; set; }
        public byte[]? Condition { get; set; }
        public string? SpecialCode { get; set; }
        public byte? SetupOnlyAnotherProcess { get; set; }
        public byte? SetupOnlyAnotherGroup { get; set; }
        public byte? SetupOnlyAnotherInventory { get; set; }
        public int? SetupReasonId { get; set; }
        public string? ProcessParameters { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? Speed { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryGroup? InventoryGroup { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpResourceOutOfUseReason? SetupReason { get; set; }
    }
}
