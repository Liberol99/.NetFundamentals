using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryGroup
    {
        public ErpInventoryGroup()
        {
            ErpBudgetItems = new HashSet<ErpBudgetItem>();
            ErpGiftVoucherDepts = new HashSet<ErpGiftVoucherDept>();
            ErpGiftVoucherTypeDepts = new HashSet<ErpGiftVoucherTypeDept>();
            ErpInventories = new HashSet<ErpInventory>();
            ErpInventoryAttributeSets = new HashSet<ErpInventoryAttributeSet>();
            ErpInventoryAttributes = new HashSet<ErpInventoryAttribute>();
            ErpInventoryCampaignItems = new HashSet<ErpInventoryCampaignItem>();
            ErpInventoryGroupIas = new HashSet<ErpInventoryGroupIa>();
            ErpInventoryMargins = new HashSet<ErpInventoryMargin>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpParameterBonus = new HashSet<ErpParameterBonu>();
            ErpProcessResources = new HashSet<ErpProcessResource>();
            ErpRecipes = new HashSet<ErpRecipe>();
            ErpResourceInventories = new HashSet<ErpResourceInventory>();
            PosMenuItems = new HashSet<PosMenuItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? GroupCode { get; set; }
        public string? GroupName { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public string? ShortCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? IsFixedAssetGroup { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpBudgetItem> ErpBudgetItems { get; set; }
        public virtual ICollection<ErpGiftVoucherDept> ErpGiftVoucherDepts { get; set; }
        public virtual ICollection<ErpGiftVoucherTypeDept> ErpGiftVoucherTypeDepts { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpInventoryAttributeSet> ErpInventoryAttributeSets { get; set; }
        public virtual ICollection<ErpInventoryAttribute> ErpInventoryAttributes { get; set; }
        public virtual ICollection<ErpInventoryCampaignItem> ErpInventoryCampaignItems { get; set; }
        public virtual ICollection<ErpInventoryGroupIa> ErpInventoryGroupIas { get; set; }
        public virtual ICollection<ErpInventoryMargin> ErpInventoryMargins { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpParameterBonu> ErpParameterBonus { get; set; }
        public virtual ICollection<ErpProcessResource> ErpProcessResources { get; set; }
        public virtual ICollection<ErpRecipe> ErpRecipes { get; set; }
        public virtual ICollection<ErpResourceInventory> ErpResourceInventories { get; set; }
        public virtual ICollection<PosMenuItem> PosMenuItems { get; set; }
    }
}
