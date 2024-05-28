using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaUserCompany
    {
        public int RecId { get; set; }
        public int? UserId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? WarehouseId { get; set; }
        public byte? IsDefault { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual MetaUser? User { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
