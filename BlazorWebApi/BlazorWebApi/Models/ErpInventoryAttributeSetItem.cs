using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryAttributeSetItem
    {
        public ErpInventoryAttributeSetItem()
        {
            ErpInventoryAttributes = new HashSet<ErpInventoryAttribute>();
            ErpInventoryCampaignItems = new HashSet<ErpInventoryCampaignItem>();
            ErpParameterBonus = new HashSet<ErpParameterBonu>();
            PosMenuItemAdditionalAttrSetItems = new HashSet<PosMenuItem>();
            PosMenuItemPromotionalAttrSetItems = new HashSet<PosMenuItem>();
        }

        public long RecId { get; set; }
        public int? AttributeSetId { get; set; }
        public string? AttributeItemCode { get; set; }
        public string? AttributeItemName { get; set; }
        public string? SpecialCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpInventoryAttributeSet? AttributeSet { get; set; }
        public virtual ICollection<ErpInventoryAttribute> ErpInventoryAttributes { get; set; }
        public virtual ICollection<ErpInventoryCampaignItem> ErpInventoryCampaignItems { get; set; }
        public virtual ICollection<ErpParameterBonu> ErpParameterBonus { get; set; }
        public virtual ICollection<PosMenuItem> PosMenuItemAdditionalAttrSetItems { get; set; }
        public virtual ICollection<PosMenuItem> PosMenuItemPromotionalAttrSetItems { get; set; }
    }
}
