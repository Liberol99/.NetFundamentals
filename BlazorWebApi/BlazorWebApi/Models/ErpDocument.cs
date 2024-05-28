using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDocument
    {
        public ErpDocument()
        {
            ErpDocumentAttachments = new HashSet<ErpDocumentAttachment>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? DepartmentId { get; set; }
        public string? DocumentNo { get; set; }
        public string? Explanation { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpDocumentAttachment> ErpDocumentAttachments { get; set; }
    }
}
