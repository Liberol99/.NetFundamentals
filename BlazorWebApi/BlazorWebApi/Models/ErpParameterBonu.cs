using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpParameterBonu
    {
        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? LowerAmount { get; set; }
        public decimal? UpperAmount { get; set; }
        public decimal? BonusRate { get; set; }
        public long? InventoryGroupId { get; set; }
        public int? InventoryAttrSetId { get; set; }
        public long? InventoryAttrSetItemId { get; set; }
        public long? ServiceGroupId { get; set; }
        public byte[]? Condition { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpInventoryAttributeSet? InventoryAttrSet { get; set; }
        public virtual ErpInventoryAttributeSetItem? InventoryAttrSetItem { get; set; }
        public virtual ErpInventoryGroup? InventoryGroup { get; set; }
        public virtual ErpServiceGroup? ServiceGroup { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
