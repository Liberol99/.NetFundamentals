using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryMargin
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public long? InventoryId { get; set; }
        public string? InventorySpecial { get; set; }
        public long? InventoryGroupId { get; set; }
        public int? InventoryCategoryId { get; set; }
        public long? InventoryMarkId { get; set; }
        public long? InventoryModelId { get; set; }
        public string? InventoryPriceGroup { get; set; }
        public string? InventoryCampaignCode { get; set; }
        public string? InventorySeasonCode { get; set; }
        public long? CurrAccId { get; set; }
        public string? CurrAccSpecial { get; set; }
        public long? CurrAccGroupId { get; set; }
        public int? CurrAccTradingGroupId { get; set; }
        public string? CurrAccDiscountGroup { get; set; }
        public string? CurrAccPriceGroup { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Explanation { get; set; }
        public decimal? Margin { get; set; }
        public string? Formula { get; set; }
        public byte[]? Condition { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrAcc { get; set; }
        public virtual ErpCurrentAccountGroup? CurrAccGroup { get; set; }
        public virtual ErpTradingGroup? CurrAccTradingGroup { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpCategory? InventoryCategory { get; set; }
        public virtual ErpInventoryGroup? InventoryGroup { get; set; }
        public virtual ErpMark? InventoryMark { get; set; }
        public virtual ErpModel? InventoryModel { get; set; }
    }
}
