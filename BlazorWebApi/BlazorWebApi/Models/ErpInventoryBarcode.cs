using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryBarcode
    {
        public long RecId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public long? InventoryAssortmentId { get; set; }
        public long? CurrentAccountId { get; set; }
        public byte? BarcodeType { get; set; }
        public string? Barcode { get; set; }
        public string? PluCode { get; set; }
        public int? UnitSetItemId { get; set; }
        public decimal? Quantity { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public Guid? UniqueId { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryAssortment? InventoryAssortment { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpInventoryUnitItemSize? UnitSetItem { get; set; }
    }
}
