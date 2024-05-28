using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaExternal
    {
        public MetaExternal()
        {
            MetaExternalXrefs = new HashSet<MetaExternalXref>();
        }

        public int RecId { get; set; }
        public string? ExtCode { get; set; }
        public string? ExtName { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ICollection<MetaExternalXref> MetaExternalXrefs { get; set; }
    }
}
