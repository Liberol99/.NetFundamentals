using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmChecking
    {
        public HrmChecking()
        {
            HrmCheckingAdds = new HashSet<HrmCheckingAdd>();
            HrmCheckingHours = new HashSet<HrmCheckingHour>();
        }

        public long RecId { get; set; }
        public long? EmployeeId { get; set; }
        public short? CalcYear { get; set; }
        public short? CalcMonth { get; set; }
        public byte? Type { get; set; }
        public decimal? RegularEarning { get; set; }
        public decimal? OverTimeEarning { get; set; }
        public decimal? AddAllowanceTotal { get; set; }
        public decimal? AddDeductionTotal { get; set; }
        public short? VacationDays { get; set; }
        public decimal? VacationPays { get; set; }
        public decimal? HourlyWages { get; set; }
        public decimal? DailyWages { get; set; }
        public decimal? GrossWages { get; set; }
        public byte? EmployeeSalaryType { get; set; }
        public decimal? EmployeeSalary { get; set; }
        public decimal? SsiDays { get; set; }
        public decimal? WorkingDays { get; set; }
        public decimal? SsiEmployeePrmBase { get; set; }
        public decimal? SsiEmployeePrm { get; set; }
        public decimal? SsiCompanyPrmBase { get; set; }
        public decimal? SsiCompanyPrm { get; set; }
        public decimal? UnEmpEmployeePrmBase { get; set; }
        public decimal? UnEmpEmployeePrm { get; set; }
        public decimal? UnEmpCompanyPrm { get; set; }
        public decimal? StampDueBase { get; set; }
        public decimal? StampDue { get; set; }
        public decimal? IncomeTaxBase { get; set; }
        public decimal? IncomeTax { get; set; }
        public decimal? CalculatedIncomeTax { get; set; }
        public decimal? IncomeTaxExempt { get; set; }
        public decimal? StampDueExempt { get; set; }
        public decimal? SsiPrmExempt { get; set; }
        public decimal? UnEmpInsExempt { get; set; }
        public decimal? TaxDeduction { get; set; }
        public decimal? TotalIncome { get; set; }
        public decimal? Deductions { get; set; }
        public decimal? NetPaid { get; set; }
        public decimal? UnionDue { get; set; }
        public decimal? PrevMonRoundation { get; set; }
        public decimal? IndPensionPrvInsurance { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexSalary { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? SsiBaseWageDiff { get; set; }
        public int? AbsenceId { get; set; }
        public decimal? MlaDeductionRate { get; set; }
        public decimal? MlaDeduction { get; set; }
        public decimal? CalculatedMlaDeduction { get; set; }
        public decimal? UnpaidVacDays { get; set; }
        public decimal? DisabledExempt { get; set; }
        public decimal? PrevMonExceedings { get; set; }
        public decimal? PrevMonExceedings2 { get; set; }
        public decimal? ThisMonExceedings { get; set; }
        public string? ArticleNo { get; set; }
        public decimal? IndPension { get; set; }
        public decimal? AutomaticIndPension { get; set; }
        public decimal? AutomaticIndPensionBase { get; set; }
        public decimal? Incentive6111 { get; set; }
        public decimal? Incentive5510 { get; set; }
        public decimal? Incentive5921 { get; set; }
        public short? Incentive5763Year { get; set; }
        public decimal? Incentive5763 { get; set; }
        public decimal? Incentive6486 { get; set; }
        public decimal? Incentive14857 { get; set; }
        public decimal? Incentive4447 { get; set; }
        public decimal? Incentive16322 { get; set; }
        public decimal? Incentive26322 { get; set; }
        public decimal? Incentive687 { get; set; }
        public decimal? Incentive1687 { get; set; }
        public decimal? IncentiveInsComExempt { get; set; }
        public decimal? IncentiveIncomeTaxExempt { get; set; }
        public decimal? TemporalIncentive1 { get; set; }
        public decimal? TemporalIncentive2 { get; set; }
        public decimal? TemporalIncentive3 { get; set; }
        public decimal? TemporalIncentive4 { get; set; }
        public decimal? TemporalIncentive5 { get; set; }
        public decimal? TemporalIncentive6 { get; set; }
        public decimal? TemporalIncentive7 { get; set; }
        public decimal? TemporalIncentive8 { get; set; }
        public decimal? TemporalIncentive9 { get; set; }
        public decimal? TemporalIncentive10 { get; set; }
        public decimal? TemporalIncentive11 { get; set; }
        public decimal? Incentive7252 { get; set; }
        public decimal? SsiEmpDifIncentive7252 { get; set; }
        public decimal? SsiCompDifIncentive7252 { get; set; }
        public decimal? UnEmpIncentive7252 { get; set; }
        public decimal? UnCompIncentive7252 { get; set; }
        public decimal? Incentive27256 { get; set; }
        public decimal? Incentive2828 { get; set; }
        public decimal? Incentive7316 { get; set; }
        public decimal? Incentive3294 { get; set; }
        public decimal? CumulativeTaxBase { get; set; }
        public decimal? MinWageIncomeTaxBase { get; set; }
        public decimal? MinWageIncomeTax { get; set; }
        public decimal? MinWageStampBase { get; set; }
        public decimal? MinWageStampDue { get; set; }
        public decimal? Roundations { get; set; }
        public decimal? Discardeds { get; set; }
        public decimal? MlaRoundations { get; set; }
        public decimal? MlaDiscardeds { get; set; }
        public decimal? MlaTotalAdded { get; set; }
        public decimal? IncomeTaxExcess { get; set; }
        public decimal? ShortTimePrmBase { get; set; }
        public decimal? ShortTimeSsiEmployeePrm { get; set; }
        public decimal? ShortTimeUnEmpEmployeePrm { get; set; }
        public byte? IsActive { get; set; }
        public byte? IsResting { get; set; }
        public byte? IsLocked { get; set; }
        public byte? IsMinWaged { get; set; }
        public byte? GoverningLawArticle { get; set; }
        public decimal? MinWageStampExempt { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public decimal? MinWageStampDueExempt { get; set; }
        public decimal? ExecutionAmount { get; set; }
        public decimal? MilitaryDebtUsedAmount { get; set; }
        public decimal? BirthDebtUsedAmount { get; set; }
        public decimal? MinWageIncomeTaxExempt { get; set; }
        public decimal? Incentive15510 { get; set; }

        public virtual MetaHrmAbsence? Absence { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ICollection<HrmCheckingAdd> HrmCheckingAdds { get; set; }
        public virtual ICollection<HrmCheckingHour> HrmCheckingHours { get; set; }
    }
}
