using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPollAnswer
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
        public byte[]? AnswerGraphic { get; set; }
        public byte? AnswerType { get; set; }
        public long? AnswerOrderNo { get; set; }

        public virtual ErpCurrentAccountContact? Contact { get; set; }
        public virtual ErpPoll? Poll { get; set; }
        public virtual ErpPollQuestion? PollItem { get; set; }
        public virtual MetaUser? User { get; set; }
    }
}
