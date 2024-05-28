using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpMaterialRequirement
    {
        public ErpMaterialRequirement()
        {
            ErpMaterialRequirementDetails = new HashSet<ErpMaterialRequirementDetail>();
            ErpMaterialRequirementItems = new HashSet<ErpMaterialRequirementItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? RequirementType { get; set; }
        public string? RequirementCode { get; set; }
        public string? RequirementName { get; set; }
        public string? Explanation { get; set; }
        public string? Options { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpMaterialRequirementDetail> ErpMaterialRequirementDetails { get; set; }
        public virtual ICollection<ErpMaterialRequirementItem> ErpMaterialRequirementItems { get; set; }
    }
}
