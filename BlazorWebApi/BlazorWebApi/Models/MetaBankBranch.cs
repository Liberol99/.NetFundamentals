using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaBankBranch
    {
        public MetaBankBranch()
        {
            ErpCheques = new HashSet<ErpCheque>();
        }

        public int RecId { get; set; }
        public int? MetaBankId { get; set; }
        public string? BranchCode { get; set; }
        public string? BranchName { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public int? DistrictId { get; set; }
        public int? TownId { get; set; }
        public int? StreetId { get; set; }
        public int? StateId { get; set; }
        public string? SwiftCode { get; set; }
        public string? ContactPerson { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaCity? City { get; set; }
        public virtual MetaCountry? Country { get; set; }
        public virtual MetaDistrict? District { get; set; }
        public virtual MetaBank? MetaBank { get; set; }
        public virtual MetaState? State { get; set; }
        public virtual MetaStreet? Street { get; set; }
        public virtual MetaTown? Town { get; set; }
        public virtual ICollection<ErpCheque> ErpCheques { get; set; }
    }
}
