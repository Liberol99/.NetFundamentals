using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaLanguageDatum
    {
        public long RecId { get; set; }
        public int? TableId { get; set; }
        public long? TableRecId { get; set; }
        public string? FieldName { get; set; }
        public short? LanguageId { get; set; }
        public string? FieldValue { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
    }
}
