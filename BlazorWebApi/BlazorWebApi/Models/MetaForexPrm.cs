using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaForexPrm
    {
        public MetaForexPrm()
        {
            ErpChequeReceipts = new HashSet<ErpChequeReceipt>();
            ErpCurrentAccounts = new HashSet<ErpCurrentAccount>();
            MetaForexRates = new HashSet<MetaForexRate>();
        }

        public int RecId { get; set; }
        public string? RateCode { get; set; }
        public string? RateName { get; set; }
        public byte? ItemOrder { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ICollection<ErpChequeReceipt> ErpChequeReceipts { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccounts { get; set; }
        public virtual ICollection<MetaForexRate> MetaForexRates { get; set; }
    }
}
