using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpLabRecipe
    {
        public ErpLabRecipe()
        {
            ErpInitialCostLabRecipes = new HashSet<ErpInitialCost>();
            ErpInitialCostPatternRecipes = new HashSet<ErpInitialCost>();
            ErpInventoryReceiptItemLabRecipes = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceiptItemPatternRecipes = new HashSet<ErpInventoryReceiptItem>();
            ErpLabRecipeItems = new HashSet<ErpLabRecipeItem>();
            ErpLabRecipeRevs = new HashSet<ErpLabRecipeRev>();
            ErpOrderReceiptItemLabRecipes = new HashSet<ErpOrderReceiptItem>();
            ErpOrderReceiptItemPatternRecipes = new HashSet<ErpOrderReceiptItem>();
            ErpPlanningLabRecipes = new HashSet<ErpPlanning>();
            ErpPlanningPatternRecipes = new HashSet<ErpPlanning>();
            ErpQualityControls = new HashSet<ErpQualityControl>();
            ErpRecipeLabRecipes = new HashSet<ErpRecipe>();
            ErpRecipePatternRecipes = new HashSet<ErpRecipe>();
            ErpWorkOrderItemLabRecipes = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderItemPatternRecipes = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderLabRecipes = new HashSet<ErpWorkOrder>();
            ErpWorkOrderPatternRecipes = new HashSet<ErpWorkOrder>();
            InverseParent = new HashSet<ErpLabRecipe>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? LabRecipeCode { get; set; }
        public string? LabRecipeName { get; set; }
        public short? LabRecipeType { get; set; }
        public short? LabRecipeSubType { get; set; }
        public string? Explanation { get; set; }
        public string? PantoneNo { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? WorkDate { get; set; }
        public DateTime? DemandDate { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public byte? IsConfirm { get; set; }
        public byte? IsDemand { get; set; }
        public byte? IsRepeat { get; set; }
        public long? ParentId { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? InventoryId { get; set; }
        public long? EmployeeId { get; set; }
        public int? ForexId { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? PatternPrintingShape { get; set; }
        public string? CustomerRecipeCode { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Capacity { get; set; }
        public decimal? ReportHeight { get; set; }
        public decimal? ReportWidth { get; set; }
        public decimal? ReportSlide { get; set; }
        public decimal? EngravingHeight { get; set; }
        public decimal? EngravingWidth { get; set; }
        public decimal? Width { get; set; }
        public decimal? Weight { get; set; }
        public DateTime? TemplateInDate { get; set; }
        public DateTime? TemplateWorkDate { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public string? VariantExplanation { get; set; }
        public int? DyeingRecipeProgramId { get; set; }
        public int? DyeingRecipeProgram2Id { get; set; }
        public int? DyeingRecipeProgram3Id { get; set; }
        public int? WashingRecipeProgramId { get; set; }
        public int? WashingRecipeProgram2Id { get; set; }
        public int? WashingRecipeProgram3Id { get; set; }
        public byte[]? DyeingGraphics { get; set; }
        public byte[]? DyeingGraphics2 { get; set; }
        public byte[]? WashingGraphics { get; set; }
        public byte[]? WashingGraphics2 { get; set; }
        public int? ForegroundColor { get; set; }
        public int? BackgroundColor { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpRecipeProgram? DyeingRecipeProgram { get; set; }
        public virtual ErpRecipeProgram? DyeingRecipeProgram2 { get; set; }
        public virtual ErpRecipeProgram? DyeingRecipeProgram3 { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpLabRecipe? Parent { get; set; }
        public virtual ErpRecipeProgram? WashingRecipeProgram { get; set; }
        public virtual ErpRecipeProgram? WashingRecipeProgram2 { get; set; }
        public virtual ErpRecipeProgram? WashingRecipeProgram3 { get; set; }
        public virtual ICollection<ErpInitialCost> ErpInitialCostLabRecipes { get; set; }
        public virtual ICollection<ErpInitialCost> ErpInitialCostPatternRecipes { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItemLabRecipes { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItemPatternRecipes { get; set; }
        public virtual ICollection<ErpLabRecipeItem> ErpLabRecipeItems { get; set; }
        public virtual ICollection<ErpLabRecipeRev> ErpLabRecipeRevs { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItemLabRecipes { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItemPatternRecipes { get; set; }
        public virtual ICollection<ErpPlanning> ErpPlanningLabRecipes { get; set; }
        public virtual ICollection<ErpPlanning> ErpPlanningPatternRecipes { get; set; }
        public virtual ICollection<ErpQualityControl> ErpQualityControls { get; set; }
        public virtual ICollection<ErpRecipe> ErpRecipeLabRecipes { get; set; }
        public virtual ICollection<ErpRecipe> ErpRecipePatternRecipes { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItemLabRecipes { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItemPatternRecipes { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrderLabRecipes { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrderPatternRecipes { get; set; }
        public virtual ICollection<ErpLabRecipe> InverseParent { get; set; }
    }
}
