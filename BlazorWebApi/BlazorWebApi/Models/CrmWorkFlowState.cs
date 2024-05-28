using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class CrmWorkFlowState
    {
        public CrmWorkFlowState()
        {
            CrmTransactionFlowItems = new HashSet<CrmTransactionFlowItem>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? StateCode { get; set; }
        public string? StateName { get; set; }
        public short? ItemNo { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<CrmTransactionFlowItem> CrmTransactionFlowItems { get; set; }
    }
}
