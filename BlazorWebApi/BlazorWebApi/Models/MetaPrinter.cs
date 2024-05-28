using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaPrinter
    {
        public MetaPrinter()
        {
            ErpParameterPosPrinters = new HashSet<ErpParameterPosPrinter>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public long? ResourceId { get; set; }
        public string? PrinterCode { get; set; }
        public string? PrinterName { get; set; }
        public string? PrinterAddress { get; set; }
        public byte? PrinterType { get; set; }
        public string? CutterCodes { get; set; }
        public string? RewindCodes { get; set; }
        public string? ReleaseCodes { get; set; }
        public string? AlarmCodes { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpResource? Resource { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
        public virtual ICollection<ErpParameterPosPrinter> ErpParameterPosPrinters { get; set; }
    }
}
