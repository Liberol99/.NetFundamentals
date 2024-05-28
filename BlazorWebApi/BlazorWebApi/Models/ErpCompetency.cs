using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpCompetency
    {
        public ErpCompetency()
        {
            ErpEmployeeCompetencies = new HashSet<ErpEmployeeCompetency>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? CompetencyName { get; set; }
        public string? SpecialCode { get; set; }
        public string? AccessCode { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ICollection<ErpEmployeeCompetency> ErpEmployeeCompetencies { get; set; }
    }
}
