using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaForex
    {
        public MetaForex()
        {
            CrmLeads = new HashSet<CrmLead>();
            CrmMarketingActivityBudgetForices = new HashSet<CrmMarketingActivity>();
            CrmMarketingActivityForices = new HashSet<CrmMarketingActivity>();
            CrmMarketingActivityProducts = new HashSet<CrmMarketingActivityProduct>();
            CrmMarketingActivityResources = new HashSet<CrmMarketingActivityResource>();
            ErpActualCosts = new HashSet<ErpActualCost>();
            ErpAsserviceFaultyItems = new HashSet<ErpAsserviceFaultyItem>();
            ErpBankAccountTotals = new HashSet<ErpBankAccountTotal>();
            ErpBankAccounts = new HashSet<ErpBankAccount>();
            ErpBankCreditExpoClosings = new HashSet<ErpBankCreditExpoClosing>();
            ErpBankCreditItems = new HashSet<ErpBankCreditItem>();
            ErpBankCredits = new HashSet<ErpBankCredit>();
            ErpBankPos = new HashSet<ErpBankPo>();
            ErpBankReceiptItems = new HashSet<ErpBankReceiptItem>();
            ErpBankReceipts = new HashSet<ErpBankReceipt>();
            ErpBudgetItems = new HashSet<ErpBudgetItem>();
            ErpBudgets = new HashSet<ErpBudget>();
            ErpCashIas = new HashSet<ErpCashIa>();
            ErpCashTotalItems = new HashSet<ErpCashTotalItem>();
            ErpCashes = new HashSet<ErpCash>();
            ErpChequeReceiptItems = new HashSet<ErpChequeReceiptItem>();
            ErpChequeReceipts = new HashSet<ErpChequeReceipt>();
            ErpCheques = new HashSet<ErpCheque>();
            ErpCompanyIas = new HashSet<ErpCompanyIa>();
            ErpContractItems = new HashSet<ErpContractItem>();
            ErpContracts = new HashSet<ErpContract>();
            ErpCostCenterTotals = new HashSet<ErpCostCenterTotal>();
            ErpCostCenters = new HashSet<ErpCostCenter>();
            ErpCurrentAccountBanks = new HashSet<ErpCurrentAccountBank>();
            ErpCurrentAccountForices = new HashSet<ErpCurrentAccount>();
            ErpCurrentAccountPaymentPlanDebitForices = new HashSet<ErpCurrentAccount>();
            ErpCurrentAccountReceiptItemForices = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCurrentAccountReceiptItemTransactionForices = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCurrentAccountReceipts = new HashSet<ErpCurrentAccountReceipt>();
            ErpCurrentAccountRiskTotals = new HashSet<ErpCurrentAccountRiskTotal>();
            ErpCurrentAccountTotals = new HashSet<ErpCurrentAccountTotal>();
            ErpCustomerTransactionActivities = new HashSet<ErpCustomerTransactionActivity>();
            ErpCustomerTransactions = new HashSet<ErpCustomerTransaction>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpDemandReceipts = new HashSet<ErpDemandReceipt>();
            ErpDiscounts = new HashSet<ErpDiscount>();
            ErpEmployeeHistories = new HashSet<ErpEmployeeHistory>();
            ErpEmployees = new HashSet<ErpEmployee>();
            ErpExpoForices = new HashSet<ErpExpo>();
            ErpExpoInsuranceForices = new HashSet<ErpExpo>();
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpGiftVouchers = new HashSet<ErpGiftVoucher>();
            ErpGlaccountTotals = new HashSet<ErpGlaccountTotal>();
            ErpGlaccounts = new HashSet<ErpGlaccount>();
            ErpGlreceiptItemForices = new HashSet<ErpGlreceiptItem>();
            ErpGlreceiptItemLedgerForices = new HashSet<ErpGlreceiptItem>();
            ErpGlreceiptItemTransactionForices = new HashSet<ErpGlreceiptItem>();
            ErpInitialCostCards = new HashSet<ErpInitialCostCard>();
            ErpInitialCostForex2s = new HashSet<ErpInitialCost>();
            ErpInitialCostForex3s = new HashSet<ErpInitialCost>();
            ErpInitialCostForices = new HashSet<ErpInitialCost>();
            ErpInitialCostItems = new HashSet<ErpInitialCostItem>();
            ErpInterestRateItems = new HashSet<ErpInterestRateItem>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInventorySuppliers = new HashSet<ErpInventorySupplier>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpLabRecipeItems = new HashSet<ErpLabRecipeItem>();
            ErpLabRecipes = new HashSet<ErpLabRecipe>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpPackingListItems = new HashSet<ErpPackingListItem>();
            ErpPaymentCards = new HashSet<ErpPaymentCard>();
            ErpPaymentPlanItems = new HashSet<ErpPaymentPlanItem>();
            ErpPos = new HashSet<ErpPo>();
            ErpProductConfiguratorItems = new HashSet<ErpProductConfiguratorItem>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
            ErpReceiptPaymentItems = new HashSet<ErpReceiptPaymentItem>();
            ErpRecipeItems = new HashSet<ErpRecipeItem>();
            ErpRefundCheques = new HashSet<ErpRefundCheque>();
            ErpRequirements = new HashSet<ErpRequirement>();
            ErpRouteItems = new HashSet<ErpRouteItem>();
            ErpServicePriceLists = new HashSet<ErpServicePriceList>();
            ErpWorkOrderItemProcesses = new HashSet<ErpWorkOrderItemProcess>();
            ErpWorkOrderItemRecipes = new HashSet<ErpWorkOrderItemRecipe>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderProductions = new HashSet<ErpWorkOrderProduction>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            HrmCheckings = new HashSet<HrmChecking>();
            MetaForexRates = new HashSet<MetaForexRate>();
        }

        public int RecId { get; set; }
        public string? ForexCode { get; set; }
        public string? ForexSubCode { get; set; }
        public string? ForexName { get; set; }
        public string? IntlCode { get; set; }
        public byte? ItemOrder { get; set; }
        public byte[]? FlagImage { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ICollection<CrmLead> CrmLeads { get; set; }
        public virtual ICollection<CrmMarketingActivity> CrmMarketingActivityBudgetForices { get; set; }
        public virtual ICollection<CrmMarketingActivity> CrmMarketingActivityForices { get; set; }
        public virtual ICollection<CrmMarketingActivityProduct> CrmMarketingActivityProducts { get; set; }
        public virtual ICollection<CrmMarketingActivityResource> CrmMarketingActivityResources { get; set; }
        public virtual ICollection<ErpActualCost> ErpActualCosts { get; set; }
        public virtual ICollection<ErpAsserviceFaultyItem> ErpAsserviceFaultyItems { get; set; }
        public virtual ICollection<ErpBankAccountTotal> ErpBankAccountTotals { get; set; }
        public virtual ICollection<ErpBankAccount> ErpBankAccounts { get; set; }
        public virtual ICollection<ErpBankCreditExpoClosing> ErpBankCreditExpoClosings { get; set; }
        public virtual ICollection<ErpBankCreditItem> ErpBankCreditItems { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCredits { get; set; }
        public virtual ICollection<ErpBankPo> ErpBankPos { get; set; }
        public virtual ICollection<ErpBankReceiptItem> ErpBankReceiptItems { get; set; }
        public virtual ICollection<ErpBankReceipt> ErpBankReceipts { get; set; }
        public virtual ICollection<ErpBudgetItem> ErpBudgetItems { get; set; }
        public virtual ICollection<ErpBudget> ErpBudgets { get; set; }
        public virtual ICollection<ErpCashIa> ErpCashIas { get; set; }
        public virtual ICollection<ErpCashTotalItem> ErpCashTotalItems { get; set; }
        public virtual ICollection<ErpCash> ErpCashes { get; set; }
        public virtual ICollection<ErpChequeReceiptItem> ErpChequeReceiptItems { get; set; }
        public virtual ICollection<ErpChequeReceipt> ErpChequeReceipts { get; set; }
        public virtual ICollection<ErpCheque> ErpCheques { get; set; }
        public virtual ICollection<ErpCompanyIa> ErpCompanyIas { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItems { get; set; }
        public virtual ICollection<ErpContract> ErpContracts { get; set; }
        public virtual ICollection<ErpCostCenterTotal> ErpCostCenterTotals { get; set; }
        public virtual ICollection<ErpCostCenter> ErpCostCenters { get; set; }
        public virtual ICollection<ErpCurrentAccountBank> ErpCurrentAccountBanks { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccountForices { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccountPaymentPlanDebitForices { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItemForices { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItemTransactionForices { get; set; }
        public virtual ICollection<ErpCurrentAccountReceipt> ErpCurrentAccountReceipts { get; set; }
        public virtual ICollection<ErpCurrentAccountRiskTotal> ErpCurrentAccountRiskTotals { get; set; }
        public virtual ICollection<ErpCurrentAccountTotal> ErpCurrentAccountTotals { get; set; }
        public virtual ICollection<ErpCustomerTransactionActivity> ErpCustomerTransactionActivities { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactions { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceipts { get; set; }
        public virtual ICollection<ErpDiscount> ErpDiscounts { get; set; }
        public virtual ICollection<ErpEmployeeHistory> ErpEmployeeHistories { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployees { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoForices { get; set; }
        public virtual ICollection<ErpExpo> ErpExpoInsuranceForices { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpGiftVoucher> ErpGiftVouchers { get; set; }
        public virtual ICollection<ErpGlaccountTotal> ErpGlaccountTotals { get; set; }
        public virtual ICollection<ErpGlaccount> ErpGlaccounts { get; set; }
        public virtual ICollection<ErpGlreceiptItem> ErpGlreceiptItemForices { get; set; }
        public virtual ICollection<ErpGlreceiptItem> ErpGlreceiptItemLedgerForices { get; set; }
        public virtual ICollection<ErpGlreceiptItem> ErpGlreceiptItemTransactionForices { get; set; }
        public virtual ICollection<ErpInitialCostCard> ErpInitialCostCards { get; set; }
        public virtual ICollection<ErpInitialCost> ErpInitialCostForex2s { get; set; }
        public virtual ICollection<ErpInitialCost> ErpInitialCostForex3s { get; set; }
        public virtual ICollection<ErpInitialCost> ErpInitialCostForices { get; set; }
        public virtual ICollection<ErpInitialCostItem> ErpInitialCostItems { get; set; }
        public virtual ICollection<ErpInterestRateItem> ErpInterestRateItems { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInventorySupplier> ErpInventorySuppliers { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpLabRecipeItem> ErpLabRecipeItems { get; set; }
        public virtual ICollection<ErpLabRecipe> ErpLabRecipes { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpPackingListItem> ErpPackingListItems { get; set; }
        public virtual ICollection<ErpPaymentCard> ErpPaymentCards { get; set; }
        public virtual ICollection<ErpPaymentPlanItem> ErpPaymentPlanItems { get; set; }
        public virtual ICollection<ErpPo> ErpPos { get; set; }
        public virtual ICollection<ErpProductConfiguratorItem> ErpProductConfiguratorItems { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
        public virtual ICollection<ErpReceiptPaymentItem> ErpReceiptPaymentItems { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItems { get; set; }
        public virtual ICollection<ErpRefundCheque> ErpRefundCheques { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirements { get; set; }
        public virtual ICollection<ErpRouteItem> ErpRouteItems { get; set; }
        public virtual ICollection<ErpServicePriceList> ErpServicePriceLists { get; set; }
        public virtual ICollection<ErpWorkOrderItemProcess> ErpWorkOrderItemProcesses { get; set; }
        public virtual ICollection<ErpWorkOrderItemRecipe> ErpWorkOrderItemRecipes { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductions { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<HrmChecking> HrmCheckings { get; set; }
        public virtual ICollection<MetaForexRate> MetaForexRates { get; set; }
    }
}
