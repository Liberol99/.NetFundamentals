using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpGlreceiptItemInv
    {
        public long RecId { get; set; }
        public long? GlreceiptItemId { get; set; }
        public int? ItemOrderNo { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string? DocumentNo { get; set; }
        public string? CurrentAccountCode { get; set; }
        public string? CurrentAccountName { get; set; }
        public int? TaxOfficeId { get; set; }
        public string? TaxNo { get; set; }
        public string? InventoryExplanation { get; set; }
        public int? UnitId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? DocumentSerialNo { get; set; }

        public virtual ErpGlreceiptItem? GlreceiptItem { get; set; }
        public virtual MetaTaxOffice? TaxOffice { get; set; }
        public virtual MetaUnitSetItem? Unit { get; set; }
    }
}
