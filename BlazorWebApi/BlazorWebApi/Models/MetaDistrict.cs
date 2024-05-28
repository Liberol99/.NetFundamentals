using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaDistrict
    {
        public MetaDistrict()
        {
            CrmTerritories = new HashSet<CrmTerritory>();
            ErpAddresses = new HashSet<ErpAddress>();
            ErpAsserviceCurrentAccountDetails = new HashSet<ErpAsserviceCurrentAccountDetail>();
            ErpBanks = new HashSet<ErpBank>();
            ErpCompanies = new HashSet<ErpCompany>();
            ErpDepartmentDeliveries = new HashSet<ErpDepartmentDelivery>();
            ErpDepartments = new HashSet<ErpDepartment>();
            ErpMachineOwners = new HashSet<ErpMachineOwner>();
            ErpWarehouses = new HashSet<ErpWarehouse>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            ErpWorkplaces = new HashSet<ErpWorkplace>();
            HrmCvs = new HashSet<HrmCv>();
            MetaBankBranches = new HashSet<MetaBankBranch>();
            MetaHotPoints = new HashSet<MetaHotPoint>();
            MetaTaxOffices = new HashSet<MetaTaxOffice>();
            MetaTowns = new HashSet<MetaTown>();
        }

        public int RecId { get; set; }
        public int? CityId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? DistrictCode { get; set; }
        public string? DistrictName { get; set; }
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
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<CrmTerritory> CrmTerritories { get; set; }
        public virtual ICollection<ErpAddress> ErpAddresses { get; set; }
        public virtual ICollection<ErpAsserviceCurrentAccountDetail> ErpAsserviceCurrentAccountDetails { get; set; }
        public virtual ICollection<ErpBank> ErpBanks { get; set; }
        public virtual ICollection<ErpCompany> ErpCompanies { get; set; }
        public virtual ICollection<ErpDepartmentDelivery> ErpDepartmentDeliveries { get; set; }
        public virtual ICollection<ErpDepartment> ErpDepartments { get; set; }
        public virtual ICollection<ErpMachineOwner> ErpMachineOwners { get; set; }
        public virtual ICollection<ErpWarehouse> ErpWarehouses { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<ErpWorkplace> ErpWorkplaces { get; set; }
        public virtual ICollection<HrmCv> HrmCvs { get; set; }
        public virtual ICollection<MetaBankBranch> MetaBankBranches { get; set; }
        public virtual ICollection<MetaHotPoint> MetaHotPoints { get; set; }
        public virtual ICollection<MetaTaxOffice> MetaTaxOffices { get; set; }
        public virtual ICollection<MetaTown> MetaTowns { get; set; }
    }
}
