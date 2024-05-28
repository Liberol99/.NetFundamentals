using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class CrmLead
    {
        public CrmLead()
        {
            CrmLeadAttachments = new HashSet<CrmLeadAttachment>();
            CrmLeadContacts = new HashSet<CrmLeadContact>();
            ErpAddresses = new HashSet<ErpAddress>();
            ErpCustomerTransactions = new HashSet<ErpCustomerTransaction>();
            ErpDemandReceipts = new HashSet<ErpDemandReceipt>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? LeadCode { get; set; }
        public string? LeadName { get; set; }
        public string? Explanation { get; set; }
        public byte? LeadType { get; set; }
        public long? MarketingActivityId { get; set; }
        public int? SectorId { get; set; }
        public long? InventoryId { get; set; }
        public long? ServiceId { get; set; }
        public long? ResourceId { get; set; }
        public int? CompetitorId { get; set; }
        public int? CompetitorProductId { get; set; }
        public int? StatusId { get; set; }
        public long? CurrentAccountId { get; set; }
        public decimal? TotalRevenue { get; set; }
        public int? NumberOfEmployees { get; set; }
        public int? NumberOfBranches { get; set; }
        public decimal? ExpectedRevenue { get; set; }
        public int? ForexId { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public short? Possibility { get; set; }
        public string? AccessCode { get; set; }
        public string? SpecialCode { get; set; }
        public string? Email { get; set; }
        public string? WebAddress { get; set; }
        public string? Blog { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public int? TaxOfficeId { get; set; }
        public string? TaxNo { get; set; }
        public byte? InUse { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCompetitor? Competitor { get; set; }
        public virtual ErpCompetitorProduct? CompetitorProduct { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual CrmMarketingActivity? MarketingActivity { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual MetaSector? Sector { get; set; }
        public virtual ErpService? Service { get; set; }
        public virtual CrmStatus? Status { get; set; }
        public virtual MetaTaxOffice? TaxOffice { get; set; }
        public virtual ICollection<CrmLeadAttachment> CrmLeadAttachments { get; set; }
        public virtual ICollection<CrmLeadContact> CrmLeadContacts { get; set; }
        public virtual ICollection<ErpAddress> ErpAddresses { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactions { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceipts { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
    }
}
