using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpTaxIa
    {
        public int RecId { get; set; }
        public int? TaxId { get; set; }
        public int? TypeNo { get; set; }
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
        public virtual ErpGlaccount? Glaccount { get; set; }
        public virtual ErpTax? Tax { get; set; }
    }
}
