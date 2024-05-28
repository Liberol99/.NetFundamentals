using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCashTotalItem
    {
        public long RecId { get; set; }
        public long? CashTotalId { get; set; }
        public int? PaymentCardId { get; set; }
        public long? ShiftsId { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexAmount { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCashTotal? CashTotal { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpPaymentCard? PaymentCard { get; set; }
        public virtual PosShift? Shifts { get; set; }
    }
}
