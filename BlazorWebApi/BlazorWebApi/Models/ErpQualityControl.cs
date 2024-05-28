using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpQualityControl
    {
        public ErpQualityControl()
        {
            ErpInventorySerialCards = new HashSet<ErpInventorySerialCard>();
            ErpQualityControlAttachments = new HashSet<ErpQualityControlAttachment>();
            ErpQualityControlProcessDetails = new HashSet<ErpQualityControlProcessDetail>();
            ErpQualityControlTestDetails = new HashSet<ErpQualityControlTestDetail>();
            ErpRoutes = new HashSet<ErpRoute>();
            InverseTemplate = new HashSet<ErpQualityControl>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? QualityControlNo { get; set; }
        public long? WorkOrderId { get; set; }
        public long? WorkOrderItemId { get; set; }
        public long? InventoryReceiptItemId { get; set; }
        public DateTime? QualityControlDate { get; set; }
        public long? QualityControllerId { get; set; }
        public long? InventoryId { get; set; }
        public long? LabRecipeId { get; set; }
        public int? RouteId { get; set; }
        public long? TemplateId { get; set; }
        public long? CurrentAccountId { get; set; }
        public string? Explanation { get; set; }
        public decimal? RawWidth { get; set; }
        public decimal? RawGram { get; set; }
        public decimal? RequestWidth { get; set; }
        public decimal? RequestGram { get; set; }
        public decimal? ProductWidth { get; set; }
        public decimal? ProductGram { get; set; }
        public decimal? RequestShirinkingWidth { get; set; }
        public decimal? RequestShirinkingLength { get; set; }
        public decimal? RequestShirinkingRotation { get; set; }
        public decimal? ProductShirinkingWidth { get; set; }
        public decimal? ProductShirinkingLength { get; set; }
        public decimal? ProductShirinkingRotation { get; set; }
        public decimal? FastnessWashing { get; set; }
        public decimal? FastnessDryRubbing { get; set; }
        public decimal? FastnessWetRubbing { get; set; }
        public decimal? FastnessLight { get; set; }
        public decimal? FastnessWater { get; set; }
        public decimal? FastnessWaterWidthChlorine { get; set; }
        public decimal? FastnessMarineWater { get; set; }
        public decimal? FastnessMoisture { get; set; }
        public decimal? FastnessDryCleaning { get; set; }
        public decimal? FinishingWaterproofTest { get; set; }
        public decimal? FinishingOilYmpulseTest { get; set; }
        public decimal? FinishingNonWrinkleTest { get; set; }
        public decimal? FinishingFlammabilityTest { get; set; }
        public decimal? FinishingPillingTest { get; set; }
        public decimal? FinishingStrenghtTest { get; set; }
        public decimal? FinishingWoolFeltingTest { get; set; }
        public decimal? FinishingWaleSpirality { get; set; }
        public decimal? FinishingPhvalue { get; set; }
        public DateTime? RamQualityControlDate { get; set; }
        public long? RamQualityControllerId { get; set; }
        public decimal? RamWidth { get; set; }
        public decimal? RamGram { get; set; }
        public decimal? RamShrinkingWidth { get; set; }
        public decimal? RamShrinkingLength { get; set; }
        public decimal? RamShrinkingRotation { get; set; }
        public DateTime? SanforizeQualityControlDate { get; set; }
        public long? SanforizeQualityControllerId { get; set; }
        public decimal? SanforizeWidth { get; set; }
        public decimal? SanforizeGsanforize { get; set; }
        public decimal? SanforizeShrinkingWidth { get; set; }
        public decimal? SanforizeShrinkingLength { get; set; }
        public decimal? SanforizeShrinkingRotation { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? LiwashingSymbol { get; set; }
        public byte? LibleachingSymbol { get; set; }
        public byte? LitumbleDryingSymbol { get; set; }
        public byte? LinaturalDryingSymbol { get; set; }
        public byte? LiironingSymbol { get; set; }
        public byte? LichemicalCleaningSymbol { get; set; }
        public byte? LiwetCleaningSymbol { get; set; }
        public byte? LielestaneDirectionSymbol { get; set; }
        public short? QualityControlType { get; set; }
        public short? ShipmentStatus { get; set; }
        public byte? IsSample { get; set; }
        public byte? InUse { get; set; }
        public byte? IsChecked { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public decimal? ControlQuantity { get; set; }
        public decimal? ApprovedQuantity { get; set; }
        public decimal? RejectedQuantity { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryReceiptItem? InventoryReceiptItem { get; set; }
        public virtual ErpLabRecipe? LabRecipe { get; set; }
        public virtual ErpEmployee? QualityController { get; set; }
        public virtual ErpEmployee? RamQualityController { get; set; }
        public virtual ErpRoute? Route { get; set; }
        public virtual ErpEmployee? SanforizeQualityController { get; set; }
        public virtual ErpQualityControl? Template { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderItem { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpInventorySerialCard> ErpInventorySerialCards { get; set; }
        public virtual ICollection<ErpQualityControlAttachment> ErpQualityControlAttachments { get; set; }
        public virtual ICollection<ErpQualityControlProcessDetail> ErpQualityControlProcessDetails { get; set; }
        public virtual ICollection<ErpQualityControlTestDetail> ErpQualityControlTestDetails { get; set; }
        public virtual ICollection<ErpRoute> ErpRoutes { get; set; }
        public virtual ICollection<ErpQualityControl> InverseTemplate { get; set; }
    }
}
