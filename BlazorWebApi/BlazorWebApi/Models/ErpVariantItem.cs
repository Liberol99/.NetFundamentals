using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpVariantItem
    {
        public ErpVariantItem()
        {
            ErpInventoryCampaignItems = new HashSet<ErpInventoryCampaignItem>();
            ErpInventoryVariantVariant1s = new HashSet<ErpInventoryVariant>();
            ErpInventoryVariantVariant2s = new HashSet<ErpInventoryVariant>();
            ErpInventoryVariantVariant3s = new HashSet<ErpInventoryVariant>();
            ErpInventoryVariantVariant4s = new HashSet<ErpInventoryVariant>();
            ErpInventoryVariantVariant5s = new HashSet<ErpInventoryVariant>();
            ErpInventoryWorkStudyVariant1s = new HashSet<ErpInventoryWorkStudy>();
            ErpInventoryWorkStudyVariant2s = new HashSet<ErpInventoryWorkStudy>();
            ErpRequirementVariant1Navigations = new HashSet<ErpRequirement>();
            ErpRequirementVariant2Navigations = new HashSet<ErpRequirement>();
            ErpRequirementVariant3s = new HashSet<ErpRequirement>();
            ErpRequirementVariant4s = new HashSet<ErpRequirement>();
            ErpRequirementVariant5s = new HashSet<ErpRequirement>();
            ErpSizeSetItemVariants = new HashSet<ErpSizeSetItemVariant>();
            ErpWorkOrderItemV1Navigations = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderItemV2Navigations = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderItemV3Navigations = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderItemV4Navigations = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderItemV5Navigations = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderItemV6Navigations = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderItemV7Navigations = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderItemV8Navigations = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderItemVariant1s = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderItemVariant2s = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderItemVariant3s = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderItemVariant4s = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderItemVariant5s = new HashSet<ErpWorkOrderItem>();
            ErpWorkOrderProductionVariant1Navigations = new HashSet<ErpWorkOrderProduction>();
            ErpWorkOrderProductionVariant2Navigations = new HashSet<ErpWorkOrderProduction>();
            InverseRelated = new HashSet<ErpVariantItem>();
        }

        public int RecId { get; set; }
        public int? CardId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public string? Explanation { get; set; }
        public string? ItemData { get; set; }
        public int? SortOrder { get; set; }
        public string? Barcode { get; set; }
        public int? RelatedId { get; set; }
        public byte? LiwashingSymbol { get; set; }
        public byte? LibleachingSymbol { get; set; }
        public byte? LitumbleDryingSymbol { get; set; }
        public byte? LinaturalDryingSymbol { get; set; }
        public byte? LiironingSymbol { get; set; }
        public byte? LichemicalCleaningSymbol { get; set; }
        public byte? LiwetCleaningSymbol { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpVariantCard? Card { get; set; }
        public virtual ErpVariantItem? Related { get; set; }
        public virtual ICollection<ErpInventoryCampaignItem> ErpInventoryCampaignItems { get; set; }
        public virtual ICollection<ErpInventoryVariant> ErpInventoryVariantVariant1s { get; set; }
        public virtual ICollection<ErpInventoryVariant> ErpInventoryVariantVariant2s { get; set; }
        public virtual ICollection<ErpInventoryVariant> ErpInventoryVariantVariant3s { get; set; }
        public virtual ICollection<ErpInventoryVariant> ErpInventoryVariantVariant4s { get; set; }
        public virtual ICollection<ErpInventoryVariant> ErpInventoryVariantVariant5s { get; set; }
        public virtual ICollection<ErpInventoryWorkStudy> ErpInventoryWorkStudyVariant1s { get; set; }
        public virtual ICollection<ErpInventoryWorkStudy> ErpInventoryWorkStudyVariant2s { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirementVariant1Navigations { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirementVariant2Navigations { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirementVariant3s { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirementVariant4s { get; set; }
        public virtual ICollection<ErpRequirement> ErpRequirementVariant5s { get; set; }
        public virtual ICollection<ErpSizeSetItemVariant> ErpSizeSetItemVariants { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItemV1Navigations { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItemV2Navigations { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItemV3Navigations { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItemV4Navigations { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItemV5Navigations { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItemV6Navigations { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItemV7Navigations { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItemV8Navigations { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItemVariant1s { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItemVariant2s { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItemVariant3s { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItemVariant4s { get; set; }
        public virtual ICollection<ErpWorkOrderItem> ErpWorkOrderItemVariant5s { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductionVariant1Navigations { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductionVariant2Navigations { get; set; }
        public virtual ICollection<ErpVariantItem> InverseRelated { get; set; }
    }
}
