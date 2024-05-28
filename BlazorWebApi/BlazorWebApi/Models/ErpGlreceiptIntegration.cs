using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpGlreceiptIntegration
    {
        public long RecId { get; set; }
        public byte? IntegrationType { get; set; }
        public short? SourceModule { get; set; }
        public long? SourceId { get; set; }
        public long? SourceItemId { get; set; }
        public long? GlreceiptId { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public Guid? UniqueId { get; set; }
        public short? SourceType { get; set; }

        public virtual ErpGlreceipt? Glreceipt { get; set; }
    }
}
