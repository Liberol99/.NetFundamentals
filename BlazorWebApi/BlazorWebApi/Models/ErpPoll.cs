using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPoll
    {
        public ErpPoll()
        {
            ErpEducations = new HashSet<ErpEducation>();
            ErpInventories = new HashSet<ErpInventory>();
            ErpPollAnswers = new HashSet<ErpPollAnswer>();
            ErpPollQuestions = new HashSet<ErpPollQuestion>();
            ErpPollUserAnswers = new HashSet<ErpPollUserAnswer>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public byte? PollType { get; set; }
        public string? PollCode { get; set; }
        public string? Caption { get; set; }
        public string? Explanation { get; set; }
        public byte? NotificationType { get; set; }
        public long? Effort { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? ListContent { get; set; }
        public string? Content { get; set; }
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
        public string? WorkplaceIds { get; set; }
        public string? DepartmentIds { get; set; }
        public string? UserIds { get; set; }
        public string? UserGroupIds { get; set; }
        public byte[]? PollGraphic { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpEducation> ErpEducations { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpPollAnswer> ErpPollAnswers { get; set; }
        public virtual ICollection<ErpPollQuestion> ErpPollQuestions { get; set; }
        public virtual ICollection<ErpPollUserAnswer> ErpPollUserAnswers { get; set; }
    }
}
