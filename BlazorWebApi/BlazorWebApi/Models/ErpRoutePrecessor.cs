using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpRoutePrecessor
    {
        public long RecId { get; set; }
        public long? RouteItemId { get; set; }
        public long? OverlapRouteItemId { get; set; }
        public int? OverlapRate { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpRouteItem? OverlapRouteItem { get; set; }
        public virtual ErpRouteItem? RouteItem { get; set; }
    }
}
