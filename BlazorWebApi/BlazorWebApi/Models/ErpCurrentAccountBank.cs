using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCurrentAccountBank
    {
        public ErpCurrentAccountBank()
        {
            ErpInvoices = new HashSet<ErpInvoice>();
        }

        public long RecId { get; set; }
        public long? CurrentAccountId { get; set; }
        public int? BankAccountId { get; set; }
        public short? CabankKind { get; set; }
        public string? AccountName { get; set; }
        public string? AccountNo { get; set; }
        public string? BankBranch { get; set; }
        public string? IbanNo { get; set; }
        public string? Explanation { get; set; }
        public int? ForexId { get; set; }
        public byte? IsDefault { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? IsDbsaccount { get; set; }
        public decimal? Dbslimit { get; set; }
        public short? DbsriskOver { get; set; }

        public virtual ErpBankAccount? BankAccount { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual MetaForex? Forex { get; set; }
        public virtual ICollection<ErpInvoice> ErpInvoices { get; set; }
    }
}
