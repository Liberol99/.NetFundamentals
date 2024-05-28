using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryCampaignPromotion
    {
        public long RecId { get; set; }
        public string? PromotionCode { get; set; }
        public string? Explanation { get; set; }
        public long? InventoryCampaignId { get; set; }
        public long? CurrentAccountId { get; set; }
        public string? Phone { get; set; }
        public string? EmailAddress { get; set; }
        public int? UsedQuantity { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpInventoryCampaign? InventoryCampaign { get; set; }
    }
}
