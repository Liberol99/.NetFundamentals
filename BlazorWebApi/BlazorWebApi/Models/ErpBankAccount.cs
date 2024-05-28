using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBankAccount
    {
        public ErpBankAccount()
        {
            ErpBankAccountIas = new HashSet<ErpBankAccountIa>();
            ErpBankAccountTotals = new HashSet<ErpBankAccountTotal>();
            ErpBankAccountWorkplaces = new HashSet<ErpBankAccountWorkplace>();
            ErpBankCreditAdvisingBankAccounts = new HashSet<ErpBankCredit>();
            ErpBankCreditBeneficiaryBanks = new HashSet<ErpBankCredit>();
            ErpBankCreditIssuingBanks = new HashSet<ErpBankCredit>();
            ErpBankPos = new HashSet<ErpBankPo>();
            ErpBankReceiptItems = new HashSet<ErpBankReceiptItem>();
            ErpChequeBankAccountNavigations = new HashSet<ErpCheque>();
            ErpChequeOutflowBankAccounts = new HashSet<ErpCheque>();
            ErpChequeReceiptItems = new HashSet<ErpChequeReceiptItem>();
            ErpChequeReceipts = new HashSet<ErpChequeReceipt>();
            ErpCompanyBanks = new HashSet<ErpCompanyBank>();
            ErpCurrentAccountBanks = new HashSet<ErpCurrentAccountBank>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpExpoAdvisingBankAccounts = new HashSet<ErpExpo>();
            ErpExpoCorrespondentBanks = new HashSet<ErpExpo>();
            ErpExpoDabbanks = new HashSet<ErpExpo>();
            ErpExpoGuaranteeBanks = new HashSet<ErpExpo>();
            ErpExpoIntermediaryBanks = new HashSet<ErpExpo>();
            ErpPaymentCards = new HashSet<ErpPaymentCard>();
            ErpPaymentPlanItems = new HashSet<ErpPaymentPlanItem>();
        }

        public int RecId { get; set; }
        public int? BankId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? AccountCode { get; set; }
        public string? AccountName { get; set; }
        public int? ForexId { get; set; }
        public byte? ForCreditCard { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? WithholdingRate { get; set; }
        public decimal? FundRate { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public string? AccountNo { get; set; }
        public string? IbanNo { get; set; }
        public byte? AccountType { get; set; }
        public byte? AccountSubType { get; set; }
        public decimal? ChequeInterestRate { get; set; }
        public decimal? ChequeCreditRate { get; set; }
        public decimal? ChequeCreditLimit { get; set; }
        public decimal? BondInterestRate { get; set; }
        public decimal? BondCreditRate { get; set; }
        public decimal? BondCreditLimit { get; set; }
        public decimal? InsecureInterestRate { get; set; }
        public decimal? InsecureCreditLimit { get; set; }
        public decimal? LetterOfGuaranteeLimit { get; set; }
        public byte? InUse { get; set; }
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

        public virtual ErpBank? Bank { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpBankAccountIa> ErpBankAccountIas { get; set; }
        public virtual ICollection<ErpBankAccountTotal> ErpBankAccountTotals { get; set; }
        public virtual ICollection<ErpBankAccountWorkplace> ErpBankAccountWorkplaces { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCreditAdvisingBankAccounts { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCreditBeneficiaryBanks { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCreditIssuingBanks { get; set; }
        public virtual ICollection<ErpBankPo> ErpBankPos { get; set; }
        public virtual ICollection<ErpBankReceiptItem> ErpBankReceiptItems { get; set; }
        public virtual ICollection<ErpCheque> ErpChequeBankAccountNavigations { get; set; }
        public virtual ICollection<ErpCheque> ErpChequeOutflowBankAccounts { get; set; }
        public virtual ICollection<ErpChequeReceiptItem> ErpChequeReceiptItems { get; set; }
        public virtual ICollection<ErpChequeReceipt> ErpChequeReceipts { get; set; }
        public virtual ICollection<ErpCompanyBank> ErpCompanyBanks { get; set; }
        public virtual ICollection<ErpCurrentAccountBank> ErpCurrentAccountBanks { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoAdvisingBankAccounts { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoCorrespondentBanks { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoDabbanks { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoGuaranteeBanks { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoIntermediaryBanks { get; set; }
        public virtual ICollection<ErpPaymentCard> ErpPaymentCards { get; set; }
        public virtual ICollection<ErpPaymentPlanItem> ErpPaymentPlanItems { get; set; }
    }
}
