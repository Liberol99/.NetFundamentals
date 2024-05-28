using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaTown
    {
        public MetaTown()
        {
            CrmTerritories = new HashSet<CrmTerritory>();
            ErpAddresses = new HashSet<ErpAddress>();
            ErpBanks = new HashSet<ErpBank>();
            ErpCompanies = new HashSet<ErpCompany>();
            ErpDepartmentDeliveries = new HashSet<ErpDepartmentDelivery>();
            ErpDepartments = new HashSet<ErpDepartment>();
            ErpMachineOwners = new HashSet<ErpMachineOwner>();
            ErpWarehouses = new HashSet<ErpWarehouse>();
            ErpWorkplaces = new HashSet<ErpWorkplace>();
            HrmCvs = new HashSet<HrmCv>();
            MetaBankBranches = new HashSet<MetaBankBranch>();
            MetaStreets = new HashSet<MetaStreet>();
            MetaTaxOffices = new HashSet<MetaTaxOffice>();
        }

        public int RecId { get; set; }
        public int? DistrictId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? CityId { get; set; }
        public string? TownCode { get; set; }
        public string? TownName { get; set; }
        public string? PostalCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaCity? City { get; set; }
        public virtual MetaDistrict? District { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<CrmTerritory> CrmTerritories { get; set; }
        public virtual ICollection<ErpAddress> ErpAddresses { get; set; }
        public virtual ICollection<ErpBank> ErpBanks { get; set; }
        public virtual ICollection<ErpCompany> ErpCompanies { get; set; }
        public virtual ICollection<ErpDepartmentDelivery> ErpDepartmentDeliveries { get; set; }
        public virtual ICollection<ErpDepartment> ErpDepartments { get; set; }
        public virtual ICollection<ErpMachineOwner> ErpMachineOwners { get; set; }
        public virtual ICollection<ErpWarehouse> ErpWarehouses { get; set; }
        public virtual ICollection<ErpWorkplace> ErpWorkplaces { get; set; }
        public virtual ICollection<HrmCv> HrmCvs { get; set; }
        public virtual ICollection<MetaBankBranch> MetaBankBranches { get; set; }
        public virtual ICollection<MetaStreet> MetaStreets { get; set; }
        public virtual ICollection<MetaTaxOffice> MetaTaxOffices { get; set; }
    }
}
