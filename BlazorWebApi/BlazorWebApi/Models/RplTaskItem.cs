using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class RplTaskItem
    {
        public RplTaskItem()
        {
            RplTaskTargets = new HashSet<RplTaskTarget>();
        }

        public long RecId { get; set; }
        public long? Task { get; set; }
        public string? BoName { get; set; }
        public string? TableName { get; set; }
        public long? DataId { get; set; }
        public string? KeyCode { get; set; }
        public short? TypeCode { get; set; }
        public byte[]? Data { get; set; }

        public virtual RplTask? TaskNavigation { get; set; }
        public virtual ICollection<RplTaskTarget> RplTaskTargets { get; set; }
    }
}
