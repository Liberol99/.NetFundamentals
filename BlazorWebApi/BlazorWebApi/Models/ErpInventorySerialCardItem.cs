using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventorySerialCardItem
    {
        public long RecId { get; set; }
        public short? ItemType { get; set; }
        public long? SerialCardId { get; set; }
        public long? FaultyId { get; set; }
        public string? Explanation { get; set; }
        public decimal? FaultyStartMeter { get; set; }
        public decimal? FaultyEndMeter { get; set; }
        public decimal? FaultyQuantity { get; set; }
        public decimal? FaultyPoint { get; set; }
        public long? EmployeeId { get; set; }
        public int? ItemOrderNo { get; set; }
        public DateTime? ItemInsertedAt { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpEmployee? Employee { get; set; }
        public virtual ErpFaultyCard? Faulty { get; set; }
        public virtual ErpInventorySerialCard? SerialCard { get; set; }
    }
}
