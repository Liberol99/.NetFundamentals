using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpQualityType
    {
        public ErpQualityType()
        {
            ErpBoxes = new HashSet<ErpBox>();
            ErpFaultyCards = new HashSet<ErpFaultyCard>();
            ErpInventoryReceiptItems = new HashSet<ErpInventoryReceiptItem>();
            ErpInventorySerialCards = new HashSet<ErpInventorySerialCard>();
            ErpOrderReceiptItems = new HashSet<ErpOrderReceiptItem>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? QualityCode { get; set; }
        public string? QualityName { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public int? MinValue { get; set; }
        public int? MaxValue { get; set; }
        public byte? OnlyCleanRoll { get; set; }
        public byte? MaxMainFaultyCount { get; set; }
        public byte? MinPartCount { get; set; }
        public byte? MaxPartCount { get; set; }
        public decimal? MaxFaultyLength { get; set; }
        public decimal? StartAndEndCleanLength { get; set; }
        public decimal? MinRollLength { get; set; }
        public decimal? MaxRollLength { get; set; }
        public decimal? MinPartLength { get; set; }
        public int? TulleMaxPoints { get; set; }
        public short? MaxFaultyNumber { get; set; }
        public byte? IsDefectSystem { get; set; }
        public byte? FaultyRequired { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? BackgroundColor { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpBox> ErpBoxes { get; set; }
        public virtual ICollection<ErpFaultyCard> ErpFaultyCards { get; set; }
        public virtual ICollection<ErpInventoryReceiptItem> ErpInventoryReceiptItems { get; set; }
        public virtual ICollection<ErpInventorySerialCard> ErpInventorySerialCards { get; set; }
        public virtual ICollection<ErpOrderReceiptItem> ErpOrderReceiptItems { get; set; }
    }
}
