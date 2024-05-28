using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpReceiptPaymentItem
    {
        public ErpReceiptPaymentItem()
        {
            ErpBankReceipts = new HashSet<ErpBankReceipt>();
            ErpChequeReceipts = new HashSet<ErpChequeReceipt>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            InverseParent = new HashSet<ErpReceiptPaymentItem>();
        }

        public long RecId { get; set; }
        public short? SourceModule { get; set; }
        public long? SourceId { get; set; }
        public long? SourceItemId { get; set; }
        public int? ItemOrderNo { get; set; }
        public DateTime? TermDate { get; set; }
        public decimal? Amount { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexAmount { get; set; }
        public int? TransactionForexId { get; set; }
        public decimal? TransactionForexAmount { get; set; }
        public short? PaymentType { get; set; }
        public short? CalcType { get; set; }
        public string? Explanation { get; set; }
        public string? DocumentNo { get; set; }
        public DateTime? InstalmentDate { get; set; }
        public byte? IsPaid { get; set; }
        public DateTime? PaidDate { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? PaidForexAmount { get; set; }
        public byte? Cdtype { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? ParentId { get; set; }
        public long? CrossRecId { get; set; }
        public long? PlannedSourceId { get; set; }
        public short? PlannedSourceModule { get; set; }
        public byte? IsPaymentPlanning { get; set; }
        public byte? IsOutOfCalculate { get; set; }
        public byte? IsIntalmentPaid { get; set; }
        public decimal? InterestAmount { get; set; }
        public decimal? InterestRate { get; set; }
        public byte? IsForexValuation { get; set; }
        public byte? IsInstalment { get; set; }
        public byte? ControlCode { get; set; }
        public string? SpecialCode { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? DocumentSerialNo { get; set; }
        public long? GlreceiptId { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGlreceipt? Glreceipt { get; set; }
        public virtual ErpReceiptPaymentItem? Parent { get; set; }
        public virtual ICollection<ErpBankReceipt> ErpBankReceipts { get; set; }
        public virtual ICollection<ErpChequeReceipt> ErpChequeReceipts { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpReceiptPaymentItem> InverseParent { get; set; }
    }
}
