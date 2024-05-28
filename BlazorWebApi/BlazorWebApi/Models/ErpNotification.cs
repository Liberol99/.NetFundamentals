using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpNotification
    {
        public ErpNotification()
        {
            ErpNews = new HashSet<ErpNews>();
            ErpNotificationItems = new HashSet<ErpNotificationItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? NotificationCode { get; set; }
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
        public int? IssueBy { get; set; }
        public byte? NotifyChannel { get; set; }
        public string? FormFieldName { get; set; }
        public string? FormFormDef { get; set; }
        public long? TemplateId { get; set; }
        public short? SenderType { get; set; }
        public string? ExternalMailType { get; set; }
        public string? ContactWhereStr { get; set; }
        public string? CcMailAddresses { get; set; }
        public string? BccMailAddresses { get; set; }
        public string? CommandDetail { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpNews> ErpNews { get; set; }
        public virtual ICollection<ErpNotificationItem> ErpNotificationItems { get; set; }
    }
}
