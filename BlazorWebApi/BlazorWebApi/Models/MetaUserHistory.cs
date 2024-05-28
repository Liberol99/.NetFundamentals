using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaUserHistory
    {
        public long RecId { get; set; }
        public int? UserId { get; set; }
        public short? ItemType { get; set; }
        public DateTime? OperationAt { get; set; }
        public string? Password { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaUser? User { get; set; }
    }
}
