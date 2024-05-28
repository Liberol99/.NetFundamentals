using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaDataFieldValue
    {
        public long RecId { get; set; }
        public long? FieldId { get; set; }
        public short? ItemOrder { get; set; }
        public string? CodeValue { get; set; }
        public string? Explanation { get; set; }
        public string? FilterColumn { get; set; }
        public string? FilterValue { get; set; }
        public string? CompanyIds { get; set; }
        public string? WorkplaceIds { get; set; }
        public string? UserIds { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaDataField? Field { get; set; }
    }
}
