using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmCveducation
    {
        public long RecId { get; set; }
        public long? CvId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public byte? EducationType { get; set; }
        public string? EducationName { get; set; }
        public string? EducationDepartment { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public decimal? Grade { get; set; }
        public byte? GradeSystem { get; set; }
        public string? EducationLanguage { get; set; }
        public byte? Scholarship { get; set; }
        public string? Explanation { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaCity? City { get; set; }
        public virtual MetaCountry? Country { get; set; }
        public virtual HrmCv? Cv { get; set; }
    }
}
