using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpEinvoice
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public long? InvoiceId { get; set; }
        public byte? EinvoiceType { get; set; }
        public string? Uuid { get; set; }
        public string? Explanation { get; set; }
        public string? ReceiverName { get; set; }
        public string? DocumentNo { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string? ReceiptTypeName { get; set; }
        public long? InventoryReceiptId { get; set; }
        public string? InventoryReceiptDocumentNo { get; set; }
        public DateTime? InventoryReceiptDate { get; set; }
        public long? OrderReceiptId { get; set; }
        public string? OrderReceiptDocumentNo { get; set; }
        public DateTime? OrderReceiptDate { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? ExciseTaxAmount { get; set; }
        public decimal? DiscountsTotal { get; set; }
        public decimal? ExpensesTotal { get; set; }
        public decimal? GrandTotal { get; set; }
        public string? CurrencyCode { get; set; }
        public byte? ApprovedStatus { get; set; }
        public byte? IsPrinted { get; set; }
        public DateTime? InvoiceAcceptDate { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public byte[]? EinvoiceData { get; set; }
        public long? EinvoiceReference { get; set; }
        public string? EinvoiceSpecial { get; set; }
        public byte? TransactionType { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public string? DocumentSerialNo { get; set; }
        public string? ReceiverTaxNo { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpInventoryReceipt? InventoryReceipt { get; set; }
        public virtual ErpInvoice? Invoice { get; set; }
    }
}
