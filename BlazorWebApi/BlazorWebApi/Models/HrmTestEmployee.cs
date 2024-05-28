using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmTestEmployee
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public long? TestId { get; set; }
        public byte? ItemType { get; set; }
        public long? EmployeeId { get; set; }
        public int? PositionId { get; set; }
        public int? DepartmentId { get; set; }
        public long? ApplicationId { get; set; }
        public byte? ApplicantStatus { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual HrmApplication? Application { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual HrmPosition? Position { get; set; }
        public virtual HrmTest? Test { get; set; }
    }
}
