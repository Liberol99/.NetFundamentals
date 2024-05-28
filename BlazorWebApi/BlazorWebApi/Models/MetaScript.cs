using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaScript
    {
        public long RecId { get; set; }
        public short? Priority { get; set; }
        public string? ScriptName { get; set; }
        public string? Description { get; set; }
        public byte[]? Script { get; set; }
        public byte? IsRunAfter { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
    }
}
