using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpRecipeProgram
    {
        public ErpRecipeProgram()
        {
            ErpLabRecipeDyeingRecipeProgram2s = new HashSet<ErpLabRecipe>();
            ErpLabRecipeDyeingRecipeProgram3s = new HashSet<ErpLabRecipe>();
            ErpLabRecipeDyeingRecipePrograms = new HashSet<ErpLabRecipe>();
            ErpLabRecipeRevDyeingRecipeProgram2s = new HashSet<ErpLabRecipeRev>();
            ErpLabRecipeRevDyeingRecipeProgram3s = new HashSet<ErpLabRecipeRev>();
            ErpLabRecipeRevDyeingRecipePrograms = new HashSet<ErpLabRecipeRev>();
            ErpLabRecipeRevPatternRecipePrograms = new HashSet<ErpLabRecipeRev>();
            ErpLabRecipeRevWashingRecipeProgram2s = new HashSet<ErpLabRecipeRev>();
            ErpLabRecipeRevWashingRecipeProgram3s = new HashSet<ErpLabRecipeRev>();
            ErpLabRecipeRevWashingRecipePrograms = new HashSet<ErpLabRecipeRev>();
            ErpLabRecipeWashingRecipeProgram2s = new HashSet<ErpLabRecipe>();
            ErpLabRecipeWashingRecipeProgram3s = new HashSet<ErpLabRecipe>();
            ErpLabRecipeWashingRecipePrograms = new HashSet<ErpLabRecipe>();
            ErpRecipeItems = new HashSet<ErpRecipeItem>();
            ErpRecipeOprRecipeProgram2s = new HashSet<ErpRecipeOpr>();
            ErpRecipeOprRecipePrograms = new HashSet<ErpRecipeOpr>();
            ErpRecipeProgramItems = new HashSet<ErpRecipeProgramItem>();
            ErpRouteItems = new HashSet<ErpRouteItem>();
            ErpWorkOrderItemProcesses = new HashSet<ErpWorkOrderItemProcess>();
            ErpWorkOrderItemRecipes = new HashSet<ErpWorkOrderItemRecipe>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? ProgramType { get; set; }
        public int? ProgramTypeId { get; set; }
        public string? ProgramCode { get; set; }
        public string? ProgramName { get; set; }
        public string? AutomationCode { get; set; }
        public int? ProcessId { get; set; }
        public long? InventoryId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? CalcType { get; set; }
        public DateTime? ProcessingTime { get; set; }
        public decimal? SpecialLiquor { get; set; }
        public decimal? WetPickRate { get; set; }
        public decimal? MinimumLevel { get; set; }
        public decimal? DyeSolutions { get; set; }
        public decimal? RecipeFactor { get; set; }
        public decimal? RecipeDivisor { get; set; }
        public byte[]? ProgramGraphics { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpRecipeProgramType? ProgramTypeNavigation { get; set; }
        public virtual ICollection<ErpLabRecipe> ErpLabRecipeDyeingRecipeProgram2s { get; set; }
        public virtual ICollection<ErpLabRecipe> ErpLabRecipeDyeingRecipeProgram3s { get; set; }
        public virtual ICollection<ErpLabRecipe> ErpLabRecipeDyeingRecipePrograms { get; set; }
        public virtual ICollection<ErpLabRecipeRev> ErpLabRecipeRevDyeingRecipeProgram2s { get; set; }
        public virtual ICollection<ErpLabRecipeRev> ErpLabRecipeRevDyeingRecipeProgram3s { get; set; }
        public virtual ICollection<ErpLabRecipeRev> ErpLabRecipeRevDyeingRecipePrograms { get; set; }
        public virtual ICollection<ErpLabRecipeRev> ErpLabRecipeRevPatternRecipePrograms { get; set; }
        public virtual ICollection<ErpLabRecipeRev> ErpLabRecipeRevWashingRecipeProgram2s { get; set; }
        public virtual ICollection<ErpLabRecipeRev> ErpLabRecipeRevWashingRecipeProgram3s { get; set; }
        public virtual ICollection<ErpLabRecipeRev> ErpLabRecipeRevWashingRecipePrograms { get; set; }
        public virtual ICollection<ErpLabRecipe> ErpLabRecipeWashingRecipeProgram2s { get; set; }
        public virtual ICollection<ErpLabRecipe> ErpLabRecipeWashingRecipeProgram3s { get; set; }
        public virtual ICollection<ErpLabRecipe> ErpLabRecipeWashingRecipePrograms { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItems { get; set; }
        public virtual ICollection<ErpRecipeOpr> ErpRecipeOprRecipeProgram2s { get; set; }
        public virtual ICollection<ErpRecipeOpr> ErpRecipeOprRecipePrograms { get; set; }
        public virtual ICollection<ErpRecipeProgramItem> ErpRecipeProgramItems { get; set; }
        public virtual ICollection<ErpRouteItem> ErpRouteItems { get; set; }
        public virtual ICollection<ErpWorkOrderItemProcess> ErpWorkOrderItemProcesses { get; set; }
        public virtual ICollection<ErpWorkOrderItemRecipe> ErpWorkOrderItemRecipes { get; set; }
    }
}
