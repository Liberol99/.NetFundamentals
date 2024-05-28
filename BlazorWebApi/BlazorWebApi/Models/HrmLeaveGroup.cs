using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmLeaveGroup
    {
        public HrmLeaveGroup()
        {
            ErpEmployees = new HashSet<ErpEmployee>();
            HrmLeaveGroupItems = new HashSet<HrmLeaveGroupItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? LeaveCode { get; set; }
        public string? Explanation { get; set; }
        public byte? CriteriaType { get; set; }
        public byte? TakeoverType { get; set; }
        public byte? MaxTakeoverDay { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployees { get; set; }
        public virtual ICollection<HrmLeaveGroupItem> HrmLeaveGroupItems { get; set; }
    }
}
