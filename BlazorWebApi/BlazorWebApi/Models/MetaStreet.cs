using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaStreet
    {
        public MetaStreet()
        {
            CrmTerritories = new HashSet<CrmTerritory>();
            ErpAddresses = new HashSet<ErpAddress>();
            ErpBanks = new HashSet<ErpBank>();
            ErpCompanyAcountant2Streets = new HashSet<ErpCompany>();
            ErpCompanyAcountantStreets = new HashSet<ErpCompany>();
            ErpCompanyStreetNavigations = new HashSet<ErpCompany>();
            ErpDepartmentDeliveries = new HashSet<ErpDepartmentDelivery>();
            ErpDepartments = new HashSet<ErpDepartment>();
            ErpMachineOwners = new HashSet<ErpMachineOwner>();
            ErpWarehouses = new HashSet<ErpWarehouse>();
            ErpWorkplaces = new HashSet<ErpWorkplace>();
            HrmCvs = new HashSet<HrmCv>();
            MetaBankBranches = new HashSet<MetaBankBranch>();
            MetaTaxOffices = new HashSet<MetaTaxOffice>();
        }

        public int RecId { get; set; }
        public int? TownId { get; set; }
        public short? StreetType { get; set; }
        public string? StreetCode { get; set; }
        public string? StreetName { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaTown? Town { get; set; }
        public virtual ICollection<CrmTerritory> CrmTerritories { get; set; }
        public virtual ICollection<ErpAddress> ErpAddresses { get; set; }
        public virtual ICollection<ErpBank> ErpBanks { get; set; }
        public virtual ICollection<ErpCompany> ErpCompanyAcountant2Streets { get; set; }
        public virtual ICollection<ErpCompany> ErpCompanyAcountantStreets { get; set; }
        public virtual ICollection<ErpCompany> ErpCompanyStreetNavigations { get; set; }
        public virtual ICollection<ErpDepartmentDelivery> ErpDepartmentDeliveries { get; set; }
        public virtual ICollection<ErpDepartment> ErpDepartments { get; set; }
        public virtual ICollection<ErpMachineOwner> ErpMachineOwners { get; set; }
        public virtual ICollection<ErpWarehouse> ErpWarehouses { get; set; }
        public virtual ICollection<ErpWorkplace> ErpWorkplaces { get; set; }
        public virtual ICollection<HrmCv> HrmCvs { get; set; }
        public virtual ICollection<MetaBankBranch> MetaBankBranches { get; set; }
        public virtual ICollection<MetaTaxOffice> MetaTaxOffices { get; set; }
    }
}
