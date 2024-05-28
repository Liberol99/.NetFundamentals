using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpServiceGroup
    {
        public ErpServiceGroup()
        {
            ErpBudgetItems = new HashSet<ErpBudgetItem>();
            ErpParameterBonus = new HashSet<ErpParameterBonu>();
            ErpServicePriceLists = new HashSet<ErpServicePriceList>();
            ErpServices = new HashSet<ErpService>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? GroupCode { get; set; }
        public string? GroupName { get; set; }
        public string? SpecialCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpBudgetItem> ErpBudgetItems { get; set; }
        public virtual ICollection<ErpParameterBonu> ErpParameterBonus { get; set; }
        public virtual ICollection<ErpServicePriceList> ErpServicePriceLists { get; set; }
        public virtual ICollection<ErpService> ErpServices { get; set; }
    }
}
