using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDeclarationApp7
    {
        public long RecId { get; set; }
        public long? DecRecId { get; set; }
        public short? ItemNo { get; set; }
        public string? Title { get; set; }
        public string? CountryCode { get; set; }
        public string? TaxNo { get; set; }
        public string? TridNo { get; set; }
        public short? DocumentCount { get; set; }
        public decimal? VatAmount { get; set; }

        public virtual ErpDeclaration? DecRec { get; set; }
    }
}
