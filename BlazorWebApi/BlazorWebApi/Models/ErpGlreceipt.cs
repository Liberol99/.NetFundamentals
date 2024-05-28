using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpGlreceipt
    {
        public ErpGlreceipt()
        {
            ErpActualCosts = new HashSet<ErpActualCost>();
            ErpBankCreditGlreceiptId1Navigations = new HashSet<ErpBankCredit>();
            ErpBankCreditGlreceipts = new HashSet<ErpBankCredit>();
            ErpBankReceipts = new HashSet<ErpBankReceipt>();
            ErpChequeReceiptItems = new HashSet<ErpChequeReceiptItem>();
            ErpChequeReceipts = new HashSet<ErpChequeReceipt>();
            ErpContracts = new HashSet<ErpContract>();
            ErpCostCenterDistributions = new HashSet<ErpCostCenterDistribution>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCurrentAccountReceipts = new HashSet<ErpCurrentAccountReceipt>();
            ErpDemandReceipts = new HashSet<ErpDemandReceipt>();
            ErpGlreceiptIntegrations = new HashSet<ErpGlreceiptIntegration>();
            ErpGlreceiptItems = new HashSet<ErpGlreceiptItem>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInvoiceGlreceiptId1Navigations = new HashSet<ErpInvoice>();
            ErpInvoiceGlreceipts = new HashSet<ErpInvoice>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
            ErpReceiptPaymentItems = new HashSet<ErpReceiptPaymentItem>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public short? ReceiptType { get; set; }
        public string? ReceiptNo { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public DateTime? ReceiptTime { get; set; }
        public string? DocumentNo { get; set; }
        public string? DocumentType { get; set; }
        public string? Explanation { get; set; }
        public byte? ControlCode { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public int? CashId { get; set; }
        public int? RegBookNo { get; set; }
        public int? ProjectId { get; set; }
        public short? SourceModule { get; set; }
        public long? SourceId { get; set; }
        public long? SourceItemId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit2 { get; set; }
        public decimal? Credit2 { get; set; }
        public decimal? Debit3 { get; set; }
        public decimal? Credit3 { get; set; }
        public byte? IsPrinted { get; set; }
        public short? PageCount { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public byte? IsClosed { get; set; }
        public byte? IsCancelled { get; set; }
        public string? CancelledExplanation { get; set; }
        public short? TfrsUfrsType { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public string? DocumentSerialNo { get; set; }
        public short? SourceType { get; set; }

        public virtual ErpCash? Cash { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpActualCost> ErpActualCosts { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCreditGlreceiptId1Navigations { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCreditGlreceipts { get; set; }
        public virtual ICollection<ErpBankReceipt> ErpBankReceipts { get; set; }
        public virtual ICollection<ErpChequeReceiptItem> ErpChequeReceiptItems { get; set; }
        public virtual ICollection<ErpChequeReceipt> ErpChequeReceipts { get; set; }
        public virtual ICollection<ErpContract> ErpContracts { get; set; }
        public virtual ICollection<ErpCostCenterDistribution> ErpCostCenterDistributions { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpCurrentAccountReceipt> ErpCurrentAccountReceipts { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceipts { get; set; }
        public virtual ICollection<ErpGlreceiptIntegration> ErpGlreceiptIntegrations { get; set; }
        public virtual ICollection<ErpGlreceiptItem> ErpGlreceiptItems { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceGlreceiptId1Navigations { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceGlreceipts { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
        public virtual ICollection<ErpReceiptPaymentItem> ErpReceiptPaymentItems { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
    }
}
