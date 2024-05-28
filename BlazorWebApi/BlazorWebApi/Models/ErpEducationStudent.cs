using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpEducationStudent
    {
        public long RecId { get; set; }
        public long? EducationId { get; set; }
        public byte? UserType { get; set; }
        public int? UserId { get; set; }
        public int? UserGroupId { get; set; }
        public long? ContactId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }

        public virtual ErpCurrentAccountContact? Contact { get; set; }
        public virtual ErpEducation? Education { get; set; }
        public virtual MetaUser? User { get; set; }
    }
}
