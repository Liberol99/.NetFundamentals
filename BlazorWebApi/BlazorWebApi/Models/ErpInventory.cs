using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventory
    {
        public ErpInventory()
        {
            CrmLeads = new HashSet<CrmLead>();
            CrmMarketingActivityProducts = new HashSet<CrmMarketingActivityProduct>();
            ErpActualCosts = new HashSet<ErpActualCost>();
            ErpAsserviceFaulties = new HashSet<ErpAsserviceFaulty>();
            ErpAsserviceFaultyItems = new HashSet<ErpAsserviceFaultyItem>();
            ErpBoxItems = new HashSet<ErpBoxItem>();
            ErpBudgetItems = new HashSet<ErpBudgetItem>();
            ErpCompetitorProducts = new HashSet<ErpCompetitorProduct>();
            ErpContractItemVariants = new HashSet<ErpContractItemVariant>();
            ErpContractItems = new HashSet<ErpContractItem>();
            ErpCostCenterDistributions = new HashSet<ErpCostCenterDistribution>();
            ErpCustomerTransactions = new HashSet<ErpCustomerTransaction>();
            ErpDemandReceiptItemVariants = new HashSet<ErpDemandReceiptItemVariant>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpEmployeeCompetencies = new HashSet<ErpEmployeeCompetency>();
            ErpExpoItemVariants = new HashSet<ErpExpoItemVariant>();
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpFixedAssetDebitInventories = new HashSet<ErpFixedAssetDebit>();
            ErpFixedAssetDebitInventoryInventories = new HashSet<ErpFixedAssetDebit>();
            ErpFixedAssetDepreciations = new HashSet<ErpFixedAssetDepreciation>();
            ErpFixedAssetExpenses = new HashSet<ErpFixedAssetExpense>();
            ErpInitialCostItems = new HashSet<ErpInitialCostItem>();
            ErpInitialCosts = new HashSet<ErpInitialCost>();
            ErpInventoryAllocations = new HashSet<ErpInventoryAllocation>();
            ErpInventoryAlternativeAlternatives = new HashSet<ErpInventoryAlternative>();
            ErpInventoryAlternativeInventories = new HashSet<ErpInventoryAlternative>();
            ErpInventoryAssortments = new HashSet<ErpInventoryAssortment>();
            ErpInventoryAttachments = new HashSet<ErpInventoryAttachment>();
            ErpInventoryAttributes = new HashSet<ErpInventoryAttribute>();
            ErpInventoryBarcodes = new HashSet<ErpInventoryBarcode>();
            ErpInventoryCampaignItems = new HashSet<ErpInventoryCampaignItem>();
            ErpInventoryCampaigns = new HashSet<ErpInventoryCampaign>();
            ErpInventoryExplanations = new HashSet<ErpInventoryExplanation>();
            ErpInventoryIas = new HashSet<ErpInventoryIa>();
            ErpInventoryMargins = new HashSet<ErpInventoryMargin>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpInventoryReceiptItemCostInventories = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceiptItemInventories = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceiptItemVariants = new HashSet<ErpInventoryReceiptItemVariant>();
            ErpInventoryReceiptShipments = new HashSet<ErpInventoryReceiptShipment>();
            ErpInventorySerialCards = new HashSet<ErpInventorySerialCard>();
            ErpInventorySuppliers = new HashSet<ErpInventorySupplier>();
            ErpInventoryTotals = new HashSet<ErpInventoryTotal>();
            ErpInventoryUnitItemSizes = new HashSet<ErpInventoryUnitItemSize>();
            ErpInventoryVariants = new HashSet<ErpInventoryVariant>();
            ErpInventoryWarehouses = new HashSet<ErpInventoryWarehouse>();
            ErpInventoryWorkStudies = new HashSet<ErpInventoryWorkStudy>();
            ErpInventoryWorkplaces = new HashSet<ErpInventoryWorkplace>();
            ErpLabRecipeItems = new HashSet<ErpLabRecipeItem>();
            ErpLabRecipes = new HashSet<ErpLabRecipe>();
            ErpMaterialRequirementItems = new HashSet<ErpMaterialRequirementItem>();
            ErpOrderReceiptItemVariants = new HashSet<ErpOrderReceiptItemVariant>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpPackingListItemVariants = new HashSet<ErpPackingListItemVariant>();
            ErpPackingListItems = new HashSet<ErpPackingListItem>();
            ErpProcessResources = new HashSet<ErpProcessResource>();
            ErpProductConfiguratorItems = new HashSet<ErpProductConfiguratorItem>();
            ErpProductConfigurators = new HashSet<ErpProductConfigurator>();
            ErpProjects = new HashSet<ErpProject>();
            ErpQualityControlReceiptItems = new HashSet<ErpQualityControlReceiptItem>();
            ErpQualityControlReceipts = new HashSet<ErpQualityControlReceipt>();
            ErpQualityControls = new HashSet<ErpQualityControl>();
            ErpQuotationReceiptItemVariants = new HashSet<ErpQuotationReceiptItemVariant>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            ErpRecipeItemInventories = new HashSet<ErpRecipeItem>();
            ErpRecipeItemOwnerInventories = new HashSet<ErpRecipeItem>();
            ErpRecipeProgramItems = new HashSet<ErpRecipeProgramItem>();
            ErpRecipePrograms = new HashSet<ErpRecipeProgram>();
            ErpRecipes = new HashSet<ErpRecipe>();
            ErpRequirementInventories = new HashSet<ErpRequirement>();
            ErpRequirementStyles = new HashSet<ErpRequirement>();
            ErpResourceInventories = new HashSet<ErpResourceInventory>();
            ErpResources = new HashSet<ErpResource>();
            ErpRoutes = new HashSet<ErpRoute>();
            ErpSizeSetItemVariants = new HashSet<ErpSizeSetItemVariant>();
            ErpSizeSetItems = new HashSet<ErpSizeSetItem>();
            ErpSizeSets = new HashSet<ErpSizeSet>();
            ErpTestItems = new HashSet<ErpTestItem>();
            ErpWarehouseLocationTotals = new HashSet<ErpWarehouseLocationTotal>();
            ErpWarehouseLocations = new HashSet<ErpWarehouseLocation>();
            ErpWorkOrderCostDistributions = new HashSet<ErpWorkOrderCostDistribution>();
            ErpWorkOrderItemProcesses = new HashSet<ErpWorkOrderItemProcess>();
            ErpWorkOrderItemRecipes = new HashSet<ErpWorkOrderItemRecipe>();
            ErpWorkOrderItemVariants = new HashSet<ErpWorkOrderItemVariant>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderProductionFabrics = new HashSet<ErpWorkOrderProduction>();
            ErpWorkOrderProductionInventories = new HashSet<ErpWorkOrderProduction>();
            ErpWorkOrderProductionVariants = new HashSet<ErpWorkOrderProductionVariant>();
            ErpWorkOrderProgresses = new HashSet<ErpWorkOrderProgress>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
            InverseParent = new HashSet<ErpInventory>();
            PosMenuItemInventories = new HashSet<PosMenuItem>();
            PosMenuItemSetMenuOrAdditionalInventories = new HashSet<PosMenuItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public short? InventoryType { get; set; }
        public short? InventorySubType { get; set; }
        public string? InventoryCode { get; set; }
        public string? InventoryName { get; set; }
        public string? InventoryProductCode { get; set; }
        public long? GroupId { get; set; }
        public int? CategoryId { get; set; }
        public string? PluCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? IsClass { get; set; }
        public long? ParentId { get; set; }
        public int? UnitId { get; set; }
        public int? TaxId { get; set; }
        public byte? HasVatPositiveEffect { get; set; }
        public int? VatId { get; set; }
        public int? RetailVatId { get; set; }
        public int? RetailReturnVatId { get; set; }
        public int? WholeSaleVatId { get; set; }
        public int? WholeSaleReturnVatId { get; set; }
        public byte? HasVariant { get; set; }
        public byte? HasRowVariant { get; set; }
        public byte? HasSeries { get; set; }
        public byte? HasSeparableSeries { get; set; }
        public byte? IsWithholdable { get; set; }
        public byte? WithholdingFactor { get; set; }
        public byte? WithholdingDivisor { get; set; }
        public string? ProducerInventoryCode { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? CtspId { get; set; }
        public byte? Tracking { get; set; }
        public byte? IsQcrequried { get; set; }
        public byte? IsTool { get; set; }
        public byte? IsPackagingMaterial { get; set; }
        public byte? DepreciationType { get; set; }
        public decimal? DepreciationRate { get; set; }
        public short? DepreciationPeriod { get; set; }
        public decimal? SalvageValue { get; set; }
        public byte? Revaluation { get; set; }
        public byte? PartialDepreciation { get; set; }
        public byte? IsBuilding { get; set; }
        public DateTime? DepreciationStartDate { get; set; }
        public DateTime? DepreciationEndDate { get; set; }
        public decimal? PurchaseCost { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string? PurchaseDocument { get; set; }
        public decimal? PurchaseAmount { get; set; }
        public DateTime? SoldDate { get; set; }
        public string? SoldDocument { get; set; }
        public decimal? SoldAmount { get; set; }
        public short? ShelfLife { get; set; }
        public byte? ShelfLifeUnit { get; set; }
        public byte? UseForCommon { get; set; }
        public byte? UseForPurchase { get; set; }
        public byte? UseForSale { get; set; }
        public byte? UseForRecipe { get; set; }
        public int? ProcessId { get; set; }
        public int? RouteId { get; set; }
        public long? MarkId { get; set; }
        public long? ModelId { get; set; }
        public long? SeasonId { get; set; }
        public string? SeasonCode { get; set; }
        public string? CampaignGroup { get; set; }
        public string? PriceGroup { get; set; }
        public string? IsoDocumentNo { get; set; }
        public string? WebContent { get; set; }
        public long? SymbolId { get; set; }
        public long? UsefulServiceLifeId { get; set; }
        public string? Stext { get; set; }
        public string? Ctext { get; set; }
        public int? Variant1TypeId { get; set; }
        public int? Variant2TypeId { get; set; }
        public int? Variant3TypeId { get; set; }
        public int? Variant4TypeId { get; set; }
        public int? Variant5TypeId { get; set; }
        public short? Variant1TypeControlType { get; set; }
        public short? Variant2TypeControlType { get; set; }
        public short? Variant3TypeControlType { get; set; }
        public short? Variant4TypeControlType { get; set; }
        public short? Variant5TypeControlType { get; set; }
        public byte? IsTaxGrossQuantity { get; set; }
        public decimal? GrossQuantityTax { get; set; }
        public decimal? LocalCurrencyForexRate2 { get; set; }
        public decimal? LocalCurrencyForexRate3 { get; set; }
        public byte? InUse { get; set; }
        public byte? IsLocked { get; set; }
        public string? SpecialCode { get; set; }
        public decimal? RecipeQuantity { get; set; }
        public int? RecipeUnitItemId { get; set; }
        public decimal? RecipeCostPrice { get; set; }
        public short? RevisionNumber { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsApproved { get; set; }
        public byte? IsPublishWeb { get; set; }
        public byte? IsPriceUpdate { get; set; }
        public byte? IsPiecesProduct { get; set; }
        public byte? IsWeightedProduct { get; set; }
        public byte? IsPricedProduct { get; set; }
        public byte? NonRefundable { get; set; }
        public byte? IsSecondHand { get; set; }
        public byte? IsInstantPrice { get; set; }
        public byte? IsInstantQuantity { get; set; }
        public DateTime? PreparationTime { get; set; }
        public long? DegreeOfDifficulty { get; set; }
        public byte? HasDontTotalEffect { get; set; }
        public byte? ExpenseType { get; set; }
        public long? GiftVoucherId { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }
        public byte? SupplyType { get; set; }
        public int? SupplyDay { get; set; }
        public decimal? SupplyCoefficient { get; set; }
        public byte? IsDepositProduct { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public byte? UseForMrp { get; set; }
        public byte? QccontrolType { get; set; }
        public long? InventoryReceiptItemId { get; set; }
        public string? UdUzunKod { get; set; }
        public string? UdSabitKiyGid { get; set; }
        public byte? IsSparePart { get; set; }
        public int? CostCenterId { get; set; }
        public string? Markers1 { get; set; }
        public string? Markers2 { get; set; }
        public string? Markers3 { get; set; }
        public string? Markers4 { get; set; }
        public string? Markers5 { get; set; }
        public string? Markers6 { get; set; }
        public string? Markers7 { get; set; }
        public string? Markers8 { get; set; }
        public string? Markers9 { get; set; }
        public string? Markers10 { get; set; }
        public string? D01 { get; set; }
        public string? D02 { get; set; }
        public string? D03 { get; set; }
        public string? D04 { get; set; }
        public string? D05 { get; set; }
        public string? D06 { get; set; }
        public string? D07 { get; set; }
        public string? D08 { get; set; }
        public string? D09 { get; set; }
        public string? D10 { get; set; }
        public string? CustomerStyle { get; set; }
        public string? Explanation1 { get; set; }
        public string? Explanation2 { get; set; }
        public string? Explanation3 { get; set; }
        public string? Explanation4 { get; set; }
        public string? Explanation5 { get; set; }
        public string? V1 { get; set; }
        public string? V2 { get; set; }
        public string? V3 { get; set; }
        public string? V4 { get; set; }
        public string? V5 { get; set; }
        public string? V6 { get; set; }
        public string? V7 { get; set; }
        public string? V8 { get; set; }
        public string? SvalueText { get; set; }
        public string? Cadcode { get; set; }
        public string? PreviousCode { get; set; }
        public short? VersionType { get; set; }
        public string? Explanation6 { get; set; }
        public string? Explanation7 { get; set; }
        public string? Explanation8 { get; set; }
        public string? Explanation9 { get; set; }
        public string? Explanation10 { get; set; }
        public string? PieceDefinition { get; set; }
        public int? V1typeId { get; set; }
        public int? V2typeId { get; set; }
        public int? V3typeId { get; set; }
        public int? V4typeId { get; set; }
        public int? V5typeId { get; set; }
        public int? V6typeId { get; set; }
        public int? V7typeId { get; set; }
        public int? V8typeId { get; set; }
        public long? PollId { get; set; }
        public short? MergeTime { get; set; }
        public int? ManufacturingWarehouseId { get; set; }
        public int? ConsumptionWarehouseId { get; set; }
        public decimal? OptimumQuantity { get; set; }
        public decimal? MinimumQuantity { get; set; }
        public decimal? MinimumOrderQuantity { get; set; }

        public virtual ErpCategory? Category { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpWarehouse? ConsumptionWarehouse { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual MetaCtsp? Ctsp { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpGiftVoucher? GiftVoucher { get; set; }
        public virtual ErpInventoryGroup? Group { get; set; }
        public virtual ErpInventoryReceiptItem? InventoryReceiptItem { get; set; }
        public virtual ErpWarehouse? ManufacturingWarehouse { get; set; }
        public virtual ErpMark? Mark { get; set; }
        public virtual ErpModel? Model { get; set; }
        public virtual ErpInventory? Parent { get; set; }
        public virtual ErpPoll? Poll { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpInventoryUnitItemSize? RecipeUnitItem { get; set; }
        public virtual ErpTax? RetailReturnVat { get; set; }
        public virtual ErpTax? RetailVat { get; set; }
        public virtual ErpRoute? Route { get; set; }
        public virtual ErpSeason? Season { get; set; }
        public virtual MetaSymbol? Symbol { get; set; }
        public virtual ErpTax? Tax { get; set; }
        public virtual MetaUnitSet? Unit { get; set; }
        public virtual ErpFixedAssetUsefulServiceLife? UsefulServiceLife { get; set; }
        public virtual ErpVariantType? Variant1Type { get; set; }
        public virtual ErpVariantType? Variant2Type { get; set; }
        public virtual ErpVariantType? Variant3Type { get; set; }
        public virtual ErpVariantType? Variant4Type { get; set; }
        public virtual ErpVariantType? Variant5Type { get; set; }
        public virtual ErpTax? Vat { get; set; }
        public virtual ErpTax? WholeSaleReturnVat { get; set; }
        public virtual ErpTax? WholeSaleVat { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<CrmLead> CrmLeads { get; set; }
        public virtual ICollection<CrmMarketingActivityProduct> CrmMarketingActivityProducts { get; set; }
        public virtual ICollection<ErpActualCost> ErpActualCosts { get; set; }
        public virtual ICollection<ErpAsserviceFaulty> ErpAsserviceFaulties { get; set; }
        public virtual ICollection<ErpAsserviceFaultyItem> ErpAsserviceFaultyItems { get; set; }
        public virtual ICollection<ErpBoxItem> ErpBoxItems { get; set; }
        public virtual ICollection<ErpBudgetItem> ErpBudgetItems { get; set; }
        public virtual ICollection<ErpCompetitorProduct> ErpCompetitorProducts { get; set; }
        public virtual ICollection<ErpContractItemVariant> ErpContractItemVariants { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItems { get; set; }
        public virtual ICollection<ErpCostCenterDistribution> ErpCostCenterDistributions { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactions { get; set; }
        public virtual ICollection<ErpDemandReceiptItemVariant> ErpDemandReceiptItemVariants { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpEmployeeCompetency> ErpEmployeeCompetencies { get; set; }
        public virtual ICollection<ErpExpoItemVariant> ErpExpoItemVariants { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpFixedAssetDebit> ErpFixedAssetDebitInventories { get; set; }
        public virtual ICollection<ErpFixedAssetDebit> ErpFixedAssetDebitInventoryInventories { get; set; }
        public virtual ICollection<ErpFixedAssetDepreciation> ErpFixedAssetDepreciations { get; set; }
        public virtual ICollection<ErpFixedAssetExpense> ErpFixedAssetExpenses { get; set; }
        public virtual ICollection<ErpInitialCostItem> ErpInitialCostItems { get; set; }
        public virtual ICollection<ErpInitialCost> ErpInitialCosts { get; set; }
        public virtual ICollection<ErpInventoryAllocation> ErpInventoryAllocations { get; set; }
        public virtual ICollection<ErpInventoryAlternative> ErpInventoryAlternativeAlternatives { get; set; }
        public virtual ICollection<ErpInventoryAlternative> ErpInventoryAlternativeInventories { get; set; }
        public virtual ICollection<ErpInventoryAssortment> ErpInventoryAssortments { get; set; }
        public virtual ICollection<ErpInventoryAttachment> ErpInventoryAttachments { get; set; }
        public virtual ICollection<ErpInventoryAttribute> ErpInventoryAttributes { get; set; }
        public virtual ICollection<ErpInventoryBarcode> ErpInventoryBarcodes { get; set; }
        public virtual ICollection<ErpInventoryCampaignItem> ErpInventoryCampaignItems { get; set; }
        public virtual ICollection<ErpInventoryCampaign> ErpInventoryCampaigns { get; set; }
        public virtual ICollection<ErpInventoryExplanation> ErpInventoryExplanations { get; set; }
        public virtual ICollection<ErpInventoryIa> ErpInventoryIas { get; set; }
        public virtual ICollection<ErpInventoryMargin> ErpInventoryMargins { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItemCostInventories { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItemInventories { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemVariant> ErpInventoryReceiptItemVariants { get; set; }
        public virtual ICollection<ErpInventoryReceiptShipment> ErpInventoryReceiptShipments { get; set; }
        public virtual ICollection<ErpInventorySerialCard> ErpInventorySerialCards { get; set; }
        public virtual ICollection<ErpInventorySupplier> ErpInventorySuppliers { get; set; }
        public virtual ICollection<ErpInventoryTotal> ErpInventoryTotals { get; set; }
        public virtual ICollection<ErpInventoryUnitItemSize> ErpInventoryUnitItemSizes { get; set; }
        public virtual ICollection<ErpInventoryVariant> ErpInventoryVariants { get; set; }
        public virtual ICollection<ErpInventoryWarehouse> ErpInventoryWarehouses { get; set; }
        public virtual ICollection<ErpInventoryWorkStudy> ErpInventoryWorkStudies { get; set; }
        public virtual ICollection<ErpInventoryWorkplace> ErpInventoryWorkplaces { get; set; }
        public virtual ICollection<ErpLabRecipeItem> ErpLabRecipeItems { get; set; }
        public virtual ICollection<ErpLabRecipe> ErpLabRecipes { get; set; }
        public virtual ICollection<ErpMaterialRequirementItem> ErpMaterialRequirementItems { get; set; }
        public virtual ICollection<ErpOrderReceiptItemVariant> ErpOrderReceiptItemVariants { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpPackingListItemVariant> ErpPackingListItemVariants { get; set; }
        public virtual ICollection<ErpPackingListItem> ErpPackingListItems { get; set; }
        public virtual ICollection<ErpProcessResource> ErpProcessResources { get; set; }
        public virtual ICollection<ErpProductConfiguratorItem> ErpProductConfiguratorItems { get; set; }
        public virtual ICollection<ErpProductConfigurator> ErpProductConfigurators { get; set; }
        public virtual ICollection<ErpProject> ErpProjects { get; set; }
        public virtual ICollection<ErpQualityControlReceiptItem> ErpQualityControlReceiptItems { get; set; }
        public virtual ICollection<ErpQualityControlReceipt> ErpQualityControlReceipts { get; set; }
        public virtual ICollection<ErpQualityControl> ErpQualityControls { get; set; }
        public virtual ICollection<ErpQuotationReceiptItemVariant> ErpQuotationReceiptItemVariants { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItemInventories { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItemOwnerInventories { get; set; }
        public virtual ICollection<ErpRecipeProgramItem> ErpRecipeProgramItems { get; set; }
        public virtual ICollection<ErpRecipeProgram> ErpRecipePrograms { get; set; }
        public virtual ICollection<ErpRecipe> ErpRecipes { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirementInventories { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirementStyles { get; set; }
        public virtual ICollection<ErpResourceInventory> ErpResourceInventories { get; set; }
        public virtual ICollection<ErpResource> ErpResources { get; set; }
        public virtual ICollection<ErpRoute> ErpRoutes { get; set; }
        public virtual ICollection<ErpSizeSetItemVariant> ErpSizeSetItemVariants { get; set; }
        public virtual ICollection<ErpSizeSetItem> ErpSizeSetItems { get; set; }
        public virtual ICollection<ErpSizeSet> ErpSizeSets { get; set; }
        public virtual ICollection<ErpTestItem> ErpTestItems { get; set; }
        public virtual ICollection<ErpWarehouseLocationTotal> ErpWarehouseLocationTotals { get; set; }
        public virtual ICollection<ErpWarehouseLocation> ErpWarehouseLocations { get; set; }
        public virtual ICollection<ErpWorkOrderCostDistribution> ErpWorkOrderCostDistributions { get; set; }
        public virtual ICollection<ErpWorkOrderItemProcess> ErpWorkOrderItemProcesses { get; set; }
        public virtual ICollection<ErpWorkOrderItemRecipe> ErpWorkOrderItemRecipes { get; set; }
        public virtual ICollection<ErpWorkOrderItemVariant> ErpWorkOrderItemVariants { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductionFabrics { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductionInventories { get; set; }
        public virtual ICollection<ErpWorkOrderProductionVariant> ErpWorkOrderProductionVariants { get; set; }
        public virtual ICollection<ErpWorkOrderProgress> ErpWorkOrderProgresses { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
        public virtual ICollection<ErpInventory> InverseParent { get; set; }
        public virtual ICollection<PosMenuItem> PosMenuItemInventories { get; set; }
        public virtual ICollection<PosMenuItem> PosMenuItemSetMenuOrAdditionalInventories { get; set; }
    }
}
