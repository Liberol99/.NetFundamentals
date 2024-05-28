using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaHrmTaxSegment
    {
        public int RecId { get; set; }
        public string? TaxCode { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? LowerLimit { get; set; }
        public decimal? UpperLimit { get; set; }
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
