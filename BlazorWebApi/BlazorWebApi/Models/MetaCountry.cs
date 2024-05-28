using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaCountry
    {
        public MetaCountry()
        {
            CrmTerritories = new HashSet<CrmTerritory>();
            ErpAddresses = new HashSet<ErpAddress>();
            ErpAsserviceCurrentAccountDetails = new HashSet<ErpAsserviceCurrentAccountDetail>();
            ErpBanks = new HashSet<ErpBank>();
            ErpCompanyAcountant2Countries = new HashSet<ErpCompany>();
            ErpCompanyAcountantCountries = new HashSet<ErpCompany>();
            ErpCompanyCountries = new HashSet<ErpCompany>();
            ErpCurrentAccounts = new HashSet<ErpCurrentAccount>();
            ErpDepartmentDeliveries = new HashSet<ErpDepartmentDelivery>();
            ErpDepartments = new HashSet<ErpDepartment>();
            ErpExpos = new HashSet<ErpExpo>();
            ErpMachineOwners = new HashSet<ErpMachineOwner>();
            ErpWarehouses = new HashSet<ErpWarehouse>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            ErpWorkplaces = new HashSet<ErpWorkplace>();
            HrmCveducations = new HashSet<HrmCveducation>();
            HrmCvs = new HashSet<HrmCv>();
            MetaBankBranches = new HashSet<MetaBankBranch>();
            MetaBanks = new HashSet<MetaBank>();
            MetaCalendars = new HashSet<MetaCalendar>();
            MetaCities = new HashSet<MetaCity>();
            MetaCtsps = new HashSet<MetaCtsp>();
            MetaHotPoints = new HashSet<MetaHotPoint>();
            MetaStates = new HashSet<MetaState>();
            MetaTaxOffices = new HashSet<MetaTaxOffice>();
        }

        public int RecId { get; set; }
        public string? CountryCode { get; set; }
        public string? CountryName { get; set; }
        public string? Language { get; set; }
        public string? CodeN { get; set; }
        public string? CodeN2 { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ICollection<CrmTerritory> CrmTerritories { get; set; }
        public virtual ICollection<ErpAddress> ErpAddresses { get; set; }
        public virtual ICollection<ErpAsserviceCurrentAccountDetail> ErpAsserviceCurrentAccountDetails { get; set; }
        public virtual ICollection<ErpBank> ErpBanks { get; set; }
        public virtual ICollection<ErpCompany> ErpCompanyAcountant2Countries { get; set; }
        public virtual ICollection<ErpCompany> ErpCompanyAcountantCountries { get; set; }
        public virtual ICollection<ErpCompany> ErpCompanyCountries { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccounts { get; set; }
        public virtual ICollection<ErpDepartmentDelivery> ErpDepartmentDeliveries { get; set; }
        public virtual ICollection<ErpDepartment> ErpDepartments { get; set; }
        public virtual ICollection<ErpExpo> ErpExpos { get; set; }
        public virtual ICollection<ErpMachineOwner> ErpMachineOwners { get; set; }
        public virtual ICollection<ErpWarehouse> ErpWarehouses { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<ErpWorkplace> ErpWorkplaces { get; set; }
        public virtual ICollection<HrmCveducation> HrmCveducations { get; set; }
        public virtual ICollection<HrmCv> HrmCvs { get; set; }
        public virtual ICollection<MetaBankBranch> MetaBankBranches { get; set; }
        public virtual ICollection<MetaBank> MetaBanks { get; set; }
        public virtual ICollection<MetaCalendar> MetaCalendars { get; set; }
        public virtual ICollection<MetaCity> MetaCities { get; set; }
        public virtual ICollection<MetaCtsp> MetaCtsps { get; set; }
        public virtual ICollection<MetaHotPoint> MetaHotPoints { get; set; }
        public virtual ICollection<MetaState> MetaStates { get; set; }
        public virtual ICollection<MetaTaxOffice> MetaTaxOffices { get; set; }
    }
}
