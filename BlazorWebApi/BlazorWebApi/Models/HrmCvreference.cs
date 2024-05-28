using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmCvreference
    {
        public long RecId { get; set; }
        public long? CvId { get; set; }
        public string? ReferenceName { get; set; }
        public string? ReferenceSurname { get; set; }
        public byte? ReferenceType { get; set; }
        public string? ReferenceCompany { get; set; }
        public long? CompanySectorId { get; set; }
        public int? PositionId { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
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
