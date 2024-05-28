using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpParameter
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public short? PrmGroup { get; set; }
        public int? PrmId { get; set; }
        public string? PrmValue { get; set; }
        public byte[]? Condition { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
