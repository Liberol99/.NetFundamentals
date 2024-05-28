using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class PosMenu
    {
        public PosMenu()
        {
            PosMenuItems = new HashSet<PosMenuItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? MenuCode { get; set; }
        public string? Explanation { get; set; }
        public int? DepartmentId { get; set; }
        public byte? SalesType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public short? ValidDays { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ICollection<PosMenuItem> PosMenuItems { get; set; }
    }
}
