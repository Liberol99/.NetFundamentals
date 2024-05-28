using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpAccessCode
    {
        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? ModuleType { get; set; }
        public string? AccessCode { get; set; }
        public string? Explanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
    }
}
