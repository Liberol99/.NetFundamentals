using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpProductConfiguratorItem
    {
        public ErpProductConfiguratorItem()
        {
            InverseParent = new HashSet<ErpProductConfiguratorItem>();
        }

        public long RecId { get; set; }
        public long? ProductConfiguratorId { get; set; }
        public byte? ItemType { get; set; }
        public int? ItemOrderNo { get; set; }
        public string? Explanation { get; set; }
        public long? ParentId { get; set; }
        public byte? RequiredType { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public int? UnitId { get; set; }
        public int? ProcessId { get; set; }
        public decimal? Quantity { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public byte[]? Condition { get; set; }
        public byte? InOut { get; set; }
        public byte? RequirementType { get; set; }
        public byte? ControlType { get; set; }
        public int? RouteId { get; set; }
        public int? OutWarehouseId { get; set; }
        public decimal? Wastage { get; set; }
        public int? ForexId { get; set; }
        public decimal? Price { get; set; }
        public byte? IsDefault { get; set; }
        public byte? EditorType { get; set; }
        public string? FieldName { get; set; }

        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpWarehouse? OutWarehouse { get; set; }
        public virtual ErpProductConfiguratorItem? Parent { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpProductConfigurator? ProductConfigurator { get; set; }
        public virtual ErpRoute? Route { get; set; }
        public virtual MetaUnitSetItem? Unit { get; set; }
        public virtual ICollection<ErpProductConfiguratorItem> InverseParent { get; set; }
    }
}
