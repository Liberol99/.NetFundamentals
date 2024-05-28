using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaSchedule
    {
        public MetaSchedule()
        {
            ErpTasks = new HashSet<ErpTask>();
            MetaMessages = new HashSet<MetaMessage>();
        }

        public int RecId { get; set; }
        public string? ScheduleCode { get; set; }
        public string? ScheduleName { get; set; }
        public string? Explanation { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short? ScheduleType { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public short? Period { get; set; }
        public short? DayInterval { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ICollection<ErpTask> ErpTasks { get; set; }
        public virtual ICollection<MetaMessage> MetaMessages { get; set; }
    }
}
