using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmApplication
    {
        public HrmApplication()
        {
            HrmPlacementItems = new HashSet<HrmPlacementItem>();
            HrmTestEmployees = new HashSet<HrmTestEmployee>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public long? CvId { get; set; }
        public long? AdvertisementId { get; set; }
        public string? ApplicationCode { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public string? Explanation { get; set; }
        public string? Email { get; set; }
        public byte? ApplicationStatus { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual HrmAdvertisement? Advertisement { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual HrmCv? Cv { get; set; }
        public virtual ICollection<HrmPlacementItem> HrmPlacementItems { get; set; }
        public virtual ICollection<HrmTestEmployee> HrmTestEmployees { get; set; }
    }
}
