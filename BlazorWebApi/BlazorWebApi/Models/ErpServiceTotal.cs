using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpServiceTotal
    {
        public long RecId { get; set; }
        public long? ServiceId { get; set; }
        public DateTime? TotalDate { get; set; }
        public DateTime? LastInDate { get; set; }
        public DateTime? LastOutDate { get; set; }
        public decimal? LastInPrice { get; set; }
        public decimal? LastOutPrice { get; set; }
        public decimal? AveragePrice { get; set; }
        public decimal? TotalInflow { get; set; }
        public decimal? TotalInflowAmount { get; set; }
        public decimal? TotalOutflow { get; set; }
        public decimal? TotalOutflowAmount { get; set; }
        public decimal? ActualDemand { get; set; }
        public decimal? Reserved { get; set; }
        public decimal? Planned { get; set; }
        public decimal? PrePurchaseOrder { get; set; }
        public decimal? PrePurchaseOrderAmount { get; set; }
        public decimal? PurchaseOrder { get; set; }
        public decimal? PurchaseOrderAmount { get; set; }
        public decimal? PreCustomerOrder { get; set; }
        public decimal? PreCustomerOrderAmount { get; set; }
        public decimal? CustomerOrder { get; set; }
        public decimal? CustomerOrderAmount { get; set; }
        public decimal? Shipped { get; set; }
        public decimal? ShippedAmount { get; set; }
        public decimal? Received { get; set; }
        public decimal? ReceivedAmount { get; set; }
        public decimal? Purchase { get; set; }
        public decimal? PurchaseAmount { get; set; }
        public decimal? PurchaseReturn { get; set; }
        public decimal? PurchaseReturnAmount { get; set; }
        public decimal? Sale { get; set; }
        public decimal? SaleAmount { get; set; }
        public decimal? SaleReturn { get; set; }
        public decimal? SaleReturnAmount { get; set; }
    }
}
