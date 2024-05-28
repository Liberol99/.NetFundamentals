using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpEmployeeCompetency
    {
        public long RecId { get; set; }
        public long? EmployeeId { get; set; }
        public long? InventoryId { get; set; }
        public long? ServiceId { get; set; }
        public int? ProcessId { get; set; }
        public long? ResourceId { get; set; }
        public int? CompetencyId { get; set; }
        public short? CompetencyLevel { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompetency? Competency { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpService? Service { get; set; }
    }
}
