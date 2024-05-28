using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDeclarationApp1
    {
        public long RecId { get; set; }
        public long? DecRecId { get; set; }
        public short? ItemNo { get; set; }
        public byte? IsHeadOffice { get; set; }
        public string? TaxNo { get; set; }
        public DateTime? InvDate { get; set; }
        public string? ReceiverTaxNo { get; set; }
        public decimal? Amount { get; set; }
        public string? InvNo { get; set; }
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
