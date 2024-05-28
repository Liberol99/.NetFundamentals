using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpParameterRevaluation
    {
        public int RecId { get; set; }
        public int? RevaluationYear { get; set; }
        public int? RevaluationMonth { get; set; }
        public decimal? RevaluationRate { get; set; }
        public decimal? ProducerPriceIndex { get; set; }
        public decimal? ConsumerPriceIndex { get; set; }
    }
}
