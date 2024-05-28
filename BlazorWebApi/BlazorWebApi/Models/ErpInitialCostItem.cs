using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInitialCostItem
    {
        public ErpInitialCostItem()
        {
            InverseParentItem = new HashSet<ErpInitialCostItem>();
        }

        public long RecId { get; set; }
        public long? InitialCostId { get; set; }
        public long? InitialCostCardId { get; set; }
        public int? ItemOrderNo { get; set; }
        public short? CostItemType { get; set; }
        public long? ParentItemId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public string? Explanation { get; set; }
        public string? Description { get; set; }
        public decimal? LotQuantity { get; set; }
        public decimal? UsageRate { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexUnitPrice { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitId { get; set; }
        public decimal? Factor { get; set; }
        public decimal? Divisor { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? NetQuantity { get; set; }
        public decimal? Wastage { get; set; }
        public string? Size { get; set; }
        public decimal? MarkerWidth { get; set; }
        public decimal? MarkerLength { get; set; }
        public decimal? MarkerPieces { get; set; }
        public decimal? MarkerM2gram { get; set; }
        public decimal? UnitGram { get; set; }
        public decimal? KnitWastage { get; set; }
        public decimal? KnitPrice { get; set; }
        public int? KnitForexId { get; set; }
        public decimal? KnitForexRate { get; set; }
        public decimal? KnitForexPrice { get; set; }
        public decimal? OperationWastage { get; set; }
        public decimal? PrintWidth { get; set; }
        public decimal? PrintM2gram { get; set; }
        public decimal? PrintWastage { get; set; }
        public decimal? PrintPrice { get; set; }
        public int? PrintForexId { get; set; }
        public decimal? PrintForexRate { get; set; }
        public decimal? PrintForexPrice { get; set; }
        public int? ProcessId { get; set; }
        public byte? FabricType { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public long? RecipeItemTransferId { get; set; }
        public short? GrossNet { get; set; }
        public decimal? CalcItemTotal { get; set; }

        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInitialCost? InitialCost { get; set; }
        public virtual ErpInitialCostCard? InitialCostCard { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpInitialCostItem? ParentItem { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual MetaUnitSetItem? Unit { get; set; }
        public virtual ICollection<ErpInitialCostItem> InverseParentItem { get; set; }
    }
}
