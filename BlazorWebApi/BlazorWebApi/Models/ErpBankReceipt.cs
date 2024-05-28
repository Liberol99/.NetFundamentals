using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBankReceipt
    {
        public ErpBankReceipt()
        {
            ErpBankReceiptAttachments = new HashSet<ErpBankReceiptAttachment>();
            ErpBankReceiptItems = new HashSet<ErpBankReceiptItem>();
            ErpChequeReceiptItems = new HashSet<ErpChequeReceiptItem>();
            ErpChequeReceipts = new HashSet<ErpChequeReceipt>();
            ErpCurrentAccountReceipts = new HashSet<ErpCurrentAccountReceipt>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public short? ReceiptType { get; set; }
        public string? ReceiptNo { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string? DocumentNo { get; set; }
        public byte? ControlCode { get; set; }
        public int? CostCenterId { get; set; }
        public int? CashId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public string? Explanation { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexDebit { get; set; }
        public decimal? ForexCredit { get; set; }
        public decimal? Debit2 { get; set; }
        public decimal? Credit2 { get; set; }
        public decimal? Debit3 { get; set; }
        public decimal? Credit3 { get; set; }
        public decimal? GpsXcoordinate { get; set; }
        public decimal? GpsYcoordinate { get; set; }
        public short? SourceModule { get; set; }
        public long? SourceId { get; set; }
        public long? CurrentAccountReceiptId { get; set; }
        public long? GlreceiptId { get; set; }
        public long? ReceiptPaymentItemId { get; set; }
        public Guid? UniqueId { get; set; }
        public byte? IsPaymentPlanning { get; set; }
        public byte? IsPrinted { get; set; }
        public short? PageCount { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsForexReceipt { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public byte? IsClosed { get; set; }
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
        public string? ApprovedExplanation { get; set; }
        public string? DocumentSerialNo { get; set; }
        public short? ReceiptSubType { get; set; }
        public byte? IsPaymentOrder { get; set; }

        public virtual ErpCash? Cash { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpCurrentAccountReceipt? CurrentAccountReceipt { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGlreceipt? Glreceipt { get; set; }
        public virtual ErpReceiptPaymentItem? ReceiptPaymentItem { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpBankReceiptAttachment> ErpBankReceiptAttachments { get; set; }
        public virtual ICollection<ErpBankReceiptItem> ErpBankReceiptItems { get; set; }
        public virtual ICollection<ErpChequeReceiptItem> ErpChequeReceiptItems { get; set; }
        public virtual ICollection<ErpChequeReceipt> ErpChequeReceipts { get; set; }
        public virtual ICollection<ErpCurrentAccountReceipt> ErpCurrentAccountReceipts { get; set; }
    }
}
