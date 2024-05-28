using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryAssortment
    {
        public ErpInventoryAssortment()
        {
            ErpContractItems = new HashSet<ErpContractItem>();
            ErpInventoryAssortmentItems = new HashSet<ErpInventoryAssortmentItem>();
            ErpInventoryBarcodes = new HashSet<ErpInventoryBarcode>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
        }

        public long RecId { get; set; }
        public byte? AssortmentType { get; set; }
        public long? InventoryId { get; set; }
        public string? LotCode { get; set; }
        public string? LotDescription { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
        public virtual ICollection<ErpContractItem> ErpContractItems { get; set; }
        public virtual ICollection<ErpInventoryAssortmentItem> ErpInventoryAssortmentItems { get; set; }
        public virtual ICollection<ErpInventoryBarcode> ErpInventoryBarcodes { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
    }
}
