using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class CrmTerritory
    {
        public CrmTerritory()
        {
            CrmMarketingActivities = new HashSet<CrmMarketingActivity>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? TerritoryName { get; set; }
        public string? Explanation { get; set; }
        public string? Venue { get; set; }
        public int? DistrictId { get; set; }
        public int? CityId { get; set; }
        public int? CountryId { get; set; }
        public int? TownId { get; set; }
        public int? StreetId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaCity? City { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual MetaCountry? Country { get; set; }
        public virtual MetaDistrict? District { get; set; }
        public virtual MetaStreet? Street { get; set; }
        public virtual MetaTown? Town { get; set; }
        public virtual ICollection<CrmMarketingActivity> CrmMarketingActivities { get; set; }
    }
}
