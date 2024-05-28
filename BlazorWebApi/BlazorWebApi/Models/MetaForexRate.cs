using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaForexRate
    {
        public long RecId { get; set; }
        public DateTime? RateDate { get; set; }
        public int? ForexId { get; set; }
        public int? RateId { get; set; }
        public decimal? Price { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaForex? Forex { get; set; }
        public virtual MetaForexPrm? Rate { get; set; }
    }
}
