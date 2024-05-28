using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmEmployeeLeave
    {
        public long RecId { get; set; }
        public long? EmployeeId { get; set; }
        public int? CompanyId { get; set; }
        public byte? LeaveDays { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? LeaveAddress { get; set; }
        public short? LeaveYear { get; set; }
        public short? LeaveMonth { get; set; }
        public DateTime? RequestedAt { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public long? ApprovedBy { get; set; }
        public int? LeaveTypeId { get; set; }
        public string? Explanation { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? LeaveTime { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpEmployee? ApprovedByNavigation { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual HrmLeaveType? LeaveType { get; set; }
    }
}
