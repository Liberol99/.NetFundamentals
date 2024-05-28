using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpEmployeeRelation
    {
        public long RecId { get; set; }
        public long? EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? IdCardNo { get; set; }
        public short? RelationType { get; set; }
        public string? Nationality { get; set; }
        public byte? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? Phone { get; set; }
        public string? GsmNo { get; set; }
        public byte? IsDependent { get; set; }
        public byte? IsSocialAssistanceActive { get; set; }
        public string? FathersName { get; set; }
        public string? MothersName { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public short? RegisteredDuration { get; set; }
        public string? SchoolName { get; set; }
        public string? ClassNo { get; set; }
        public byte? ChildType { get; set; }
        public string? Explanation { get; set; }
        public byte? WorkingStatus { get; set; }
        public string? EmailAddress { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public long? Cvid { get; set; }
        public byte? HasDisabled { get; set; }
        public byte? DisabilityStatus { get; set; }
        public decimal? DisabilityRate { get; set; }

        public virtual HrmCv? Cv { get; set; }
        public virtual ErpEmployee? Employee { get; set; }
    }
}
