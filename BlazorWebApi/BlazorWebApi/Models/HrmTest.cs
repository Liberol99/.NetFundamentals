using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmTest
    {
        public HrmTest()
        {
            HrmPlacementItems = new HashSet<HrmPlacementItem>();
            HrmTestEmployees = new HashSet<HrmTestEmployee>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? TestCode { get; set; }
        public string? TestName { get; set; }
        public DateTime? TestDate { get; set; }
        public DateTime? TestTime { get; set; }
        public string? Explanation { get; set; }
        public string? ResultExplanation { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<HrmPlacementItem> HrmPlacementItems { get; set; }
        public virtual ICollection<HrmTestEmployee> HrmTestEmployees { get; set; }
    }
}
