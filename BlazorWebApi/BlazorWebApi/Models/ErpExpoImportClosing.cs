using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpExpoImportClosing
    {
        public long RecId { get; set; }
        public short? Type { get; set; }
        public long? ExpoId { get; set; }
        public long? ImportItemId { get; set; }
        public string? Explanation { get; set; }
        public decimal? Quantity { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpExpo? Expo { get; set; }
        public virtual ErpExpoItem? ImportItem { get; set; }
    }
}
