using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class PosMenuItem
    {
        public PosMenuItem()
        {
            InverseParentItem = new HashSet<PosMenuItem>();
        }

        public long RecId { get; set; }
        public long? MenuId { get; set; }
        public byte? MenuType { get; set; }
        public byte? IsMenuHeader { get; set; }
        public byte? IsPopup { get; set; }
        public string? Explanation { get; set; }
        public byte[]? MenuImage { get; set; }
        public short? ItemOrderNo { get; set; }
        public long? ParentItemId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryGroupId { get; set; }
        public int? AdditionalAttrSetId { get; set; }
        public long? AdditionalAttrSetItemId { get; set; }
        public int? PromotionalAttrSetId { get; set; }
        public long? PromotionalAttrSetItemId { get; set; }
        public long? ServiceId { get; set; }
        public byte? CheckInStock { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public short? ValidDays { get; set; }
        public short? FreeItemQuantity { get; set; }
        public byte? ButtonSize { get; set; }
        public string? PrinterNames { get; set; }
        public long? SetMenuOrAdditionalInventoryId { get; set; }
        public decimal? MenuQuantity { get; set; }
        public decimal? MenuPrice { get; set; }
        public byte? IsMustExplanation { get; set; }
        public string? InventoryCodeTepmlate { get; set; }
        public byte? HasDontTotalEffect { get; set; }
        public short? GroupNo { get; set; }
        public byte? HasSellDifferentQuantities { get; set; }
        public byte? HasSellDifferentPrices { get; set; }
        public byte? IsStopSale { get; set; }
        public byte? IsShowQrmenu { get; set; }
        public byte? IsBoxedSale { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? IsRemovalMaterial { get; set; }

        public virtual ErpInventoryAttributeSet? AdditionalAttrSet { get; set; }
        public virtual ErpInventoryAttributeSetItem? AdditionalAttrSetItem { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryGroup? InventoryGroup { get; set; }
        public virtual PosMenu? Menu { get; set; }
        public virtual PosMenuItem? ParentItem { get; set; }
        public virtual ErpInventoryAttributeSet? PromotionalAttrSet { get; set; }
        public virtual ErpInventoryAttributeSetItem? PromotionalAttrSetItem { get; set; }
        public virtual ErpService? Service { get; set; }
        public virtual ErpInventory? SetMenuOrAdditionalInventory { get; set; }
        public virtual ICollection<PosMenuItem> InverseParentItem { get; set; }
    }
}
