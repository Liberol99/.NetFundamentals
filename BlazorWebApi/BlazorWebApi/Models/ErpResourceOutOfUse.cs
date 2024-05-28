using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpResourceOutOfUse
    {
        public long RecId { get; set; }
        public long? ResourceId { get; set; }
        public string? Explanation { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ReasonId { get; set; }
        public long? PlanningId { get; set; }
        public long? WorkOrderItemId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpPlanning? Planning { get; set; }
        public virtual ErpResourceOutOfUseReason? Reason { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpWorkOrderItem? WorkOrderItem { get; set; }
    }
}
