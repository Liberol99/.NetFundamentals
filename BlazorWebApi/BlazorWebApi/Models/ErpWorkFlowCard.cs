using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpWorkFlowCard
    {
        public ErpWorkFlowCard()
        {
            ErpWorkFlowCardItems = new HashSet<ErpWorkFlowCardItem>();
            InverseNextWorkFlowCard = new HashSet<ErpWorkFlowCard>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public byte? WorkFlowType { get; set; }
        public string? CardCode { get; set; }
        public string? Explanation { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short? Priority { get; set; }
        public int? NextWorkFlowCardId { get; set; }
        public short? Module { get; set; }
        public short? ModuleCommand { get; set; }
        public byte[]? Condition { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? IsHierarchy { get; set; }
        public byte? IsAutoStart { get; set; }
        public int? ConfirmationNumber { get; set; }
        public int? RejectionNumber { get; set; }
        public string? Boname { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? IsDepartmentHierarchy { get; set; }
        public int? PositionId { get; set; }
        public byte? NotifyChannel { get; set; }
        public string? FormFieldName { get; set; }
        public string? FormFormDef { get; set; }
        public string? CcMailAddresses { get; set; }
        public string? BccMailAddresses { get; set; }
        public string? FormName { get; set; }
        public byte? ApprovedNotifyChannel { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpWorkFlowCard? NextWorkFlowCard { get; set; }
        public virtual HrmPosition? Position { get; set; }
        public virtual ICollection<ErpWorkFlowCardItem> ErpWorkFlowCardItems { get; set; }
        public virtual ICollection<ErpWorkFlowCard> InverseNextWorkFlowCard { get; set; }
    }
}
