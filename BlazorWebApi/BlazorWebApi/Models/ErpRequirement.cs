using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpRequirement
    {
        public ErpRequirement()
        {
            ErpInventoryAllocations = new HashSet<ErpInventoryAllocation>();
            InverseParent = new HashSet<ErpRequirement>();
        }

        public long RecId { get; set; }
        public short? RequirementType { get; set; }
        public long? ParentId { get; set; }
        public long? WorkOrderId { get; set; }
        public long? WorkOrderItemId { get; set; }
        public long? OrderReceiptId { get; set; }
        public long? OrderReceiptItemId { get; set; }
        public long? RecipeId { get; set; }
        public long? StyleId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public string? Variant1 { get; set; }
        public string? Variant2 { get; set; }
        public short? OperationType { get; set; }
        public decimal? Quantity { get; set; }
        public int? UnitId { get; set; }
        public int? ItemOrderNo { get; set; }
        public byte? CreatedBySystem { get; set; }
        public int? ProcessId { get; set; }
        public string? Explanation { get; set; }
        public decimal? Wastage { get; set; }
        public decimal? CutWastage { get; set; }
        public decimal? DyeWastage { get; set; }
        public decimal? PrintWastage { get; set; }
        public decimal? DyeQuantity { get; set; }
        public decimal? PrintQuantity { get; set; }
        public int? Variant1Id { get; set; }
        public int? Variant2Id { get; set; }
        public int? Variant3Id { get; set; }
        public int? Variant4Id { get; set; }
        public int? Variant5Id { get; set; }
        public decimal? SubContractorIn0 { get; set; }
        public decimal? SubContractorIn1 { get; set; }
        public decimal? SubContractorIn2 { get; set; }
        public decimal? SubContractorIn3 { get; set; }
        public decimal? SubContractorIn4 { get; set; }
        public decimal? SubContractorIn5 { get; set; }
        public decimal? SubContractorIn6 { get; set; }
        public decimal? SubContractorIn7 { get; set; }
        public decimal? SubContractorIn8 { get; set; }
        public decimal? SubContractorIn9 { get; set; }
        public decimal? SubContractorIn10 { get; set; }
        public decimal? SubContractorIn11 { get; set; }
        public decimal? SubContractorIn12 { get; set; }
        public decimal? SubContractorIn13 { get; set; }
        public decimal? SubContractorIn14 { get; set; }
        public decimal? SubContractorIn15 { get; set; }
        public decimal? SubContractorOut0 { get; set; }
        public decimal? SubContractorOut1 { get; set; }
        public decimal? SubContractorOut2 { get; set; }
        public decimal? SubContractorOut3 { get; set; }
        public decimal? SubContractorOut4 { get; set; }
        public decimal? SubContractorOut5 { get; set; }
        public decimal? SubContractorOut6 { get; set; }
        public decimal? SubContractorOut7 { get; set; }
        public decimal? SubContractorOut8 { get; set; }
        public decimal? SubContractorOut9 { get; set; }
        public decimal? SubContractorOut10 { get; set; }
        public decimal? SubContractorOut11 { get; set; }
        public decimal? SubContractorOut12 { get; set; }
        public decimal? SubContractorOut13 { get; set; }
        public decimal? SubContractorOut14 { get; set; }
        public decimal? SubContractorOut15 { get; set; }
        public short? GroupNo { get; set; }
        public byte? IsPurchase { get; set; }
        public byte? IsDye { get; set; }
        public byte? IsPrint { get; set; }
        public byte? IsOther1 { get; set; }
        public byte? IsOther2 { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? TermDate { get; set; }
        public short? RequirementSubType { get; set; }
        public int? OutWarehouseId { get; set; }
        public int? WastageWarehouseId { get; set; }
        public byte? ControlType { get; set; }
        public byte? InOut { get; set; }
        public int? ForexId { get; set; }
        public decimal? Price { get; set; }

        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpOrderReceipt? OrderReceipt { get; set; }
        public virtual ErpOrderReceiptItem? OrderReceiptItem { get; set; }
        public virtual ErpWarehouse? OutWarehouse { get; set; }
        public virtual ErpRequirement? Parent { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpRecipe? Recipe { get; set; }
        public virtual ErpInventory? Style { get; set; }
        public virtual ErpInventoryUnitItemSize? Unit { get; set; }
        public virtual ErpVariantItem? Variant1Navigation { get; set; }
        public virtual ErpVariantItem? Variant2Navigation { get; set; }
        public virtual ErpVariantItem? Variant3 { get; set; }
        public virtual ErpVariantItem? Variant4 { get; set; }
        public virtual ErpVariantItem? Variant5 { get; set; }
        public virtual ErpWarehouse? WastageWarehouse { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderItem { get; set; }
        public virtual ICollection<ErpInventoryAllocation> ErpInventoryAllocations { get; set; }
        public virtual ICollection<ErpRequirement> InverseParent { get; set; }
    }
}
