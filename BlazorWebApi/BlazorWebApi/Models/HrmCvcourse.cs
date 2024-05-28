using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmCvcourse
    {
        public long RecId { get; set; }
        public long? CvId { get; set; }
        public string? CourseName { get; set; }
        public string? CourseInstitution { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Duration { get; set; }
        public string? Explanation { get; set; }
        public string? CertificateName { get; set; }
        public DateTime? CertificateDate { get; set; }
        public string? CertificateExplanation { get; set; }
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
