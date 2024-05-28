using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpManufacturingType
    {
        public ErpManufacturingType()
        {
            ErpCostCenters = new HashSet<ErpCostCenter>();
            ErpWorkOrders = new HashSet<ErpWorkOrder>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? TypeCode { get; set; }
        public string? Explanation { get; set; }
        public int? ForegroundColor { get; set; }
        public int? BackgroundColor { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpCostCenter> ErpCostCenters { get; set; }
        public virtual ICollection<ErpWorkOrder> ErpWorkOrders { get; set; }
    }
}
