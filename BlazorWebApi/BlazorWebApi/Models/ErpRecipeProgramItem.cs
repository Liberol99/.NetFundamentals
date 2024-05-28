using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpRecipeProgramItem
    {
        public long RecId { get; set; }
        public int? RecipeProgramId { get; set; }
        public int? ItemOrderNo { get; set; }
        public int? AutomationOrderNo { get; set; }
        public long? InventoryId { get; set; }
        public decimal? RecipeRate { get; set; }
        public decimal? RecipeQuantity { get; set; }
        public string? SpecialCode { get; set; }
        public byte? CalcType { get; set; }
        public decimal? SpecialLiquor { get; set; }
        public decimal? WetPickRate { get; set; }
        public decimal? MinimumLevel { get; set; }
        public decimal? DyeSolutions { get; set; }
        public decimal? RecipeFactor { get; set; }
        public decimal? RecipeDivisor { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpRecipeProgram? RecipeProgram { get; set; }
    }
}
