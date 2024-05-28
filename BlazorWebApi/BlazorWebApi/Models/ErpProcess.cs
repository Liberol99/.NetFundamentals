using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpProcess
    {
        public ErpProcess()
        {
            ErpCostCenterDistributions = new HashSet<ErpCostCenterDistribution>();
            ErpEmployeeCompetencies = new HashSet<ErpEmployeeCompetency>();
            ErpEmployees = new HashSet<ErpEmployee>();
            ErpFaultyCards = new HashSet<ErpFaultyCard>();
            ErpInitialCostCards = new HashSet<ErpInitialCostCard>();
            ErpInitialCostItems = new HashSet<ErpInitialCostItem>();
            ErpInventories = new HashSet<ErpInventory>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryWorkStudyProcesses = new HashSet<ErpInventoryWorkStudy>();
            ErpInventoryWorkStudyProductionProcesses = new HashSet<ErpInventoryWorkStudy>();
            ErpPlannings = new HashSet<ErpPlanning>();
            ErpProcessAttachments = new HashSet<ErpProcessAttachment>();
            ErpProcessResources = new HashSet<ErpProcessResource>();
            ErpProductConfiguratorItems = new HashSet<ErpProductConfiguratorItem>();
            ErpQualityControlProcessDetails = new HashSet<ErpQualityControlProcessDetail>();
            ErpQualityControlReceiptItems = new HashSet<ErpQualityControlReceiptItem>();
            ErpQualityControlReceipts = new HashSet<ErpQualityControlReceipt>();
            ErpQualityControlTestDetails = new HashSet<ErpQualityControlTestDetail>();
            ErpRecipeItems = new HashSet<ErpRecipeItem>();
            ErpRecipeOprs = new HashSet<ErpRecipeOpr>();
            ErpRecipeProgramTypeProcess2s = new HashSet<ErpRecipeProgramType>();
            ErpRecipeProgramTypeProcesses = new HashSet<ErpRecipeProgramType>();
            ErpRecipePrograms = new HashSet<ErpRecipeProgram>();
            ErpRequirements = new HashSet<ErpRequirement>();
            ErpResources = new HashSet<ErpResource>();
            ErpRouteItemParentProcesses = new HashSet<ErpRouteItem>();
            ErpRouteItemProcesses = new HashSet<ErpRouteItem>();
            ErpSizeSetItems = new HashSet<ErpSizeSetItem>();
            ErpWorkOrderExplanations = new HashSet<ErpWorkOrderExplanation>();
            ErpWorkOrderItemProcessParentProcesses = new HashSet<ErpWorkOrderItemProcess>();
            ErpWorkOrderItemProcessProcesses = new HashSet<ErpWorkOrderItemProcess>();
            ErpWorkOrderItemRecipes = new HashSet<ErpWorkOrderItemRecipe>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderProductions = new HashSet<ErpWorkOrderProduction>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            InverseParent = new HashSet<ErpProcess>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? ProcessCode { get; set; }
        public string? ProcessName { get; set; }
        public string? ProcessExplanation { get; set; }
        public int? ParentId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? CheckRoute { get; set; }
        public byte? UseManufacturing { get; set; }
        public byte? CheckManufacturing { get; set; }
        public byte? UsePlanning { get; set; }
        public byte? CheckPlanning { get; set; }
        public byte? CheckActiveManufacturing { get; set; }
        public byte? JumpControl { get; set; }
        public int? ForegroundColor { get; set; }
        public int? BackgroundColor { get; set; }
        public byte? QuantityEntryWindow { get; set; }
        public byte? RawMaterialConsumption { get; set; }
        public byte? DyeRawMaterialConsumption { get; set; }
        public byte? CreateContainer { get; set; }
        public byte? CalcType { get; set; }
        public byte? PrintForm { get; set; }
        public byte? MultipleResourceUsage { get; set; }
        public long? ServiceId { get; set; }
        public long? SymbolId { get; set; }
        public long? ResourceId { get; set; }
        public string? Explanation { get; set; }
        public string? Segment { get; set; }
        public string? ProxyNo { get; set; }
        public byte? WidthEntryWindows { get; set; }
        public byte? GramEntryWindows { get; set; }
        public string? ComingTransactionType1 { get; set; }
        public string? ComingTransactionType2 { get; set; }
        public string? ComingTransactionType3 { get; set; }
        public string? ComingTransactionType4 { get; set; }
        public string? ComingTransactionType5 { get; set; }
        public byte? WarningType { get; set; }
        public string? WarningAdress { get; set; }
        public byte? ActualType { get; set; }
        public long? LateTimeInterval { get; set; }
        public long? InitialCostCardId { get; set; }
        public decimal? StandartTime { get; set; }
        public decimal? StandartTimeInitial { get; set; }
        public decimal? StandartTimeDistribution { get; set; }
        public decimal? StandartTimeActual { get; set; }
        public decimal? CrewCount { get; set; }
        public decimal? CompetencyPoints { get; set; }
        public byte? AutomaticProcessOut { get; set; }
        public byte? IsParticleQuantity { get; set; }
        public byte? CheckProcessInRoute { get; set; }
        public decimal? DefaultPrice { get; set; }
        public int? CostCenterId { get; set; }
        public short? SubContractorType { get; set; }
        public string? ProductionDetailFields { get; set; }
        public byte? AllowMultipleProduction { get; set; }
        public byte? CreateInventoryReceipt { get; set; }
        public byte? IsMainProcess { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpInitialCostCard? InitialCostCard { get; set; }
        public virtual ErpProcess? Parent { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpService? Service { get; set; }
        public virtual MetaSymbol? Symbol { get; set; }
        public virtual ICollection<ErpCostCenterDistribution> ErpCostCenterDistributions { get; set; }
        public virtual ICollection<ErpEmployeeCompetency> ErpEmployeeCompetencies { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployees { get; set; }
        public virtual ICollection<ErpFaultyCard> ErpFaultyCards { get; set; }
        public virtual ICollection<ErpInitialCostCard> ErpInitialCostCards { get; set; }
        public virtual ICollection<ErpInitialCostItem> ErpInitialCostItems { get; set; }
        public virtual ICollection<ErpInventory> ErpInventories { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryWorkStudy> ErpInventoryWorkStudyProcesses { get; set; }
        public virtual ICollection<ErpInventoryWorkStudy> ErpInventoryWorkStudyProductionProcesses { get; set; }
        public virtual ICollection<ErpPlanning> ErpPlannings { get; set; }
        public virtual ICollection<ErpProcessAttachment> ErpProcessAttachments { get; set; }
        public virtual ICollection<ErpProcessResource> ErpProcessResources { get; set; }
        public virtual ICollection<ErpProductConfiguratorItem> ErpProductConfiguratorItems { get; set; }
        public virtual ICollection<ErpQualityControlProcessDetail> ErpQualityControlProcessDetails { get; set; }
        public virtual ICollection<ErpQualityControlReceiptItem> ErpQualityControlReceiptItems { get; set; }
        public virtual ICollection<ErpQualityControlReceipt> ErpQualityControlReceipts { get; set; }
        public virtual ICollection<ErpQualityControlTestDetail> ErpQualityControlTestDetails { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItems { get; set; }
        public virtual ICollection<ErpRecipeOpr> ErpRecipeOprs { get; set; }
        public virtual ICollection<ErpRecipeProgramType> ErpRecipeProgramTypeProcess2s { get; set; }
        public virtual ICollection<ErpRecipeProgramType> ErpRecipeProgramTypeProcesses { get; set; }
        public virtual ICollection<ErpRecipeProgram> ErpRecipePrograms { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirements { get; set; }
        public virtual ICollection<ErpResource> ErpResources { get; set; }
        public virtual ICollection<ErpRouteItem> ErpRouteItemParentProcesses { get; set; }
        public virtual ICollection<ErpRouteItem> ErpRouteItemProcesses { get; set; }
        public virtual ICollection<ErpSizeSetItem> ErpSizeSetItems { get; set; }
        public virtual ICollection<ErpWorkOrderExplanation> ErpWorkOrderExplanations { get; set; }
        public virtual ICollection<ErpWorkOrderItemProcess> ErpWorkOrderItemProcessParentProcesses { get; set; }
        public virtual ICollection<ErpWorkOrderItemProcess> ErpWorkOrderItemProcessProcesses { get; set; }
        public virtual ICollection<ErpWorkOrderItemRecipe> ErpWorkOrderItemRecipes { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductions { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<ErpProcess> InverseParent { get; set; }
    }
}
