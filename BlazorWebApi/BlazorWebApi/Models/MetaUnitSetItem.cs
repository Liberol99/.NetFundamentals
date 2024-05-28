using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaUnitSetItem
    {
        public MetaUnitSetItem()
        {
            ErpActualCosts = new HashSet<ErpActualCost>();
            ErpBudgetItems = new HashSet<ErpBudgetItem>();
            ErpContractItems = new HashSet<ErpContractItem>();
            ErpDemandReceiptItems = new HashSet<ErpDemandReceiptItem>();
            ErpExpoItemDetails = new HashSet<ErpExpoItemDetail>();
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpGlreceiptItemInvs = new HashSet<ErpGlreceiptItemInv>();
            ErpInitialCostCards = new HashSet<ErpInitialCostCard>();
            ErpInitialCostItems = new HashSet<ErpInitialCostItem>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpInventoryUnitItemSizes = new HashSet<ErpInventoryUnitItemSize>();
            ErpMaterialRequirementItems = new HashSet<ErpMaterialRequirementItem>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
            ErpProductConfiguratorItems = new HashSet<ErpProductConfiguratorItem>();
            ErpQualityControlProcessDetails = new HashSet<ErpQualityControlProcessDetail>();
            ErpQuotationReceiptItems = new HashSet<ErpQuotationReceiptItem>();
            ErpServiceUnitItemSizes = new HashSet<ErpServiceUnitItemSize>();
            ErpWorkOrderProductions = new HashSet<ErpWorkOrderProduction>();
        }

        public int RecId { get; set; }
        public int? UnitSetId { get; set; }
        public string? UnitCode { get; set; }
        public string? UnitName { get; set; }
        public decimal? UnitFactor { get; set; }
        public decimal? UnitDivisor { get; set; }
        public decimal? UnitWidth { get; set; }
        public int? UnitWidthUnitId { get; set; }
        public decimal? UnitLength { get; set; }
        public int? UnitLengthUnitId { get; set; }
        public decimal? UnitHeight { get; set; }
        public int? UnitHeightUnitId { get; set; }
        public decimal? UnitArea { get; set; }
        public int? UnitAreaUnitId { get; set; }
        public decimal? UnitVolume { get; set; }
        public int? UnitVolumeUnitId { get; set; }
        public decimal? UnitWeight { get; set; }
        public int? UnitWeightUnitId { get; set; }
        public byte? IsMainUnit { get; set; }
        public string? UniversalCode { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaUnitSet? UnitSet { get; set; }
        public virtual ICollection<ErpActualCost> ErpActualCosts { get; set; }
        public virtual ICollection<ErpBudgetItem> ErpBudgetItems { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItems { get; set; }
        public virtual ICollection<ErpDemandReceiptItem> ErpDemandReceiptItems { get; set; }
        public virtual ICollection<ErpExpoItemDetail> ErpExpoItemDetails { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpGlreceiptItemInv> ErpGlreceiptItemInvs { get; set; }
        public virtual ICollection<ErpInitialCostCard> ErpInitialCostCards { get; set; }
        public virtual ICollection<ErpInitialCostItem> ErpInitialCostItems { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventoryUnitItemSize> ErpInventoryUnitItemSizes { get; set; }
        public virtual ICollection<ErpMaterialRequirementItem> ErpMaterialRequirementItems { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
        public virtual ICollection<ErpProductConfiguratorItem> ErpProductConfiguratorItems { get; set; }
        public virtual ICollection<ErpQualityControlProcessDetail> ErpQualityControlProcessDetails { get; set; }
        public virtual ICollection<ErpQuotationReceiptItem> ErpQuotationReceiptItems { get; set; }
        public virtual ICollection<ErpServiceUnitItemSize> ErpServiceUnitItemSizes { get; set; }
        public virtual ICollection<ErpWorkOrderProduction> ErpWorkOrderProductions { get; set; }
    }
}
