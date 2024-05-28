using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWorkOrder
    {
        public ErpWorkOrder()
        {
            ErpActualCosts = new HashSet<ErpActualCost>();
            ErpBankCreditItems = new HashSet<ErpBankCreditItem>();
            ErpBoxes = new HashSet<ErpBox>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpDemandReceipts = new HashSet<ErpDemandReceipt>();
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpInitialCosts = new HashSet<ErpInitialCost>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryReceipts = new HashSet<ErpInventoryReceipt>();
            ErpInventorySerialCards = new HashSet<ErpInventorySerialCard>();
            ErpInvoices = new HashSet<ErpInvoice>();
            ErpOrderReceiptItemReferenceWorkOrders = new HashSet<ErpOrderReceiptItem>();
            ErpOrderReceiptItemWorkOrders = new HashSet<ErpOrderReceiptItem>();
            ErpOrderReceipts = new HashSet<ErpOrderReceipt>();
            ErpPackingListItems = new HashSet<ErpPackingListItem>();
            ErpPlannings = new HashSet<ErpPlanning>();
            ErpPollUserAnswers = new HashSet<ErpPollUserAnswer>();
            ErpPos = new HashSet<ErpPo>();
            ErpQualityControlReceiptItems = new HashSet<ErpQualityControlReceiptItem>();
            ErpQualityControlReceipts = new HashSet<ErpQualityControlReceipt>();
            ErpQualityControls = new HashSet<ErpQualityControl>();
            ErpQuotationReceipts = new HashSet<ErpQuotationReceipt>();
            ErpRecipeItems = new HashSet<ErpRecipeItem>();
            ErpRequirements = new HashSet<ErpRequirement>();
            ErpSizeSetItems = new HashSet<ErpSizeSetItem>();
            ErpSizeSets = new HashSet<ErpSizeSet>();
            ErpWorkOrderAttachments = new HashSet<ErpWorkOrderAttachment>();
            ErpWorkOrderCostDistributions = new HashSet<ErpWorkOrderCostDistribution>();
            ErpWorkOrderExplanations = new HashSet<ErpWorkOrderExplanation>();
            ErpWorkOrderItemProcesses = new HashSet<ErpWorkOrderItemProcess>();
            ErpWorkOrderItemRecipes = new HashSet<ErpWorkOrderItemRecipe>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderProductionAttachments = new HashSet<ErpWorkOrderProductionAttachment>();
            ErpWorkOrderProductions = new HashSet<ErpWorkOrderProduction>();
            ErpWorkOrderProgresses = new HashSet<ErpWorkOrderProgress>();
            InverseParent = new HashSet<ErpWorkOrder>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public short? WorkOrderType { get; set; }
        public short? WorkOrderSubType { get; set; }
        public string? WorkOrderNo { get; set; }
        public DateTime? WorkOrderDate { get; set; }
        public DateTime? WorkOrderTime { get; set; }
        public DateTime? PlanDate { get; set; }
        public string? DocumentNo { get; set; }
        public byte? ControlCode { get; set; }
        public int? CostCenterId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public int? ProjectId { get; set; }
        public long? EmployeeId { get; set; }
        public int? VehicleId { get; set; }
        public long? ParentId { get; set; }
        public int? RouteId { get; set; }
        public long? RouteItemId { get; set; }
        public long? RecipeId { get; set; }
        public long? PatternRecipeId { get; set; }
        public int? ProcessId { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexUnitPrice { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Expense { get; set; }
        public decimal? TotalDistance { get; set; }
        public decimal? TotalDuration { get; set; }
        public long? CurrentAccountId { get; set; }
        public string? CustomerOrderNo { get; set; }
        public long? CustomerId { get; set; }
        public long? OrderItemId { get; set; }
        public long? InventoryId { get; set; }
        public int? InventoryUnitId { get; set; }
        public long? ServiceCardId { get; set; }
        public long? ServiceCardUnitId { get; set; }
        public long? CustomerTransactionId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? AdditionalQuantity { get; set; }
        public decimal? ReducedQuantity { get; set; }
        public decimal? PackageQuantity { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? Explanation { get; set; }
        public decimal? GpsXcoordinate { get; set; }
        public decimal? GpsYcoordinate { get; set; }
        public long? GlreceiptId { get; set; }
        public byte? Status { get; set; }
        public byte? RepairType { get; set; }
        public short? RepairCount { get; set; }
        public DateTime? RepairAt { get; set; }
        public int? RepairBy { get; set; }
        public byte? IsSample { get; set; }
        public long? LabRecipeId { get; set; }
        public int? ManufacturingTypeId { get; set; }
        public long? ResourceId { get; set; }
        public decimal? RecipeQuantity { get; set; }
        public decimal? PatternRecipeQuantity { get; set; }
        public decimal? Capacity { get; set; }
        public byte? CalculateType { get; set; }
        public string? RecipeCombineWorkOrderNo { get; set; }
        public string? ProxyNo { get; set; }
        public string? Stext { get; set; }
        public string? Ctext { get; set; }
        public decimal? LeftoverGoodsPrice { get; set; }
        public string? Agent { get; set; }
        public decimal? CommissionRate { get; set; }
        public decimal? CommissionAmount { get; set; }
        public decimal? OverheadCostRate { get; set; }
        public decimal? OverheadCostAmount { get; set; }
        public decimal? OverheadCostForexAmount { get; set; }
        public byte? IsRequirementLocked { get; set; }
        public byte? IsEmergency { get; set; }
        public DateTime? EmergencyTermDate { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public byte? IsClosed { get; set; }
        public DateTime? ClosedAt { get; set; }
        public int? ClosedBy { get; set; }
        public string? ClosedExplanation { get; set; }
        public byte? IsCancelled { get; set; }
        public string? CancelledExplanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public string? DocumentSerialNo { get; set; }
        public byte? IgnoreRecipe { get; set; }
        public string? MaintenanceDescription { get; set; }
        public string? MalfunctionDescription { get; set; }
        public string? CheckDescription { get; set; }
        public short? PeriodRangeCount { get; set; }
        public byte? PeriodRange { get; set; }
        public short? PeriodCount { get; set; }
        public long? SerialCardId { get; set; }
        public int? DistrictId { get; set; }
        public int? CityId { get; set; }
        public int? CountryId { get; set; }
        public string? DriverName { get; set; }
        public string? Phone { get; set; }
        public decimal? MachineWorkingHour { get; set; }
        public string? CustomerComplaint { get; set; }
        public string? OtherComplaint { get; set; }
        public string? ServiceWorkOrderExplanation { get; set; }
        public string? RejectExplanation { get; set; }
        public string? ServiceExplanation { get; set; }
        public long? DespatchContactId { get; set; }
        public int? StateId { get; set; }
        public long? OwnerId { get; set; }
        public string? V1 { get; set; }
        public string? V2 { get; set; }
        public string? V3 { get; set; }
        public string? V4 { get; set; }
        public string? V5 { get; set; }
        public string? V6 { get; set; }
        public string? V7 { get; set; }
        public string? V8 { get; set; }
        public decimal? QuantityPerLot { get; set; }
        public decimal? TotalAmount { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public DateTime? PackingDate { get; set; }
        public decimal? PackingQuantity { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Country { get; set; }
        public string? SpecialCode1 { get; set; }
        public string? SpecialCode2 { get; set; }
        public string? PackingType { get; set; }
        public string? PackingExplanation { get; set; }
        public decimal? CuttingExtra { get; set; }
        public decimal? CuttingUnitPrice { get; set; }
        public string? Factory { get; set; }
        public string? Explanation1 { get; set; }
        public string? Explanation2 { get; set; }
        public string? Explanation3 { get; set; }
        public string? Explanation4 { get; set; }
        public string? Explanation5 { get; set; }
        public string? Explanation6 { get; set; }
        public short? VersionType { get; set; }
        public short? RepeatCount { get; set; }
        public short? WorkOrderCreationType { get; set; }
        public short? WorkOrderSampleType { get; set; }
        public long? ReferenceWorkOrderId { get; set; }
        public byte? VariantEntryCumulative { get; set; }
        public byte? VariantEntryCumulativeColumn { get; set; }
        public byte? AdditionalQuantityType { get; set; }
        public byte? ReducedQuantityType { get; set; }
        public string? CuttingTotalColumns { get; set; }
        public string? LimitTotalColumns { get; set; }
        public string? Explanation7 { get; set; }
        public string? Explanation8 { get; set; }
        public string? Explanation9 { get; set; }
        public string? Explanation10 { get; set; }
        public byte? AsserviceControl1 { get; set; }
        public byte? AsserviceControl2 { get; set; }
        public byte? AsserviceControl3 { get; set; }
        public string? InterimChassisSerialNo { get; set; }
        public string? ChassisSerialNo { get; set; }
        public long? ParentId2 { get; set; }
        public long? Level { get; set; }
        public string? AsserviceIssueCode { get; set; }
        public long? AsserviceInvoiceId { get; set; }

        public virtual ErpInvoice? AsserviceInvoice { get; set; }
        public virtual MetaCity? City { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual MetaCountry? CountryNavigation { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpCurrentAccount? Customer { get; set; }
        public virtual ErpCustomerTransaction? CustomerTransaction { get; set; }
        public virtual ErpDespatchContact? DespatchContact { get; set; }
        public virtual MetaDistrict? District { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGlreceipt? Glreceipt { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryUnitItemSize? InventoryUnit { get; set; }
        public virtual ErpLabRecipe? LabRecipe { get; set; }
        public virtual ErpManufacturingType? ManufacturingType { get; set; }
        public virtual ErpOrderReceiptItem? OrderItem { get; set; }
        public virtual ErpMachineOwner? Owner { get; set; }
        public virtual ErpWorkOrder? Parent { get; set; }
        public virtual ErpLabRecipe? PatternRecipe { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpProject? Project { get; set; }
        public virtual ErpRecipe? Recipe { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpRoute? Route { get; set; }
        public virtual ErpRouteItem? RouteItem { get; set; }
        public virtual ErpInventorySerialCard? SerialCard { get; set; }
        public virtual ErpService? ServiceCard { get; set; }
        public virtual ErpServiceUnitItemSize? ServiceCardUnit { get; set; }
        public virtual MetaState? State { get; set; }
        public virtual ErpVehicle? Vehicle { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpActualCost> ErpActualCosts { get; set; }
        public virtual ICollection<ErpBankCreditItem> ErpBankCreditItems { get; set; }
        public virtual ICollection<ErpBox> ErpBoxes { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpDemandReceipt> ErpDemandReceipts { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpInitialCost> ErpInitialCosts { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryReceipt> ErpInventoryReceipts { get; set; }
        public virtual ICollection<ErpInventorySerialCard> ErpInventorySerialCards { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItemReferenceWorkOrders { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItemWorkOrders { get; set; }
        public virtual ICollection<ErpOrderReceipt> ErpOrderReceipts { get; set; }
        public virtual ICollection<ErpPackingListItem> ErpPackingListItems { get; set; }
        public virtual ICollection<ErpPlanning> ErpPlannings { get; set; }
        public virtual ICollection<ErpPollUserAnswer> ErpPollUserAnswers { get; set; }
        public virtual ICollection<ErpPo> ErpPos { get; set; }
        public virtual ICollection<ErpQualityControlReceiptItem> ErpQualityControlReceiptItems { get; set; }
        public virtual ICollection<ErpQualityControlReceipt> ErpQualityControlReceipts { get; set; }
        public virtual ICollection<ErpQualityControl> ErpQualityControls { get; set; }
        public virtual ICollection<ErpQuotationReceipt> ErpQuotationReceipts { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItems { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirements { get; set; }
        public virtual ICollection<ErpSizeSetItem> ErpSizeSetItems { get; set; }
        public virtual ICollection<ErpSizeSet> ErpSizeSets { get; set; }
        public virtual ICollection<ErpWorkOrderAttachment> ErpWorkOrderAttachments { get; set; }
        public virtual ICollection<ErpWorkOrderCostDistribution> ErpWorkOrderCostDistributions { get; set; }
        public virtual ICollection<ErpWorkOrderExplanation> ErpWorkOrderExplanations { get; set; }
        public virtual ICollection<ErpWorkOrderItemProcess> ErpWorkOrderItemProcesses { get; set; }
        public virtual ICollection<ErpWorkOrderItemRecipe> ErpWorkOrderItemRecipes { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
        public virtual ICollection<ErpWorkOrderProductionAttachment> ErpWorkOrderProductionAttachments { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductions { get; set; }
        public virtual ICollection<ErpWorkOrderProgress> ErpWorkOrderProgresses { get; set; }
        public virtual ICollection<ErpWorkOrder> InverseParent { get; set; }
    }
}
