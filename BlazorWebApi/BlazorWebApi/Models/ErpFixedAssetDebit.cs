using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpFixedAssetDebit
    {
        public long RecId { get; set; }
        public int? WorkplaceId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryInventoryId { get; set; }
        public long? DebitEmployeeId { get; set; }
        public byte? DebitType { get; set; }
        public long? UsedEmployeeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Explanation { get; set; }
        public decimal? Quantity { get; set; }
        public short? SourceModule { get; set; }
        public short? SourceType { get; set; }
        public long? SourceId { get; set; }
        public long? SourceItemId { get; set; }
        public byte? IsPrinted { get; set; }
        public byte? IsApproved { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? ApprovedExplanation { get; set; }

        public virtual ErpEmployee? DebitEmployee { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventory? InventoryInventory { get; set; }
        public virtual ErpEmployee? UsedEmployee { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
