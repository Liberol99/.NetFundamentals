using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaUserGroup
    {
        public int RecId { get; set; }
        public string? GroupCode { get; set; }
        public string? GroupName { get; set; }
        public string? SpecialCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaUserGroupItem? MetaUserGroupItem { get; set; }
    }
}
