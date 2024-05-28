using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpFixedAssetDepreciation
    {
        public long RecId { get; set; }
        public long? InventoryId { get; set; }
        public int? DepreciationYear { get; set; }
        public byte? Period { get; set; }
        public byte? Type { get; set; }
        public decimal? Rate { get; set; }
        public decimal? DepreciationRate { get; set; }
        public decimal? AccumulatedAmount { get; set; }
        public decimal? RevaluatedAmount { get; set; }
        public decimal? RevaluatedExpenseAmount { get; set; }
        public decimal? CurrentValue { get; set; }
        public decimal? CurrentDepreciationAmount { get; set; }
        public decimal? PartianDepreciationRemainder { get; set; }
        public decimal? PreviousDepreciationAmount { get; set; }
        public decimal? CurrentYearDepreciationAmount { get; set; }
        public decimal? TotalAccumulatedDepreciationAmount { get; set; }
        public decimal? AppreciationAmount { get; set; }
        public decimal? RevaluationRate { get; set; }
        public decimal? RevaluationPurchaseCost { get; set; }
        public decimal? RevaluationAccumulatedAmount { get; set; }
        public decimal? RevaluationNetAmount { get; set; }
        public decimal? RevaluationAppreciationAmount { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public decimal? RevaluationRate298c { get; set; }
        public decimal? RevaluationPurchaseCost298c { get; set; }
        public decimal? RevaluationAccumulatedAmount298c { get; set; }
        public decimal? RevaluationNetAmount298c { get; set; }
        public decimal? RevaluationAppreciationAmount298c { get; set; }
        public byte? RevaluationBeConsidered { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
    }
}
