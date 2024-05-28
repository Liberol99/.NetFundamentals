using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaCalendar
    {
        public int RecId { get; set; }
        public string? Explanation { get; set; }
        public string? Dday { get; set; }
        public short? Dmonth { get; set; }
        public short? Dyear { get; set; }
        public DateTime? StartTime { get; set; }
        public short? Period { get; set; }
        public int? CountryId { get; set; }
        public int? CityId { get; set; }
        public short? SalesImpact { get; set; }
        public byte? IsForever { get; set; }
        public short? ImpactArea { get; set; }
        public short? Dtype { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual MetaCity? City { get; set; }
        public virtual MetaCountry? Country { get; set; }
    }
}
