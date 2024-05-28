using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpFixedAssetExpense
    {
        public long RecId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryReceiptItemId { get; set; }
        public byte? ExpenseType { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public string? DocumentNo { get; set; }
        public string? Explanation { get; set; }
        public decimal? Amount { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? DocumentSerialNo { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryReceiptItem? InventoryReceiptItem { get; set; }
    }
}
