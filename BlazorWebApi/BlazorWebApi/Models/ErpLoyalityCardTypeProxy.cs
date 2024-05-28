using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpLoyalityCardTypeProxy
    {
        public int RecId { get; set; }
        public int? TypeId { get; set; }
        public string? Explanation { get; set; }
        public string? StartingSerialNo { get; set; }
        public string? EndingSerialNo { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpLoyalityCardType? Type { get; set; }
    }
}
