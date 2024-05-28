using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaUserGroupItem
    {
        public int RecId { get; set; }
        public int? UserGroupId { get; set; }
        public int? UserId { get; set; }
        public string? SpecialCode { get; set; }
        public string? Explanation { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaUser? User { get; set; }
        public virtual MetaUserGroup? UserGroup { get; set; }
    }
}
