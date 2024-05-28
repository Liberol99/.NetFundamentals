using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class Replication
    {
        public Guid LogId { get; set; }
        public DateTime? LogTime { get; set; }
        public int? LocationId { get; set; }
        public short? LogType { get; set; }
        public short? Type { get; set; }
        public short? Priority { get; set; }
        public string? BoName { get; set; }
        public string? Message { get; set; }
        public string? BoCode { get; set; }
        public string? ToBoCode { get; set; }
        public short? BoType { get; set; }
    }
}
