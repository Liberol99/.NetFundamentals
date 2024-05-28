using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaUserAccess
    {
        public long RecId { get; set; }
        public int? UserId { get; set; }
        public short? AccessModule { get; set; }
        public short? AccessType { get; set; }
        public string? AccessCode { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaUser? User { get; set; }
    }
}
