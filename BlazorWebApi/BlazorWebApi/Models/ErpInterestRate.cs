using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInterestRate
    {
        public ErpInterestRate()
        {
            ErpBankCreditBankInterestRates = new HashSet<ErpBankCredit>();
            ErpBankCreditLiborInterestRates = new HashSet<ErpBankCredit>();
            ErpCurrentAccounts = new HashSet<ErpCurrentAccount>();
            ErpInterestRateItems = new HashSet<ErpInterestRateItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public short? InterestRateType { get; set; }
        public string? InterestRateCode { get; set; }
        public string? InterestRateName { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCreditBankInterestRates { get; set; }
        public virtual ICollection<ErpBankCredit> ErpBankCreditLiborInterestRates { get; set; }
        public virtual ICollection<ErpCurrentAccount> ErpCurrentAccounts { get; set; }
        public virtual ICollection<ErpInterestRateItem> ErpInterestRateItems { get; set; }
    }
}
