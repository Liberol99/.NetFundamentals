using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpInventoryTotal
    {
        public long RecId { get; set; }
        public long? InventoryId { get; set; }
        public long? InventoryVariantId { get; set; }
        public int? WarehouseId { get; set; }
        public DateTime? TotalDate { get; set; }
        public DateTime? LastInDate { get; set; }
        public DateTime? LastOutDate { get; set; }
        public decimal? LastInPrice { get; set; }
        public decimal? LastOutPrice { get; set; }
        public decimal? AveragePrice { get; set; }
        public decimal? ActualStock { get; set; }
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
        public decimal? Counting { get; set; }
        public decimal? CountingAmount { get; set; }
        public decimal? TransferIn { get; set; }
        public decimal? TransferInAmount { get; set; }
        public decimal? TransferOut { get; set; }
        public decimal? TransferOutAmount { get; set; }
        public decimal? OtherIn { get; set; }
        public decimal? OtherInAmount { get; set; }
        public decimal? OtherOut { get; set; }
        public decimal? OtherOutAmount { get; set; }
        public decimal? Purchase { get; set; }
        public decimal? PurchaseAmount { get; set; }
        public decimal? PurchaseReturn { get; set; }
        public decimal? PurchaseReturnAmount { get; set; }
        public decimal? PurchaseUnQc { get; set; }
        public decimal? PurchaseAmountUnQc { get; set; }
        public decimal? WholeSale { get; set; }
        public decimal? WholeSaleAmount { get; set; }
        public decimal? WholeSaleReturn { get; set; }
        public decimal? WholeSaleReturnAmount { get; set; }
        public decimal? Retail { get; set; }
        public decimal? RetailAmount { get; set; }
        public decimal? RetailReturn { get; set; }
        public decimal? RetailReturnAmount { get; set; }
        public decimal? ConsignedSale { get; set; }
        public decimal? ConsignedSaleAmount { get; set; }
        public decimal? ConsignedSaleReturn { get; set; }
        public decimal? ConsignedSaleReturnAmount { get; set; }
        public decimal? ConsignedIn { get; set; }
        public decimal? ConsignedInAmount { get; set; }
        public decimal? ConsignedInReturn { get; set; }
        public decimal? ConsignedInReturnAmount { get; set; }
        public decimal? SubContractorIn { get; set; }
        public decimal? SubContractorInAmount { get; set; }
        public decimal? SubContractorInReturn { get; set; }
        public decimal? SubContractorInReturnAmount { get; set; }
        public decimal? SubContractorOut { get; set; }
        public decimal? SubContractorOutAmount { get; set; }
        public decimal? SubContractorOutReturn { get; set; }
        public decimal? SubContractorOutReturnAmount { get; set; }
        public decimal? Manufactured { get; set; }
        public decimal? ManufacturedAmount { get; set; }
        public decimal? ManufacturedUnQc { get; set; }
        public decimal? ManufacturedAmountUnQc { get; set; }
        public decimal? Consumed { get; set; }
        public decimal? ConsumedAmount { get; set; }
        public decimal? Wasted { get; set; }
        public decimal? WastedAmount { get; set; }
        public decimal? SalesCostAmount { get; set; }
        public decimal? SalesReturnCostAmount { get; set; }
        public decimal? UdInflow { get; set; }
        public decimal? UdInflowAmount { get; set; }
        public decimal? UdOutflow { get; set; }
        public decimal? UdOutflowAmount { get; set; }

        public virtual ErpInventory? Inventory { get; set; }
        public virtual ErpInventoryVariant? InventoryVariant { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
    }
}
