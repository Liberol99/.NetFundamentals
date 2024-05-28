using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmAdvertisement
    {
        public HrmAdvertisement()
        {
            HrmApplications = new HashSet<HrmApplication>();
            HrmPlacementItems = new HashSet<HrmPlacementItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? PositionId { get; set; }
        public int? DepartmentId { get; set; }
        public string? AdvertisementCode { get; set; }
        public string? AdvertisementName { get; set; }
        public DateTime? AdvertisementStartDate { get; set; }
        public DateTime? AdvertisementEndDate { get; set; }
        public string? AdvertisementCompany { get; set; }
        public string? JobDescription { get; set; }
        public string? Explanation { get; set; }
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
        public virtual HrmPosition? Position { get; set; }
        public virtual ICollection<HrmApplication> HrmApplications { get; set; }
        public virtual ICollection<HrmPlacementItem> HrmPlacementItems { get; set; }
    }
}
