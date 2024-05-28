using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpQualityControlTestDetail
    {
        public long RecId { get; set; }
        public long? QualityControlId { get; set; }
        public int? ProcessId { get; set; }
        public DateTime? QualityControlTestDate { get; set; }
        public long? QualityControllerId { get; set; }
        public string? Explanation1 { get; set; }
        public string? Explanation2 { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpProcess? Process { get; set; }
        public virtual ErpQualityControl? QualityControl { get; set; }
        public virtual ErpEmployee? QualityController { get; set; }
    }
}
