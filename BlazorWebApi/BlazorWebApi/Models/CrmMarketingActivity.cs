using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class CrmMarketingActivity
    {
        public CrmMarketingActivity()
        {
            CrmLeads = new HashSet<CrmLead>();
            CrmMarketingActivityAttachments = new HashSet<CrmMarketingActivityAttachment>();
            CrmMarketingActivityProducts = new HashSet<CrmMarketingActivityProduct>();
            CrmMarketingActivityResources = new HashSet<CrmMarketingActivityResource>();
            ErpCustomerTransactions = new HashSet<ErpCustomerTransaction>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public long? MarketingTypeId { get; set; }
        public string? ActivityCode { get; set; }
        public string? Explanation { get; set; }
        public short? ActivityType { get; set; }
        public int? SectorId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? TerritoryId { get; set; }
        public decimal? QuotedQuantity { get; set; }
        public decimal? QuotedAmount { get; set; }
        public int? ForexId { get; set; }
        public decimal? BudgetAmount { get; set; }
        public int? BudgetForexId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaForex? BudgetForex { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual CrmMarketingType? MarketingType { get; set; }
        public virtual MetaSector? Sector { get; set; }
        public virtual CrmTerritory? Territory { get; set; }
        public virtual ICollection<CrmLead> CrmLeads { get; set; }
        public virtual ICollection<CrmMarketingActivityAttachment> CrmMarketingActivityAttachments { get; set; }
        public virtual ICollection<CrmMarketingActivityProduct> CrmMarketingActivityProducts { get; set; }
        public virtual ICollection<CrmMarketingActivityResource> CrmMarketingActivityResources { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactions { get; set; }
    }
}
