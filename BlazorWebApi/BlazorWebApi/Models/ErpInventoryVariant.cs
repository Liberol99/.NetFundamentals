using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryVariant
    {
        public ErpInventoryVariant()
        {
            ErpBoxItemVariants = new HashSet<ErpBoxItemVariant>();
            ErpContractItemVariants = new HashSet<ErpContractItemVariant>();
            ErpDemandReceiptItemVariants = new HashSet<ErpDemandReceiptItemVariant>();
            ErpExpoItemVariants = new HashSet<ErpExpoItemVariant>();
            ErpInitialCostItems = new HashSet<ErpInitialCostItem>();
            ErpInventoryAllocations = new HashSet<ErpInventoryAllocation>();
            ErpInventoryAssortmentItems = new HashSet<ErpInventoryAssortmentItem>();
            ErpInventoryAttachments = new HashSet<ErpInventoryAttachment>();
            ErpInventoryBarcodes = new HashSet<ErpInventoryBarcode>();
            ErpInventoryPriceLists = new HashSet<ErpInventoryPriceList>();
            ErpInventoryReceiptItemVariants = new HashSet<ErpInventoryReceiptItemVariant>();
            ErpInventoryReceiptShipments = new HashSet<ErpInventoryReceiptShipment>();
            ErpInventorySerialCards = new HashSet<ErpInventorySerialCard>();
            ErpInventorySuppliers = new HashSet<ErpInventorySupplier>();
            ErpInventoryTotals = new HashSet<ErpInventoryTotal>();
            ErpInventoryWarehouses = new HashSet<ErpInventoryWarehouse>();
            ErpMaterialRequirementItems = new HashSet<ErpMaterialRequirementItem>();
            ErpOrderReceiptItemVariants = new HashSet<ErpOrderReceiptItemVariant>();
            ErpPackingListItemVariants = new HashSet<ErpPackingListItemVariant>();
            ErpProductConfiguratorItems = new HashSet<ErpProductConfiguratorItem>();
            ErpQuotationReceiptItemVariants = new HashSet<ErpQuotationReceiptItemVariant>();
            ErpRecipeItems = new HashSet<ErpRecipeItem>();
            ErpRecipes = new HashSet<ErpRecipe>();
            ErpRequirements = new HashSet<ErpRequirement>();
            ErpSizeSetItemVariants = new HashSet<ErpSizeSetItemVariant>();
            ErpWarehouseLocationTotals = new HashSet<ErpWarehouseLocationTotal>();
            ErpWorkOrderItemRecipes = new HashSet<ErpWorkOrderItemRecipe>();
            ErpWorkOrderItemVariants = new HashSet<ErpWorkOrderItemVariant>();
            ErpWorkOrderItems = new HashSet<ErpWorkOrderItem>();
        }

        public long RecId { get; set; }
        public long? InventoryId { get; set; }
        public int? Variant1TypeId { get; set; }
        public int? Variant1Id { get; set; }
        public short? Variant1Order { get; set; }
        public int? Variant2TypeId { get; set; }
        public int? Variant2Id { get; set; }
        public short? Variant2Order { get; set; }
        public int? Variant3TypeId { get; set; }
        public int? Variant3Id { get; set; }
        public short? Variant3Order { get; set; }
        public int? Variant4TypeId { get; set; }
        public int? Variant4Id { get; set; }
        public short? Variant4Order { get; set; }
        public int? Variant5TypeId { get; set; }
        public int? Variant5Id { get; set; }
        public short? Variant5Order { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpVariantItem? Variant1 { get; set; }
        public virtual ErpVariantType? Variant1Type { get; set; }
        public virtual ErpVariantItem? Variant2 { get; set; }
        public virtual ErpVariantType? Variant2Type { get; set; }
        public virtual ErpVariantItem? Variant3 { get; set; }
        public virtual ErpVariantType? Variant3Type { get; set; }
        public virtual ErpVariantItem? Variant4 { get; set; }
        public virtual ErpVariantType? Variant4Type { get; set; }
        public virtual ErpVariantItem? Variant5 { get; set; }
        public virtual ErpVariantType? Variant5Type { get; set; }
        public virtual ICollection<ErpBoxItemVariant> ErpBoxItemVariants { get; set; }
        public virtual ICollection<ErpContractItemVariant> ErpContractItemVariants { get; set; }
        public virtual ICollection<ErpDemandReceiptItemVariant> ErpDemandReceiptItemVariants { get; set; }
        public virtual ICollection<ErpExpoItemVariant> ErpExpoItemVariants { get; set; }
        public virtual ICollection<ErpInitialCostItem> ErpInitialCostItems { get; set; }
        public virtual ICollection<ErpInventoryAllocation> ErpInventoryAllocations { get; set; }
        public virtual ICollection<ErpInventoryAssortmentItem> ErpInventoryAssortmentItems { get; set; }
        public virtual ICollection<ErpInventoryAttachment> ErpInventoryAttachments { get; set; }
        public virtual ICollection<ErpInventoryBarcode> ErpInventoryBarcodes { get; set; }
        public virtual ICollection<ErpInventoryPriceList> ErpInventoryPriceLists { get; set; }
        public virtual ICollection<ErpInventoryReceiptItemVariant> ErpInventoryReceiptItemVariants { get; set; }
        public virtual ICollection<ErpInventoryReceiptShipment> ErpInventoryReceiptShipments { get; set; }
        public virtual ICollection<ErpInventorySerialCard> ErpInventorySerialCards { get; set; }
        public virtual ICollection<ErpInventorySupplier> ErpInventorySuppliers { get; set; }
        public virtual ICollection<ErpInventoryTotal> ErpInventoryTotals { get; set; }
        public virtual ICollection<ErpInventoryWarehouse> ErpInventoryWarehouses { get; set; }
        public virtual ICollection<ErpMaterialRequirementItem> ErpMaterialRequirementItems { get; set; }
        public virtual ICollection<ErpOrderReceiptItemVariant> ErpOrderReceiptItemVariants { get; set; }
        public virtual ICollection<ErpPackingListItemVariant> ErpPackingListItemVariants { get; set; }
        public virtual ICollection<ErpProductConfiguratorItem> ErpProductConfiguratorItems { get; set; }
        public virtual ICollection<ErpQuotationReceiptItemVariant> ErpQuotationReceiptItemVariants { get; set; }
        public virtual ICollection<ErpRecipeItem> ErpRecipeItems { get; set; }
        public virtual ICollection<ErpRecipe> ErpRecipes { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirements { get; set; }
        public virtual ICollection<ErpSizeSetItemVariant> ErpSizeSetItemVariants { get; set; }
        public virtual ICollection<ErpWarehouseLocationTotal> ErpWarehouseLocationTotals { get; set; }
        public virtual ICollection<ErpWorkOrderItemRecipe> ErpWorkOrderItemRecipes { get; set; }
        public virtual ICollection<ErpWorkOrderItemVariant> ErpWorkOrderItemVariants { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItems { get; set; }
    }
}
