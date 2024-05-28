using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPaymentCardItem
    {
        public int RecId { get; set; }
        public int? PaymentCardId { get; set; }
        public short? ItemOrderNo { get; set; }
        public short? TermDay { get; set; }
        public decimal? CommRate { get; set; }
        public decimal? BonusRate { get; set; }
        public string? Explanation { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpPaymentCard? PaymentCard { get; set; }
    }
}
