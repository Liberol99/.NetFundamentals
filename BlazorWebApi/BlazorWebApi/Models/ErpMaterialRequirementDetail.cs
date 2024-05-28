using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpMaterialRequirementDetail
    {
        public long RecId { get; set; }
        public long? MaterialRequirementId { get; set; }
        public int? Action { get; set; }
        public long? ParentItemId { get; set; }
        public DateTime? TermDate { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public int? UnitId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? MinimumQuantity { get; set; }
        public decimal? OptimumQuantity { get; set; }
        public decimal? MinimumOrderQuantity { get; set; }
        public int? Offer { get; set; }
        public DateTime? OriginalTermDate { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public long? SourceItemId { get; set; }
        public byte? SupplyType { get; set; }
        public int? SupplyDay { get; set; }
        public short? MergeTime { get; set; }

        public virtual ErpMaterialRequirement? MaterialRequirement { get; set; }
    }
}
