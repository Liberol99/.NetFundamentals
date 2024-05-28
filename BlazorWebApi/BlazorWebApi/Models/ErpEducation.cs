using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpEducation
    {
        public ErpEducation()
        {
            ErpEducationAttachments = new HashSet<ErpEducationAttachment>();
            ErpEducationStudents = new HashSet<ErpEducationStudent>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? EducationCode { get; set; }
        public string? Caption { get; set; }
        public string? Explanation { get; set; }
        public byte? NotificationType { get; set; }
        public DateTime? IssueAt { get; set; }
        public byte? InUse { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }
        public byte? IsExamination { get; set; }
        public long? PollId { get; set; }
        public string? ExaminationExplanation { get; set; }
        public byte? IsCertification { get; set; }
        public string? CertificationExplanation { get; set; }
        public string? WorkplaceIds { get; set; }
        public string? DepartmentIds { get; set; }
        public string? UserIds { get; set; }
        public string? UserGroupIds { get; set; }
        public short? StudentCount { get; set; }
        public int? TeacherId { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpPoll? Poll { get; set; }
        public virtual MetaUser? Teacher { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpEducationAttachment> ErpEducationAttachments { get; set; }
        public virtual ICollection<ErpEducationStudent> ErpEducationStudents { get; set; }
    }
}
