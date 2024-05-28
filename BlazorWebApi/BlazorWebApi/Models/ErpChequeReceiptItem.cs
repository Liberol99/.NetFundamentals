using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpChequeReceiptItem
    {
        public long RecId { get; set; }
        public long? ChequeReceiptId { get; set; }
        public short? ChequeType { get; set; }
        public long? ChequeId { get; set; }
        public byte? ControlCode { get; set; }
        public short? ItemNo { get; set; }
        public byte? Status { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? BankAccountId { get; set; }
        public decimal? Amount { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexAmount { get; set; }
        public long? CurrentAccountReceiptId { get; set; }
        public long? GlreceiptId { get; set; }
        public long? BankReceiptId { get; set; }
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
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }

        public virtual ErpBankAccount? BankAccount { get; set; }
        public virtual ErpBankReceipt? BankReceipt { get; set; }
        public virtual ErpCheque? Cheque { get; set; }
        public virtual ErpChequeReceipt? ChequeReceipt { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpCurrentAccountReceiptItem? CurrentAccountReceipt { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGlreceipt? Glreceipt { get; set; }
    }
}
