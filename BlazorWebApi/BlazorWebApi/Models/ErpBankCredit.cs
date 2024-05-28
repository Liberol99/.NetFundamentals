using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBankCredit
    {
        public ErpBankCredit()
        {
            ErpBankCreditAttachments = new HashSet<ErpBankCreditAttachment>();
            ErpBankCreditExpoClosings = new HashSet<ErpBankCreditExpoClosing>();
            ErpBankCreditItems = new HashSet<ErpBankCreditItem>();
            ErpChequeReceipts = new HashSet<ErpChequeReceipt>();
            ErpContracts = new HashSet<ErpContract>();
            ErpExpos = new HashSet<ErpExpo>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public byte? CreditUpType { get; set; }
        public byte? CreditType { get; set; }
        public string? CreditNo { get; set; }
        public short? CreditYear { get; set; }
        public DateTime? CreditDate { get; set; }
        public string? CreditReferenceNo { get; set; }
        public byte? CreditOperationType { get; set; }
        public byte? CreditGuaranteeType { get; set; }
        public byte? CreditCalcType { get; set; }
        public int? ProjectId { get; set; }
        public decimal? TermMonth { get; set; }
        public string? OperationType { get; set; }
        public string? Explanation { get; set; }
        public string? ToleransTotal { get; set; }
        public int? IssuingBankId { get; set; }
        public string? IssuingContanct { get; set; }
        public string? BankReferenceNo { get; set; }
        public int? BeneficiaryBankId { get; set; }
        public string? BeneficiaryContanct { get; set; }
        public int? AdvisingBankAccountId { get; set; }
        public DateTime? CreditStartDate { get; set; }
        public DateTime? CreditFinishDate { get; set; }
        public DateTime? CommitStartDate { get; set; }
        public DateTime? CommitFinishDate { get; set; }
        public string? PaymentCardId { get; set; }
        public long? PaymentPlanId { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? ProformaInvoiceId { get; set; }
        public int? CostCenterId { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public byte? CreditUsageType { get; set; }
        public string? ManufacturingPlace { get; set; }
        public string? GuaranteesGroup { get; set; }
        public decimal? CommissionTotal { get; set; }
        public decimal? InterestTotal { get; set; }
        public decimal? CreditTotal { get; set; }
        public decimal? CreditTotalForex { get; set; }
        public decimal? Bsmvtotal { get; set; }
        public decimal? Kkdftotal { get; set; }
        public string? Lclocation { get; set; }
        public long? ContractId { get; set; }
        public byte? IsOpening { get; set; }
        public byte? IsClosed { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
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
        public byte? DeliveryType { get; set; }
        public long? BankInterestRateId { get; set; }
        public long? LiborInterestRateId { get; set; }
        public byte? IsLiborUsage { get; set; }
        public byte? UseValueDate { get; set; }
        public byte? CalculateBsmv { get; set; }
        public byte? CashCommissionTax { get; set; }
        public byte? CashInterest { get; set; }
        public byte? TermInterestPayment { get; set; }
        public short? PrincipalPeriod { get; set; }
        public byte? PrincipalPeriodType { get; set; }
        public short? PrincipalNoPayBackPeriod { get; set; }
        public byte? PrincipalNoPayBackPeriodType { get; set; }
        public byte? PrincipalAfterTermDatePayment { get; set; }
        public short? InterestPeriod { get; set; }
        public byte? InterestPeriodType { get; set; }
        public short? InterestNoPayBackPeriod { get; set; }
        public byte? InterestNoPayBackPeriodType { get; set; }
        public byte? InterestAfterTermDatePayment { get; set; }
        public byte? EqualTermPayment { get; set; }
        public byte? UserEntry { get; set; }
        public byte? FullUserEntry { get; set; }
        public decimal? CommissionRate { get; set; }
        public string? Interlocutor { get; set; }
        public int? DebitGlaccountId { get; set; }
        public int? CreditGlaccountId { get; set; }
        public long? GlreceiptId { get; set; }
        public long? GlreceiptId1 { get; set; }

        public virtual ErpBankAccount? AdvisingBankAccount { get; set; }
        public virtual ErpInterestRate? BankInterestRate { get; set; }
        public virtual ErpBankAccount? BeneficiaryBank { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpContract? Contract { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpGlaccount? CreditGlaccount { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpGlaccount? DebitGlaccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGlreceipt? Glreceipt { get; set; }
        public virtual ErpGlreceipt? GlreceiptId1Navigation { get; set; }
        public virtual ErpBankAccount? IssuingBank { get; set; }
        public virtual ErpInterestRate? LiborInterestRate { get; set; }
        public virtual ErpInvoice? ProformaInvoice { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpBankCreditAttachment> ErpBankCreditAttachments { get; set; }
        public virtual ICollection<ErpBankCreditExpoClosing> ErpBankCreditExpoClosings { get; set; }
        public virtual ICollection<ErpBankCreditItem> ErpBankCreditItems { get; set; }
        public virtual ICollection<ErpChequeReceipt> ErpChequeReceipts { get; set; }
        public virtual ICollection<ErpContract> ErpContracts { get; set; }
        public virtual ICollection<ErpExpo> ErpExpos { get; set; }
    }
}
