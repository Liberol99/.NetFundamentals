using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryCampaign
    {
        public ErpInventoryCampaign()
        {
            ErpGiftVoucherTypes = new HashSet<ErpGiftVoucherType>();
            ErpInventoryCampaignDepartments = new HashSet<ErpInventoryCampaignDepartment>();
            ErpInventoryCampaignItems = new HashSet<ErpInventoryCampaignItem>();
            ErpInventoryCampaignPromotions = new HashSet<ErpInventoryCampaignPromotion>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? CampaignCode { get; set; }
        public short? CampaignType { get; set; }
        public long? InventoryId { get; set; }
        public short? Priority { get; set; }
        public string? Explanation { get; set; }
        public decimal? LowerAmountLimit { get; set; }
        public byte? IsMultiple { get; set; }
        public byte? IsPromotionMultiple { get; set; }
        public byte? ApplyPromotionToMinPrice { get; set; }
        public byte? CampaignSuffrable { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public short? ValidDays { get; set; }
        public byte[]? Condition { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? IsProductPromotion { get; set; }
        public byte? OnlyFirstSale { get; set; }
        public int? UserId { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual MetaUser? User { get; set; }
        public virtual ICollection<ErpGiftVoucherType> ErpGiftVoucherTypes { get; set; }
        public virtual ICollection<ErpInventoryCampaignDepartment> ErpInventoryCampaignDepartments { get; set; }
        public virtual ICollection<ErpInventoryCampaignItem> ErpInventoryCampaignItems { get; set; }
        public virtual ICollection<ErpInventoryCampaignPromotion> ErpInventoryCampaignPromotions { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
    }
}
