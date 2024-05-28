using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCallerIdLog
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? DepartmentId { get; set; }
        public byte? CallType { get; set; }
        public DateTime? CallDate { get; set; }
        public string? CallNumber { get; set; }
        public long? PosReceiptId { get; set; }
        public long? CurrentAccountId { get; set; }
        public Guid? UniqueId { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCurrentAccount? CurrentAccount { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpPo? PosReceipt { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
