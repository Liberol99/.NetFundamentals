using System;
using System.Collections.Generic;

namespace BlazorWebAPI.Models
{
    public partial class HrmEmployeeAccrual
    {
        public long RecId { get; set; }
        public int? CompanyId { get; set; }
        public int? DepartmentId { get; set; }
        public long? EmployeeId { get; set; }
        public short? EmployeeRowNumber { get; set; }
        public short? Month { get; set; }
        public short? Year { get; set; }
        public string? Day1 { get; set; }
        public short? Fm1 { get; set; }
        public string? Color1 { get; set; }
        public string? Day2 { get; set; }
        public short? Fm2 { get; set; }
        public string? Color2 { get; set; }
        public string? Day3 { get; set; }
        public short? Fm3 { get; set; }
        public string? Color3 { get; set; }
        public string? Day4 { get; set; }
        public short? Fm4 { get; set; }
        public string? Color4 { get; set; }
        public string? Day5 { get; set; }
        public short? Fm5 { get; set; }
        public string? Color5 { get; set; }
        public string? Day6 { get; set; }
        public short? Fm6 { get; set; }
        public string? Color6 { get; set; }
        public string? Day7 { get; set; }
        public short? Fm7 { get; set; }
        public string? Color7 { get; set; }
        public string? Day8 { get; set; }
        public short? Fm8 { get; set; }
        public string? Color8 { get; set; }
        public string? Day9 { get; set; }
        public short? Fm9 { get; set; }
        public string? Color9 { get; set; }
        public string? Day10 { get; set; }
        public short? Fm10 { get; set; }
        public string? Color10 { get; set; }
        public string? Day11 { get; set; }
        public short? Fm11 { get; set; }
        public string? Color11 { get; set; }
        public string? Day12 { get; set; }
        public short? Fm12 { get; set; }
        public string? Color12 { get; set; }
        public string? Day13 { get; set; }
        public short? Fm13 { get; set; }
        public string? Color13 { get; set; }
        public string? Day14 { get; set; }
        public short? Fm14 { get; set; }
        public string? Color14 { get; set; }
        public string? Day15 { get; set; }
        public short? Fm15 { get; set; }
        public string? Color15 { get; set; }
        public string? Day16 { get; set; }
        public short? Fm16 { get; set; }
        public string? Color16 { get; set; }
        public string? Day17 { get; set; }
        public short? Fm17 { get; set; }
        public string? Color17 { get; set; }
        public string? Day18 { get; set; }
        public short? Fm18 { get; set; }
        public string? Color18 { get; set; }
        public string? Day19 { get; set; }
        public short? Fm19 { get; set; }
        public string? Color19 { get; set; }
        public string? Day20 { get; set; }
        public short? Fm20 { get; set; }
        public string? Color20 { get; set; }
        public string? Day21 { get; set; }
        public short? Fm21 { get; set; }
        public string? Color21 { get; set; }
        public string? Day22 { get; set; }
        public short? Fm22 { get; set; }
        public string? Color22 { get; set; }
        public string? Day23 { get; set; }
        public short? Fm23 { get; set; }
        public string? Color23 { get; set; }
        public string? Day24 { get; set; }
        public short? Fm24 { get; set; }
        public string? Color24 { get; set; }
        public string? Day25 { get; set; }
        public short? Fm25 { get; set; }
        public string? Color25 { get; set; }
        public string? Day26 { get; set; }
        public short? Fm26 { get; set; }
        public string? Color26 { get; set; }
        public string? Day27 { get; set; }
        public short? Fm27 { get; set; }
        public string? Color27 { get; set; }
        public string? Day28 { get; set; }
        public short? Fm28 { get; set; }
        public string? Color28 { get; set; }
        public string? Day29 { get; set; }
        public short? Fm29 { get; set; }
        public string? Color29 { get; set; }
        public string? Day30 { get; set; }
        public short? Fm30 { get; set; }
        public string? Color30 { get; set; }
        public string? Day31 { get; set; }
        public short? Fm31 { get; set; }
        public string? Color31 { get; set; }
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
        public virtual ErpEmployee? Employee { get; set; }
    }
}
