using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpSeason
    {
        public ErpSeason()
        {
            ErpInventories = new HashSet<ErpInventory>();
            ErpInventoryCampaignItems = new HashSet<ErpInventoryCampaignItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? SeasonName { get; set; }
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

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpInventoryCampaignItem> ErpInventoryCampaignItems { get; set; }
    }
}
