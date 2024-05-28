using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDeclarationApp5
    {
        public long RecId { get; set; }
        public long? DecRecId { get; set; }
        public short? ItemNo { get; set; }
        public byte? IsManager { get; set; }
        public byte? IsMember { get; set; }
        public byte? IsPartner { get; set; }
        public byte? IsLegal { get; set; }
        public string? TridNo { get; set; }
        public string? TaxNo { get; set; }
        public string? Title1 { get; set; }
        public string? Title2 { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public decimal? Share { get; set; }
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
