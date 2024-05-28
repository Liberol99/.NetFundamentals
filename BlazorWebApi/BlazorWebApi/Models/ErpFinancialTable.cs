using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpFinancialTable
    {
        public ErpFinancialTable()
        {
            ErpFinancialTableItems = new HashSet<ErpFinancialTableItem>();
            InverseBalanceTable = new HashSet<ErpFinancialTable>();
            InverseProfitlossTable = new HashSet<ErpFinancialTable>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public long? BalanceTableId { get; set; }
        public long? ProfitlossTableId { get; set; }
        public short? TableType { get; set; }
        public string? TableNo { get; set; }
        public string? TableName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? PreviousPeriodStartDate { get; set; }
        public DateTime? PreviousPeriodEndDate { get; set; }
        public string? Explanation { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpFinancialTable? BalanceTable { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpFinancialTable? ProfitlossTable { get; set; }
        public virtual ICollection<ErpFinancialTableItem> ErpFinancialTableItems { get; set; }
        public virtual ICollection<ErpFinancialTable> InverseBalanceTable { get; set; }
        public virtual ICollection<ErpFinancialTable> InverseProfitlossTable { get; set; }
    }
}
