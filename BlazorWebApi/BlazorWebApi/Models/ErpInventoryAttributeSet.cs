using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryAttributeSet
    {
        public ErpInventoryAttributeSet()
        {
            ErpCurrentAccountInventoryAttributes = new HashSet<ErpCurrentAccountInventoryAttribute>();
            ErpInventoryAttributeSetItems = new HashSet<ErpInventoryAttributeSetItem>();
            ErpInventoryAttributes = new HashSet<ErpInventoryAttribute>();
            ErpParameterBonus = new HashSet<ErpParameterBonu>();
            ErpWarehouseInventoryAttributes = new HashSet<ErpWarehouseInventoryAttribute>();
            PosMenuItemAdditionalAttrSets = new HashSet<PosMenuItem>();
            PosMenuItemPromotionalAttrSets = new HashSet<PosMenuItem>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public long? GroupId { get; set; }
        public string? AttributeCode { get; set; }
        public string? AttributeName { get; set; }
        public string? SpecialCode { get; set; }
        public byte? IsMandatory { get; set; }
        public byte? SelectionType { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpInventoryGroup? Group { get; set; }
        public virtual ICollection<ErpCurrentAccountInventoryAttribute> ErpCurrentAccountInventoryAttributes { get; set; }
        public virtual ICollection<ErpInventoryAttributeSetItem> ErpInventoryAttributeSetItems { get; set; }
        public virtual ICollection<ErpInventoryAttribute> ErpInventoryAttributes { get; set; }
        public virtual ICollection<ErpParameterBonu> ErpParameterBonus { get; set; }
        public virtual ICollection<ErpWarehouseInventoryAttribute> ErpWarehouseInventoryAttributes { get; set; }
        public virtual ICollection<PosMenuItem> PosMenuItemAdditionalAttrSets { get; set; }
        public virtual ICollection<PosMenuItem> PosMenuItemPromotionalAttrSets { get; set; }
    }
}
