using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmLeaveType
    {
        public HrmLeaveType()
        {
            HrmEmployeeLeaves = new HashSet<HrmEmployeeLeave>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? LeaveTypeCode { get; set; }
        public string? Explanation { get; set; }
        public int? TimeId { get; set; }
        public byte? UseForChecking { get; set; }
        public byte? IsEntitlement { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? MaxDay { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual HrmTime? Time { get; set; }
        public virtual ICollection<HrmEmployeeLeave> HrmEmployeeLeaves { get; set; }
    }
}
