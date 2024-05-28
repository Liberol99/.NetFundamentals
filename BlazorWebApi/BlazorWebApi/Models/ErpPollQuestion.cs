using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPollQuestion
    {
        public ErpPollQuestion()
        {
            ErpPollAnswers = new HashSet<ErpPollAnswer>();
            ErpPollUserAnswers = new HashSet<ErpPollUserAnswer>();
        }

        public long RecId { get; set; }
        public long? PollId { get; set; }
        public string? Caption { get; set; }
        public string? Explanation { get; set; }
        public byte? PollQuestionType { get; set; }
        public long? QuestionOrderNo { get; set; }
        public long? QuestionCount { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }
        public byte[]? QuestionGraphic { get; set; }

        public virtual ErpPoll? Poll { get; set; }
        public virtual ICollection<ErpPollAnswer> ErpPollAnswers { get; set; }
        public virtual ICollection<ErpPollUserAnswer> ErpPollUserAnswers { get; set; }
    }
}
