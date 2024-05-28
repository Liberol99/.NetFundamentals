using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPollUserAnswer
    {
        public long RecId { get; set; }
        public long? PollId { get; set; }
        public long? PollItemId { get; set; }
        public int? UserId { get; set; }
        public int? UserGroupId { get; set; }
        public long? ContactId { get; set; }
        public string? Answer { get; set; }
        public string? Explanation { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? SourceType { get; set; }
        public long? SourceId { get; set; }
        public long? WorkOrderId { get; set; }

        public virtual ErpCurrentAccountContact? Contact { get; set; }
        public virtual ErpPoll? Poll { get; set; }
        public virtual ErpPollQuestion? PollItem { get; set; }
        public virtual MetaUser? User { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
    }
}
