using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class PosShift
    {
        public PosShift()
        {
            ErpCashTotalItems = new HashSet<ErpCashTotalItem>();
            ErpCurrentAccountReceiptItems = new HashSet<ErpCurrentAccountReceiptItem>();
            ErpPos = new HashSet<ErpPo>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? DepartmentId { get; set; }
        public int? CashId { get; set; }
        public string? ReceiptNo { get; set; }
        public DateTime? ShiftsStart { get; set; }
        public DateTime? ShiftsEnd { get; set; }
        public string? Explanation { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public Guid? UniqueId { get; set; }

        public virtual ErpCash? Cash { get; set; }
        public virtual ErpCompany? Company { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpCashTotalItem> ErpCashTotalItems { get; set; }
        public virtual ICollection<ErpCurrentAccountReceiptItem> ErpCurrentAccountReceiptItems { get; set; }
        public virtual ICollection<ErpPo> ErpPos { get; set; }
    }
}
