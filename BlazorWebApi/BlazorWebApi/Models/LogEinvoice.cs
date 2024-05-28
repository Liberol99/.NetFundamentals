using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class LogEinvoice
    {
        public long RecId { get; set; }
        public string? CompanyCode { get; set; }
        public string? UserCode { get; set; }
        public string? SysUserCode { get; set; }
        public string? SysAdress { get; set; }
        public byte? OperationType { get; set; }
        public DateTime? OperationDate { get; set; }
        public string? ItemCode { get; set; }
        public string? Explanation { get; set; }
        public byte? TransactionType { get; set; }
    }
}
