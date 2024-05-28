using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpResourceOutOfUseReason
    {
        public ErpResourceOutOfUseReason()
        {
            ErpPlannings = new HashSet<ErpPlanning>();
            ErpProcessResources = new HashSet<ErpProcessResource>();
            ErpResourceOutOfUses = new HashSet<ErpResourceOutOfUse>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? ResourceType { get; set; }
        public string? ReasonCode { get; set; }
        public string? Explanation { get; set; }
        public short? ProcessType { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpPlanning> ErpPlannings { get; set; }
        public virtual ICollection<ErpProcessResource> ErpProcessResources { get; set; }
        public virtual ICollection<ErpResourceOutOfUse> ErpResourceOutOfUses { get; set; }
    }
}
