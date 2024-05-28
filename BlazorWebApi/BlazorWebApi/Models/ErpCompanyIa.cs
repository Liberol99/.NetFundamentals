using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCompanyIa
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? ModuleNo { get; set; }
        public short? TypeNo { get; set; }
        public int? GlaccountId { get; set; }
        public int? CostCenterId { get; set; }
        public int? ForexId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCostCenter? CostCenter { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpGlaccount? Glaccount { get; set; }
    }
}
