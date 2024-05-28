using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDeclarationApp3
    {
        public long RecId { get; set; }
        public long? DecRecId { get; set; }
        public short? ItemNo { get; set; }
        public string? Btype { get; set; }
        public decimal? Revenue { get; set; }
        public decimal? Expenses { get; set; }
        public decimal? Profit { get; set; }
        public decimal? Loss { get; set; }
        public decimal? IncomeTax { get; set; }
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
