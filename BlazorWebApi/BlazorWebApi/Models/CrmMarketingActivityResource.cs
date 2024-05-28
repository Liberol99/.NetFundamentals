using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class CrmMarketingActivityResource
    {
        public long RecId { get; set; }
        public long? MarketingActivityId { get; set; }
        public long? ResourceId { get; set; }
        public decimal? QuotedQuantity { get; set; }
        public decimal? QuotedAmount { get; set; }
        public int? ForexId { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaForex? Forex { get; set; }
        public virtual CrmMarketingActivity? MarketingActivity { get; set; }
        public virtual ErpResource? Resource { get; set; }
    }
}
