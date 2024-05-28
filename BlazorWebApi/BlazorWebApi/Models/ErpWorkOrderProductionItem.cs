using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWorkOrderProductionItem
    {
        public long RecId { get; set; }
        public long? WorkOrderProductionId { get; set; }
        public byte? ItemType { get; set; }
        public long? SerialCardId { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsApproved { get; set; }
        public byte? IsCancelled { get; set; }
        public string? CancelledExplanation { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public string? ApprovedExplanation { get; set; }

        public virtual ErpInventorySerialCard? SerialCard { get; set; }
        public virtual ErpWorkOrderProduction? WorkOrderProduction { get; set; }
    }
}
