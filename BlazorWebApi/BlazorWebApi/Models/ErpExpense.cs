using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpExpense
    {
        public ErpExpense()
        {
            ErpContractItems = new HashSet<ErpContractItem>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpLabRecipeItems = new HashSet<ErpLabRecipeItem>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            ErpRecipeItems = new HashSet<ErpRecipeItem>();
            ErpWorkOrderItemRecipes = new HashSet<ErpWorkOrderItemRecipe>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public byte? ExpenseType { get; set; }
        public string? ExpenseCode { get; set; }
        public string? Explanation { get; set; }
        public string? Formula { get; set; }
        public decimal? VatRate { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public int? GlaccountId { get; set; }
        public int? ReflectionGlaccountId { get; set; }
        public int? CostCenterId { get; set; }
        public byte? ExpoExpenseType { get; set; }
        public byte? IsUsedForCost { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpGlaccount? Glaccount { get; set; }
        public virtual ErpGlaccount? ReflectionGlaccount { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItems { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpLabRecipeItem> ErpLabRecipeItems { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItems { get; set; }
        public virtual ICollection<ErpWorkOrderItemRecipe> ErpWorkOrderItemRecipes { get; set; }
    }
}
