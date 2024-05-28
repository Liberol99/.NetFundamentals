using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaState
    {
        public MetaState()
        {
            ErpAddresses = new HashSet<ErpAddress>();
            ErpBanks = new HashSet<ErpBank>();
            ErpCompanies = new HashSet<ErpCompany>();
            ErpDepartmentDeliveries = new HashSet<ErpDepartmentDelivery>();
            ErpDepartments = new HashSet<ErpDepartment>();
            ErpWarehouses = new HashSet<ErpWarehouse>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            ErpWorkplaces = new HashSet<ErpWorkplace>();
            MetaBankBranches = new HashSet<MetaBankBranch>();
        }

        public int RecId { get; set; }
        public int? CountryId { get; set; }
        public string? StateCode { get; set; }
        public string? StateName { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaCountry? Country { get; set; }
        public virtual ICollection<ErpAddress> ErpAddresses { get; set; }
        public virtual ICollection<ErpBank> ErpBanks { get; set; }
        public virtual ICollection<ErpCompany> ErpCompanies { get; set; }
        public virtual ICollection<ErpDepartmentDelivery> ErpDepartmentDeliveries { get; set; }
        public virtual ICollection<ErpDepartment> ErpDepartments { get; set; }
        public virtual ICollection<ErpWarehouse> ErpWarehouses { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<ErpWorkplace> ErpWorkplaces { get; set; }
        public virtual ICollection<MetaBankBranch> MetaBankBranches { get; set; }
    }
}
