using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpGlaccount
    {
        public ErpGlaccount()
        {
            ErpBankAccountIas = new HashSet<ErpBankAccountIa>();
            ErpBankCreditCreditGlaccounts = new HashSet<ErpBankCredit>();
            ErpBankCreditDebitGlaccounts = new HashSet<ErpBankCredit>();
            ErpBankReceiptItems = new HashSet<ErpBankReceiptItem>();
            ErpBudgetItems = new HashSet<ErpBudgetItem>();
            ErpCashIas = new HashSet<ErpCashIa>();
            ErpCompanyCurrentAccountGlaccountId2Navigations = new HashSet<ErpCompanyCurrentAccount>();
            ErpCompanyCurrentAccountGlaccounts = new HashSet<ErpCompanyCurrentAccount>();
            ErpCompanyIas = new HashSet<ErpCompanyIa>();
            ErpCostCenterDistributions = new HashSet<ErpCostCenterDistribution>();
            ErpCurrentAccountCustomerGlaccounts = new HashSet<ErpCurrentAccount>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCurrentAccountSupplierGlaccounts = new HashSet<ErpCurrentAccount>();
            ErpDiscounts = new HashSet<ErpDiscount>();
            ErpEmployeeIas = new HashSet<ErpEmployeeIa>();
            ErpEmployees = new HashSet<ErpEmployee>();
            ErpExpenseGlaccounts = new HashSet<ErpExpense>();
            ErpExpenseReflectionGlaccounts = new HashSet<ErpExpense>();
            ErpFinancialTableItemEndAccounts = new HashSet<ErpFinancialTableItem>();
            ErpFinancialTableItemStartAccounts = new HashSet<ErpFinancialTableItem>();
            ErpGlaccountTotals = new HashSet<ErpGlaccountTotal>();
            ErpGlreceiptItemAccounts = new HashSet<ErpGlreceiptItem>();
            ErpGlreceiptItemCrossGlaccounts = new HashSet<ErpGlreceiptItem>();
            ErpGlreceiptItemGlcashAccounts = new HashSet<ErpGlreceiptItem>();
            ErpGlreflectionAccounts = new HashSet<ErpGlreflection>();
            ErpGlreflectionFirstAccounts = new HashSet<ErpGlreflection>();
            ErpGlreflectionLastAccounts = new HashSet<ErpGlreflection>();
            ErpInventoryGroupIas = new HashSet<ErpInventoryGroupIa>();
            ErpInventoryIas = new HashSet<ErpInventoryIa>();
            ErpServiceIas = new HashSet<ErpServiceIa>();
            ErpTaxIas = new HashSet<ErpTaxIa>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? AccountCode { get; set; }
        public string? AccountName { get; set; }
        public string? Explanation { get; set; }
        public short? AccountType { get; set; }
        public short? Cdtype { get; set; }
        public int? ForexId { get; set; }
        public int? GeneralRateId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public string? TaxNo { get; set; }
        public string? IdCardNo { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? CostDistributionType { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public string? UdGiderTipi { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpBankAccountIa> ErpBankAccountIas { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCreditCreditGlaccounts { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCreditDebitGlaccounts { get; set; }
        public virtual ICollection<ErpBankReceiptItem> ErpBankReceiptItems { get; set; }
        public virtual ICollection<ErpBudgetItem> ErpBudgetItems { get; set; }
        public virtual ICollection<ErpCashIa> ErpCashIas { get; set; }
        public virtual ICollection<ErpCompanyCurrentAccount> ErpCompanyCurrentAccountGlaccountId2Navigations { get; set; }
        public virtual ICollection<ErpCompanyCurrentAccount> ErpCompanyCurrentAccountGlaccounts { get; set; }
        public virtual ICollection<ErpCompanyIa> ErpCompanyIas { get; set; }
        public virtual ICollection<ErpCostCenterDistribution> ErpCostCenterDistributions { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccountCustomerGlaccounts { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccountSupplierGlaccounts { get; set; }
        public virtual ICollection<ErpDiscount> ErpDiscounts { get; set; }
        public virtual ICollection<ErpEmployeeIa> ErpEmployeeIas { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployees { get; set; }
        public virtual ICollection<ErpExpense> ErpExpenseGlaccounts { get; set; }
        public virtual ICollection<ErpExpense> ErpExpenseReflectionGlaccounts { get; set; }
        public virtual ICollection<ErpFinancialTableItem> ErpFinancialTableItemEndAccounts { get; set; }
        public virtual ICollection<ErpFinancialTableItem> ErpFinancialTableItemStartAccounts { get; set; }
        public virtual ICollection<ErpGlaccountTotal> ErpGlaccountTotals { get; set; }
        public virtual ICollection<ErpGlreceiptItem> ErpGlreceiptItemAccounts { get; set; }
        public virtual ICollection<ErpGlreceiptItem> ErpGlreceiptItemCrossGlaccounts { get; set; }
        public virtual ICollection<ErpGlreceiptItem> ErpGlreceiptItemGlcashAccounts { get; set; }
        public virtual ICollection<ErpGlreflection> ErpGlreflectionAccounts { get; set; }
        public virtual ICollection<ErpGlreflection> ErpGlreflectionFirstAccounts { get; set; }
        public virtual ICollection<ErpGlreflection> ErpGlreflectionLastAccounts { get; set; }
        public virtual ICollection<ErpInventoryGroupIa> ErpInventoryGroupIas { get; set; }
        public virtual ICollection<ErpInventoryIa> ErpInventoryIas { get; set; }
        public virtual ICollection<ErpServiceIa> ErpServiceIas { get; set; }
        public virtual ICollection<ErpTaxIa> ErpTaxIas { get; set; }
    }
}
