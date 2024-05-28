using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaDataFieldClass
    {
        public long RecId { get; set; }
        public long? FieldId { get; set; }
        public short? ModuleType { get; set; }
        public short? ModuleSubType { get; set; }
        public byte? IsActive { get; set; }
        public string? Explanation { get; set; }
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
