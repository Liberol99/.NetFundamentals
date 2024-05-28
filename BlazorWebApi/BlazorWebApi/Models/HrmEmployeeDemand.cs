using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmEmployeeDemand
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? DepartmentId { get; set; }
        public int? PositionId { get; set; }
        public string? DemandNo { get; set; }
        public byte? WorkingTimeType { get; set; }
        public int? EmployeeNumber { get; set; }
        public DateTime? DemandDate { get; set; }
        public long? DemandedId { get; set; }
        public long? ManagerId { get; set; }
        public byte? Gender { get; set; }
        public byte? EducationStatus { get; set; }
        public byte? LanguageStatus { get; set; }
        public short? MinAge { get; set; }
        public short? MaxAge { get; set; }
        public short? Experience { get; set; }
        public DateTime? WorkingStartDate { get; set; }
        public byte? DriverLicenceType { get; set; }
        public string? Explanation { get; set; }
        public byte? RequirementReasonType { get; set; }
        public string? RequirementReasonExplanation { get; set; }
        public string? Opinion { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }
        public string? DemandReasonExplanation { get; set; }
        public string? AccessCode { get; set; }
        public byte? Status { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public byte? MaritalStatus { get; set; }
        public byte? MilitaryStatus { get; set; }
        public string? Certificate { get; set; }
        public byte? DisabledWorking { get; set; }
        public string? LanguageName { get; set; }
        public short? Reading { get; set; }
        public short? Writing { get; set; }
        public short? Speaking { get; set; }
        public string? QuitEmployeeName { get; set; }
        public byte? IsApproved { get; set; }
        public byte? IsCancelled { get; set; }
        public string? CancelledExplanation { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? DemandStatus { get; set; }
        public DateTime? DemandClosingDate { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpEmployee? Demanded { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpEmployee? Manager { get; set; }
        public virtual HrmPosition? Position { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
