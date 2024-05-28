using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCurrentAccountReceiptItem
    {
        public ErpCurrentAccountReceiptItem()
        {
            ErpBankReceiptItems = new HashSet<ErpBankReceiptItem>();
            ErpChequeReceiptItems = new HashSet<ErpChequeReceiptItem>();
            ErpInventoryReceiptItemPayments = new HashSet<ErpInventoryReceiptItemPayment>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public long? CurrentAccountReceiptId { get; set; }
        public short? ReceiptType { get; set; }
        public short? ReceiptSubType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? BankAccountId { get; set; }
        public int? CostCenterId { get; set; }
        public long? DealerId { get; set; }
        public int? ItemOrderNo { get; set; }
        public DateTime? TermDate { get; set; }
        public string? DocumentNo { get; set; }
        public string? Explanation { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public int? ProjectId { get; set; }
        public long? PaymentPlanId { get; set; }
        public long? EmployeeId { get; set; }
        public long? CashierId { get; set; }
        public long? CourierId { get; set; }
        public long? LoyalityCardId { get; set; }
        public int? CashId { get; set; }
        public int? PaymentCardId { get; set; }
        public int? ExpenseId { get; set; }
        public int? GlaccountId { get; set; }
        public long? RefundChequeId { get; set; }
        public long? GiftVoucherId { get; set; }
        public byte? ControlCode { get; set; }
        public string? PaymentCardNo { get; set; }
        public short? InstallmentCount { get; set; }
        public int? Bonus { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexDebit { get; set; }
        public decimal? ForexCredit { get; set; }
        public int? TransactionForexId { get; set; }
        public decimal? TransactionForexRate { get; set; }
        public decimal? TransactionForexDebit { get; set; }
        public decimal? TransactionForexCredit { get; set; }
        public decimal? Forex2Rate { get; set; }
        public decimal? Debit2 { get; set; }
        public decimal? Credit2 { get; set; }
        public decimal? Forex3Rate { get; set; }
        public decimal? Debit3 { get; set; }
        public decimal? Credit3 { get; set; }
        public decimal? GpsXcoordinate { get; set; }
        public decimal? GpsYcoordinate { get; set; }
        public short? SourceModule { get; set; }
        public short? SourceType { get; set; }
        public long? SourceId { get; set; }
        public long? SourceItemId { get; set; }
        public byte? IsForexCorrection { get; set; }
        public long? PosReceiptId { get; set; }
        public long? OrderReceiptId { get; set; }
        public long? GlreceiptId { get; set; }
        public long? CustomerTransactionId { get; set; }
        public long? ReceiptPaymentItemId { get; set; }
        public byte? IsPaymentPlanning { get; set; }
        public byte? IsCorrection { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? CustomerInterestRate { get; set; }
        public byte? IsInterestUpdate { get; set; }
        public long? InvoiceId { get; set; }
        public long? WorkOrderItemId { get; set; }
        public long? ShiftsId { get; set; }
        public long? PosEndOfDateRaportId { get; set; }
        public int? DepartmentId { get; set; }
        public byte? IsSendOkc { get; set; }
        public byte? IsPaymentInAdvence { get; set; }
        public decimal? RealPayment { get; set; }
        public decimal? RealPaymentForex { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsForexReceipt { get; set; }
        public byte? CreatedBySystem { get; set; }
        public DateTime? InstalmentStartDate { get; set; }
        public DateTime? InstalmentEndDate { get; set; }
        public string? PosMacAddress { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }
        public string? ApprovedExplanation { get; set; }
        public byte? IsCancelled { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public string? CancelledExplanation { get; set; }
        public string? DocumentSerialNo { get; set; }
        public long? ExpoId { get; set; }
        public short? DocumentType { get; set; }
        public string? ExpenseContent { get; set; }
        public string? PlaceToTravel { get; set; }
        public string? SupplierTaxNo { get; set; }
        public string? SupplierName { get; set; }
        public byte? VatIncluded { get; set; }
        public decimal? VatRate { get; set; }
        public decimal? VatAmount { get; set; }
        public long? ServiceCardId { get; set; }

        public virtual ErpBankAccount? BankAccount { get; set; }
        public virtual ErpCash? Cash { get; set; }
        public virtual ErpEmployee? Cashier { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpEmployee? Courier { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpCurrentAccountReceipt? CurrentAccountReceipt { get; set; }
        public virtual ErpCustomerTransaction? CustomerTransaction { get; set; }
        public virtual ErpCurrentAccount? Dealer { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpExpense? Expense { get; set; }
        public virtual ErpExpo? Expo { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGiftVoucher? GiftVoucher { get; set; }
        public virtual ErpGlaccount? Glaccount { get; set; }
        public virtual ErpGlreceipt? Glreceipt { get; set; }
        public virtual ErpInvoice? Invoice { get; set; }
        public virtual ErpLoyalityCard? LoyalityCard { get; set; }
        public virtual ErpOrderReceipt? OrderReceipt { get; set; }
        public virtual ErpPaymentCard? PaymentCard { get; set; }
        public virtual ErpPaymentPlan? PaymentPlan { get; set; }
        public virtual ErpPosEndOfDateRaport? PosEndOfDateRaport { get; set; }
        public virtual ErpPo? PosReceipt { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpReceiptPaymentItem? ReceiptPaymentItem { get; set; }
        public virtual ErpRefundCheque? RefundCheque { get; set; }
        public virtual ErpService? ServiceCard { get; set; }
        public virtual PosShift? Shifts { get; set; }
        public virtual MetaForex? TransactionForex { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderItem { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpBankReceiptItem> ErpBankReceiptItems { get; set; }
        public virtual ICollection<ErpChequeReceiptItem> ErpChequeReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemPayment> ErpInventoryReceiptItemPayments { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
    }
}
