using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmCvexperience
    {
        public long RecId { get; set; }
        public long? CvId { get; set; }
        public long? CompanySectorId { get; set; }
        public long? BusinessAreaId { get; set; }
        public string? ExperienceCompany { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? PositionId { get; set; }
        public byte? IsWorked { get; set; }
        public string? ExperienceExplanation { get; set; }
        public byte? ExperienceLevel { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual HrmCv? Cv { get; set; }
        public virtual HrmPosition? Position { get; set; }
    }
}
