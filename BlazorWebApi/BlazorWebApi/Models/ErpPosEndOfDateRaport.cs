using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPosEndOfDateRaport
    {
        public ErpPosEndOfDateRaport()
        {
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpPos = new HashSet<ErpPo>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? DepartmentId { get; set; }
        public int? CashId { get; set; }
        public short? EndOfDateType { get; set; }
        public int? EndOfDateNo { get; set; }
        public DateTime? EndOfDate { get; set; }
        public DateTime? EndOfDateTime { get; set; }
        public string? Explanation { get; set; }
        public byte[]? ReportData { get; set; }
        public decimal? ReceiptCount { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? VatAmount { get; set; }
        public decimal? GrandTotal { get; set; }
        public decimal? ReturnReceiptCount { get; set; }
        public decimal? ReturnTotal { get; set; }
        public decimal? DiscountTotal { get; set; }
        public Guid? UniqueId { get; set; }
        public string? PosMacAddress { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCash? Cash { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpPo> ErpPos { get; set; }
    }
}
