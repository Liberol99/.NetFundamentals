using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCalendarItem
    {
        public ErpCalendarItem()
        {
            InverseParent = new HashSet<ErpCalendarItem>();
        }

        public long RecId { get; set; }
        public long? CalendarId { get; set; }
        public byte? Ctype { get; set; }
        public string? Explanation { get; set; }
        public string? TimeCode { get; set; }
        public long? ParentId { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public byte? StartDay { get; set; }
        public byte? EndDay { get; set; }
        public byte? IsForever { get; set; }
        public short? ImpactArea { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCalendar? Calendar { get; set; }
        public virtual ErpCalendarItem? Parent { get; set; }
        public virtual ICollection<ErpCalendarItem> InverseParent { get; set; }
    }
}
