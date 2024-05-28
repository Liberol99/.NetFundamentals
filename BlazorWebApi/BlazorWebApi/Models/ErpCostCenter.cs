using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCostCenter
    {
        public ErpCostCenter()
        {
            ErpBankAccountIas = new HashSet<ErpBankAccountIa>();
            ErpBankCredits = new HashSet<ErpBankCredit>();
            ErpBankReceiptItems = new HashSet<ErpBankReceiptItem>();
            ErpBankReceipts = new HashSet<ErpBankReceipt>();
            ErpBudgetItems = new HashSet<ErpBudgetItem>();
            ErpBudgets = new HashSet<ErpBudget>();
            ErpCashIas = new HashSet<ErpCashIa>();
            ErpCashes = new HashSet<ErpCash>();
            ErpChequeReceipts = new HashSet<ErpChequeReceipt>();
            ErpCompanyIas = new HashSet<ErpCompanyIa>();
            ErpContractItems = new HashSet<ErpContractItem>();
            ErpContracts = new HashSet<ErpContract>();
            ErpCostCenterDistributionCostCenters = new HashSet<ErpCostCenterDistribution>();
            ErpCostCenterDistributionDetailCostCenters = new HashSet<ErpCostCenterDistribution>();
            ErpCostCenterTotals = new HashSet<ErpCostCenterTotal>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCurrentAccountReceipts = new HashSet<ErpCurrentAccountReceipt>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpDemandReceipts = new HashSet<ErpDemandReceipt>();
            ErpDepartments = new HashSet<ErpDepartment>();
            ErpDiscounts = new HashSet<ErpDiscount>();
            ErpEmployeeIas = new HashSet<ErpEmployeeIa>();
            ErpEmployees = new HashSet<ErpEmployee>();
            ErpExpenses = new HashSet<ErpExpense>();
            ErpGlreceiptItems = new HashSet<ErpGlreceiptItem>();
            ErpInventories = new HashSet<ErpInventory>();
            ErpInventoryGroupIas = new HashSet<ErpInventoryGroupIa>();
            ErpInventoryIas = new HashSet<ErpInventoryIa>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpPos = new HashSet<ErpPo>();
            ErpProcesses = new HashSet<ErpProcess>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
            ErpServiceIas = new HashSet<ErpServiceIa>();
            ErpTaxIas = new HashSet<ErpTaxIa>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            MetaUsers = new HashSet<MetaUser>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? CostCenterCode { get; set; }
        public string? CostCenterName { get; set; }
        public string? Explanation { get; set; }
        public int? ForexId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? IsMain { get; set; }
        public int? ManufacturingTypeId { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpManufacturingType? ManufacturingType { get; set; }
        public virtual ICollection<ErpBankAccountIa> ErpBankAccountIas { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCredits { get; set; }
        public virtual ICollection<ErpBankReceiptItem> ErpBankReceiptItems { get; set; }
        public virtual ICollection<ErpBankReceipt> ErpBankReceipts { get; set; }
        public virtual ICollection<ErpBudgetItem> ErpBudgetItems { get; set; }
        public virtual ICollection<ErpBudget> ErpBudgets { get; set; }
        public virtual ICollection<ErpCashIa> ErpCashIas { get; set; }
        public virtual ICollection<ErpCash> ErpCashes { get; set; }
        public virtual ICollection<ErpChequeReceipt> ErpChequeReceipts { get; set; }
        public virtual ICollection<ErpCompanyIa> ErpCompanyIas { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItems { get; set; }
        public virtual ICollection<ErpContract> ErpContracts { get; set; }
        public virtual ICollection<ErpCostCenterDistribution> ErpCostCenterDistributionCostCenters { get; set; }
        public virtual ICollection<ErpCostCenterDistribution> ErpCostCenterDistributionDetailCostCenters { get; set; }
        public virtual ICollection<ErpCostCenterTotal> ErpCostCenterTotals { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpCurrentAccountReceipt> ErpCurrentAccountReceipts { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceipts { get; set; }
        public virtual ICollection<ErpDepartment> ErpDepartments { get; set; }
        public virtual ICollection<ErpDiscount> ErpDiscounts { get; set; }
        public virtual ICollection<ErpEmployeeIa> ErpEmployeeIas { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployees { get; set; }
        public virtual ICollection<ErpExpense> ErpExpenses { get; set; }
        public virtual ICollection<ErpGlreceiptItem> ErpGlreceiptItems { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpInventoryGroupIa> ErpInventoryGroupIas { get; set; }
        public virtual ICollection<ErpInventoryIa> ErpInventoryIas { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpPo> ErpPos { get; set; }
        public virtual ICollection<ErpProcess> ErpProcesses { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
        public virtual ICollection<ErpServiceIa> ErpServiceIas { get; set; }
        public virtual ICollection<ErpTaxIa> ErpTaxIas { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<MetaUser> MetaUsers { get; set; }
    }
}
