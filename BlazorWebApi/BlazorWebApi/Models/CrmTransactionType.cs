using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class CrmTransactionType
    {
        public CrmTransactionType()
        {
            CrmTransactionFlowItemPrevTranTypes = new HashSet<CrmTransactionFlowItem>();
            CrmTransactionFlowItemTranTypes = new HashSet<CrmTransactionFlowItem>();
            CrmTransactionTypeResourceAttributes = new HashSet<CrmTransactionTypeResourceAttribute>();
            CrmTransactionTypeResults = new HashSet<CrmTransactionTypeResult>();
            ErpCustomerTransactionActivities = new HashSet<ErpCustomerTransactionActivity>();
            ErpCustomerTransactionPrevTransactions = new HashSet<ErpCustomerTransaction>();
            ErpCustomerTransactionTranSubTypes = new HashSet<ErpCustomerTransaction>();
            ErpCustomerTransactionTranTypes = new HashSet<ErpCustomerTransaction>();
            InverseParent = new HashSet<CrmTransactionType>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public long? ParentId { get; set; }
        public int? DepartmentId { get; set; }
        public string? ActivityName { get; set; }
        public string? Explanation { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? IsUserDefaultResource { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual CrmTransactionType? Parent { get; set; }
        public virtual ICollection<CrmTransactionFlowItem> CrmTransactionFlowItemPrevTranTypes { get; set; }
        public virtual ICollection<CrmTransactionFlowItem> CrmTransactionFlowItemTranTypes { get; set; }
        public virtual ICollection<CrmTransactionTypeResourceAttribute> CrmTransactionTypeResourceAttributes { get; set; }
        public virtual ICollection<CrmTransactionTypeResult> CrmTransactionTypeResults { get; set; }
        public virtual ICollection<ErpCustomerTransactionActivity> ErpCustomerTransactionActivities { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactionPrevTransactions { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactionTranSubTypes { get; set; }
        public virtual ICollection<ErpCustomerTransaction> ErpCustomerTransactionTranTypes { get; set; }
        public virtual ICollection<CrmTransactionType> InverseParent { get; set; }
    }
}
