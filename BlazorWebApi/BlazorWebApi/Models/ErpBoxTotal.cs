using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpBoxTotal
    {
        public long RecId { get; set; }
        public long? BoxId { get; set; }
        public int? WarehouseId { get; set; }
        public int? WarehouseLocationId { get; set; }
        public decimal? Quantity { get; set; }

        public virtual ErpBox? Box { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpWarehouseLocation? WarehouseLocation { get; set; }
    }
}
