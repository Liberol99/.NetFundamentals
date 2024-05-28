using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmCvinterview
    {
        public long RecId { get; set; }
        public long? Cvid { get; set; }
        public long? InterviewerId { get; set; }
        public DateTime? InterviewDate { get; set; }
        public DateTime? InterviewStartTime { get; set; }
        public DateTime? InterviewEndTime { get; set; }
        public string? InterviewExplanation { get; set; }
        public byte? InterviewResultType { get; set; }
        public string? InterviewResult { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual HrmCv? Cv { get; set; }
        public virtual ErpEmployee? Interviewer { get; set; }
    }
}
