using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBankAccountTotal
    {
        public long RecId { get; set; }
        public int? BankAccountId { get; set; }
        public short? TotalYear { get; set; }
        public byte? TotalMonth { get; set; }
        public int? ForexId { get; set; }
        public short? TotalType { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }

        public virtual ErpBankAccount? BankAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
    }
}
