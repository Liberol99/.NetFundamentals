using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpRecipeOpr
    {
        public long RecId { get; set; }
        public long? RecipeId { get; set; }
        public int? RecipeProgramTypeId { get; set; }
        public int? RecipeProgramId { get; set; }
        public int? RecipeProgram2Id { get; set; }
        public int? ItemOrderNo { get; set; }
        public long? LabRecipeRevId { get; set; }
        public long? RouteItemId { get; set; }
        public byte? CalcType { get; set; }
        public DateTime? ProcessingTime { get; set; }
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
        public int? ProcessId { get; set; }

        public virtual ErpLabRecipeRev? LabRecipeRev { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpRecipe? Recipe { get; set; }
        public virtual ErpRecipeProgram? RecipeProgram { get; set; }
        public virtual ErpRecipeProgram? RecipeProgram2 { get; set; }
        public virtual ErpRecipeProgramType? RecipeProgramType { get; set; }
        public virtual ErpRouteItem? RouteItem { get; set; }
    }
}
