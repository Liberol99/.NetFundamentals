using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpGleledger
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? WorkplaceId { get; set; }
        public string? ElfileCode { get; set; }
        public short? Elyear { get; set; }
        public short? Elmonth { get; set; }
        public DateTime? ElstartDate { get; set; }
        public DateTime? ElendDate { get; set; }
        public DateTime? AccountingPeriodStart { get; set; }
        public DateTime? AccountingPeriodEnd { get; set; }
        public DateTime? EllastReceiptDate { get; set; }
        public short? ElitemNo { get; set; }
        public short? Eltype { get; set; }
        public string? ElledgerFileName { get; set; }
        public string? ElledgerData { get; set; }
        public string? ElcertificateFileName { get; set; }
        public string? ElcertificateData { get; set; }
        public short? Elstatus { get; set; }
        public string? Elguid { get; set; }
        public string? EltrialBalanceFileCode { get; set; }
        public string? EltrialBalanceFileName { get; set; }
        public Guid? EltrialBalanceGuid { get; set; }
        public decimal? ElfileSize { get; set; }
        public byte? IsException { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpWorkplace? Workplace { get; set; }
    }
}
