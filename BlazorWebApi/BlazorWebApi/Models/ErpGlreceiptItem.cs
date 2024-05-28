using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpGlreceiptItem
    {
        public ErpGlreceiptItem()
        {
            ErpCostCenterDistributions = new HashSet<ErpCostCenterDistribution>();
            ErpGlreceiptItemInvs = new HashSet<ErpGlreceiptItemInv>();
            InverseParentItem = new HashSet<ErpGlreceiptItem>();
        }

        public long RecId { get; set; }
        public long? GlreceiptId { get; set; }
        public short? ReceiptType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public short? ItemType { get; set; }
        public int? ItemOrderNo { get; set; }
        public byte? ControlCode { get; set; }
        public string? SpecialCode { get; set; }
        public int? AccountId { get; set; }
        public int? GlcashAccountId { get; set; }
        public int? CostCenterId { get; set; }
        public long? ParentItemId { get; set; }
        public string? Explanation { get; set; }
        public DateTime? TermDate { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Debit2 { get; set; }
        public decimal? Debit3 { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Credit2 { get; set; }
        public decimal? Credit3 { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public string? DocumentNo { get; set; }
        public string? DocumentType { get; set; }
        public decimal? VatRate { get; set; }
        public decimal? VatAmount { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexRate2 { get; set; }
        public decimal? ForexRate3 { get; set; }
        public decimal? ForexAmount { get; set; }
        public int? TransactionForexId { get; set; }
        public decimal? TransactionForexRate { get; set; }
        public decimal? TransactionForexAmount { get; set; }
        public byte? IsForexCorrection { get; set; }
        public int? LedgerForexId { get; set; }
        public decimal? LedgerForexRate { get; set; }
        public decimal? LedgerForexDebit { get; set; }
        public decimal? LedgerForexCredit { get; set; }
        public byte? IsCashItem { get; set; }
        public long? RegBookNo { get; set; }
        public int? ProjectId { get; set; }
        public short? SourceModule { get; set; }
        public short? SourceType { get; set; }
        public long? SourceId { get; set; }
        public byte? IsReflecting { get; set; }
        public byte? IsChecked { get; set; }
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
        public string? ApprovedExplanation { get; set; }
        public string? DocumentSerialNo { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? CrossGlaccountId { get; set; }
        public byte? IsCorrection { get; set; }
        public int? CorrectionCount { get; set; }
        public long? CrossRecId { get; set; }

        public virtual ErpGlaccount? Account { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpGlaccount? CrossGlaccount { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGlaccount? GlcashAccount { get; set; }
        public virtual ErpGlreceipt? Glreceipt { get; set; }
        public virtual MetaForex? LedgerForex { get; set; }
        public virtual ErpGlreceiptItem? ParentItem { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual MetaForex? TransactionForex { get; set; }
        public virtual ICollection<ErpCostCenterDistribution> ErpCostCenterDistributions { get; set; }
        public virtual ICollection<ErpGlreceiptItemInv> ErpGlreceiptItemInvs { get; set; }
        public virtual ICollection<ErpGlreceiptItem> InverseParentItem { get; set; }
    }
}
