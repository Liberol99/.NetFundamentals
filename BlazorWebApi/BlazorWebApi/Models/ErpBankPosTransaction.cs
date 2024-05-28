using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBankPosTransaction
    {
        public int RecId { get; set; }
        public int? ItemId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? BankPosId { get; set; }
        public decimal? Amount { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpBankPo? BankPos { get; set; }
    }
}
