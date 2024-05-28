using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaExternalXref
    {
        public int RecId { get; set; }
        public string? TableName { get; set; }
        public short? TypeCode { get; set; }
        public string? KeyValue1 { get; set; }
        public string? KeyValue2 { get; set; }
        public string? KeyValue3 { get; set; }
        public int? ExtId { get; set; }
        public string? ExtKeyValue1 { get; set; }
        public string? ExtKeyValue2 { get; set; }
        public string? ExtKeyValue3 { get; set; }
        public string? ExtKeyValue4 { get; set; }
        public short? CriteriaType { get; set; }
        public string? CriteriaValue1 { get; set; }
        public string? CriteriaValue2 { get; set; }
        public byte? Module { get; set; }
        public short? ItemId { get; set; }
        public int? SubItemId { get; set; }
        public byte[]? Condition { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaExternal? Ext { get; set; }
    }
}
