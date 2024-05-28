using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCurrentAccountCategory
    {
        public ErpCurrentAccountCategory()
        {
            ErpCurrentAccounts = new HashSet<ErpCurrentAccount>();
            ErpInventoryCampaignItems = new HashSet<ErpInventoryCampaignItem>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            InverseParent = new HashSet<ErpCurrentAccountCategory>();
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
        public int? UpdateBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccountCategory? Parent { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccounts { get; set; }
        public virtual ICollection<ErpInventoryCampaignItem> ErpInventoryCampaignItems { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpCurrentAccountCategory> InverseParent { get; set; }
    }
}
