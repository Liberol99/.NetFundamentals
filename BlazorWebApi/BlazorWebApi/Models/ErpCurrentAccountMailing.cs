using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCurrentAccountMailing
    {
        public long RecId { get; set; }
        public byte? MailType { get; set; }
        public string? MailCode { get; set; }
        public long? CurrentAccountId { get; set; }
        public DateTime? MailDate { get; set; }
        public string? Explanation { get; set; }
        public byte? IsSent { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
    }
}
