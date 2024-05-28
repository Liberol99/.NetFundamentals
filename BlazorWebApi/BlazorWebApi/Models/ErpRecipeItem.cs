using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpRecipeItem
    {
        public ErpRecipeItem()
        {
            ErpRecipeItemWastageWarehouses = new HashSet<ErpRecipeItemWastageWarehouse>();
            InverseParentItem = new HashSet<ErpRecipeItem>();
        }

        public long RecId { get; set; }
        public long? RecipeId { get; set; }
        public byte? RecipeType { get; set; }
        public long? OwnerInventoryId { get; set; }
        public long? OwnerServiceId { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? ProcessId { get; set; }
        public byte? ItemType { get; set; }
        public short? ItemNo { get; set; }
        public byte? InOut { get; set; }
        public short? GroupNo { get; set; }
        public long? InventoryId { get; set; }
        public string? Explanation { get; set; }
        public byte? ControlType { get; set; }
        public int? UnitId { get; set; }
        public decimal? Quantity { get; set; }
        public long? RecipeOprId { get; set; }
        public decimal? RecipeRate { get; set; }
        public decimal? RecipeQuantity { get; set; }
        public decimal? MinimumWastage { get; set; }
        public decimal? Wastage { get; set; }
        public int? OutWarehouseId { get; set; }
        public decimal? Price { get; set; }
        public int? ForexId { get; set; }
        public int? ExpenseId { get; set; }
        public byte[]? Condition { get; set; }
        public string? Variant1 { get; set; }
        public string? Variant2 { get; set; }
        public string? Variant3 { get; set; }
        public string? Variant4 { get; set; }
        public string? Variant5 { get; set; }
        public int? RouteId { get; set; }
        public short? OperationType { get; set; }
        public string? MatrixDefinition { get; set; }
        public int? AutomationOrderNo { get; set; }
        public byte? CalcType { get; set; }
        public decimal? SpecialLiquor { get; set; }
        public decimal? WetPickRate { get; set; }
        public decimal? MinimumLevel { get; set; }
        public decimal? DyeSolutions { get; set; }
        public decimal? RecipeFactor { get; set; }
        public decimal? RecipeDivisor { get; set; }
        public byte[]? ProgramGraphics { get; set; }
        public byte? IsMaster { get; set; }
        public byte? IsAddition { get; set; }
        public int? AdditionNo { get; set; }
        public int? RecipeProgramId { get; set; }
        public long? WorkOrderReceiptId { get; set; }
        public long? InventoryVariantId { get; set; }
        public int? WastageWarehouseId { get; set; }
        public int? ProjectId { get; set; }
        public long? ServiceCardId { get; set; }
        public long? ResourceId { get; set; }
        public DateTime? TermDate { get; set; }
        public byte? HasSellDifferentQuantities { get; set; }
        public byte? InUse { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public byte? IsCancelled { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public string? CancelledExplanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }
        public byte? RequirementType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Filters { get; set; }
        public decimal? CutWastage { get; set; }
        public decimal? DyeWastage { get; set; }
        public decimal? PrintWastage { get; set; }
        public decimal? RawWidth { get; set; }
        public decimal? RawGram { get; set; }
        public decimal? DyeWidth { get; set; }
        public decimal? DyeGram { get; set; }
        public string? Fein { get; set; }
        public string? Pus { get; set; }
        public decimal? FinalWidth { get; set; }
        public decimal? FinalGram { get; set; }
        public decimal? MarkerWidth { get; set; }
        public decimal? MarkerLength { get; set; }
        public decimal? MarkerPieces { get; set; }
        public decimal? MarkerM2gram { get; set; }
        public string? InventoryVariantIds { get; set; }
        public string? InventorySizeVariantIds { get; set; }
        public string? InventoryVariantQtys { get; set; }
        public long? ParentItemId { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpExpense? Expense { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpWarehouse? OutWarehouse { get; set; }
        public virtual ErpInventory? OwnerInventory { get; set; }
        public virtual ErpService? OwnerService { get; set; }
        public virtual ErpRecipeItem? ParentItem { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpRecipe? Recipe { get; set; }
        public virtual ErpRecipeProgram? RecipeProgram { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpRoute? Route { get; set; }
        public virtual ErpInventoryUnitItemSize? Unit { get; set; }
        public virtual ErpWarehouse? WastageWarehouse { get; set; }
        public virtual ErpWorkOrder? WorkOrderReceipt { get; set; }
        public virtual ICollection<ErpRecipeItemWastageWarehouse> ErpRecipeItemWastageWarehouses { get; set; }
        public virtual ICollection<ErpRecipeItem> InverseParentItem { get; set; }
    }
}
