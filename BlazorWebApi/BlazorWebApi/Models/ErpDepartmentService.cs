using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDepartmentService
    {
        public int RecId { get; set; }
        public int? DepartmentId { get; set; }
        public long? ServiceId { get; set; }
        public string? Explanation { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public short? WeekDays { get; set; }
        public short? ServiceDuration { get; set; }
        public byte? ServiceDurationUnit { get; set; }
        public byte[]? Condition { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpService? Service { get; set; }
    }
}
