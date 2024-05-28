using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpEmployeeTimeAttandance
    {
        public int RecId { get; set; }
        public long? EmployeeId { get; set; }
        public short? Type { get; set; }
        public short? Reason { get; set; }
        public DateTime? TrDate { get; set; }
        public DateTime? TrTime { get; set; }
        public short? Trype { get; set; }
        public short? Status { get; set; }
        public short? ResourceType { get; set; }
        public long? ResourceId { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpResource? Resource { get; set; }
    }
}
