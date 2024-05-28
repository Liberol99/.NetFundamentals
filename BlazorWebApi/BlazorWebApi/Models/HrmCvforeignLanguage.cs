using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmCvforeignLanguage
    {
        public long RecId { get; set; }
        public long? CvId { get; set; }
        public short? LanguageId { get; set; }
        public short? Reading { get; set; }
        public short? Writing { get; set; }
        public short? Speaking { get; set; }
        public string? ExamName { get; set; }
        public DateTime? ExamDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? LearningPlace { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual HrmCv? Cv { get; set; }
    }
}
