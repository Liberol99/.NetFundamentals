using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpEmployeeIa
    {
        public long RecId { get; set; }
        public long? EmployeeId { get; set; }
        public short? TypeNo { get; set; }
        public int? GlaccountId { get; set; }
        public int? CostCenterId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpGlaccount? Glaccount { get; set; }
    }
}
