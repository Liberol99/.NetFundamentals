using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpChequeReceipt
    {
        public ErpChequeReceipt()
        {
            ErpChequeReceiptAttachments = new HashSet<ErpChequeReceiptAttachment>();
            ErpChequeReceiptItems = new HashSet<ErpChequeReceiptItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? TransferWorkplaceId { get; set; }
        public short? ReceiptType { get; set; }
        public string? ReceiptNo { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public byte? Status { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? BankAccountId { get; set; }
        public int? CashId { get; set; }
        public int? CostCenterId { get; set; }
        public int? ProjectId { get; set; }
        public byte? ControlCode { get; set; }
        public string? DocumentNo { get; set; }
        public string? Explanation { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public short? AverageDays { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public int? ForexRateId { get; set; }
        public decimal? TotalAmountForex { get; set; }
        public decimal? TotalOutflowAmountForex { get; set; }
        public decimal? GpsXcoordinate { get; set; }
        public decimal? GpsYcoordinate { get; set; }
        public long? BankReceiptId { get; set; }
        public long? CurrentAccountReceiptId { get; set; }
        public long? GlreceiptId { get; set; }
        public long? BankCreditId { get; set; }
        public long? ReceiptPaymentItemId { get; set; }
        public byte? IsPaymentPlanning { get; set; }
        public byte? IsPrinted { get; set; }
        public short? PageCount { get; set; }
        public byte? IsOpening { get; set; }
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
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public string? DocumentSerialNo { get; set; }

        public virtual ErpBankAccount? BankAccount { get; set; }
        public virtual ErpBankCredit? BankCredit { get; set; }
        public virtual ErpBankReceipt? BankReceipt { get; set; }
        public virtual ErpCash? Cash { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpCurrentAccountReceipt? CurrentAccountReceipt { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual MetaForexPrm? ForexRateNavigation { get; set; }
        public virtual ErpGlreceipt? Glreceipt { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpReceiptPaymentItem? ReceiptPaymentItem { get; set; }
        public virtual ErpWorkplace? TransferWorkplace { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpChequeReceiptAttachment> ErpChequeReceiptAttachments { get; set; }
        public virtual ICollection<ErpChequeReceiptItem> ErpChequeReceiptItems { get; set; }
    }
}
