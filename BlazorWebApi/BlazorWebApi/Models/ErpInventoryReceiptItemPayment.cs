using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryReceiptItemPayment
    {
        public long RecId { get; set; }
        public long? PosReceiptId { get; set; }
        public long? InventoryReceiptItemId { get; set; }
        public long? CurrentAccountReceiptItemId { get; set; }
        public byte? PaymentType { get; set; }
        public decimal? ItemQuantity { get; set; }
        public decimal? ItemAmount { get; set; }
        public decimal? ItemPaymentAmount { get; set; }
        public decimal? PaymentAmount { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCurrentAccountReceiptItem? CurrentAccountReceiptItem { get; set; }
        public virtual ErpInventoryReceiptItem? InventoryReceiptItem { get; set; }
        public virtual ErpPo? PosReceipt { get; set; }
    }
}
