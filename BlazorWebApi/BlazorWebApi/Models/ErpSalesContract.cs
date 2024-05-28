using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpSalesContract
    {
        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? ContractCode { get; set; }
        public string? Explanation { get; set; }
        public short? ContractType { get; set; }
        public long? CurrentAccountId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short? ItemType { get; set; }
        public string? Code1 { get; set; }
        public string? Code2 { get; set; }
        public decimal? Amount1 { get; set; }
        public decimal? Amount2 { get; set; }
        public decimal? Rate { get; set; }
        public byte? VatIncluded { get; set; }
        public byte[]? Condition { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
    }
}
