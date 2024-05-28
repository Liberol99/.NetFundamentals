using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpService
    {
        public ErpService()
        {
            CrmLeads = new HashSet<CrmLead>();
            CrmMarketingActivityProducts = new HashSet<CrmMarketingActivityProduct>();
            CrmTransactionFlowItems = new HashSet<CrmTransactionFlowItem>();
            ErpBudgetItems = new HashSet<ErpBudgetItem>();
            ErpCompetitorProducts = new HashSet<ErpCompetitorProduct>();
            ErpContractItems = new HashSet<ErpContractItem>();
            ErpCostCenterDistributions = new HashSet<ErpCostCenterDistribution>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCustomerTransactions = new HashSet<ErpCustomerTransaction>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpDepartmentServices = new HashSet<ErpDepartmentService>();
            ErpDepartments = new HashSet<ErpDepartment>();
            ErpEmployeeCompetencies = new HashSet<ErpEmployeeCompetency>();
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpLoyalityCardServices = new HashSet<ErpLoyalityCardService>();
            ErpLoyalityCardTypeServices = new HashSet<ErpLoyalityCardTypeService>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpProcesses = new HashSet<ErpProcess>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            ErpRecipeItems = new HashSet<ErpRecipeItem>();
            ErpRecipes = new HashSet<ErpRecipe>();
            ErpResources = new HashSet<ErpResource>();
            ErpServiceAttachments = new HashSet<ErpServiceAttachment>();
            ErpServiceExplanations = new HashSet<ErpServiceExplanation>();
            ErpServiceIas = new HashSet<ErpServiceIa>();
            ErpServicePriceLists = new HashSet<ErpServicePriceList>();
            ErpServiceUnitItemSizes = new HashSet<ErpServiceUnitItemSize>();
            ErpServiceWorkplaces = new HashSet<ErpServiceWorkplace>();
            ErpWorkOrderItemRecipes = new HashSet<ErpWorkOrderItemRecipe>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            InverseParent = new HashSet<ErpService>();
            PosMenuItems = new HashSet<PosMenuItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? ServiceType { get; set; }
        public string? ServiceCode { get; set; }
        public string? ServiceName { get; set; }
        public long? GroupId { get; set; }
        public int? CategoryId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? IsClass { get; set; }
        public long? ParentId { get; set; }
        public int? UnitId { get; set; }
        public byte? BarcodeType { get; set; }
        public string? Barcode { get; set; }
        public int? TaxId { get; set; }
        public int? PurchaseVatId { get; set; }
        public int? PurchaseReturnVatId { get; set; }
        public int? SalesVatId { get; set; }
        public int? SalesReturnVatId { get; set; }
        public byte? IsWithholdable { get; set; }
        public byte? WithholdingFactor { get; set; }
        public byte? WithholdingDivisor { get; set; }
        public string? CampaignGroup { get; set; }
        public string? PriceGroup { get; set; }
        public string? IsoDocumentNo { get; set; }
        public string? WebContent { get; set; }
        public byte? HasVatPositiveEffect { get; set; }
        public byte? ExpenseType { get; set; }
        public byte? InUse { get; set; }
        public byte? IsLocked { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? SctvatId { get; set; }
        public int? ExtvatId { get; set; }
        public int? AccvatId { get; set; }
        public byte? IsKkegmasterAccountsEffective { get; set; }

        public virtual ErpTax? Accvat { get; set; }
        public virtual ErpCategory? Category { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpTax? Extvat { get; set; }
        public virtual ErpServiceGroup? Group { get; set; }
        public virtual ErpService? Parent { get; set; }
        public virtual ErpTax? PurchaseReturnVat { get; set; }
        public virtual ErpTax? PurchaseVat { get; set; }
        public virtual ErpTax? SalesReturnVat { get; set; }
        public virtual ErpTax? SalesVat { get; set; }
        public virtual ErpTax? Sctvat { get; set; }
        public virtual ErpTax? Tax { get; set; }
        public virtual MetaUnitSet? Unit { get; set; }
        public virtual ICollection<CrmLead> CrmLeads { get; set; }
        public virtual ICollection<CrmMarketingActivityProduct> CrmMarketingActivityProducts { get; set; }
        public virtual ICollection<CrmTransactionFlowItem> CrmTransactionFlowItems { get; set; }
        public virtual ICollection<ErpBudgetItem> ErpBudgetItems { get; set; }
        public virtual ICollection<ErpCompetitorProduct> ErpCompetitorProducts { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItems { get; set; }
        public virtual ICollection<ErpCostCenterDistribution> ErpCostCenterDistributions { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactions { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpDepartmentService> ErpDepartmentServices { get; set; }
        public virtual ICollection<ErpDepartment> ErpDepartments { get; set; }
        public virtual ICollection<ErpEmployeeCompetency> ErpEmployeeCompetencies { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpLoyalityCardService> ErpLoyalityCardServices { get; set; }
        public virtual ICollection<ErpLoyalityCardTypeService> ErpLoyalityCardTypeServices { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpProcess> ErpProcesses { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItems { get; set; }
        public virtual ICollection<ErpRecipe> ErpRecipes { get; set; }
        public virtual ICollection<ErpResource> ErpResources { get; set; }
        public virtual ICollection<ErpServiceAttachment> ErpServiceAttachments { get; set; }
        public virtual ICollection<ErpServiceExplanation> ErpServiceExplanations { get; set; }
        public virtual ICollection<ErpServiceIa> ErpServiceIas { get; set; }
        public virtual ICollection<ErpServicePriceList> ErpServicePriceLists { get; set; }
        public virtual ICollection<ErpServiceUnitItemSize> ErpServiceUnitItemSizes { get; set; }
        public virtual ICollection<ErpServiceWorkplace> ErpServiceWorkplaces { get; set; }
        public virtual ICollection<ErpWorkOrderItemRecipe> ErpWorkOrderItemRecipes { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<ErpService> InverseParent { get; set; }
        public virtual ICollection<PosMenuItem> PosMenuItems { get; set; }
    }
}
