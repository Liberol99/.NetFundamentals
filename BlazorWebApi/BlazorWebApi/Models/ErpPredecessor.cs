using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpPredecessor
    {
        public long DependentPlanningId { get; set; }
        public long PredecessorPlanningId { get; set; }
        public short? DependencyType { get; set; }

        public virtual ErpPlanning DependentPlanning { get; set; } = null!;
        public virtual ErpPlanning PredecessorPlanning { get; set; } = null!;
    }
}
