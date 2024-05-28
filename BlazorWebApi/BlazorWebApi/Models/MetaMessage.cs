using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaMessage
    {
        public long RecId { get; set; }
        public DateTime? MessageDate { get; set; }
        public int? MessageFromUserId { get; set; }
        public int? MessageToUserId { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public byte? IsRead { get; set; }
        public DateTime? ReadDate { get; set; }
        public int? ScheduleId { get; set; }
        public byte? IsCommand { get; set; }
        public string? CommandExplanation { get; set; }
        public string? Pm { get; set; }
        public string? KeyField { get; set; }
        public string? BoName { get; set; }
        public string? Command { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public short? SourceModule { get; set; }
        public long? SourceId { get; set; }
        public long? SourceItemId { get; set; }

        public virtual MetaUser? MessageFromUser { get; set; }
        public virtual MetaUser? MessageToUser { get; set; }
        public virtual MetaSchedule? Schedule { get; set; }
    }
}
