using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDepartmentCapacity
    {
        public int RecId { get; set; }
        public int? DepartmentId { get; set; }
        public short? Ctype { get; set; }
        public int? CategoryId { get; set; }
        public long? CurrentAccountId { get; set; }
        public decimal? Capacity { get; set; }
        public decimal? Turnover { get; set; }
        public byte[]? Condition { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCategory? Category { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpDepartment? Department { get; set; }
    }
}
