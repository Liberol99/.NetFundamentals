using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBank
    {
        public ErpBank()
        {
            ErpBankAccounts = new HashSet<ErpBankAccount>();
            ErpBankWorkplaces = new HashSet<ErpBankWorkplace>();
            ErpInterestRateItems = new HashSet<ErpInterestRateItem>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? MetaBankId { get; set; }
        public string? BankCode { get; set; }
        public string? BankName { get; set; }
        public string? BranchCode { get; set; }
        public string? BranchName { get; set; }
        public string? SwiftCode { get; set; }
        public string? ContactPerson { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public int? DistrictId { get; set; }
        public int? CityId { get; set; }
        public string? PostalCode { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public int? TownId { get; set; }
        public int? StreetId { get; set; }
        public decimal? GpsXcoordinate { get; set; }
        public decimal? GpsYcoordinate { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? TransferSchemaType { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }

        public virtual MetaCity? City { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual MetaCountry? Country { get; set; }
        public virtual MetaDistrict? District { get; set; }
        public virtual MetaBank? MetaBank { get; set; }
        public virtual MetaState? State { get; set; }
        public virtual MetaStreet? Street { get; set; }
        public virtual MetaTown? Town { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpBankAccount> ErpBankAccounts { get; set; }
        public virtual ICollection<ErpBankWorkplace> ErpBankWorkplaces { get; set; }
        public virtual ICollection<ErpInterestRateItem> ErpInterestRateItems { get; set; }
    }
}
