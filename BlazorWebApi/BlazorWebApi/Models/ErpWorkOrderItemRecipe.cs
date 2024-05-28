using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWorkOrderItemRecipe
    {
        public ErpWorkOrderItemRecipe()
        {
            InverseParent = new HashSet<ErpWorkOrderItemRecipe>();
        }

        public long RecId { get; set; }
        public long? RecipeId { get; set; }
        public byte? RecipeType { get; set; }
        public long? ParentId { get; set; }
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
        public decimal? RecipeRate { get; set; }
        public decimal? RecipeQuantity { get; set; }
        public decimal? DilutionRate { get; set; }
        public decimal? WeighingQuantity { get; set; }
        public decimal? Wastage { get; set; }
        public int? OutWarehouseId { get; set; }
        public decimal? Price { get; set; }
        public int? ForexId { get; set; }
        public int? ExpenseId { get; set; }
        public byte[]? Condition { get; set; }
        public string? Variant1 { get; set; }
        public string? Variant2 { get; set; }
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
        public long? WorkOrderItemId { get; set; }
        public long? InventoryVariantId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpExpense? Expense { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpWarehouse? OutWarehouse { get; set; }
        public virtual ErpInventory? OwnerInventory { get; set; }
        public virtual ErpService? OwnerService { get; set; }
        public virtual ErpWorkOrderItemRecipe? Parent { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpRecipe? Recipe { get; set; }
        public virtual ErpRecipeProgram? RecipeProgram { get; set; }
        public virtual ErpInventoryUnitItemSize? Unit { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderItem { get; set; }
        public virtual ErpWorkOrder? WorkOrderReceipt { get; set; }
        public virtual ICollection<ErpWorkOrderItemRecipe> InverseParent { get; set; }
    }
}
