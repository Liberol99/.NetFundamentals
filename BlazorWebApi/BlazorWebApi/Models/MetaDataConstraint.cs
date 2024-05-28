using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaDataConstraint
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? TableName { get; set; }
        public string? FieldName { get; set; }
        public byte? IsDynamicField { get; set; }
        public short? ModuleType { get; set; }
        public short? ModuleSubType { get; set; }
        public int? ConstraintType { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
    }
}
