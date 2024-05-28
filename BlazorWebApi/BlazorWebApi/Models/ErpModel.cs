using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpModel
    {
        public ErpModel()
        {
            ErpContractItems = new HashSet<ErpContractItem>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpInventories = new HashSet<ErpInventory>();
            ErpInventoryCampaignItems = new HashSet<ErpInventoryCampaignItem>();
            ErpInventoryMargins = new HashSet<ErpInventoryMargin>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            ErpRecipes = new HashSet<ErpRecipe>();
        }

        public long RecId { get; set; }
        public long? MarkId { get; set; }
        public string? ModelName { get; set; }
        public string? Explanation { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public string? ShortCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpMark? Mark { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItems { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpInventoryCampaignItem> ErpInventoryCampaignItems { get; set; }
        public virtual ICollection<ErpInventoryMargin> ErpInventoryMargins { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpRecipe> ErpRecipes { get; set; }
    }
}
