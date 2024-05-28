using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpLabRecipeRev
    {
        public ErpLabRecipeRev()
        {
            ErpLabRecipeItems = new HashSet<ErpLabRecipeItem>();
            ErpRecipeLabRecipeRev2s = new HashSet<ErpRecipe>();
            ErpRecipeLabRecipeRevs = new HashSet<ErpRecipe>();
            ErpRecipeOprs = new HashSet<ErpRecipeOpr>();
            InverseParent = new HashSet<ErpLabRecipeRev>();
        }

        public long RecId { get; set; }
        public long? LabRecipeId { get; set; }
        public int? ItemOrderNo { get; set; }
        public int? RevNo { get; set; }
        public int? PatternRecipeProgramId { get; set; }
        public string? Explanation { get; set; }
        public DateTime? WorkDate { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public byte? IsConfirm { get; set; }
        public byte? IsRepeat { get; set; }
        public byte? IsTrim { get; set; }
        public string? SpecialCode { get; set; }
        public decimal? Rakle { get; set; }
        public decimal? Viscosity { get; set; }
        public int? MeshNo { get; set; }
        public decimal? DyeRate { get; set; }
        public decimal? DilutionRate { get; set; }
        public byte[]? DyeingGraphics { get; set; }
        public byte[]? DyeingGraphics2 { get; set; }
        public byte[]? WashingGraphics { get; set; }
        public byte[]? WashingGraphics2 { get; set; }
        public int? ForegroundColor { get; set; }
        public int? BackgroundColor { get; set; }
        public int? DyeingRecipeProgramId { get; set; }
        public int? DyeingRecipeProgram2Id { get; set; }
        public int? DyeingRecipeProgram3Id { get; set; }
        public int? WashingRecipeProgramId { get; set; }
        public int? WashingRecipeProgram2Id { get; set; }
        public int? WashingRecipeProgram3Id { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public long? ParentId { get; set; }

        public virtual ErpRecipeProgram? DyeingRecipeProgram { get; set; }
        public virtual ErpRecipeProgram? DyeingRecipeProgram2 { get; set; }
        public virtual ErpRecipeProgram? DyeingRecipeProgram3 { get; set; }
        public virtual ErpLabRecipe? LabRecipe { get; set; }
        public virtual ErpLabRecipeRev? Parent { get; set; }
        public virtual ErpRecipeProgram? PatternRecipeProgram { get; set; }
        public virtual ErpRecipeProgram? WashingRecipeProgram { get; set; }
        public virtual ErpRecipeProgram? WashingRecipeProgram2 { get; set; }
        public virtual ErpRecipeProgram? WashingRecipeProgram3 { get; set; }
        public virtual ICollection<ErpLabRecipeItem> ErpLabRecipeItems { get; set; }
        public virtual ICollection<ErpRecipe> ErpRecipeLabRecipeRev2s { get; set; }
        public virtual ICollection<ErpRecipe> ErpRecipeLabRecipeRevs { get; set; }
        public virtual ICollection<ErpRecipeOpr> ErpRecipeOprs { get; set; }
        public virtual ICollection<ErpLabRecipeRev> InverseParent { get; set; }
    }
}
