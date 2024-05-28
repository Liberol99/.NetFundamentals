using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCashTotal
    {
        public ErpCashTotal()
        {
            ErpCashTotalItems = new HashSet<ErpCashTotalItem>();
        }

        public long RecId { get; set; }
        public int? CashId { get; set; }
        public byte? TotalType { get; set; }
        public DateTime? TotalDate { get; set; }
        public byte? TotalShift { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? Explanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCash? Cash { get; set; }
        public virtual ICollection<ErpCashTotalItem> ErpCashTotalItems { get; set; }
    }
}
