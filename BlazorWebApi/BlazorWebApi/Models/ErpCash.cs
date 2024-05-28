using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCash
    {
        public ErpCash()
        {
            ErpBankReceipts = new HashSet<ErpBankReceipt>();
            ErpCashIas = new HashSet<ErpCashIa>();
            ErpCashTotals = new HashSet<ErpCashTotal>();
            ErpChequeReceipts = new HashSet<ErpChequeReceipt>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCurrentAccountReceipts = new HashSet<ErpCurrentAccountReceipt>();
            ErpDepartmentCashes = new HashSet<ErpDepartmentCash>();
            ErpGlreceipts = new HashSet<ErpGlreceipt>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpLoyalityCards = new HashSet<ErpLoyalityCard>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpParameterDocNos = new HashSet<ErpParameterDocNo>();
            ErpPos = new HashSet<ErpPo>();
            ErpPosEndOfDateRaports = new HashSet<ErpPosEndOfDateRaport>();
            MetaPos = new HashSet<MetaPo>();
            MetaUsers = new HashSet<MetaUser>();
            PosShifts = new HashSet<PosShift>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? CashCode { get; set; }
        public string? Explanation { get; set; }
        public int? CostCenterId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? IsManualTurnover { get; set; }
        public int? ForexId { get; set; }
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
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpBankReceipt> ErpBankReceipts { get; set; }
        public virtual ICollection<ErpCashIa> ErpCashIas { get; set; }
        public virtual ICollection<ErpCashTotal> ErpCashTotals { get; set; }
        public virtual ICollection<ErpChequeReceipt> ErpChequeReceipts { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpCurrentAccountReceipt> ErpCurrentAccountReceipts { get; set; }
        public virtual ICollection<ErpDepartmentCash> ErpDepartmentCashes { get; set; }
        public virtual ICollection<ErpGlreceipt> ErpGlreceipts { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpLoyalityCard> ErpLoyalityCards { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpParameterDocNo> ErpParameterDocNos { get; set; }
        public virtual ICollection<ErpPo> ErpPos { get; set; }
        public virtual ICollection<ErpPosEndOfDateRaport> ErpPosEndOfDateRaports { get; set; }
        public virtual ICollection<MetaPo> MetaPos { get; set; }
        public virtual ICollection<MetaUser> MetaUsers { get; set; }
        public virtual ICollection<PosShift> PosShifts { get; set; }
    }
}
