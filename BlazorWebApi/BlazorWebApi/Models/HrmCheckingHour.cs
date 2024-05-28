using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmCheckingHour
    {
        public long RecId { get; set; }
        public long? CheckingId { get; set; }
        public byte? HourType { get; set; }
        public int? HourTypeId { get; set; }
        public decimal? Hours { get; set; }
        public decimal? HourEarning { get; set; }
        public decimal? NetHourEarning { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual HrmChecking? Checking { get; set; }
        public virtual HrmTime? HourTypeNavigation { get; set; }
    }
}
