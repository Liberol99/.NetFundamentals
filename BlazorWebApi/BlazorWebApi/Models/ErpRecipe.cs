using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpRecipe
    {
        public ErpRecipe()
        {
            ErpInitialCosts = new HashSet<ErpInitialCost>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpPlannings = new HashSet<ErpPlanning>();
            ErpRecipeAttachments = new HashSet<ErpRecipeAttachment>();
            ErpRecipeItems = new HashSet<ErpRecipeItem>();
            ErpRecipeOprs = new HashSet<ErpRecipeOpr>();
            ErpRequirements = new HashSet<ErpRequirement>();
            ErpWorkOrderItemRecipes = new HashSet<ErpWorkOrderItemRecipe>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            InverseRevisedRecipe = new HashSet<ErpRecipe>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? RecipeType { get; set; }
        public string? RecipeCode { get; set; }
        public string? Explanation { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public int? WorkplaceId { get; set; }
        public long? InventoryId { get; set; }
        public long? ServiceId { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? RouteId { get; set; }
        public decimal? Quantity { get; set; }
        public int? UnitId { get; set; }
        public int? RevisionNo { get; set; }
        public DateTime? RevisionDate { get; set; }
        public string? RevisionExplanation { get; set; }
        public long? RevisedRecipeId { get; set; }
        public long? PatternRecipeId { get; set; }
        public DateTime? RecipeDate { get; set; }
        public DateTime? RecipeTime { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? AutomationProcessNo { get; set; }
        public byte? IsContinueRecipe { get; set; }
        public decimal? WetPickRate { get; set; }
        public decimal? MinimumLevel { get; set; }
        public decimal? DyeSolutions { get; set; }
        public long? LabRecipeId { get; set; }
        public long? LabRecipeRevId { get; set; }
        public long? LabRecipeRev2Id { get; set; }
        public long? InventoryVariantId { get; set; }
        public long? InventoryGroupId { get; set; }
        public int? CategoryId { get; set; }
        public long? MarkId { get; set; }
        public long? ModelId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }
        public short? RecipeSubType { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }

        public virtual ErpCategory? Category { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryGroup? InventoryGroup { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpLabRecipe? LabRecipe { get; set; }
        public virtual ErpLabRecipeRev? LabRecipeRev { get; set; }
        public virtual ErpLabRecipeRev? LabRecipeRev2 { get; set; }
        public virtual ErpMark? Mark { get; set; }
        public virtual ErpModel? Model { get; set; }
        public virtual ErpLabRecipe? PatternRecipe { get; set; }
        public virtual ErpRecipe? RevisedRecipe { get; set; }
        public virtual ErpRoute? Route { get; set; }
        public virtual ErpService? Service { get; set; }
        public virtual ErpInventoryUnitItemSize? Unit { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpInitialCost> ErpInitialCosts { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpPlanning> ErpPlannings { get; set; }
        public virtual ICollection<ErpRecipeAttachment> ErpRecipeAttachments { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItems { get; set; }
        public virtual ICollection<ErpRecipeOpr> ErpRecipeOprs { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirements { get; set; }
        public virtual ICollection<ErpWorkOrderItemRecipe> ErpWorkOrderItemRecipes { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<ErpRecipe> InverseRevisedRecipe { get; set; }
    }
}
