using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpGlreflection
    {
        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? GlreflectionDefId { get; set; }
        public short? ReflectionType { get; set; }
        public int? FirstAccountId { get; set; }
        public int? LastAccountId { get; set; }
        public int? AccountId { get; set; }
        public byte? SubAccount { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public short? DebitCreditType { get; set; }

        public virtual ErpGlaccount? Account { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpGlaccount? FirstAccount { get; set; }
        public virtual ErpGlreflectionDefinition? GlreflectionDef { get; set; }
        public virtual ErpGlaccount? LastAccount { get; set; }
    }
}
