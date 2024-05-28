using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpProductConfigurator
    {
        public ErpProductConfigurator()
        {
            ErpProductConfiguratorItems = new HashSet<ErpProductConfiguratorItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public short? Type { get; set; }
        public string? Code { get; set; }
        public string? Explanation { get; set; }
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
        public string? AccessCode { get; set; }
        public string? SpecialCode { get; set; }
        public long? InventoryId { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpProductConfiguratorItem> ErpProductConfiguratorItems { get; set; }
    }
}
