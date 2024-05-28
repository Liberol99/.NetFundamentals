using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDeclarationItem
    {
        public long RecId { get; set; }
        public long? DecRecId { get; set; }
        public int? FieldNo { get; set; }
        public string? FieldValue { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpDeclaration? DecRec { get; set; }
    }
}
