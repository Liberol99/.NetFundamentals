using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCurrentAccountRiskTotal
    {
        public long RecId { get; set; }
        public long? CurrentAccountId { get; set; }
        public long? ParentCurrentAccountId { get; set; }
        public short? FiscalYear { get; set; }
        public int? ForexId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Balance { get; set; }
        public decimal? ForexDebit { get; set; }
        public decimal? ForexCredit { get; set; }
        public decimal? ForexBalance { get; set; }
        public decimal? AgingRange01 { get; set; }
        public decimal? AgingRange02 { get; set; }
        public decimal? AgingRange03 { get; set; }
        public decimal? AgingRange04 { get; set; }
        public decimal? AgingRange05 { get; set; }
        public decimal? AgingRange06 { get; set; }
        public decimal? AgingRange07 { get; set; }
        public decimal? AgingRange08 { get; set; }
        public decimal? AgingRange09 { get; set; }
        public decimal? AgingRange10 { get; set; }
        public decimal? AgingRange11 { get; set; }
        public decimal? AgingRange12 { get; set; }
        public decimal? ChequeAmount { get; set; }
        public decimal? RiskChequeAmount { get; set; }
        public decimal? BouncedChequeAmount { get; set; }
        public decimal? ForexBouncedChequeAmount { get; set; }
        public decimal? OrderAmount { get; set; }
        public decimal? UnapprovedOrderAmount { get; set; }
        public decimal? SalesAmount { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
    }
}
