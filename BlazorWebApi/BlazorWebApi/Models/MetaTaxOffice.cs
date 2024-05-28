using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaTaxOffice
    {
        public MetaTaxOffice()
        {
            CrmLeads = new HashSet<CrmLead>();
            ErpCompanies = new HashSet<ErpCompany>();
            ErpCurrentAccounts = new HashSet<ErpCurrentAccount>();
            ErpEmployees = new HashSet<ErpEmployee>();
            ErpGlreceiptItemInvs = new HashSet<ErpGlreceiptItemInv>();
        }

        public int RecId { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public string? Name { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public int? DistrictId { get; set; }
        public int? TownId { get; set; }
        public int? StreetId { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? CodeN { get; set; }
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
        public virtual MetaStreet? Street { get; set; }
        public virtual MetaTown? Town { get; set; }
        public virtual ICollection<CrmLead> CrmLeads { get; set; }
        public virtual ICollection<ErpCompany> ErpCompanies { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccounts { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployees { get; set; }
        public virtual ICollection<ErpGlreceiptItemInv> ErpGlreceiptItemInvs { get; set; }
    }
}
