using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class CrmStatus
    {
        public CrmStatus()
        {
            CrmLeads = new HashSet<CrmLead>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? StatusName { get; set; }
        public string? Explanation { get; set; }
        public string? GroupCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<CrmLead> CrmLeads { get; set; }
    }
}
