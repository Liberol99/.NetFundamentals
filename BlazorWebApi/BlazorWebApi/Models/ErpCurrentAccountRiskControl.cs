using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCurrentAccountRiskControl
    {
        public ErpCurrentAccountRiskControl()
        {
            ErpCurrentAccountTransactions = new HashSet<ErpCurrentAccountTransaction>();
        }

        public long RecId { get; set; }
        public long? CurrentAccountId { get; set; }
        public DateTime? ControlDate { get; set; }
        public short? ControlType { get; set; }
        public string? Explanation { get; set; }
        public decimal? Capital { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ICollection<ErpCurrentAccountTransaction> ErpCurrentAccountTransactions { get; set; }
    }
}
