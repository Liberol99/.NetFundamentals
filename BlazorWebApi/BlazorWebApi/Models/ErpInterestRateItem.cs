using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInterestRateItem
    {
        public long RecId { get; set; }
        public long? InterestRateId { get; set; }
        public int? ItemOrderNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ForexId { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? InterestRateEarlyPaid { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? BankId { get; set; }
        public decimal? InterestRate3Monthly { get; set; }
        public decimal? InterestRate6Monthly { get; set; }
        public decimal? InterestRateYearly { get; set; }
        public byte? SubTransactionType { get; set; }

        public virtual ErpBank? Bank { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ErpInterestRate? InterestRateNavigation { get; set; }
    }
}
