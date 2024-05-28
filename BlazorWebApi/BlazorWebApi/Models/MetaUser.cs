using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaUser
    {
        public MetaUser()
        {
            ErpAddresses = new HashSet<ErpAddress>();
            ErpApprovedTransactions = new HashSet<ErpApprovedTransaction>();
            ErpCurrentAccountContacts = new HashSet<ErpCurrentAccountContact>();
            ErpEducationStudents = new HashSet<ErpEducationStudent>();
            ErpEducations = new HashSet<ErpEducation>();
            ErpInventoryCampaignItems = new HashSet<ErpInventoryCampaignItem>();
            ErpInventoryCampaigns = new HashSet<ErpInventoryCampaign>();
            ErpNotificationItems = new HashSet<ErpNotificationItem>();
            ErpPollAnswers = new HashSet<ErpPollAnswer>();
            ErpPollUserAnswers = new HashSet<ErpPollUserAnswer>();
            ErpSubscriptions = new HashSet<ErpSubscription>();
            ErpTasks = new HashSet<ErpTask>();
            ErpWorkFlowCardItems = new HashSet<ErpWorkFlowCardItem>();
            InverseRole = new HashSet<MetaUser>();
            LicenseActiveUsers = new HashSet<LicenseActiveUser>();
            MetaMessageMessageFromUsers = new HashSet<MetaMessage>();
            MetaMessageMessageToUsers = new HashSet<MetaMessage>();
            MetaPresets = new HashSet<MetaPreset>();
            MetaReports = new HashSet<MetaReport>();
            MetaResourceUserRoles = new HashSet<MetaResource>();
            MetaResourceUsers = new HashSet<MetaResource>();
            MetaUserAccesses = new HashSet<MetaUserAccess>();
            MetaUserAttachments = new HashSet<MetaUserAttachment>();
            MetaUserCompanies = new HashSet<MetaUserCompany>();
            MetaUserGroupItems = new HashSet<MetaUserGroupItem>();
            MetaUserHistories = new HashSet<MetaUserHistory>();
            MetaUserRights = new HashSet<MetaUserRight>();
            MetaUserRoleRoles = new HashSet<MetaUserRole>();
            MetaUserRoleUsers = new HashSet<MetaUserRole>();
            MetaWindowSettings = new HashSet<MetaWindowSetting>();
        }

        public int RecId { get; set; }
        public string? UserCode { get; set; }
        public string? UserName { get; set; }
        public string? EntryCode { get; set; }
        public string? Password { get; set; }
        public int? RoleId { get; set; }
        public long? EmployeeId { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? CashId { get; set; }
        public int? DepartmentId { get; set; }
        public int? CostCenterId { get; set; }
        public string? Email { get; set; }
        public string? EmailPassword { get; set; }
        public string? EmailServerName { get; set; }
        public int? EmailPort { get; set; }
        public byte? EmailSsl { get; set; }
        public byte? EmailAuthenticateMode { get; set; }
        public short? SslsecurityProtocol { get; set; }
        public short? LanguageCode { get; set; }
        public byte? IsSeller { get; set; }
        public byte? IsCashier { get; set; }
        public byte? IsUserRole { get; set; }
        public byte? ShowUserLoginScreen { get; set; }
        public byte? EmailAlwaysAddBcc { get; set; }
        public string? EmailReplyTo { get; set; }
        public byte? InUse { get; set; }
        public string? IpMin { get; set; }
        public string? IpMax { get; set; }
        public string? MacAddress { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public byte? WorkDays { get; set; }
        public byte? ControlCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? PwdChangeAfterUse { get; set; }
        public short? PasswordExpiration { get; set; }
        public DateTime? PasswordDate { get; set; }
        public short? PasswordChangeRange { get; set; }
        public byte[]? Startup { get; set; }
        public byte? WhenStartupCloseAppClose { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public short? PasswordPolicyType { get; set; }
        public byte? AllowSms { get; set; }
        public byte? AllowEmail { get; set; }
        public byte? AllowNotify { get; set; }
        public string? Phone { get; set; }
        public string? GsmPhone { get; set; }
        public byte? IsHrmuser { get; set; }
        public int? ApplicationCloseTime { get; set; }
        public int? SessionCloseTime { get; set; }
        public string? OnDemandDashboardDefinition { get; set; }
        public byte? IsOpenDashboard { get; set; }
        public byte? RetailAppType { get; set; }
        public string? SpecialCode { get; set; }

        public virtual ErpCash? Cash { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual MetaUser? Role { get; set; }
        public virtual ICollection<ErpAddress> ErpAddresses { get; set; }
        public virtual ICollection<ErpApprovedTransaction> ErpApprovedTransactions { get; set; }
        public virtual ICollection<ErpCurrentAccountContact> ErpCurrentAccountContacts { get; set; }
        public virtual ICollection<ErpEducationStudent> ErpEducationStudents { get; set; }
        public virtual ICollection<ErpEducation> ErpEducations { get; set; }
        public virtual ICollection<ErpInventoryCampaignItem> ErpInventoryCampaignItems { get; set; }
        public virtual ICollection<ErpInventoryCampaign> ErpInventoryCampaigns { get; set; }
        public virtual ICollection<ErpNotificationItem> ErpNotificationItems { get; set; }
        public virtual ICollection<ErpPollAnswer> ErpPollAnswers { get; set; }
        public virtual ICollection<ErpPollUserAnswer> ErpPollUserAnswers { get; set; }
        public virtual ICollection<ErpSubscription> ErpSubscriptions { get; set; }
        public virtual ICollection<ErpTask> ErpTasks { get; set; }
        public virtual ICollection<ErpWorkFlowCardItem> ErpWorkFlowCardItems { get; set; }
        public virtual ICollection<MetaUser> InverseRole { get; set; }
        public virtual ICollection<LicenseActiveUser> LicenseActiveUsers { get; set; }
        public virtual ICollection<MetaMessage> MetaMessageMessageFromUsers { get; set; }
        public virtual ICollection<MetaMessage> MetaMessageMessageToUsers { get; set; }
        public virtual ICollection<MetaPreset> MetaPresets { get; set; }
        public virtual ICollection<MetaReport> MetaReports { get; set; }
        public virtual ICollection<MetaResource> MetaResourceUserRoles { get; set; }
        public virtual ICollection<MetaResource> MetaResourceUsers { get; set; }
        public virtual ICollection<MetaUserAccess> MetaUserAccesses { get; set; }
        public virtual ICollection<MetaUserAttachment> MetaUserAttachments { get; set; }
        public virtual ICollection<MetaUserCompany> MetaUserCompanies { get; set; }
        public virtual ICollection<MetaUserGroupItem> MetaUserGroupItems { get; set; }
        public virtual ICollection<MetaUserHistory> MetaUserHistories { get; set; }
        public virtual ICollection<MetaUserRight> MetaUserRights { get; set; }
        public virtual ICollection<MetaUserRole> MetaUserRoleRoles { get; set; }
        public virtual ICollection<MetaUserRole> MetaUserRoleUsers { get; set; }
        public virtual ICollection<MetaWindowSetting> MetaWindowSettings { get; set; }
    }
}
