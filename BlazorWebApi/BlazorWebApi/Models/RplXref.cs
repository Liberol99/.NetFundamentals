using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class RplXref
    {
        public long RecId { get; set; }
        public int? FromLocationId { get; set; }
        public int? FromCompanyId { get; set; }
        public int? ToCompanyId { get; set; }
        public string? TableName { get; set; }
        public long? FromRecId { get; set; }
        public long? ToRecId { get; set; }
        public DateTime? InsertedAt { get; set; }
        public string? KeyCode { get; set; }
        public short? TypeCode { get; set; }

        public virtual ErpCompany? FromCompany { get; set; }
        public virtual MetaLocation? FromLocation { get; set; }
        public virtual ErpCompany? ToCompany { get; set; }
    }
}
