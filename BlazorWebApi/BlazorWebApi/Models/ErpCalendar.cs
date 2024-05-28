using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCalendar
    {
        public ErpCalendar()
        {
            ErpCalendarItems = new HashSet<ErpCalendarItem>();
            ErpEmployees = new HashSet<ErpEmployee>();
            ErpResources = new HashSet<ErpResource>();
            InverseParent = new HashSet<ErpCalendar>();
        }

        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public short? CalendarType { get; set; }
        public string? CalendarCode { get; set; }
        public string? CalendarName { get; set; }
        public byte? IsDefault { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public byte? Ctype { get; set; }
        public string? TimeCode { get; set; }
        public long? ParentId { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public byte? StartDay { get; set; }
        public byte? EndDay { get; set; }
        public byte? IsForever { get; set; }
        public short? ImpactArea { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpCalendar? Parent { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpCalendarItem> ErpCalendarItems { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployees { get; set; }
        public virtual ICollection<ErpResource> ErpResources { get; set; }
        public virtual ICollection<ErpCalendar> InverseParent { get; set; }
    }
}
