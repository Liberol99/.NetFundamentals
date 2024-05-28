using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmCheckingAdd
    {
        public long RecId { get; set; }
        public long? CheckingId { get; set; }
        public long? ExecutionProceedingId { get; set; }
        public byte? Type { get; set; }
        public int? AddPaymentId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? GrossAmount { get; set; }
        public decimal? DailyAmount { get; set; }
        public decimal? PaidDay { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual HrmAddPaymentDeduction? AddPayment { get; set; }
        public virtual HrmChecking? Checking { get; set; }
        public virtual HrmExecutionProceeding? ExecutionProceeding { get; set; }
    }
}
