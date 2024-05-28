using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPackingList
    {
        public ErpPackingList()
        {
            ErpExpoItems = new HashSet<ErpExpoItem>();
            ErpPackingListItems = new HashSet<ErpPackingListItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public long WorkOrderItemId { get; set; }
        public short? ReceiptType { get; set; }
        public long? CurrentAccountId { get; set; }
        public string? ReceiptNo { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public DateTime? CheckingDate { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public short? Language { get; set; }
        public string? Explanation1 { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public byte? IsLocked { get; set; }
        public DateTime? LockedAt { get; set; }
        public byte? IsClosed { get; set; }
        public byte? IsCancelled { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? CancelledExplanation { get; set; }
        public DateTime? CancelledAt { get; set; }
        public int? CancelledBy { get; set; }
        public string? ApprovedExplanation { get; set; }
        public long? AddressId { get; set; }

        public virtual ErpAddress? Address { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpWorkOrderItem WorkOrderItem { get; set; } = null!;
        public virtual ICollection<ErpExpoItem> ErpExpoItems { get; set; }
        public virtual ICollection<ErpPackingListItem> ErpPackingListItems { get; set; }
    }
}
