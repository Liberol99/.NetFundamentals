using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpDiscount
    {
        public ErpDiscount()
        {
            ErpContractItems = new HashSet<ErpContractItem>();
            ErpCurrentAccountPurchaseDiscounts = new HashSet<ErpCurrentAccount>();
            ErpCurrentAccountSalesDiscounts = new HashSet<ErpCurrentAccount>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public byte? DiscountType { get; set; }
        public string? DiscountCode { get; set; }
        public string? Explanation { get; set; }
        public decimal? DiscountRate { get; set; }
        public string? Formula { get; set; }
        public byte? IsRateFormula { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public int? GlaccountId { get; set; }
        public int? CostCenterId { get; set; }
        public int? ForexId { get; set; }
        public decimal? Price { get; set; }
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
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGlaccount? Glaccount { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItems { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccountPurchaseDiscounts { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccountSalesDiscounts { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
    }
}
