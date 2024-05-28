using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmSeverancePay
    {
        public long RecId { get; set; }
        public long? EmployeeId { get; set; }
        public byte? Type { get; set; }
        public int? AddPaymentId { get; set; }
        public string? Explanation { get; set; }
        public decimal? IncomeAmount { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? TotalIncome { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual HrmAddPaymentDeduction? AddPayment { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
    }
}
