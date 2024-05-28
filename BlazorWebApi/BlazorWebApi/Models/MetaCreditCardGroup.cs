using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaCreditCardGroup
    {
        public MetaCreditCardGroup()
        {
            MetaCreditCardGroupItems = new HashSet<MetaCreditCardGroupItem>();
        }

        public int RecId { get; set; }
        public string? GroupCode { get; set; }
        public string? GroupName { get; set; }
        public long? SymbolId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaSymbol? Symbol { get; set; }
        public virtual ICollection<MetaCreditCardGroupItem> MetaCreditCardGroupItems { get; set; }
    }
}
