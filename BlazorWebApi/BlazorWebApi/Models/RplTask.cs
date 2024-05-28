using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class RplTask
    {
        public RplTask()
        {
            RplTaskItems = new HashSet<RplTaskItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? Type { get; set; }
        public byte? Direction { get; set; }
        public string? Explanation { get; set; }
        public DateTime? ExecuteDate { get; set; }
        public DateTime? ExecuteTime { get; set; }
        public byte? Priority { get; set; }
        public byte? IsCompleted { get; set; }
        public byte? IsFailed { get; set; }
        public string? Result { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public string? SourceTaskKey { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<RplTaskItem> RplTaskItems { get; set; }
    }
}
