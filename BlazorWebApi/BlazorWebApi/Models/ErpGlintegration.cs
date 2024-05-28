using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpGlintegration
    {
        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? ModuleNo { get; set; }
        public short? ItemNo { get; set; }
        public string? GlaccountCode { get; set; }
        public string? GlaccountCode2 { get; set; }
        public string? CostCenterCode { get; set; }
        public string? Explanation { get; set; }
        public string? IntegrationExplanation { get; set; }
        public int? TypeNo { get; set; }
        public byte[]? Condition { get; set; }
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
