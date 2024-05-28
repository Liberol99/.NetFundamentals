using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaSector
    {
        public MetaSector()
        {
            CrmLeads = new HashSet<CrmLead>();
            CrmMarketingActivities = new HashSet<CrmMarketingActivity>();
            ErpCompetitors = new HashSet<ErpCompetitor>();
            ErpCurrentAccounts = new HashSet<ErpCurrentAccount>();
            InverseParent = new HashSet<MetaSector>();
        }

        public int RecId { get; set; }
        public string? SectorName { get; set; }
        public byte? IsClass { get; set; }
        public int? ParentId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaSector? Parent { get; set; }
        public virtual ICollection<CrmLead> CrmLeads { get; set; }
        public virtual ICollection<CrmMarketingActivity> CrmMarketingActivities { get; set; }
        public virtual ICollection<ErpCompetitor> ErpCompetitors { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccounts { get; set; }
        public virtual ICollection<MetaSector> InverseParent { get; set; }
    }
}
