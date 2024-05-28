using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class RplTaskTarget
    {
        public long RecId { get; set; }
        public long? TaskItem { get; set; }
        public int? Location { get; set; }
        public int? TryCount { get; set; }
        public int? ToCompanyId { get; set; }
        public string? TaskKey { get; set; }
        public string? SourceTaskKey { get; set; }
        public DateTime? InsertTime { get; set; }
        public DateTime? ExecuteTime { get; set; }
        public DateTime? SuccessfulTime { get; set; }
        public byte? StatusType { get; set; }
        public byte? Result { get; set; }
        public string? Messages { get; set; }
        public string? Errors { get; set; }
        public Guid? GroupId { get; set; }
        public byte? GroupOrder { get; set; }

        public virtual MetaLocation? LocationNavigation { get; set; }
        public virtual RplTaskItem? TaskItemNavigation { get; set; }
        public virtual ErpCompany? ToCompany { get; set; }
    }
}
