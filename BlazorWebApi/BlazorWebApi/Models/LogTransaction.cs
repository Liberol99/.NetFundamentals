using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class LogTransaction
    {
        public long RecId { get; set; }
        public string? CompanyCode { get; set; }
        public string? UserCode { get; set; }
        public string? SysUserCode { get; set; }
        public string? SysAdress { get; set; }
        public byte? OperationType { get; set; }
        public DateTime? OperationDate { get; set; }
        public short? Program { get; set; }
        public short? LogicalModule { get; set; }
        public short? Module { get; set; }
        public string? CommandName { get; set; }
        public short? CommandId { get; set; }
        public int? ItemId { get; set; }
        public int? SubItemId { get; set; }
        public string? ItemCode { get; set; }
        public string? Explanation { get; set; }
        public decimal? GpsXcoordinate { get; set; }
        public decimal? GpsYcoordinate { get; set; }
        public byte? IsReaded { get; set; }
        public byte[]? LogData { get; set; }
        public string? Boname { get; set; }
        public long? BorecId { get; set; }
    }
}
