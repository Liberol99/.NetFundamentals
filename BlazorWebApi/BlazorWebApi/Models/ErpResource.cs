using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpResource
    {
        public ErpResource()
        {
            CrmLeads = new HashSet<CrmLead>();
            CrmMarketingActivityResources = new HashSet<CrmMarketingActivityResource>();
            CrmTransactionFlowResources = new HashSet<CrmTransactionFlowResource>();
            ErpContractItems = new HashSet<ErpContractItem>();
            ErpCostCenterDistributions = new HashSet<ErpCostCenterDistribution>();
            ErpCustomerTransactionResources = new HashSet<ErpCustomerTransactionResource>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpEmployeeCompetencies = new HashSet<ErpEmployeeCompetency>();
            ErpEmployeeTimeAttandances = new HashSet<ErpEmployeeTimeAttandance>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpInventorySerialCards = new HashSet<ErpInventorySerialCard>();
            ErpInventoryWorkStudies = new HashSet<ErpInventoryWorkStudy>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpParameterPosPrinters = new HashSet<ErpParameterPosPrinter>();
            ErpPlannings = new HashSet<ErpPlanning>();
            ErpPos = new HashSet<ErpPo>();
            ErpProcessResources = new HashSet<ErpProcessResource>();
            ErpProcesses = new HashSet<ErpProcess>();
            ErpQualityControlProcessDetails = new HashSet<ErpQualityControlProcessDetail>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            ErpRecipeItems = new HashSet<ErpRecipeItem>();
            ErpResourceAttributes = new HashSet<ErpResourceAttribute>();
            ErpResourceInventories = new HashSet<ErpResourceInventory>();
            ErpResourceOutOfUses = new HashSet<ErpResourceOutOfUse>();
            ErpRouteItems = new HashSet<ErpRouteItem>();
            ErpWorkOrderExplanations = new HashSet<ErpWorkOrderExplanation>();
            ErpWorkOrderItemProcesses = new HashSet<ErpWorkOrderItemProcess>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderProductions = new HashSet<ErpWorkOrderProduction>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            InverseParentResource = new HashSet<ErpResource>();
            MetaPrinters = new HashSet<MetaPrinter>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public long? ParentResourceId { get; set; }
        public string? ResourceCode { get; set; }
        public short? ResourceType { get; set; }
        public int? DepartmentId { get; set; }
        public long? EmployeeId { get; set; }
        public int? VehicleId { get; set; }
        public long? ServiceId { get; set; }
        public long? InventoryId { get; set; }
        public string? Explanation { get; set; }
        public decimal? Capacity { get; set; }
        public decimal? ExtraCapacity { get; set; }
        public decimal? Flote { get; set; }
        public byte? IsOwned { get; set; }
        public long? SupplierId { get; set; }
        public long? SymbolId { get; set; }
        public int? ProcessId { get; set; }
        public int? Rpm { get; set; }
        public int? LoopCount { get; set; }
        public string? AutomationCode { get; set; }
        public byte? PlanningWindow { get; set; }
        public int? DailyWorkingTime { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public string? ProxyNo { get; set; }
        public decimal? CompetencyPoints { get; set; }
        public long? CalendarId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? CheckActiveManufacturing { get; set; }
        public string? CostDistributionTypeIds { get; set; }
        public string? MachineName { get; set; }
        public DateTime? EndUsing { get; set; }
        public DateTime? StartUsing { get; set; }
        public byte? Used { get; set; }
        public long? Serial { get; set; }
        public string? WarrantyDocNo { get; set; }
        public DateTime? WarrantyStart { get; set; }
        public DateTime? WarrantyExpiration { get; set; }
        public string? ModelName { get; set; }
        public long? ModelYear { get; set; }
        public string? Brand { get; set; }
        public long? Authorized { get; set; }
        public long? ManufacturerCompany { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public long? PurchaseCompany { get; set; }
        public long? CompanyAuthorized { get; set; }

        public virtual ErpCalendar? Calendar { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpResource? ParentResource { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpService? Service { get; set; }
        public virtual ErpCurrentAccount? Supplier { get; set; }
        public virtual MetaSymbol? Symbol { get; set; }
        public virtual ErpVehicle? Vehicle { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<CrmLead> CrmLeads { get; set; }
        public virtual ICollection<CrmMarketingActivityResource> CrmMarketingActivityResources { get; set; }
        public virtual ICollection<CrmTransactionFlowResource> CrmTransactionFlowResources { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItems { get; set; }
        public virtual ICollection<ErpCostCenterDistribution> ErpCostCenterDistributions { get; set; }
        public virtual ICollection<ErpCustomerTransactionResource> ErpCustomerTransactionResources { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpEmployeeCompetency> ErpEmployeeCompetencies { get; set; }
        public virtual ICollection<ErpEmployeeTimeAttandance> ErpEmployeeTimeAttandances { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventorySerialCard> ErpInventorySerialCards { get; set; }
        public virtual ICollection<ErpInventoryWorkStudy> ErpInventoryWorkStudies { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpParameterPosPrinter> ErpParameterPosPrinters { get; set; }
        public virtual ICollection<ErpPlanning> ErpPlannings { get; set; }
        public virtual ICollection<ErpPo> ErpPos { get; set; }
        public virtual ICollection<ErpProcessResource> ErpProcessResources { get; set; }
        public virtual ICollection<ErpProcess> ErpProcesses { get; set; }
        public virtual ICollection<ErpQualityControlProcessDetail> ErpQualityControlProcessDetails { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItems { get; set; }
        public virtual ICollection<ErpResourceAttribute> ErpResourceAttributes { get; set; }
        public virtual ICollection<ErpResourceInventory> ErpResourceInventories { get; set; }
        public virtual ICollection<ErpResourceOutOfUse> ErpResourceOutOfUses { get; set; }
        public virtual ICollection<ErpRouteItem> ErpRouteItems { get; set; }
        public virtual ICollection<ErpWorkOrderExplanation> ErpWorkOrderExplanations { get; set; }
        public virtual ICollection<ErpWorkOrderItemProcess> ErpWorkOrderItemProcesses { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductions { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<ErpResource> InverseParentResource { get; set; }
        public virtual ICollection<MetaPrinter> MetaPrinters { get; set; }
    }
}
