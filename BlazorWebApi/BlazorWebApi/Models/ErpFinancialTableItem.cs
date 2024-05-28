using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpFinancialTableItem
    {
        public ErpFinancialTableItem()
        {
            InverseParentItem = new HashSet<ErpFinancialTableItem>();
        }

        public long RecId { get; set; }
        public long? FinancialTableId { get; set; }
        public byte? ItemType { get; set; }
        public string? ItemCode { get; set; }
        public short? ItemOrderNo { get; set; }
        public int? StartAccountId { get; set; }
        public int? EndAccountId { get; set; }
        public string? Explanation { get; set; }
        public string? SpecialCode { get; set; }
        public byte? AmountType { get; set; }
        public decimal? Amount { get; set; }
        public decimal? ForexAmount { get; set; }
        public decimal? CforexAmount { get; set; }
        public decimal? Amount2 { get; set; }
        public decimal? Amount3 { get; set; }
        public decimal? Pamount { get; set; }
        public decimal? PforexAmount { get; set; }
        public decimal? PcforexAmount { get; set; }
        public decimal? Pamount2 { get; set; }
        public decimal? Pamount3 { get; set; }
        public string? Formula { get; set; }
        public byte? Aptype { get; set; }
        public byte? ReverseBalance { get; set; }
        public byte? AccountType { get; set; }
        public byte? TransactionType { get; set; }
        public byte? ItemLevel { get; set; }
        public byte? IsPrintable { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? CompanyId { get; set; }
        public long? ParentItemId { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpGlaccount? EndAccount { get; set; }
        public virtual ErpFinancialTable? FinancialTable { get; set; }
        public virtual ErpFinancialTableItem? ParentItem { get; set; }
        public virtual ErpGlaccount? StartAccount { get; set; }
        public virtual ICollection<ErpFinancialTableItem> InverseParentItem { get; set; }
    }
}
