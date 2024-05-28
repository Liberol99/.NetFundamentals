using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class MetaHrmQuit
    {
        public MetaHrmQuit()
        {
            ErpEmployeeHistories = new HashSet<ErpEmployeeHistory>();
            ErpEmployeeMlssQuitReasons = new HashSet<ErpEmployee>();
            ErpEmployeeSsiQuitReasons = new HashSet<ErpEmployee>();
        }

        public int RecId { get; set; }
        public byte? Type { get; set; }
        public string? QuitCode { get; set; }
        public string? Explanation { get; set; }
        public string? Ncode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ICollection<ErpEmployeeHistory> ErpEmployeeHistories { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployeeMlssQuitReasons { get; set; }
        public virtual ICollection<ErpEmployee> ErpEmployeeSsiQuitReasons { get; set; }
    }
}
