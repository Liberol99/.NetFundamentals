using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryTaxUsage
    {
        public long RecId { get; set; }
        public long? SalesInventoryReceiptItemId { get; set; }
        public long? PurchaseInventoryReceiptItemId { get; set; }
        public decimal? UsedQuantity { get; set; }
        public decimal? UsedVatAmount { get; set; }

        public virtual ErpInventoryReceiptItem? PurchaseInventoryReceiptItem { get; set; }
        public virtual ErpInventoryReceiptItem? SalesInventoryReceiptItem { get; set; }
    }
}
