using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPackingListItem
    {
        public ErpPackingListItem()
        {
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpPackingListItemVariants = new HashSet<ErpPackingListItemVariant>();
        }

        public long RecId { get; set; }
        public int? ItemOrderNo { get; set; }
        public byte? ItemType { get; set; }
        public long? InventoryId { get; set; }
        public long? WorkOrderId { get; set; }
        public long? PackingListId { get; set; }
        public decimal? ToBox { get; set; }
        public decimal? FromBox { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexUnitPrice { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? PackageQuantity { get; set; }
        public decimal? TotalQuantity { get; set; }
        public decimal? Amount { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public int? LockedBy { get; set; }
        public byte? IsClosed { get; set; }
        public byte? IsCancelled { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public string? CancelledExplanation { get; set; }
        public string? ApprovedExplanation { get; set; }

        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpPackingList? PackingList { get; set; }
        public virtual MetaUnitSet? Unit { get; set; }
        public virtual ErpWorkOrder? WorkOrder { get; set; }
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpPackingListItemVariant> ErpPackingListItemVariants { get; set; }
    }
}
