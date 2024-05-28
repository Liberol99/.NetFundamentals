using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDepartmentCash
    {
        public int RecId { get; set; }
        public int? DepartmentId { get; set; }
        public int? CashId { get; set; }
        public string? Explanation { get; set; }
        public byte[]? Condition { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCash? Cash { get; set; }
        public virtual ErpDepartment? Department { get; set; }
    }
}
