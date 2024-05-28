using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpMaterialRequirementItem
    {
        public ErpMaterialRequirementItem()
        {
            InverseParentItem = new HashSet<ErpMaterialRequirementItem>();
        }

        public long RecId { get; set; }
        public long? MaterialRequirementId { get; set; }
        public short? ItemType { get; set; }
        public short? ActionType { get; set; }
        public long? ParentItemId { get; set; }
        public long? RecipeId { get; set; }
        public long? RecipeItemId { get; set; }
        public long? ReceiptId { get; set; }
        public long? ReceiptItemId { get; set; }
        public long? WorkOrderId { get; set; }
        public long? WorkOrderItemId { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? WarehouseId { get; set; }
        public short? Status { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public int? UnitId { get; set; }
        public decimal? Quantity { get; set; }
        public short? TranStatus { get; set; }
        public string? TranMessage { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpMaterialRequirement? MaterialRequirement { get; set; }
        public virtual ErpMaterialRequirementItem? ParentItem { get; set; }
        public virtual MetaUnitSetItem? Unit { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ICollection<ErpMaterialRequirementItem> InverseParentItem { get; set; }
    }
}
