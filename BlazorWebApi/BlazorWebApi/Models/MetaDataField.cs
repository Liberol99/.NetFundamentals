using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaDataField
    {
        public MetaDataField()
        {
            MetaDataFieldClasses = new HashSet<MetaDataFieldClass>();
            MetaDataFieldValues = new HashSet<MetaDataFieldValue>();
        }

        public long RecId { get; set; }
        public string? TableName { get; set; }
        public string? FieldName { get; set; }
        public byte? DataType { get; set; }
        public byte? UsageType { get; set; }
        public string? Caption { get; set; }
        public string? Explanation { get; set; }
        public byte? UielementType { get; set; }
        public byte? Usage { get; set; }
        public byte? Decimals { get; set; }
        public byte? IsMultiLine { get; set; }
        public byte? IsVisible { get; set; }
        public string? DefaultValue { get; set; }
        public string? CompanyIds { get; set; }
        public string? WorkplaceIds { get; set; }
        public string? UserIds { get; set; }
        public string? WorkListSelectSql { get; set; }
        public string? WorkList { get; set; }
        public string? WorkListSelectedField { get; set; }
        public string? WorkListParamField { get; set; }
        public int? ItemOrderNo { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ICollection<MetaDataFieldClass> MetaDataFieldClasses { get; set; }
        public virtual ICollection<MetaDataFieldValue> MetaDataFieldValues { get; set; }
    }
}
