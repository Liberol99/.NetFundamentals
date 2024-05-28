using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBankCreditExpoClosing
    {
        public long RecId { get; set; }
        public short? Type { get; set; }
        public long? BankCreditItemId { get; set; }
        public long? BankCreditId { get; set; }
        public long? ExpoId { get; set; }
        public string? Explanation { get; set; }
        public int? ForexId { get; set; }
        public decimal? ForexRate { get; set; }
        public decimal? ForexTotal { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpBankCredit? BankCredit { get; set; }
        public virtual ErpBankCreditItem? BankCreditItem { get; set; }
        public virtual ErpExpo? Expo { get; set; }
        public virtual MetaForex? Forex { get; set; }
    }
}
