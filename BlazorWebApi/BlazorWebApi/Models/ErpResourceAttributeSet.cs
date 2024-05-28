using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpResourceAttributeSet
    {
        public ErpResourceAttributeSet()
        {
            CrmTransactionTypeResourceAttributes = new HashSet<CrmTransactionTypeResourceAttribute>();
            ErpResourceAttributeSetItems = new HashSet<ErpResourceAttributeSetItem>();
            ErpResourceAttributes = new HashSet<ErpResourceAttribute>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? ResourceType { get; set; }
        public string? AttributeCode { get; set; }
        public string? AttributeName { get; set; }
        public string? SpecialCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<CrmTransactionTypeResourceAttribute> CrmTransactionTypeResourceAttributes { get; set; }
        public virtual ICollection<ErpResourceAttributeSetItem> ErpResourceAttributeSetItems { get; set; }
        public virtual ICollection<ErpResourceAttribute> ErpResourceAttributes { get; set; }
    }
}
