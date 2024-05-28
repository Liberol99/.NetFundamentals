using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpLabRecipeItem
    {
        public long RecId { get; set; }
        public long? LabRecipeId { get; set; }
        public long? LabRecipeRevId { get; set; }
        public short? ItemType { get; set; }
        public int? ItemOrderNo { get; set; }
        public int? AutomationOrderNo { get; set; }
        public long? InventoryId { get; set; }
        public decimal? RecipeRate { get; set; }
        public decimal? RecipeQuantity { get; set; }
        public string? SpecialCode { get; set; }
        public int? ExpenseId { get; set; }
        public string? Explanation { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexUnitPrice { get; set; }
        public short? DyeingAndWashingType { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpExpense? Expense { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpLabRecipe? LabRecipe { get; set; }
        public virtual ErpLabRecipeRev? LabRecipeRev { get; set; }
    }
}
