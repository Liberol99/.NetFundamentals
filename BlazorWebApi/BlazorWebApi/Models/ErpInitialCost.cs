using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInitialCost
    {
        public ErpInitialCost()
        {
            ErpInitialCostAttachments = new HashSet<ErpInitialCostAttachment>();
            ErpInitialCostItems = new HashSet<ErpInitialCostItem>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? InitialCostCode { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? InventoryId { get; set; }
        public long? WorkOrderId { get; set; }
        public long? WorkOrderItemId { get; set; }
        public short? CostType { get; set; }
        public string? GroupCode { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public DateTime? CostDate { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public int? Forex2Id { get; set; }
        public decimal? Forex2Rate { get; set; }
        public int? Forex3Id { get; set; }
        public decimal? Forex3Rate { get; set; }
        public long? LabRecipeId { get; set; }
        public long? RecipeId { get; set; }
        public long? PatternRecipeId { get; set; }
        public int? RouteId { get; set; }
        public decimal? GivenPrice { get; set; }
        public decimal? CalculatedPrice { get; set; }
        public decimal? CostAmount1 { get; set; }
        public decimal? CostAmount2 { get; set; }
        public decimal? WastagePercent { get; set; }
        public decimal? WastageAmount { get; set; }
        public decimal? CommissionPercent { get; set; }
        public decimal? CommissionAmount { get; set; }
        public decimal? ProfitPercent { get; set; }
        public decimal? ProfitAmount { get; set; }
        public string? Explanation { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? ExpenseRate { get; set; }
        public decimal? ExpenseAmount { get; set; }
        public decimal? SubDiscountAmount { get; set; }
        public decimal? SubExpenseAmount { get; set; }
        public decimal? OrderQuantity { get; set; }
        public string? PartyNo { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public byte? InUse { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public decimal? CommissionPercent2 { get; set; }
        public decimal? CommissionPercent3 { get; set; }
        public decimal? CommissionAmount2 { get; set; }
        public decimal? CommissionAmount3 { get; set; }
        public string? ApprovedExplanation { get; set; }
        public decimal? SubCostAmount1 { get; set; }
        public decimal? SubWastageAmount { get; set; }
        public decimal? SubProfitAmount { get; set; }
        public decimal? SubCommissionAmount { get; set; }
        public decimal? SubCalculatedPrice { get; set; }
        public decimal? SubGivenPrice { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual MetaForex? Forex2 { get; set; }
        public virtual MetaForex? Forex3 { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpLabRecipe? LabRecipe { get; set; }
        public virtual ErpLabRecipe? PatternRecipe { get; set; }
        public virtual ErpRecipe? Recipe { get; set; }
        public virtual ErpRoute? Route { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderItem { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpInitialCostAttachment> ErpInitialCostAttachments { get; set; }
        public virtual ICollection<ErpInitialCostItem> ErpInitialCostItems { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
    }
}
