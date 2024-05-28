using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpEmployeeHistory
    {
        public long RecId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? QuitDate { get; set; }
        public int? QuitReasonId { get; set; }
        public string? QuitExplanation { get; set; }
        public int? MlssQuitReasonId { get; set; }
        public decimal? Salary { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexSalary { get; set; }
        public decimal? PrvInsuranceEmpPrm { get; set; }
        public decimal? PrvInsuranceComPrm { get; set; }
        public decimal? IndPensionEmpPrm { get; set; }
        public decimal? IndPensionComPrm { get; set; }
        public decimal? AttendanceFee { get; set; }
        public int? DepartmanId { get; set; }
        public byte? IsDone { get; set; }
        public string? AppliedArtical { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte[]? EmpData { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpDepartment? Departman { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual MetaHrmQuit? MlssQuitReason { get; set; }
    }
}
