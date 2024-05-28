using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmLeaveGroupItem
    {
        public long RecId { get; set; }
        public long? LeaveGroupId { get; set; }
        public short? MinValue { get; set; }
        public short? MaxValue { get; set; }
        public byte? Days { get; set; }
        public short? AgeMinValue { get; set; }
        public short? AgeMaxValue { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual HrmLeaveGroup? LeaveGroup { get; set; }
    }
}
