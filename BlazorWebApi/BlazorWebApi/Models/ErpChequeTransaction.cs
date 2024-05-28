using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpChequeTransaction
    {
        public long RecId { get; set; }
        public long? ChequeId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public short? TransactionType { get; set; }
        public string? Explanation { get; set; }
        public short? TransactionActionType { get; set; }
        public short? TransactionActionKind { get; set; }
        public short? TransactionAggrementType { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCheque? Cheque { get; set; }
    }
}
