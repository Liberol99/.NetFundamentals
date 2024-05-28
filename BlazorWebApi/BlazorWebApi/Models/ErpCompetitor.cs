using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCompetitor
    {
        public ErpCompetitor()
        {
            CrmLeads = new HashSet<CrmLead>();
            ErpCompetitorProducts = new HashSet<ErpCompetitorProduct>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? CompetitorCode { get; set; }
        public string? CompetitorName { get; set; }
        public string? Explanation { get; set; }
        public int? SectorId { get; set; }
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

        public virtual ErpCompany? Company { get; set; }
        public virtual MetaSector? Sector { get; set; }
        public virtual ICollection<CrmLead> CrmLeads { get; set; }
        public virtual ICollection<ErpCompetitorProduct> ErpCompetitorProducts { get; set; }
    }
}
