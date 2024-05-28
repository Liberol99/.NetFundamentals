using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaBlackList
    {
        public int RecId { get; set; }
        public long? CurrentAccountId { get; set; }
        public byte? DebtorKind { get; set; }
        public string? DebtorIdCardNo { get; set; }
        public string? BlackListName { get; set; }
        public string? BlackListSurname { get; set; }
        public string? BlackListTradeName { get; set; }
        public string? ContactPerson { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public string? Line3 { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
    }
}
