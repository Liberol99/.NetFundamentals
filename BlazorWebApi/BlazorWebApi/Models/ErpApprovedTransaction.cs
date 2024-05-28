using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpApprovedTransaction
    {
        public long RecId { get; set; }
        public int? ModuleId { get; set; }
        public int? SecId { get; set; }
        public int? UserId { get; set; }
        public short? Priority { get; set; }
        public string? Boname { get; set; }
        public int? SourceId { get; set; }
        public long? SourceItemId { get; set; }
        public int? WorkflowId { get; set; }
        public byte? IsApproved { get; set; }
        public string? Command { get; set; }
        public string? Explanation { get; set; }
        public byte? Status { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? CreatedBySystem { get; set; }

        public virtual MetaUser? User { get; set; }
    }
}
