using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpTest
    {
        public ErpTest()
        {
            ErpTestItems = new HashSet<ErpTestItem>();
        }

        public long RecId { get; set; }
        public long? CurrentAccountId { get; set; }
        public string? TestCode { get; set; }
        public string? TestName { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? InUse { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ICollection<ErpTestItem> ErpTestItems { get; set; }
    }
}
