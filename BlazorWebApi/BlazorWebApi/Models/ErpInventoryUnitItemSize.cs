using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryUnitItemSize
    {
        public ErpInventoryUnitItemSize()
        {
            ErpInventories = new HashSet<ErpInventory>();
            ErpInventoryAlternatives = new HashSet<ErpInventoryAlternative>();
            ErpInventoryBarcodes = new HashSet<ErpInventoryBarcode>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpRecipeItems = new HashSet<ErpRecipeItem>();
            ErpRecipes = new HashSet<ErpRecipe>();
            ErpRequirements = new HashSet<ErpRequirement>();
            ErpWorkOrderItemRecipes = new HashSet<ErpWorkOrderItemRecipe>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
        }

        public int RecId { get; set; }
        public long? InventoryId { get; set; }
        public int? UnitItemId { get; set; }
        public decimal? UnitFactor { get; set; }
        public decimal? UnitDivisor { get; set; }
        public decimal? UnitWidth { get; set; }
        public int? UnitWidthUnitId { get; set; }
        public decimal? UnitLength { get; set; }
        public int? UnitLengthUnitId { get; set; }
        public decimal? UnitHeight { get; set; }
        public int? UnitHeightUnitId { get; set; }
        public decimal? UnitArea { get; set; }
        public int? UnitAreaUnitId { get; set; }
        public decimal? UnitVolume { get; set; }
        public int? UnitVolumeUnitId { get; set; }
        public decimal? UnitWeight { get; set; }
        public int? UnitWeightUnitId { get; set; }
        public byte? UseForCommon { get; set; }
        public byte? UseForPurchase { get; set; }
        public byte? UseForSale { get; set; }
        public byte? UseForRecipe { get; set; }
        public byte? IsMainUnit { get; set; }
        public byte? IsDivisible { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
        public virtual MetaUnitSetItem? UnitItem { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpInventoryAlternative> ErpInventoryAlternatives { get; set; }
        public virtual ICollection<ErpInventoryBarcode> ErpInventoryBarcodes { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItems { get; set; }
        public virtual ICollection<ErpRecipe> ErpRecipes { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirements { get; set; }
        public virtual ICollection<ErpWorkOrderItemRecipe> ErpWorkOrderItemRecipes { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
    }
}
