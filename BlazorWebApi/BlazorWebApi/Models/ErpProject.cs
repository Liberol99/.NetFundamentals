using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpProject
    {
        public ErpProject()
        {
            ErpBankCredits = new HashSet<ErpBankCredit>();
            ErpBankReceiptItems = new HashSet<ErpBankReceiptItem>();
            ErpChequeReceipts = new HashSet<ErpChequeReceipt>();
            ErpCheques = new HashSet<ErpCheque>();
            ErpContractItems = new HashSet<ErpContractItem>();
            ErpContracts = new HashSet<ErpContract>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpCustomerTransactions = new HashSet<ErpCustomerTransaction>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpDemandReceipts = new HashSet<ErpDemandReceipt>();
            ErpEmployees = new HashSet<ErpEmployee>();
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpExpos = new HashSet<ErpExpo>();
            ErpGlreceiptItems = new HashSet<ErpGlreceiptItem>();
            ErpGlreceipts = new HashSet<ErpGlreceipt>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpPlannings = new HashSet<ErpPlanning>();
            ErpProjectAttachments = new HashSet<ErpProjectAttachment>();
            ErpQualityControlReceiptItems = new HashSet<ErpQualityControlReceiptItem>();
            ErpQualityControlReceipts = new HashSet<ErpQualityControlReceipt>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
            ErpRecipeItems = new HashSet<ErpRecipeItem>();
            ErpServicePriceLists = new HashSet<ErpServicePriceList>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? ProjectCode { get; set; }
        public string? ProjectName { get; set; }
        public string? Explanation { get; set; }
        public byte? ProjectStatus { get; set; }
        public DateTime? EstimatedStartDate { get; set; }
        public DateTime? EstimatedEndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public int? RouteId { get; set; }
        public long? InventoryId { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? AddressId { get; set; }
        public long? EmployeeId { get; set; }
        public int? WarehouseId { get; set; }
        public byte? InUse { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public byte? IsCancelled { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public string? CancelledExplanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? ProjectType { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }

        public virtual ErpAddress? Address { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpRoute? Route { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCredits { get; set; }
        public virtual ICollection<ErpBankReceiptItem> ErpBankReceiptItems { get; set; }
        public virtual ICollection<ErpChequeReceipt> ErpChequeReceipts { get; set; }
        public virtual ICollection<ErpCheque> ErpCheques { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItems { get; set; }
        public virtual ICollection<ErpContract> ErpContracts { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactions { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceipts { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployees { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpExpo> ErpExpos { get; set; }
        public virtual ICollection<ErpGlreceiptItem> ErpGlreceiptItems { get; set; }
        public virtual ICollection<ErpGlreceipt> ErpGlreceipts { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpPlanning> ErpPlannings { get; set; }
        public virtual ICollection<ErpProjectAttachment> ErpProjectAttachments { get; set; }
        public virtual ICollection<ErpQualityControlReceiptItem> ErpQualityControlReceiptItems { get; set; }
        public virtual ICollection<ErpQualityControlReceipt> ErpQualityControlReceipts { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItems { get; set; }
        public virtual ICollection<ErpServicePriceList> ErpServicePriceLists { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
    }
}
