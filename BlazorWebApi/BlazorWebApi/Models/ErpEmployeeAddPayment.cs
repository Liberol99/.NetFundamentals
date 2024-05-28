using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpEmployeeAddPayment
    {
        public long RecId { get; set; }
        public long? EmployeeId { get; set; }
        public byte? Type { get; set; }
        public int? AddPaymentId { get; set; }
        public decimal? DeductionRate { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
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
