using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmPosition
    {
        public HrmPosition()
        {
            ErpEmployees = new HashSet<ErpEmployee>();
            ErpWorkFlowCards = new HashSet<ErpWorkFlowCard>();
            HrmAdvertisements = new HashSet<HrmAdvertisement>();
            HrmCvexperiences = new HashSet<HrmCvexperience>();
            HrmCvreferences = new HashSet<HrmCvreference>();
            HrmCvs = new HashSet<HrmCv>();
            HrmEmployeeDemands = new HashSet<HrmEmployeeDemand>();
            HrmPlacementItems = new HashSet<HrmPlacementItem>();
            HrmTestEmployees = new HashSet<HrmTestEmployee>();
            InverseParent = new HashSet<HrmPosition>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? PositionCode { get; set; }
        public string? PositionName { get; set; }
        public int? ParentId { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public short? PositionGroupType { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual HrmPosition? Parent { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployees { get; set; }
        public virtual ICollection<ErpWorkFlowCard> ErpWorkFlowCards { get; set; }
        public virtual ICollection<HrmAdvertisement> HrmAdvertisements { get; set; }
        public virtual ICollection<HrmCvexperience> HrmCvexperiences { get; set; }
        public virtual ICollection<HrmCvreference> HrmCvreferences { get; set; }
        public virtual ICollection<HrmCv> HrmCvs { get; set; }
        public virtual ICollection<HrmEmployeeDemand> HrmEmployeeDemands { get; set; }
        public virtual ICollection<HrmPlacementItem> HrmPlacementItems { get; set; }
        public virtual ICollection<HrmTestEmployee> HrmTestEmployees { get; set; }
        public virtual ICollection<HrmPosition> InverseParent { get; set; }
    }
}
