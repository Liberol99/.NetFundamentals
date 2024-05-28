using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmTime
    {
        public HrmTime()
        {
            HrmCheckingHours = new HashSet<HrmCheckingHour>();
            HrmLeaveTypes = new HashSet<HrmLeaveType>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? Type { get; set; }
        public string? TimeCode { get; set; }
        public string? Explanation { get; set; }
        public byte? IsOffDuty { get; set; }
        public byte? IsWaged { get; set; }
        public byte? IsDefaultOrFactor { get; set; }
        public decimal? DefaultValue { get; set; }
        public decimal? OvertimeRate { get; set; }
        public byte? EdeclarationType { get; set; }
        public string? TimeShortCode { get; set; }
        public int? ItemOrderNo { get; set; }
        public byte? IsShortTimeWorking { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<HrmCheckingHour> HrmCheckingHours { get; set; }
        public virtual ICollection<HrmLeaveType> HrmLeaveTypes { get; set; }
    }
}
