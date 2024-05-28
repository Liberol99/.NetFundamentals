using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmLeaveEntitlement
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public long? EmployeeId { get; set; }
        public short? CalYear { get; set; }
        public decimal? Entitled { get; set; }
        public decimal? Added { get; set; }
        public decimal? Used { get; set; }
        public decimal? UsedWithoutEntitlement { get; set; }
        public decimal? Openning { get; set; }
        public decimal? Balance { get; set; }
        public string? BalanceDayHourInfo { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
    }
}
