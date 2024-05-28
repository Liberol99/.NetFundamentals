using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaHrmHazardSegment
    {
        public int RecId { get; set; }
        public string? HazardSegmentCode { get; set; }
        public short? Segment { get; set; }
        public decimal? LowerRisk { get; set; }
        public decimal? Normal { get; set; }
        public decimal? OverRisk { get; set; }
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
