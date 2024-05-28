using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpExpenseReport
    {
        public long RecId { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? ExpenseType { get; set; }
        public string? AccountName { get; set; }
        public string? AccountCode { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? InUse { get; set; }
        public decimal? Amount { get; set; }

        public virtual ErpCompany? Company { get; set; }
    }
}
