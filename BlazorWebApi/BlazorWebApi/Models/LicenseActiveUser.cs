using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class LicenseActiveUser
    {
        public long RecId { get; set; }
        public string? ProductCode { get; set; }
        public string? PlatformCode { get; set; }
        public int? UserId { get; set; }
        public string? MachineAddress { get; set; }
        public string? SessionAddress { get; set; }
        public long? LoginTime { get; set; }
        public long? CheckTime { get; set; }

        public virtual MetaUser? User { get; set; }
    }
}
