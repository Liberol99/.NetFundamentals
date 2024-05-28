using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpSubscription
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public byte? SubscriptionType { get; set; }
        public string? Name { get; set; }
        public string? Explanation { get; set; }
        public byte[]? Content { get; set; }
        public string? ContentUrl { get; set; }
        public string? ContentFullPath { get; set; }
        public string? SpecialCode { get; set; }
        public string? Email { get; set; }
        public string? WorkPhone { get; set; }
        public string? HomePhone { get; set; }
        public string? MobilePhone { get; set; }
        public string? WorkAddress { get; set; }
        public string? HomeAddress { get; set; }
        public string? CompanyName { get; set; }
        public string? Industry { get; set; }
        public string? WebAddress { get; set; }
        public byte? EmailNotification { get; set; }
        public byte? SmsNotification { get; set; }
        public byte? PushNotification { get; set; }
        public byte? AllowMarketing { get; set; }
        public byte? AllowSupport { get; set; }
        public byte? AllowInformation { get; set; }
        public int? UserId { get; set; }
        public long? ContactId { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccountContact? Contact { get; set; }
        public virtual MetaUser? User { get; set; }
    }
}
