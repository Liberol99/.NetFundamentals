using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmAddPaymentDeduction
    {
        public HrmAddPaymentDeduction()
        {
            ErpEmployeeAddPayments = new HashSet<ErpEmployeeAddPayment>();
            HrmCheckingAdds = new HashSet<HrmCheckingAdd>();
            HrmExecutionProceedings = new HashSet<HrmExecutionProceeding>();
            HrmSeverancePays = new HashSet<HrmSeverancePay>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public byte? Type { get; set; }
        public string? AddPaymentCode { get; set; }
        public string? Explanation { get; set; }
        public decimal? IncomeTaxRate { get; set; }
        public decimal? SsiPrmRate { get; set; }
        public decimal? StampDueRate { get; set; }
        public short? CalcType { get; set; }
        public decimal? DefaultForChecking { get; set; }
        public byte? IsGrossNet { get; set; }
        public string? Formula { get; set; }
        public byte? FormulaInUse { get; set; }
        public byte? UseForChecking { get; set; }
        public byte? UseForSeverancePay { get; set; }
        public byte? EdeclarationType { get; set; }
        public decimal? SsiComPrmRate { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? UseForExecutivePay { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpEmployeeAddPayment> ErpEmployeeAddPayments { get; set; }
        public virtual ICollection<HrmCheckingAdd> HrmCheckingAdds { get; set; }
        public virtual ICollection<HrmExecutionProceeding> HrmExecutionProceedings { get; set; }
        public virtual ICollection<HrmSeverancePay> HrmSeverancePays { get; set; }
    }
}
