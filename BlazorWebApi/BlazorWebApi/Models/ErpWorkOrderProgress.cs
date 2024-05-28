using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWorkOrderProgress
    {
        public long RecId { get; set; }
        public long? WorkOrderId { get; set; }
        public byte? ItemType { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public byte? ExpenseType { get; set; }
        public string? Explanation { get; set; }
        public decimal? InitialValue { get; set; }
        public decimal? ActualValue { get; set; }
        public int? ForexId { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? ForexUnitPrice { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ForexAmount { get; set; }
        public byte[]? Attachment { get; set; }
        public long? AsserviceFaultyId { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public long? OrderReceiptId { get; set; }
        public long? InventoryId { get; set; }
        public long? SerialCardId { get; set; }
        public byte? FaultyMainType { get; set; }
        public long? AsserviceFaultyKindGroupId { get; set; }
        public long? AsserviceFaultyKindId { get; set; }
        public byte? ExternalPart { get; set; }
        public byte? PartSended { get; set; }
        public byte? PartPreviousSended { get; set; }
        public decimal? Quantity { get; set; }
        public string? UniqueCode { get; set; }
        public long? OrderReceiptItemId { get; set; }
        public byte? IsPartReceived { get; set; }

        public virtual ErpAsserviceFaulty? AsserviceFaulty { get; set; }
        public virtual ErpAsserviceFaulty? AsserviceFaultyKind { get; set; }
        public virtual ErpAsserviceFaulty? AsserviceFaultyKindGroup { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpOrderReceipt? OrderReceipt { get; set; }
        public virtual ErpOrderReceiptItem? OrderReceiptItem { get; set; }
        public virtual ErpInventorySerialCard? SerialCard { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
    }
}
