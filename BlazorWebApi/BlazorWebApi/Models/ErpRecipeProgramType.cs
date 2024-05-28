using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class ErpRecipeProgramType
    {
        public ErpRecipeProgramType()
        {
            ErpRecipeOprs = new HashSet<ErpRecipeOpr>();
            ErpRecipePrograms = new HashSet<ErpRecipeProgram>();
        }

        public int RecId { get; set; }
        public int? CompanyId { get; set; }
        public string? TypeName { get; set; }
        public int? ProcessId { get; set; }
        public int? Process2Id { get; set; }
        public byte? IsDefault { get; set; }
        public int? ItemOrderNo { get; set; }
        public short? ProgramType { get; set; }
        public byte? InUse { get; set; }
        public DateTime? InsertedAt { get; set; }
        public int? InsertedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public byte? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }

        public virtual ErpCompany? Company { get; set; }
        public virtual ErpProcess? Process { get; set; }
        public virtual ErpProcess? Process2 { get; set; }
        public virtual ICollection<ErpRecipeOpr> ErpRecipeOprs { get; set; }
        public virtual ICollection<ErpRecipeProgram> ErpRecipePrograms { get; set; }
    }
}
