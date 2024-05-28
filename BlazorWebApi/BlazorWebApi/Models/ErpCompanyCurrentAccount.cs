using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCompanyCurrentAccount
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? CompanyId2 { get; set; }
        public long? CurrentAccountId2 { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? GlaccountId { get; set; }
        public int? GlaccountId2 { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCompany? CompanyId2Navigation { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpCurrentAccount? CurrentAccountId2Navigation { get; set; }
        public virtual ErpGlaccount? Glaccount { get; set; }
        public virtual ErpGlaccount? GlaccountId2Navigation { get; set; }
    }
}
