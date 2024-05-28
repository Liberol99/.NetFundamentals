using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPaymentPlan
    {
        public ErpPaymentPlan()
        {
            ErpContractItems = new HashSet<ErpContractItem>();
            ErpContracts = new HashSet<ErpContract>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCurrentAccounts = new HashSet<ErpCurrentAccount>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpDemandReceipts = new HashSet<ErpDemandReceipt>();
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpExpos = new HashSet<ErpExpo>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpPaymentPlanItems = new HashSet<ErpPaymentPlanItem>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
            ErpServicePriceLists = new HashSet<ErpServicePriceList>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? PlanCode { get; set; }
        public string? Explanation { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public decimal? LatePayment { get; set; }
        public decimal? EarlyPayment { get; set; }
        public byte? PaymentDays { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? UniversalCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? TermDay { get; set; }
        public byte? TermDayCalcType { get; set; }
        public byte? IsForexReceipt { get; set; }
        public byte? IsFreeOfCharge { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItems { get; set; }
        public virtual ICollection<ErpContract> ErpContracts { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccounts { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceipts { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpExpo> ErpExpos { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpPaymentPlanItem> ErpPaymentPlanItems { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
        public virtual ICollection<ErpServicePriceList> ErpServicePriceLists { get; set; }
    }
}
