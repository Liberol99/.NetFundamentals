using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaWindowSetting
    {
        public long RecId { get; set; }
        public short? ProductCode { get; set; }
        public int? UserId { get; set; }
        public string? WindowName { get; set; }
        public short? Type { get; set; }
        public string? ControlName { get; set; }
        public string? PropertyName { get; set; }
        public string? PropertyValue { get; set; }

        public virtual MetaUser? User { get; set; }
    }
}
