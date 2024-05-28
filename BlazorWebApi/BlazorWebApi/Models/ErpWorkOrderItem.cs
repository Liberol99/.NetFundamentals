using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWorkOrderItem
    {
        public ErpWorkOrderItem()
        {
            ErpActualCosts = new HashSet<ErpActualCost>();
            ErpBankCreditItems = new HashSet<ErpBankCreditItem>();
            ErpBankReceiptItems = new HashSet<ErpBankReceiptItem>();
            ErpBoxes = new HashSet<ErpBox>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpInitialCosts = new HashSet<ErpInitialCost>();
            ErpInventoryAllocations = new HashSet<ErpInventoryAllocation>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpInventorySerialCards = new HashSet<ErpInventorySerialCard>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpPackingLists = new HashSet<ErpPackingList>();
            ErpPlannings = new HashSet<ErpPlanning>();
            ErpQualityControlReceipts = new HashSet<ErpQualityControlReceipt>();
            ErpQualityControls = new HashSet<ErpQualityControl>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            ErpRequirements = new HashSet<ErpRequirement>();
            ErpResourceOutOfUses = new HashSet<ErpResourceOutOfUse>();
            ErpWorkOrderAttachments = new HashSet<ErpWorkOrderAttachment>();
            ErpWorkOrderExplanations = new HashSet<ErpWorkOrderExplanation>();
            ErpWorkOrderItemProcesses = new HashSet<ErpWorkOrderItemProcess>();
            ErpWorkOrderItemReceipts = new HashSet<ErpWorkOrderItemReceipt>();
            ErpWorkOrderItemRecipes = new HashSet<ErpWorkOrderItemRecipe>();
            ErpWorkOrderItemVariants = new HashSet<ErpWorkOrderItemVariant>();
            ErpWorkOrderProductionAttachments = new HashSet<ErpWorkOrderProductionAttachment>();
            ErpWorkOrderProductions = new HashSet<ErpWorkOrderProduction>();
            InverseParentItem = new HashSet<ErpWorkOrderItem>();
        }

        public long RecId { get; set; }
        public long? WorkOrderId { get; set; }
        public short? WorkOrderSubType { get; set; }
        public int? ItemOrderNo { get; set; }
        public int? SubNo { get; set; }
        public string? OperationCode { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ActualArrivalDate { get; set; }
        public DateTime? ActualDepartureDate { get; set; }
        public decimal? Distance { get; set; }
        public decimal? Duration { get; set; }
        public string? SpecialCode { get; set; }
        public string? Explanation { get; set; }
        public string? CustomerOrderNo { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? ProjectId { get; set; }
        public int? RouteId { get; set; }
        public long? ParentItemId { get; set; }
        public long? OrderItemId { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexUnitPrice { get; set; }
        public decimal? UnitPrice { get; set; }
        public long? InventoryId { get; set; }
        public int? InventoryUnitId { get; set; }
        public long? ServiceCardId { get; set; }
        public long? ServiceCardUnitId { get; set; }
        public int? ProcessId { get; set; }
        public long? RouteItemId { get; set; }
        public long? ResourceId { get; set; }
        public long? LabRecipeId { get; set; }
        public long? RecipeId { get; set; }
        public long? PatternRecipeId { get; set; }
        public int? TimeUnit { get; set; }
        public int? ProcessTime { get; set; }
        public decimal? Width { get; set; }
        public decimal? Weight { get; set; }
        public decimal? WeightMt { get; set; }
        public decimal? PlannedQuantity { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? SecondQuantity { get; set; }
        public decimal? AdditionalQuantity { get; set; }
        public decimal? ReducedQuantity { get; set; }
        public decimal? ShippedGrossQty { get; set; }
        public decimal? ShippedNetQty { get; set; }
        public decimal? PackageQuantity { get; set; }
        public decimal? WastageQuantity { get; set; }
        public string? ProxyNo { get; set; }
        public long? DegreeOfDifficulty { get; set; }
        public long? GlreceiptId { get; set; }
        public byte? Status { get; set; }
        public DateTime? FabricTermDate { get; set; }
        public byte? IsClosed { get; set; }
        public DateTime? ClosedAt { get; set; }
        public int? ClosedBy { get; set; }
        public string? ClosedExplanation { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public byte? IsCancelled { get; set; }
        public string? CancelledExplanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public long? InitialCostId { get; set; }
        public string? ApprovedExplanation { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public int? V1 { get; set; }
        public int? V2 { get; set; }
        public int? V3 { get; set; }
        public int? V4 { get; set; }
        public int? V5 { get; set; }
        public int? V6 { get; set; }
        public int? V7 { get; set; }
        public int? V8 { get; set; }
        public string? InventoryVariantIds { get; set; }
        public int? Variant1Id { get; set; }
        public int? Variant2Id { get; set; }
        public int? Variant3Id { get; set; }
        public int? Variant4Id { get; set; }
        public int? Variant5Id { get; set; }
        public string? Description { get; set; }
        public string? OrderVariants { get; set; }
        public long? InventoryVariantId { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGlreceipt? Glreceipt { get; set; }
        public virtual ErpInitialCost? InitialCost { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryUnitItemSize? InventoryUnit { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpLabRecipe? LabRecipe { get; set; }
        public virtual ErpOrderReceiptItem? OrderItem { get; set; }
        public virtual ErpWorkOrderItem? ParentItem { get; set; }
        public virtual ErpLabRecipe? PatternRecipe { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpRecipe? Recipe { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpRoute? Route { get; set; }
        public virtual ErpRouteItem? RouteItem { get; set; }
        public virtual ErpService? ServiceCard { get; set; }
        public virtual ErpServiceUnitItemSize? ServiceCardUnit { get; set; }
        public virtual ErpVariantItem? V1Navigation { get; set; }
        public virtual ErpVariantItem? V2Navigation { get; set; }
        public virtual ErpVariantItem? V3Navigation { get; set; }
        public virtual ErpVariantItem? V4Navigation { get; set; }
        public virtual ErpVariantItem? V5Navigation { get; set; }
        public virtual ErpVariantItem? V6Navigation { get; set; }
        public virtual ErpVariantItem? V7Navigation { get; set; }
        public virtual ErpVariantItem? V8Navigation { get; set; }
        public virtual ErpVariantItem? Variant1 { get; set; }
        public virtual ErpVariantItem? Variant2 { get; set; }
        public virtual ErpVariantItem? Variant3 { get; set; }
        public virtual ErpVariantItem? Variant4 { get; set; }
        public virtual ErpVariantItem? Variant5 { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ICollection<ErpActualCost> ErpActualCosts { get; set; }
        public virtual ICollection<ErpBankCreditItem> ErpBankCreditItems { get; set; }
        public virtual ICollection<ErpBankReceiptItem> ErpBankReceiptItems { get; set; }
        public virtual ICollection<ErpBox> ErpBoxes { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpInitialCost> ErpInitialCosts { get; set; }
        public virtual ICollection<ErpInventoryAllocation> ErpInventoryAllocations { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventorySerialCard> ErpInventorySerialCards { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpPackingList> ErpPackingLists { get; set; }
        public virtual ICollection<ErpPlanning> ErpPlannings { get; set; }
        public virtual ICollection<ErpQualityControlReceipt> ErpQualityControlReceipts { get; set; }
        public virtual ICollection<ErpQualityControl> ErpQualityControls { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirements { get; set; }
        public virtual ICollection<ErpResourceOutOfUse> ErpResourceOutOfUses { get; set; }
        public virtual ICollection<ErpWorkOrderAttachment> ErpWorkOrderAttachments { get; set; }
        public virtual ICollection<ErpWorkOrderExplanation> ErpWorkOrderExplanations { get; set; }
        public virtual ICollection<ErpWorkOrderItemProcess> ErpWorkOrderItemProcesses { get; set; }
        public virtual ICollection<ErpWorkOrderItemReceipt> ErpWorkOrderItemReceipts { get; set; }
        public virtual ICollection<ErpWorkOrderItemRecipe> ErpWorkOrderItemRecipes { get; set; }
        public virtual ICollection<ErpWorkOrderItemVariant> ErpWorkOrderItemVariants { get; set; }
        public virtual ICollection<ErpWorkOrderProductionAttachment> ErpWorkOrderProductionAttachments { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductions { get; set; }
        public virtual ICollection<ErpWorkOrderItem> InverseParentItem { get; set; }
    }
}
