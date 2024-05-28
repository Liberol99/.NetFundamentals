using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmExecutionProceeding
    {
        public HrmExecutionProceeding()
        {
            HrmCheckingAdds = new HashSet<HrmCheckingAdd>();
        }

        public long RecId { get; set; }
        public long? EmployeeId { get; set; }
        public byte? PaymentType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public string? DocumentNo { get; set; }
        public string? DocumentOwner { get; set; }
        public string? ExecutionOffice { get; set; }
        public string? Explanation { get; set; }
        public decimal? Amount { get; set; }
        public decimal? DeductionAmount { get; set; }
        public decimal? DeductionRate { get; set; }
        public int? AddPaymentId { get; set; }
        public string? BankName { get; set; }
        public string? AccountNo { get; set; }
        public string? IbanNo { get; set; }
        public byte? IsContinueNextDocument { get; set; }
        public byte? InUse { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? ExecutionType { get; set; }
        public string? DocumentSerialNo { get; set; }
        public decimal? AddPaymentDeductionRate { get; set; }

        public virtual HrmAddPaymentDeduction? AddPayment { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ICollection<HrmCheckingAdd> HrmCheckingAdds { get; set; }
    }
}
