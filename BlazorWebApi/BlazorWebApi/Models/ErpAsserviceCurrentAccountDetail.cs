using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpAsserviceCurrentAccountDetail
    {
        public long RecId { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? EmployeeId { get; set; }
        public byte? ItemType { get; set; }
        public int? DistrictId { get; set; }
        public int? CityId { get; set; }
        public int? CountryId { get; set; }
        public string? Explanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaCity? City { get; set; }
        public virtual MetaCountry? Country { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaDistrict? District { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
    }
}
