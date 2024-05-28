using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpQualityControlTestCard
    {
        public ErpQualityControlTestCard()
        {
            ErpQualityControlProcessDetails = new HashSet<ErpQualityControlProcessDetail>();
        }

        public int RecId { get; set; }
        public int CompanyId { get; set; }
        public string? TestCode { get; set; }
        public string? TestName { get; set; }
        public string? Explanation { get; set; }
        public string? Method { get; set; }
        public string? Standart { get; set; }
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

        public virtual ErpCompany Company { get; set; } = null!;
        public virtual ICollection<ErpQualityControlProcessDetail> ErpQualityControlProcessDetails { get; set; }
    }
}
