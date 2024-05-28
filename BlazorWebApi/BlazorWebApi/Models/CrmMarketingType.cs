using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class CrmMarketingType
    {
        public CrmMarketingType()
        {
            CrmMarketingActivities = new HashSet<CrmMarketingActivity>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? TypeName { get; set; }
        public string? Explanation { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<CrmMarketingActivity> CrmMarketingActivities { get; set; }
    }
}
