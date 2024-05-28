using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaHrmSsiPrm
    {
        public int RecId { get; set; }
        public string? PrmCode { get; set; }
        public string? PrmName { get; set; }
        public short? PrmType { get; set; }
        public decimal? PrmRate { get; set; }
        public decimal? EmpRate { get; set; }
        public decimal? ComRate { get; set; }
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
