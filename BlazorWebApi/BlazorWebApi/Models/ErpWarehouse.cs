using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWarehouse
    {
        public ErpWarehouse()
        {
            ErpAddresses = new HashSet<ErpAddress>();
            ErpBoxTotals = new HashSet<ErpBoxTotal>();
            ErpBudgetItems = new HashSet<ErpBudgetItem>();
            ErpBudgets = new HashSet<ErpBudget>();
            ErpContractItemVariants = new HashSet<ErpContractItemVariant>();
            ErpContractItems = new HashSet<ErpContractItem>();
            ErpContracts = new HashSet<ErpContract>();
            ErpCurrentAccountTransactions = new HashSet<ErpCurrentAccountTransaction>();
            ErpCurrentAccounts = new HashSet<ErpCurrentAccount>();
            ErpDemandReceiptItemOutWarehouses = new HashSet<ErpDemandReceiptItem>();
            ErpDemandReceiptItemVariants = new HashSet<ErpDemandReceiptItemVariant>();
            ErpDemandReceiptItemWarehouses = new HashSet<ErpDemandReceiptItem>();
            ErpDemandReceiptOutWarehouses = new HashSet<ErpDemandReceipt>();
            ErpDemandReceiptWarehouses = new HashSet<ErpDemandReceipt>();
            ErpDepartmentWarehouses = new HashSet<ErpDepartmentWarehouse>();
            ErpInventoryConsumptionWarehouses = new HashSet<ErpInventory>();
            ErpInventoryManufacturingWarehouses = new HashSet<ErpInventory>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpInventoryReceiptConsumptionWarehouses = new HashSet<ErpInventoryReceipt>();
            ErpInventoryReceiptInWarehouses = new HashSet<ErpInventoryReceipt>();
            ErpInventoryReceiptItemInWarehouses = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceiptItemOutWarehouses = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceiptItemQcrejectedWarehouses = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceiptItemVariantInWarehouses = new HashSet<ErpInventoryReceiptItemVariant>();
            ErpInventoryReceiptItemVariantOutWarehouses = new HashSet<ErpInventoryReceiptItemVariant>();
            ErpInventoryReceiptItemVariantQcrejectedWarehouses = new HashSet<ErpInventoryReceiptItemVariant>();
            ErpInventoryReceiptOutWarehouses = new HashSet<ErpInventoryReceipt>();
            ErpInventoryReceiptQcrejectedWarehouses = new HashSet<ErpInventoryReceipt>();
            ErpInventorySerialCardTotals = new HashSet<ErpInventorySerialCardTotal>();
            ErpInventorySerialTransactionInWarehouses = new HashSet<ErpInventorySerialTransaction>();
            ErpInventorySerialTransactionOutWarehouses = new HashSet<ErpInventorySerialTransaction>();
            ErpInventoryTotals = new HashSet<ErpInventoryTotal>();
            ErpInventoryWarehouses = new HashSet<ErpInventoryWarehouse>();
            ErpInventoryWorkplaces = new HashSet<ErpInventoryWorkplace>();
            ErpInvoiceInWarehouses = new HashSet<ErpInvoice>();
            ErpInvoiceOutWarehouses = new HashSet<ErpInvoice>();
            ErpInvoiceQcrejectedWarehouses = new HashSet<ErpInvoice>();
            ErpMaterialRequirementItems = new HashSet<ErpMaterialRequirementItem>();
            ErpOrderReceiptItemVariants = new HashSet<ErpOrderReceiptItemVariant>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpPos = new HashSet<ErpPo>();
            ErpProductConfiguratorItems = new HashSet<ErpProductConfiguratorItem>();
            ErpProjects = new HashSet<ErpProject>();
            ErpQuotationReceiptItemVariants = new HashSet<ErpQuotationReceiptItemVariant>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
            ErpRecipeItemOutWarehouses = new HashSet<ErpRecipeItem>();
            ErpRecipeItemWastageWarehouses = new HashSet<ErpRecipeItem>();
            ErpRecipeItemWastageWarehousesNavigation = new HashSet<ErpRecipeItemWastageWarehouse>();
            ErpRequirementOutWarehouses = new HashSet<ErpRequirement>();
            ErpRequirementWastageWarehouses = new HashSet<ErpRequirement>();
            ErpRoutes = new HashSet<ErpRoute>();
            ErpServiceWorkplaces = new HashSet<ErpServiceWorkplace>();
            ErpVehicleConnectedWarehouses = new HashSet<ErpVehicle>();
            ErpVehicleWarehouses = new HashSet<ErpVehicle>();
            ErpWarehouseInventoryAttributes = new HashSet<ErpWarehouseInventoryAttribute>();
            ErpWarehouseLocationInventoryWarehouses = new HashSet<ErpWarehouseLocation>();
            ErpWarehouseLocationWarehouses = new HashSet<ErpWarehouseLocation>();
            ErpWorkOrderItemRecipes = new HashSet<ErpWorkOrderItemRecipe>();
            InverseParent = new HashSet<ErpWarehouse>();
            MetaReports = new HashSet<MetaReport>();
            MetaUserCompanies = new HashSet<MetaUserCompany>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? WarehouseCode { get; set; }
        public string? WarehouseName { get; set; }
        public int? ParentId { get; set; }
        public byte? IsDefaultMain { get; set; }
        public byte? IsDefaultShipment { get; set; }
        public byte? IsVirtual { get; set; }
        public short? InventoryTypes { get; set; }
        public short? InventorySubTypes { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public int? DistrictId { get; set; }
        public int? CityId { get; set; }
        public string? PostalCode { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public int? TownId { get; set; }
        public int? StreetId { get; set; }
        public decimal? GpsXcoordinate { get; set; }
        public decimal? GpsYcoordinate { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte? FollowUpWarehouseLocation { get; set; }
        public byte? InUse { get; set; }
        public byte? Usage { get; set; }
        public string? AccessCode { get; set; }
        public string? SpecialCode { get; set; }
        public byte? ControlType { get; set; }
        public byte? McontrolType { get; set; }
        public byte? OptimumControlType { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? UseForMrp { get; set; }
        public byte? LocationControlType { get; set; }

        public virtual MetaCity? City { get; set; }
        public virtual MetaCountry? Country { get; set; }
        public virtual MetaDistrict? District { get; set; }
        public virtual ErpWarehouse? Parent { get; set; }
        public virtual MetaState? State { get; set; }
        public virtual MetaStreet? Street { get; set; }
        public virtual MetaTown? Town { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpAddress> ErpAddresses { get; set; }
        public virtual ICollection<ErpBoxTotal> ErpBoxTotals { get; set; }
        public virtual ICollection<ErpBudgetItem> ErpBudgetItems { get; set; }
        public virtual ICollection<ErpBudget> ErpBudgets { get; set; }
        public virtual ICollection<ErpContractItemVariant> ErpContractItemVariants { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItems { get; set; }
        public virtual ICollection<ErpContract> ErpContracts { get; set; }
        public virtual ICollection<ErpCurrentAccountTransaction> ErpCurrentAccountTransactions { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccounts { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItemOutWarehouses { get; set; }
        public virtual ICollection<ErpDemandReceiptItemVariant> ErpDemandReceiptItemVariants { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItemWarehouses { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceiptOutWarehouses { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceiptWarehouses { get; set; }
        public virtual ICollection<ErpDepartmentWarehouse> ErpDepartmentWarehouses { get; set; }
        public virtual ICollection<ErpInventory> ErpInventoryConsumptionWarehouses { get; set; }
        public virtual ICollection<ErpInventory> ErpInventoryManufacturingWarehouses { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceiptConsumptionWarehouses { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceiptInWarehouses { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItemInWarehouses { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItemOutWarehouses { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItemQcrejectedWarehouses { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemVariant> ErpInventoryReceiptItemVariantInWarehouses { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemVariant> ErpInventoryReceiptItemVariantOutWarehouses { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemVariant> ErpInventoryReceiptItemVariantQcrejectedWarehouses { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceiptOutWarehouses { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceiptQcrejectedWarehouses { get; set; }
        public virtual ICollection<ErpInventorySerialCardTotal> ErpInventorySerialCardTotals { get; set; }
        public virtual ICollection<ErpInventorySerialTransaction> ErpInventorySerialTransactionInWarehouses { get; set; }
        public virtual ICollection<ErpInventorySerialTransaction> ErpInventorySerialTransactionOutWarehouses { get; set; }
        public virtual ICollection<ErpInventoryTotal> ErpInventoryTotals { get; set; }
        public virtual ICollection<ErpInventoryWarehouse> ErpInventoryWarehouses { get; set; }
        public virtual ICollection<ErpInventoryWorkplace> ErpInventoryWorkplaces { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceInWarehouses { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceOutWarehouses { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoiceQcrejectedWarehouses { get; set; }
        public virtual ICollection<ErpMaterialRequirementItem> ErpMaterialRequirementItems { get; set; }
        public virtual ICollection<ErpOrderReceiptItemVariant> ErpOrderReceiptItemVariants { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpPo> ErpPos { get; set; }
        public virtual ICollection<ErpProductConfiguratorItem> ErpProductConfiguratorItems { get; set; }
        public virtual ICollection<ErpProject> ErpProjects { get; set; }
        public virtual ICollection<ErpQuotationReceiptItemVariant> ErpQuotationReceiptItemVariants { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItemOutWarehouses { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItemWastageWarehouses { get; set; }
        public virtual ICollection<ErpRecipeItemWastageWarehouse> ErpRecipeItemWastageWarehousesNavigation { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirementOutWarehouses { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirementWastageWarehouses { get; set; }
        public virtual ICollection<ErpRoute> ErpRoutes { get; set; }
        public virtual ICollection<ErpServiceWorkplace> ErpServiceWorkplaces { get; set; }
        public virtual ICollection<ErpVehicle> ErpVehicleConnectedWarehouses { get; set; }
        public virtual ICollection<ErpVehicle> ErpVehicleWarehouses { get; set; }
        public virtual ICollection<ErpWarehouseInventoryAttribute> ErpWarehouseInventoryAttributes { get; set; }
        public virtual ICollection<ErpWarehouseLocation> ErpWarehouseLocationInventoryWarehouses { get; set; }
        public virtual ICollection<ErpWarehouseLocation> ErpWarehouseLocationWarehouses { get; set; }
        public virtual ICollection<ErpWorkOrderItemRecipe> ErpWorkOrderItemRecipes { get; set; }
        public virtual ICollection<ErpWarehouse> InverseParent { get; set; }
        public virtual ICollection<MetaReport> MetaReports { get; set; }
        public virtual ICollection<MetaUserCompany> MetaUserCompanies { get; set; }
    }
}
