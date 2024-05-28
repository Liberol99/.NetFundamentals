using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaCity
    {
        public MetaCity()
        {
            CrmTerritories = new HashSet<CrmTerritory>();
            ErpAddresses = new HashSet<ErpAddress>();
            ErpAsserviceCurrentAccountDetails = new HashSet<ErpAsserviceCurrentAccountDetail>();
            ErpBanks = new HashSet<ErpBank>();
            ErpCompanyAcountant2Cities = new HashSet<ErpCompany>();
            ErpCompanyAcountantCities = new HashSet<ErpCompany>();
            ErpCompanyCities = new HashSet<ErpCompany>();
            ErpDepartmentDeliveries = new HashSet<ErpDepartmentDelivery>();
            ErpDepartments = new HashSet<ErpDepartment>();
            ErpMachineOwners = new HashSet<ErpMachineOwner>();
            ErpWarehouses = new HashSet<ErpWarehouse>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            ErpWorkplaces = new HashSet<ErpWorkplace>();
            HrmCveducations = new HashSet<HrmCveducation>();
            HrmCvs = new HashSet<HrmCv>();
            MetaBankBranches = new HashSet<MetaBankBranch>();
            MetaCalendars = new HashSet<MetaCalendar>();
            MetaDistricts = new HashSet<MetaDistrict>();
            MetaHotPoints = new HashSet<MetaHotPoint>();
            MetaTaxOffices = new HashSet<MetaTaxOffice>();
            MetaTowns = new HashSet<MetaTown>();
        }

        public int RecId { get; set; }
        public int? CountryId { get; set; }
        public string? CityCode { get; set; }
        public string? CityName { get; set; }
        public string? CodeN { get; set; }
        public string? LicensePlate { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaCountry? Country { get; set; }
        public virtual ICollection<CrmTerritory> CrmTerritories { get; set; }
        public virtual ICollection<ErpAddress> ErpAddresses { get; set; }
        public virtual ICollection<ErpAsserviceCurrentAccountDetail> ErpAsserviceCurrentAccountDetails { get; set; }
        public virtual ICollection<ErpBank> ErpBanks { get; set; }
        public virtual ICollection<ErpCompany> ErpCompanyAcountant2Cities { get; set; }
        public virtual ICollection<ErpCompany> ErpCompanyAcountantCities { get; set; }
        public virtual ICollection<ErpCompany> ErpCompanyCities { get; set; }
        public virtual ICollection<ErpDepartmentDelivery> ErpDepartmentDeliveries { get; set; }
        public virtual ICollection<ErpDepartment> ErpDepartments { get; set; }
        public virtual ICollection<ErpMachineOwner> ErpMachineOwners { get; set; }
        public virtual ICollection<ErpWarehouse> ErpWarehouses { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<ErpWorkplace> ErpWorkplaces { get; set; }
        public virtual ICollection<HrmCveducation> HrmCveducations { get; set; }
        public virtual ICollection<HrmCv> HrmCvs { get; set; }
        public virtual ICollection<MetaBankBranch> MetaBankBranches { get; set; }
        public virtual ICollection<MetaCalendar> MetaCalendars { get; set; }
        public virtual ICollection<MetaDistrict> MetaDistricts { get; set; }
        public virtual ICollection<MetaHotPoint> MetaHotPoints { get; set; }
        public virtual ICollection<MetaTaxOffice> MetaTaxOffices { get; set; }
        public virtual ICollection<MetaTown> MetaTowns { get; set; }
    }
}
