using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCurrentAccountTotal
    {
        public long RecId { get; set; }
        public long? CurrentAccountId { get; set; }
        public short? FiscalYear { get; set; }
        public int? ForexId { get; set; }
        public decimal? Debit01 { get; set; }
        public decimal? Debit02 { get; set; }
        public decimal? Debit03 { get; set; }
        public decimal? Debit04 { get; set; }
        public decimal? Debit05 { get; set; }
        public decimal? Debit06 { get; set; }
        public decimal? Debit07 { get; set; }
        public decimal? Debit08 { get; set; }
        public decimal? Debit09 { get; set; }
        public decimal? Debit10 { get; set; }
        public decimal? Debit11 { get; set; }
        public decimal? Debit12 { get; set; }
        public decimal? Credit01 { get; set; }
        public decimal? Credit02 { get; set; }
        public decimal? Credit03 { get; set; }
        public decimal? Credit04 { get; set; }
        public decimal? Credit05 { get; set; }
        public decimal? Credit06 { get; set; }
        public decimal? Credit07 { get; set; }
        public decimal? Credit08 { get; set; }
        public decimal? Credit09 { get; set; }
        public decimal? Credit10 { get; set; }
        public decimal? Credit11 { get; set; }
        public decimal? Credit12 { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
    }
}
