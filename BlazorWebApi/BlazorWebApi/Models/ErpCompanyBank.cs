using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCompanyBank
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? BankAccountId { get; set; }
        public short? CbankKind { get; set; }
        public string? AccountName { get; set; }
        public string? AccountNo { get; set; }
        public string? BankBranch { get; set; }
        public string? IbanNo { get; set; }
        public string? Explanation { get; set; }
        public byte? IsDefault { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpBankAccount? BankAccount { get; set; }
        public virtual ErpCompany? Company { get; set; }
    }
}
