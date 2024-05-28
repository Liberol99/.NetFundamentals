using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmPlacement
    {
        public HrmPlacement()
        {
            HrmCvs = new HashSet<HrmCv>();
            HrmPlacementItems = new HashSet<HrmPlacementItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? PlacementCompany { get; set; }
        public string? Explanation { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? Deadline { get; set; }
        public byte? PlacementType { get; set; }
        public byte? PlacementStatus { get; set; }
        public byte? IsApproved { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<HrmCv> HrmCvs { get; set; }
        public virtual ICollection<HrmPlacementItem> HrmPlacementItems { get; set; }
    }
}
