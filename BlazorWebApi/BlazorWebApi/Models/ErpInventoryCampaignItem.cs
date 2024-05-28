using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryCampaignItem
    {
        public long RecId { get; set; }
        public long? CampaignId { get; set; }
        public long? InventoryId { get; set; }
        public long? GroupId { get; set; }
        public string? GroupSpecialCode { get; set; }
        public int? CategoryId { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? CurrentAccountGroupId { get; set; }
        public int? CurrentAccountCategoryId { get; set; }
        public long? MarkId { get; set; }
        public long? ModelId { get; set; }
        public long? SeasonId { get; set; }
        public string? SeasonCode { get; set; }
        public string? CampaignGroup { get; set; }
        public string? PriceGroup { get; set; }
        public int? VariantTypeId { get; set; }
        public int? VariantId { get; set; }
        public byte[]? Condition { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? PromotionQuantity { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Price { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountMin { get; set; }
        public decimal? AmountMax { get; set; }
        public long? PromotionAttributeSetItemId { get; set; }
        public short? ItemNo { get; set; }
        public string? Explanation { get; set; }
        public byte? IsMain { get; set; }
        public byte? IsSameProduct { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? UserId { get; set; }

        public virtual ErpInventoryCampaign? Campaign { get; set; }
        public virtual ErpCategory? Category { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpCurrentAccountCategory? CurrentAccountCategory { get; set; }
        public virtual ErpCurrentAccountGroup? CurrentAccountGroup { get; set; }
        public virtual ErpInventoryGroup? Group { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpMark? Mark { get; set; }
        public virtual ErpModel? Model { get; set; }
        public virtual ErpInventoryAttributeSetItem? PromotionAttributeSetItem { get; set; }
        public virtual ErpSeason? Season { get; set; }
        public virtual MetaUser? User { get; set; }
        public virtual ErpVariantItem? Variant { get; set; }
        public virtual ErpVariantType? VariantType { get; set; }
    }
}
