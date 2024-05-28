using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaReport
    {
        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? WarehouseId { get; set; }
        public int? UserId { get; set; }
        public int? DepartmentId { get; set; }
        public short? ProductCode { get; set; }
        public short? Module { get; set; }
        public int? ItemCode { get; set; }
        public int? SubItemCode { get; set; }
        public string? ReportName { get; set; }
        public string? ReportTitle { get; set; }
        public string? Explanation { get; set; }
        public byte[]? Definition { get; set; }
        public byte[]? Options { get; set; }
        public byte[]? Condition { get; set; }
        public byte[]? Query { get; set; }
        public long? FilterId { get; set; }
        public byte? IsDefault { get; set; }
        public byte? IsUserDefined { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpDepartment? Department { get; set; }
        public virtual MetaPreset? Filter { get; set; }
        public virtual MetaUser? User { get; set; }
        public virtual ErpWarehouse? Warehouse { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
