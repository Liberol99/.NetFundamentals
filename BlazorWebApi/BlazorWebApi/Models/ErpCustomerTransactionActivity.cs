using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCustomerTransactionActivity
    {
        public long RecId { get; set; }
        public long? CustomerTransactionId { get; set; }
        public long? TranTypeId { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? EndTime { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexUnitPrice { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Quantity { get; set; }
        public string? Explanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCustomerTransaction? CustomerTransaction { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual CrmTransactionType? TranType { get; set; }
    }
}
