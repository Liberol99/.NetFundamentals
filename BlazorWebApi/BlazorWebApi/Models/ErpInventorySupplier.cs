using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventorySupplier
    {
        public long RecId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public long? CurrentAccountId { get; set; }
        public byte? ItemType { get; set; }
        public int? ItemOrderNo { get; set; }
        public string? Explanation { get; set; }
        public decimal? SupplyRate { get; set; }
        public int? SupplyDay { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }
        public decimal? MinumumOrderQuantity { get; set; }
        public decimal? SupplyCoefficient { get; set; }
        public short? MergeTime { get; set; }
        public short? CurrentAccountStatus { get; set; }
        public int? ForexId { get; set; }
        public string? PriceCode { get; set; }
        public decimal? Price { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? EndTime { get; set; }
        public string? CrossInventoryCode { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
    }
}
