using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCheque
    {
        public ErpCheque()
        {
            ErpChequeReceiptItems = new HashSet<ErpChequeReceiptItem>();
            ErpChequeTransactions = new HashSet<ErpChequeTransaction>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public short? ChequeType { get; set; }
        public string? ChequeCode { get; set; }
        public DateTime? TermDate { get; set; }
        public byte? ControlCode { get; set; }
        public byte? Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? BankAccountId { get; set; }
        public long? OutflowCurrentAccountId { get; set; }
        public int? OutflowBankAccountId { get; set; }
        public byte? DebtorKind { get; set; }
        public string? Debtor { get; set; }
        public string? PaymentPlace { get; set; }
        public string? BankBranch { get; set; }
        public string? BankAccount { get; set; }
        public string? ChequeNo { get; set; }
        public string? DebtorIdCardNo { get; set; }
        public string? IbanNo { get; set; }
        public decimal? Amount { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public byte? IsForex { get; set; }
        public byte? IsEndorsment { get; set; }
        public string? Guarantor1 { get; set; }
        public string? Guarantor2 { get; set; }
        public decimal? Expense { get; set; }
        public decimal? Stamp { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? IsRisk { get; set; }
        public byte? IsBlackList { get; set; }
        public byte[]? ChequeFrontPicture { get; set; }
        public byte[]? ChequeBackPicture { get; set; }
        public int? MetaBankId { get; set; }
        public int? MetaBankBranchId { get; set; }
        public byte? IsCancelled { get; set; }
        public string? CancelledExplanation { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
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
        public int? ProjectId { get; set; }

        public virtual ErpBankAccount? BankAccountNavigation { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual MetaBank? MetaBank { get; set; }
        public virtual MetaBankBranch? MetaBankBranch { get; set; }
        public virtual ErpBankAccount? OutflowBankAccount { get; set; }
        public virtual ErpCurrentAccount? OutflowCurrentAccount { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpChequeReceiptItem> ErpChequeReceiptItems { get; set; }
        public virtual ICollection<ErpChequeTransaction> ErpChequeTransactions { get; set; }
    }
}
