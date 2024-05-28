using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmPlacementItem
    {
        public long RecId { get; set; }
        public long? PlacementId { get; set; }
        public byte? ItemType { get; set; }
        public int? DepartmentId { get; set; }
        public int? PositionId { get; set; }
        public long? ApplicationId { get; set; }
        public long? AdvertisementId { get; set; }
        public long? TestId { get; set; }
        public long? EmployeeId { get; set; }
        public decimal? RequirementQuantity { get; set; }
        public string? Explanation { get; set; }
        public DateTime? PlannedDate { get; set; }
        public DateTime? PlannedTime { get; set; }
        public DateTime? InterviewDate { get; set; }
        public DateTime? InterviewStartTime { get; set; }
        public DateTime? InterviewEndTime { get; set; }
        public string? InterviewExplanation { get; set; }
        public byte? InterviewResult { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual HrmAdvertisement? Advertisement { get; set; }
        public virtual HrmApplication? Application { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
        public virtual HrmPlacement? Placement { get; set; }
        public virtual HrmPosition? Position { get; set; }
        public virtual HrmTest? Test { get; set; }
    }
}
