using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpParameterPosExp
    {
        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? CodeList { get; set; }
        public string? ExplanationList { get; set; }
        public short? ItemOrderNo { get; set; }
        public byte? IsMandatory { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
