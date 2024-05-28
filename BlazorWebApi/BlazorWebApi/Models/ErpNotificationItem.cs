using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpNotificationItem
    {
        public long RecId { get; set; }
        public long? NotificationId { get; set; }
        public byte? UserType { get; set; }
        public int? UserId { get; set; }
        public int? UserGroupId { get; set; }
        public long? ContactId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? DepartmentId { get; set; }

        public virtual ErpCurrentAccountContact? Contact { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpNotification? Notification { get; set; }
        public virtual MetaUser? User { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
