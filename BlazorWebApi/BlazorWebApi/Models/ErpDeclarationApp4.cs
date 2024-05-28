using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDeclarationApp4
    {
        public long RecId { get; set; }
        public long? DecRecId { get; set; }
        public short? ItemNo { get; set; }
        public short? ItemType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string? ReceiptNo { get; set; }
        public short? Exemption { get; set; }
        public string? Registration { get; set; }
        public string? TaxNo { get; set; }
        public string? Title1 { get; set; }
        public string? Title2 { get; set; }
        public string? Inventory { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ForexAmount { get; set; }
        public decimal? VatAmount { get; set; }
        public string? CountryCode { get; set; }
        public string? TridNo { get; set; }
        public decimal? VatRate { get; set; }
        public byte? WithholdingFactor { get; set; }
        public byte? WithholdingDivisor { get; set; }
        public decimal? WithholdingAmount { get; set; }
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
