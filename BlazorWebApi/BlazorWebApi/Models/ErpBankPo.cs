using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBankPo
    {
        public ErpBankPo()
        {
            ErpBankPosTransactions = new HashSet<ErpBankPosTransaction>();
        }

        public int RecId { get; set; }
        public string? PosCode { get; set; }
        public string? PosName { get; set; }
        public string? Explanation { get; set; }
        public short? TechnologyType { get; set; }
        public int? BankAccountId { get; set; }
        public int? ForexId { get; set; }
        public byte? IsVirtual { get; set; }
        public string? ApiUser { get; set; }
        public string? ApiPassword { get; set; }
        public string? ThreeDmodel { get; set; }
        public string? ThreeDgateUrl { get; set; }
        public string? ThreeDstoreKey { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpBankAccount? BankAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ICollection<ErpBankPosTransaction> ErpBankPosTransactions { get; set; }
    }
}
