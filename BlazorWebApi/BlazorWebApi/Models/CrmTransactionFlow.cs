using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class CrmTransactionFlow
    {
        public CrmTransactionFlow()
        {
            CrmTransactionFlowItemFlows = new HashSet<CrmTransactionFlowItem>();
            CrmTransactionFlowItemNextFlows = new HashSet<CrmTransactionFlowItem>();
            CrmTransactionFlowItemPrevFlows = new HashSet<CrmTransactionFlowItem>();
            CrmTransactionFlowItemStartingFlows = new HashSet<CrmTransactionFlowItem>();
            CrmTransactionFlowResources = new HashSet<CrmTransactionFlowResource>();
            CrmTransactionFlowResults = new HashSet<CrmTransactionFlowResult>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? FlowCode { get; set; }
        public string? Explanation { get; set; }
        public byte? FlowType { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short? EstimatedTime { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? IsStartable { get; set; }
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
        public virtual ICollection<CrmTransactionFlowItem> CrmTransactionFlowItemFlows { get; set; }
        public virtual ICollection<CrmTransactionFlowItem> CrmTransactionFlowItemNextFlows { get; set; }
        public virtual ICollection<CrmTransactionFlowItem> CrmTransactionFlowItemPrevFlows { get; set; }
        public virtual ICollection<CrmTransactionFlowItem> CrmTransactionFlowItemStartingFlows { get; set; }
        public virtual ICollection<CrmTransactionFlowResource> CrmTransactionFlowResources { get; set; }
        public virtual ICollection<CrmTransactionFlowResult> CrmTransactionFlowResults { get; set; }
    }
}
