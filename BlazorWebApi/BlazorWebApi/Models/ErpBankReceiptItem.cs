using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBankReceiptItem
    {
        public ErpBankReceiptItem()
        {
            InverseBankTransferReceiptItem = new HashSet<ErpBankReceiptItem>();
        }

        public long RecId { get; set; }
        public long? BankReceiptId { get; set; }
        public short? ReceiptType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public short? ReceiptSubType { get; set; }
        public string? DocumentNo { get; set; }
        public string? SpecialCode { get; set; }
        public int? BankAccountId { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? ItemOrderNo { get; set; }
        public byte? ControlCode { get; set; }
        public long? EmployeeId { get; set; }
        public int? GlaccountId { get; set; }
        public int? PaymentCardId { get; set; }
        public string? Explanation { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexDebit { get; set; }
        public decimal? ForexCredit { get; set; }
        public decimal? Forex2Rate { get; set; }
        public decimal? Debit2 { get; set; }
        public decimal? Credit2 { get; set; }
        public decimal? Forex3Rate { get; set; }
        public decimal? Debit3 { get; set; }
        public decimal? Credit3 { get; set; }
        public int? CostCenterId { get; set; }
        public int? ProjectId { get; set; }
        public short? Status { get; set; }
        public short? TransactionType { get; set; }
        public string? CurrentAccountBank { get; set; }
        public string? CurrentAccountBankBranch { get; set; }
        public string? CurrentAccountBankIbanNo { get; set; }
        public string? CurrentAccountAccountNo { get; set; }
        public long? BankCreditItemId { get; set; }
        public long? BankTransferReceiptItemId { get; set; }
        public long? WorkOrderItemId { get; set; }
        public byte? IsDownPayment { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsForexReceipt { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public byte? IsCancelled { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public string? CancelledExplanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? DocumentSerialNo { get; set; }
        public long? ExpoId { get; set; }
        public byte? ExpoType { get; set; }
        public decimal? Expense { get; set; }
        public decimal? ForexExpense { get; set; }
        public byte? IsCompanySales { get; set; }
        public byte? SubTransactionType { get; set; }
        public decimal? TermInterestRate { get; set; }
        public decimal? TermWithholdingRate { get; set; }
        public long? TermInterestDay { get; set; }
        public long? CurrentAccountReceiptItemId { get; set; }
        public decimal? TermInterestForexRate { get; set; }
        public decimal? TermWithholdingForexRate { get; set; }

        public virtual ErpBankAccount? BankAccount { get; set; }
        public virtual ErpBankCreditItem? BankCreditItem { get; set; }
        public virtual ErpBankReceipt? BankReceipt { get; set; }
        public virtual ErpBankReceiptItem? BankTransferReceiptItem { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpCurrentAccountReceiptItem? CurrentAccountReceiptItem { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpExpo? Expo { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGlaccount? Glaccount { get; set; }
        public virtual ErpPaymentCard? PaymentCard { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderItem { get; set; }
        public virtual ICollection<ErpBankReceiptItem> InverseBankTransferReceiptItem { get; set; }
    }
}
