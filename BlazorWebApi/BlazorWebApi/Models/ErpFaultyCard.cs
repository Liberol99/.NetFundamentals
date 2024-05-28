using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpFaultyCard
    {
        public ErpFaultyCard()
        {
            ErpInventorySerialCardItems = new HashSet<ErpInventorySerialCardItem>();
            ErpQualityControlReceiptItems = new HashSet<ErpQualityControlReceiptItem>();
            InverseParent = new HashSet<ErpFaultyCard>();
        }

        public long RecId { get; set; }
        public short? FaultyType { get; set; }
        public string? FaultyCode { get; set; }
        public string? FaultyName { get; set; }
        public decimal? FaultyPoint { get; set; }
        public byte? IsPointDefects { get; set; }
        public byte? IsMainFaulty { get; set; }
        public byte? DividedIntoParts { get; set; }
        public int? QualityTypeRecId { get; set; }
        public int? ProcessId { get; set; }
        public byte? FaultPointManuelChange { get; set; }
        public byte? IsMajor { get; set; }
        public byte? IsMinor { get; set; }
        public byte? IsCritical { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public long? ParentId { get; set; }

        public virtual ErpFaultyCard? Parent { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpQualityType? QualityTypeRec { get; set; }
        public virtual ICollection<ErpInventorySerialCardItem> ErpInventorySerialCardItems { get; set; }
        public virtual ICollection<ErpQualityControlReceiptItem> ErpQualityControlReceiptItems { get; set; }
        public virtual ICollection<ErpFaultyCard> InverseParent { get; set; }
    }
}
