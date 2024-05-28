using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCategory
    {
        public ErpCategory()
        {
            ErpBudgetItems = new HashSet<ErpBudgetItem>();
            ErpDepartmentCapacities = new HashSet<ErpDepartmentCapacity>();
            ErpInventories = new HashSet<ErpInventory>();
            ErpInventoryCampaignItems = new HashSet<ErpInventoryCampaignItem>();
            ErpInventoryMargins = new HashSet<ErpInventoryMargin>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpRecipes = new HashSet<ErpRecipe>();
            ErpServices = new HashSet<ErpService>();
            InverseParent = new HashSet<ErpCategory>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryName2 { get; set; }
        public int? ParentId { get; set; }
        public short? ItemOrderNo { get; set; }
        public string? ShortCode { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCategory? Parent { get; set; }
        public virtual ICollection<ErpBudgetItem> ErpBudgetItems { get; set; }
        public virtual ICollection<ErpDepartmentCapacity> ErpDepartmentCapacities { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpInventoryCampaignItem> ErpInventoryCampaignItems { get; set; }
        public virtual ICollection<ErpInventoryMargin> ErpInventoryMargins { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpRecipe> ErpRecipes { get; set; }
        public virtual ICollection<ErpService> ErpServices { get; set; }
        public virtual ICollection<ErpCategory> InverseParent { get; set; }
    }
}
