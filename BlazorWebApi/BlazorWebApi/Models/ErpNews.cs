using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpNews
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? NewsCode { get; set; }
        public string? Caption { get; set; }
        public string? ShortExplanation { get; set; }
        public string? Explanation { get; set; }
        public long? NotificationId { get; set; }
        public byte? Notify { get; set; }
        public DateTime? IssueAt { get; set; }
        public string? VideoLink { get; set; }
        public string? ContentLink { get; set; }
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

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpNotification? Notification { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
