using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpParameterPosPrinter
    {
        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public int? DepartmentId { get; set; }
        public long? ResourceId { get; set; }
        public byte? UsageType { get; set; }
        public byte? PrintingType { get; set; }
        public string? CodeList { get; set; }
        public int? PrinterId { get; set; }
        public string? MonitorFolder { get; set; }
        public byte? IsExcluded { get; set; }
        public byte[]? Condition { get; set; }
        public byte? IsOnlyTableReceiptPrint { get; set; }
        public byte? IsOnlyPackedServiceReceiptPrint { get; set; }
        public byte? IsOnlySelfServiceReceiptPrint { get; set; }
        public byte? IsOnlyForNamesReceiptPrint { get; set; }
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
        public virtual MetaPrinter? Printer { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
